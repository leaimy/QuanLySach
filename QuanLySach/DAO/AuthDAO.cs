using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DAO
{
    public class AuthDAO
    {
        private AuthDAO()
        {

        }

        private static AuthDAO instance;
        public static AuthDAO Instance
        {
            get
            {
                if (instance == null)  
                    instance = new AuthDAO();
                return instance;
            }
        }

        public LoginInfoDTO GetLoginInfo(string userName)
        {
            string query = "EXEC dbo.sp_GetLoginInfo @LoginName";
            object[] param = new object[] { userName };

            DataTable table = DataProvider.Instance.ExecuteQuery(query, param);

            foreach (DataRow row in table.Rows)
            {
                return new LoginInfoDTO(row);
            }

            return null;
        }
    }
}
