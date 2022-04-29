using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DAO
{
    public class ChiNhanhDAO
    {
        private ChiNhanhDAO()
        {
        }

        private static ChiNhanhDAO instance;
        public static ChiNhanhDAO Instance
        {
            get
            {
                if (instance == null)  
                    instance = new ChiNhanhDAO();
                return instance;
            }
        }

        public ChiNhanhDTO GetChiNhanhByID(int chiNhanhID)
        {
            string query = "EXEC sp_GetChiNhanh_ByID @ID";
            object[] param = new object[] { chiNhanhID };

            DataTable table = DataProvider.Instance.ExecuteQuery(query, param);

            foreach (DataRow row in table.Rows)
            {
                return new ChiNhanhDTO(row);
            }

            return null;
        }
    }
}
