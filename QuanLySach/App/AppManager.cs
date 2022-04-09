﻿using QuanLySach.App.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.App
{
    internal class AppManager
    {
        private AppManager() { }

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
    }
}