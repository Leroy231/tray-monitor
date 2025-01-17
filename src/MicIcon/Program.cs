﻿using TrayIconLibrary;
using System;
using System.Windows.Forms;

namespace MicIcon
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
            TrayIcon trayIcon = new CustomTrayIcon();
            Application.Run();
        }
    }
}
