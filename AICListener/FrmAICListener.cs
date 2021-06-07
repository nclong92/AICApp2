﻿using AICListener.Code;
using ApplicationCore.Code;
using ApplicationCore.Models;
using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AICListener
{
    public partial class FrmAICListener : Form
    {
        HubConnection _signalRConnection;
        IHubProxy _hubProxy;

        static List<string> _serverLogs = new List<string>();

        public log4net.ILog _log;

        public FrmAICListener()
        {
            log4net.Config.BasicConfigurator.Configure();
            _log = log4net.LogManager.GetLogger(typeof(Program));

            InitializeComponent();
        }

        private async void btnKetNoi_Click(object sender, EventArgs e)
        {
            _signalRConnection = new HubConnection(txtServerAIC.Text);
            _signalRConnection.StateChanged += HubConnection_StateChanged;

            _hubProxy = _signalRConnection.CreateHubProxy("ServerHub");

            //await _hubProxy.Invoke("SendObj", new ObjMessage() { });

            _hubProxy.On<string, string>("AddObjMessage", (name, message) =>
            {
                writeToLog(message);
                _log.Info($"{name}: {message}");
            });

            btnKetNoi.Enabled = false;

            try
            {
                await _signalRConnection.Start();
                await _hubProxy.Invoke("SetUserName", "AICListener");

                txtServerAIC.Enabled = false;
                btnHuy.Enabled = true;

                SettingsExtensions.SetValue(txtServerAIC.Text);
                _log.Info($"Connected {txtServerAIC.Text}");
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = "Lỗi kết nối";
                btnKetNoi.Enabled = true;
                txtServerAIC.Enabled = true;
                _log.Error($"{ex.Message}");
            }
        }

        private void HubConnection_StateChanged(StateChange obj)
        {
            if (obj.NewState == Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
            {
                lblTrangThai.Text = "Đã kết nối";
            }
            else if (obj.NewState == Microsoft.AspNet.SignalR.Client.ConnectionState.Disconnected)
            {
                lblTrangThai.Text = "Chờ kết nối";
            }
            else if (obj.NewState == Microsoft.AspNet.SignalR.Client.ConnectionState.Connecting)
            {
                lblTrangThai.Text = "Đang kết nối";
            }
            //else
            //{
            //    lblTrangThai.Text = "Lỗi kết nối";
            //}
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (_signalRConnection != null)
            {
                _signalRConnection.Stop();
                _signalRConnection.Dispose();
                _signalRConnection = null;

                btnKetNoi.Enabled = true;
                txtServerAIC.Enabled = true;
                btnHuy.Enabled = false;

                lblTrangThai.Text = "Chờ kết nối";

                _log.Info($"Disconnected");
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
                }));
            }
            else
            {
                var logDisplay = $"{DateTime.Now} - {log}";
                _serverLogs.Add(logDisplay);

                string[] row = { logDisplay };
                var listViewItem = new ListViewItem(row);
                lvLichSu.Items.Add(listViewItem);
            }

            lvLichSu.EnsureVisible(lvLichSu.Items.Count - 1);
            lvLichSu.Update();
        }

        private void FrmAICListener_Load(object sender, EventArgs e)
        {
            txtServerAIC.Text = SettingsExtensions.GetValue("AICServerName");
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];

            int i = 1;
            int i2 = 1;

            foreach (ListViewItem lvi in lvLichSu.Items)
            {
                i = 1;
                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                {
                    ws.Cells[i2, i] = lvs.Text;
                    i++;
                }
                i2++;
            }

            var currentPath = Directory.GetCurrentDirectory();

            var excelName = $"{StringHelper.UniqueKey(10)}.xlsx";

            var subPath = $"{currentPath}\\excel";
            if (!System.IO.Directory.Exists(subPath))
            {
                System.IO.Directory.CreateDirectory(subPath);
            }

            var filePath = $"{subPath}\\{excelName}";
            wb.SaveAs(filePath);
            //wb.Close();
            //app.Quit();

            //MessageBox.Show($"Tạo file excel thành công. Bạn có thể tìm tệp theo đường dẫn: {filePath}");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RemoveAllLog();

            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                foreach (var item in _serverLogs)
                {
                    if (item.ToLower().Contains($"- {txtSearch.Text.ToLower()}"))
                    {
                        lvLichSu.Items.Add(item);
                    }
                }
            }
            else
            {
                RefreshAllLog();
            }
        }

        private void RemoveAllLog()
        {
            foreach (ListViewItem item in lvLichSu.Items)
            {
                lvLichSu.Items.Remove(item);
            }
        }

        private void RefreshAllLog()
        {
            RemoveAllLog();

            foreach (var item in _serverLogs)
            {
                string[] row = { item };
                var listViewItem = new ListViewItem(row);
                lvLichSu.Items.Add(listViewItem);
            }
        }
    }
}