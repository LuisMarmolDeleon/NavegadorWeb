using CefSharp;
using CefSharp.WinForms;
using EasyTabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeChromium();
        }

        public ChromiumWebBrowser chromeBrowser;

        private void InitializeChromium()
        {
            CefSettings settings = new();

            if (!Cef.IsInitialized)
            {
                Cef.Initialize(new CefSettings());
            }
            chromeBrowser = new ChromiumWebBrowser("https://google.com");
            panelBody.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;


            //eventos
            chromeBrowser.LoadingStateChanged += cargaPagina;
        }

        private void cargaPagina(object sender, LoadingStateChangedEventArgs e)
        {
            this.Invoke((Action)delegate
            {
                loader.Visible = e.IsLoading;
                textBox1.Text = chromeBrowser.Address;
            }

             );
        }

        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                cargarpagina(textBox1.Text.Trim());
            }
        }

        void cargarpagina(string link)
        {
            if (link.StartsWith("http"))
            {
                chromeBrowser.Load(link);
            }
            else
            {
                chromeBrowser.Load($"https://www.google.com/search?q={link}");
            }
        }

        private void leftbtn_Click(object sender, EventArgs e)
        {
            if (chromeBrowser.CanGoBack)
            {
                chromeBrowser.Back();
            }
        }

        private void relbtn_Click(object sender, EventArgs e)
        {
            chromeBrowser.Reload();
        }
    }
}
