using System.Drawing;
using System.Windows.Forms;
using CefSharp;
using CefSharp.Internals;



namespace BatuhanKitaplık
{
    public partial class KitaplikGSearch : Form
    {
        public KitaplikGSearch()
        {
            InitializeComponent();
        }

        public CefSharp.WinForms.ChromiumWebBrowser browser;
        
        private void BatuhanKitaplikGSearch_Load(object sender, System.EventArgs e)
        {
            browser = new CefSharp.WinForms.ChromiumWebBrowser("https://www.google.com")
            {
                Dock = DockStyle.Fill,
                Size = new Size(600, 600),
                Location = new Point(200,200)
                
            };
            this.Controls.Add(browser);
        }
    }
}
