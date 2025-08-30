using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using Microsoft.Web.WebView2.WinForms;
using webWinForm = Microsoft.Web.WebView2.WinForms;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Wpf;



namespace STA
{
    public partial class Form1 : Form
    {
        private webWinForm.WebView2 webView;

        public Form1()
        {
            InitializeComponent();
            InitThisForm();
        }

        private void InitThisForm()
        {
        
            emptyLbl.Text = " ";
            this.WindowState = FormWindowState.Maximized;
            searchWebBtn.Text = "🌐 Search";
            browseBtn.Text = " ➤ ";
            keyWordsTxt.Text = "short term accommodation" + Environment.NewLine + "hotel property valuation" + Environment.NewLine + "property valuation approaches" + Environment.NewLine + "property appraisal methods" + Environment.NewLine + "hotel type";


            webView = new webWinForm.WebView2();
            webView.Dock = DockStyle.Fill;
            browserPnl.Controls.Add(webView);
            webView.Source = new Uri("about:blank");
            webView.Top = foundUrlsListBox.Top;
            webView.Left = 1500;

            browserPnl.Visible = false;
            //searchWebBtn.Focus();
            searchWebBtn.Select();
            foundUrlsListBox.Items.Clear();
        }


        private void searchWebBtn_Click(object sender, EventArgs e)
        {
            string pythonExe = @"C:\Users\YuanG\AppData\Local\miniconda3\python.exe";
            string scriptPath = @"C:\Users\YuanG\OneDrive - Government of Ontario (1)\Documents\00_AI_Part_2_July2025\Hotel_ShortTerm_Accommo\hello1.py";

            string argument = "G.Y.";

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = pythonExe;
            psi.Arguments = $"\"{scriptPath}\" {argument}";
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;

            using (Process process = Process.Start(psi))
            {
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                MessageBox.Show(output);
            }
        }

        //private void Form1_ResizeEnd(object sender, EventArgs e)
        //{

        //}

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            browserPnl.Width = this.Width - browserPnl.Left - 120;
            //extractBrowserPnl.Width = browserPnl.Width;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showFoundUrlsBtn_Click(object sender, EventArgs e)
        {
            foundUrlsListBox.Items.Clear();
            foundUrlsListBox.Items.Add("https://www.oakville.ca/business-development/licences/short-term-accommodation-licence/");
            foundUrlsListBox.Items.Add("https://files.ontario.ca/edu-learning-for-all-2013-en-2022-01-28.pdf");
            foundUrlsListBox.Items.Add("https://www.supportedemployment.ca/hrtoolkit/accommodations");
            foundUrlsListBox.Items.Add("https://www.oakville.ca/getmedia/7e483e5e-2b81-4834-9343-63ab009f12d0/zoning-by-law-2014-014-part-03-definitions.pdf");


        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            if (foundUrlsListBox.SelectedIndex < 0)
            { 
                MessageBox.Show("Please select a URL from the list first.");
                return;
            }
            
            browserPnl.Visible = true;
            browserPnl.Top = keyWordsTxt.Top;
            browserPnl.Height = this.Height - browserPnl.Top -120;
            webView.Source = new Uri(foundUrlsListBox.SelectedItem.ToString());


        }
    }
}
