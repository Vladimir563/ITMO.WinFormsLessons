﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new WinQuestion());
            //Application.Run(new TestList());
            //Application.Run(new WinContainer());
            //Application.Run(new RegistrationForm());
            Application.Run(new BiblWorm());
        }
    }
}
