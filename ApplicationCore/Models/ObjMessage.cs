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
        public LoaiTrangThai TrangThai { get; set; }
    }

    public enum LoaiTrangThai
    {
        [Display(Name = "Đăng ký")]
        DangKy = 0,
        [Display(Name = "Hủy")]
        Huy = 1,
        [Display(Name = "Ngẫu nhiên")]
        NgauNhien = 3
    }
}
