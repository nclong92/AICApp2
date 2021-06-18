using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class ObjMessage
    {
        public string AICSenderFake { get; set; }
        public string SoGhe { get; set; }
        public AicCommandStatus TrangThai { get; set; }
    }

    public enum ClientStatus
    {
        [Display(Name = "Chờ kết nối")]
        ChoKetNoi = 0,
        [Display(Name = "Đã kết nối")]
        DaKetNoi = 1,
        [Display(Name = "Đang kết nối")]
        DangKetNoi = 2,
        [Display(Name = "Lỗi kết nối")]
        LoiKetNoi = 3
    }

    public enum ServerStatus
    {
        [Display(Name = "Đang chờ")]
        DangCho = 0,
        [Display(Name = "Đã khởi động")]
        DaKhoiDong = 1,
        [Display(Name = "Đang khởi động")]
        DangKhoiDong = 2,
        [Display(Name = "Lỗi khởi động")]
        LoiKhoiDong = 3
    }
}
