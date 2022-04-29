using QuanLySach.App.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.App
{
    public class AppManager
    {
        private AppManager() 
        {
            Cart = new Cart();
        }

        private static AppManager instance;
        public static AppManager Instance
        {
            get
            {
                if (instance == null)  
                    instance = new AppManager();
                return instance;
            }
        }

        public User User { get; set; }
        public Customer Customer { get; set; }
        public Cart Cart { get; set; }
        public bool IsNewLoggedInSession { get; set; }
    }
}
