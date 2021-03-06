﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static int exitCode = 1;

        [STAThread]
        static int Main(string[] args)
        {
            String rut = args[0];
            String name = args[1];
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2(rut, name));
            return exitCode;
        }

        public static void ExitApplication(int exitCode)
        {
            Program.exitCode = exitCode;
            Application.Exit();
        }
    }
}
