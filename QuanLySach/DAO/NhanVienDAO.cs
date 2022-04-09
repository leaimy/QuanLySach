using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DAO
{
    internal class NhanVienDAO
    {
        private NhanVienDAO()
        {

        }

        private static NhanVienDAO instance;
        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance;
            }
        }

        public NhanVienDTO GetNhanVienByID(int id)
        {
            string query = "EXEC sp_GetNhanVien_ByID @ID";
            object[] param = new object[] { id };

            DataTable table = DataProvider.Instance.ExecuteQuery(query, param);

            foreach (DataRow row in table.Rows)
            {
                return new NhanVienDTO(row);
            }

            return null;
        }
    }
}
