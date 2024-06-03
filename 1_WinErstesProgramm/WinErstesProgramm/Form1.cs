using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinErstesProgramm {
    public partial class Form1 : Form {

        int clickCount = 0;
        public Form1 () {
            InitializeComponent( );
        }

        private void btnReset_Click ( object sender, EventArgs e ) {
            clickCount = 0;
            lblCountClicks.Text = "0";
        }

        private void btnClick_Click ( object sender, EventArgs e ) {
            clickCount++;
            lblCountClicks.Text = clickCount.ToString( );
        }
    }
}
