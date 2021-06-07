using AICSenderFake.Code;
using ApplicationCore.Code.Extensions;
using ApplicationCore.Models;
using Microsoft.AspNet.SignalR.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AICSenderFake
{
    public partial class FrmAICSenderFake : Form
    {
        HubConnection _signalRConnection;
        IHubProxy _hubProxy;

        public log4net.ILog _log;

        public FrmAICSenderFake()
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

            _hubProxy.On<string, ObjMessage>("AddObjMessage", (name, objmessage) =>
            {
                // LongNC TODO: write log when it need

            });

            btnKetNoi.Enabled = false;

            try
            {
                await _signalRConnection.Start();
                await _hubProxy.Invoke("SetUserName", "AICSenderFake");

                txtServerAIC.Enabled = false;
                btnHuy.Enabled = true;
                grpSend.Enabled = true;

                SettingsExtensions.SetValue(txtServerAIC.Text);
                _log.Info($"Connected {txtServerAIC.Text}");
            }
            catch (Exception ex)
            {
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

                grpSend.Enabled = false;

                _log.Info($"Disconnected");
            }
        }

        private void btn1Gui_Click(object sender, EventArgs e)
        {
            lbl1ThongBao.Text = "";
            var trangThai = rd1DangKy.Checked ? LoaiTrangThai.DangKy : (rd1Huy.Checked ? LoaiTrangThai.Huy : LoaiTrangThai.DangKy);
            var soGhe = txtGhe.Text;

            if (string.IsNullOrEmpty(soGhe))
            {
                lbl1ThongBao.Text = "Vui lòng chọn số ghế và trạng thái";
            }
            else
            {
                var objMessage = new ObjMessage()
                {
                    AICSenderFake = "AIC Sender Fake Name",
                    SoGhe = soGhe,
                    TrangThai = trangThai
                };

                var objMessageStr = JsonConvert.SerializeObject(objMessage);

                _hubProxy.Invoke("SendObj", objMessageStr);

                _log.Info($"SendObj --> {objMessageStr}");
            }
        }

        private async void btnnGui_Click(object sender, EventArgs e)
        {
            lblnThongBao.Text = "";

            int soLenh = Convert.ToInt32(numLenh.Value);

            if (soLenh <= 0)
            {
                lblnThongBao.Text = "Số lệnh phải lớn hơn 0";
            }
            else
            {
                int oldNumber = -1;
                for (int i = 1; i <= soLenh; i++)
                {
                    var trangthai = LoaiTrangThai.DangKy;

                    if (rdnDangKy.Checked)
                    {
                        trangthai = LoaiTrangThai.DangKy;
                    }
                    else if (rdnHuy.Checked)
                    {
                        trangthai = LoaiTrangThai.Huy;
                    }
                    else if (rdnNgauNhien.Checked)
                    {
                        var rand = new Random();
                        var randNumber = rand.Next(1, 100);
                        if (randNumber % 2 == 0)
                        {
                            trangthai = LoaiTrangThai.DangKy;
                        }
                        else
                        {
                            trangthai = LoaiTrangThai.Huy;
                        }
                    }

                    var randGheNumber = NumberExtensions.GetNewRandom(oldNumber);
                    oldNumber = randGheNumber;

                    var gheTemp = randGheNumber % 30;
                    if (gheTemp == 0)
                    {
                        randGheNumber = 30;
                    }
                    else
                    {
                        randGheNumber = gheTemp;
                    }

                    var objMessage = new ObjMessage()
                    {
                        AICSenderFake = "AIC Sender Fake Name",
                        SoGhe = $"A{randGheNumber}",
                        TrangThai = trangthai
                    };

                    var objMessageStr = JsonConvert.SerializeObject(objMessage);

                    await _hubProxy.Invoke("SendObj", objMessageStr);

                    _log.Info($"SendObj --> {objMessageStr}");
                }
            }
        }

        private void FrmAICSenderFake_Load(object sender, EventArgs e)
        {
            txtServerAIC.Text = SettingsExtensions.GetValue("AICServerName");
        }
    }
}
