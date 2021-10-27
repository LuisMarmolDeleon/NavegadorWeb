using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;


namespace WinFormsApp1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //login bunifu
        

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();

            AppContainer container = new();

            container.Tabs.Add
            (
                new EasyTabs.TitleBarTab(container)
                {
                    Content = new Form1
                    {
                        Text = "Nueva Pestaña"
                    }
                }
            );

            container.SelectedTabIndex = 0;

            TitleBarTabsApplicationContext applicationContext = new();
            applicationContext.Start(container);
            Application.Run(applicationContext);
        }
    }
}
