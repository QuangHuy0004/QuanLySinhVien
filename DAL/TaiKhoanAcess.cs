using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TaiKhoanAcess:DatabaseLogDAL
    {
        public string CheckLogic(TaiKhoan_DTO taikhoan)
        {
            string info = CheckLogicDTO(taikhoan);
            return info;
        }
    }
}
