using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class QLSV_DAL : DBconnection
    {
        public List<Studen> LayDuLieu()
        {
            try
            {
                SqlConnection conn = CreateConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from sinhvien", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                List<Studen> lstStuden = new List<Studen>();
                while (dr.Read())
                {
                    Studen studen = new Studen();
                    studen.id = dr[0].ToString();
                    studen.name = dr[1].ToString();
                    studen.dateOfBirth = dr[2].ToString();
                    studen.gender = dr[3].ToString();
                    studen.khoa = dr[4].ToString();
                    studen.img = dr[5].ToString();
                    lstStuden.Add(studen);
                }
                conn.Close();
                return lstStuden;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public string ThemSinhVien(Studen st)
        {
            try
            {
                
                SqlConnection conn = CreateConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into sinhvien values(@masv,@hoten,@ngaysinh,@gioitinh,@khoa,@hinhanh)", conn);
                cmd.Parameters.Add(new SqlParameter("@masv", st.id));
                cmd.Parameters.Add(new SqlParameter("@hoten", st.name));
                cmd.Parameters.Add(new SqlParameter("@ngaysinh", st.dateOfBirth));
                cmd.Parameters.Add(new SqlParameter("@gioitinh", st.gender));
                cmd.Parameters.Add(new SqlParameter("@khoa", st.khoa));
                cmd.Parameters.Add(new SqlParameter("@hinhanh", st.img));
                cmd.ExecuteNonQuery();
                conn.Close();
                return "success";
            }
            catch
            {
                return "error";
            }
        }

        public string XoaSinhVien(Studen st)
        {
            try
            {
                SqlConnection conn = CreateConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete sinhvien where masv=@masv ", conn);
                cmd.Parameters.Add(new SqlParameter("@masv", st.id));
                cmd.ExecuteNonQuery();
                conn.Close();
                return "success";
            }
            catch
            {
                return "error";
            }
        }

        public string XoaTatCa()
        {
            try
            {
                SqlConnection conn = CreateConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete sinhvien", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "success";
            }
            catch
            {
                return "error";
            }
        }

        public string SuaSinhVien(Studen st)
        {
            try
            {
                SqlConnection conn = CreateConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("update sinhvien set hoten=@hoten,ngaysinh=@ngaysinh,gioitinh=@gioitinh,khoa=@khoa,img=@hinhanh where masv=@masv", conn);
                cmd.Parameters.Add(new SqlParameter("@masv", st.id));
                cmd.Parameters.Add(new SqlParameter("@hoten", st.name));
                cmd.Parameters.Add(new SqlParameter("@ngaysinh", st.dateOfBirth));
                cmd.Parameters.Add(new SqlParameter("@gioitinh", st.gender));
                cmd.Parameters.Add(new SqlParameter("@khoa", st.khoa));
                cmd.Parameters.Add(new SqlParameter("@hinhanh", st.img));
                cmd.ExecuteNonQuery();
                conn.Close();
                return "success";
            }
            catch
            {
                return "error";
            }

        }

        public string ThemSinhVien(Studen studen, object dataGridView1)
        {
            throw new NotImplementedException();
        }
    }
}
