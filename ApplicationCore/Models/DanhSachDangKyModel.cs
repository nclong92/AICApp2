using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public sealed class DanhSachDangKyModel
    {
        private DanhSachDangKyModel() { }

        static readonly DanhSachDangKyModel DANHSACH_DANGKY = new DanhSachDangKyModel();

        public static DanhSachDangKyModel Instance => DANHSACH_DANGKY;

        private List<string> _danhSachDangKys = new List<string>();

        public void AddMessage(string message, LoaiTrangThai trangthai, string soGhe)
        {
            if (trangthai == LoaiTrangThai.DangKy)
            {
                _danhSachDangKys.Add(soGhe);
            }
            else if (trangthai == LoaiTrangThai.Huy)
            {
                if (_danhSachDangKys.Contains(soGhe))
                {
                    _danhSachDangKys.RemoveAll(m => m == soGhe);
                }
            }
        }

        public List<string> GetList => _danhSachDangKys;

    }
}
