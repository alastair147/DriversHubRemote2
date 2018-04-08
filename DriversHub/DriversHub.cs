using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriversHub
{
    public partial class DriversHub : Form
    {
        public DriversHub()
        {
            InitializeComponent();

            //START LOADING 
            System.Threading.Thread.Sleep(2000);
            this.BackColor = Color.HotPink;

            //LoadingBar
            Loading_Bar.Increment(10);
            Loading_Bar.Increment(20);
            Loading_Bar.Increment(10);
            Loading_Bar.Increment(20);
            Loading_Bar.Increment(20);
            Loading_Bar.Increment(10);
        }



        private void Driverhub_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //TITLE
            this.Text = "DriversHub";
            Loading_Bar.Hide();
            SendKeys.Send("{ESC}");


        }

        private void DriversHub_Load(object sender, EventArgs e)
        {

        }
    }
}
