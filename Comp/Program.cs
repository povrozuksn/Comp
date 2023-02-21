﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Comp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SQLClass.CONN = new MySqlConnection(SQLClass.CONNECTION_STRING);
            SQLClass.CONN.Open();
            DesignUserControl.ReadDefaultDesign();

            Application.Run(new MainForm());

            SQLClass.CONN.Close();
        }
    }
}
