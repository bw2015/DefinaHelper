using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DefinaClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string url = $"https://defina.a8.to/index.html?v={DateTime.Now.Ticks}";
            ChromiumWebBrowser webview = new ChromiumWebBrowser(url);
            webview.Dock = DockStyle.Fill;
            webview.MenuHandler = new MenuHandler();
            this.Controls.Add(webview);
        }
    }
}
