using QuanLySach.App.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.App
{
    public class BranchController
    {
        private BranchController()
        {

        }

        private static BranchController instance;
        public static BranchController Instance
        {
            get
            {
                if (instance == null)
                    instance = new BranchController();
                return instance;
            }
        }


        public List<Branch> GetBranchesForCombobox()
        {
            List<Branch> branches = new List<Branch>()
            {
                new Branch() { Title = "Đà Lạt", Code = ChiNhanhEnum.CN_1 },
                new Branch() { Title = "Bảo Lộc", Code = ChiNhanhEnum.CN_2 },
                new Branch() { Title = "Tất cả", Code = ChiNhanhEnum.CN_GOC },
            };

            return branches;
        }
    }
}
