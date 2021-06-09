using AICServerFake.Code;
using ApplicationCore.Code.Extensions;
using ApplicationCore.Models;
using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AICServerFake
{
    public partial class FrmAICServerFake : Form
    {
        private IDisposable _signalR;
        private BindingList<ClientItem> _clients = new BindingList<ClientItem>();

        static List<string> _serverLogs = new List<string>();

        public log4net.ILog _log;

        public FrmAICServerFake()
        {
            log4net.Config.BasicConfigurator.Configure();
            _log = log4net.LogManager.GetLogger(typeof(Program));

            InitializeComponent();

            ServerHub.ClientConnected += ServerHub_ClientConnected; ;
            ServerHub.ClientDisconnected += ServerHub_ClientDisconnected;
            ServerHub.ClientNameChanged += ServerHub_ClientNameChanged;

            ServerHub.ObjReceived += ServerHub_ObjReceived;
        }

        private void ServerHub_ObjReceived(string senderClientId, ObjMessage obj)
        {
            this.BeginInvoke(new Action(() =>
            {
                var message = $"{obj.SoGhe} - {obj.TrangThai.ToDisplayName()}";

                _log.Info($"{message}");
                writeToLog($"{message}");
            }));
        }

        private void ServerHub_ClientNameChanged(string clientId, string newName)
        {
            this.BeginInvoke(new Action(() =>
            {
                var client = _clients.FirstOrDefault(m => m.Id == clientId);

                if (client != null)
                {
                    client.Name = newName;
                }
            }));

            var content = $"Client name changed. Id:{clientId}, Name:{newName}";
            _log.Info($"{content}");
            writeToLog($"{content}");
        }

        private void ServerHub_ClientDisconnected(string clientId)
        {
            this.BeginInvoke(new Action(() =>
            {
                var client = _clients.FirstOrDefault(m => m.Id == clientId);

                if (client != null)
                {
                    _clients.Remove(client);
                }
            }));

            _log.Info($"Client disconnected: {clientId}");
            writeToLog($"Client disconnected: {clientId}");
        }

        private void ServerHub_ClientConnected(string clientId)
        {
            this.BeginInvoke(new Action(() => _clients.Add(new ClientItem() { Id = clientId, Name = clientId })));

            _log.Info($"Client connected: {clientId}");
            writeToLog($"Client connected: {clientId}");
        }

        private void btnKhoiDong_Click(object sender, EventArgs e)
        {
            lblTrangThai.Text = ServerStatus.DangKhoiDong.ToDisplayName();

            try
            {
                _signalR = WebApp.Start<Startup>(txtUrl.Text);

                btnKhoiDong.Enabled = false;
                txtUrl.Enabled = false;
                btnDung.Enabled = true;

                lblTrangThai.Text = ServerStatus.DaKhoiDong.ToDisplayName();

                _log.Info($"Server started at: {txtUrl.Text}");
                writeToLog($"Server started at: {txtUrl.Text}");

                SettingsExtensions.SetValue(txtUrl.Text);
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = ServerStatus.LoiKhoiDong.ToDisplayName();
                _log.Error($"txtKetNoi_Click -> {ex.Message}");
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void writeToLog(string log)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(() =>
                {
                    var logDisplay = $"{DateTime.Now} - {log}";
                    _serverLogs.Add(logDisplay);

                    string[] row = { logDisplay };
                    var listViewItem = new ListViewItem(row);
                    lvLichSu.Items.Add(listViewItem);
                    lvLichSu.EnsureVisible(lvLichSu.Items.Count - 1);
                    lvLichSu.Update();
                }));
            }
            else
            {
                var logDisplay = $"{DateTime.Now} - {log}";
                _serverLogs.Add(logDisplay);

                string[] row = { logDisplay };
                var listViewItem = new ListViewItem(row);
                lvLichSu.Items.Add(listViewItem);
                lvLichSu.EnsureVisible(lvLichSu.Items.Count - 1);
                lvLichSu.Update();
            }

        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            _clients.Clear();

            ServerHub.ClearState();

            if (_signalR != null)
            {
                _signalR.Dispose();
                _signalR = null;

                btnDung.Enabled = false;
                btnKhoiDong.Enabled = true;
                txtUrl.Enabled = true;

                lblTrangThai.Text = ServerStatus.LoiKhoiDong.ToDisplayName();

                _log.Info("Server stopped");
                writeToLog("Server stopped");
            }
        }

        private void FrmAICServerFake_Load(object sender, EventArgs e)
        {
            txtUrl.Text = SettingsExtensions.GetValue("AICServerName");
            lblTrangThai.Text = ServerStatus.DangCho.ToDisplayName();
        }
    }
}
