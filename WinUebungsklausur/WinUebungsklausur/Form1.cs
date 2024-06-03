using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUebungsklausur {
    public partial class Form1 : Form {

        List<string> books = new List<string> { 
            "Mein Kampf,Hitler,1945",
            "Test Buch,Mustermann,1922"
        };

        public Form1 () {
            InitializeComponent( );
            listUpdate( );
        }

        private void btnAdd_Click ( object sender, EventArgs e ) {

            if(!string.IsNullOrEmpty(tbTitel.Text) &&
               !string.IsNullOrEmpty(tbAutor.Text) &&
               !string.IsNullOrEmpty(tbVDatum.Text)) {

                books.Add(tbTitel.Text + "," + tbAutor.Text + "," + tbVDatum.Text);
                listUpdate( );
                tbClear( );
            }

        }
        private void btnRemove_Click ( object sender, EventArgs e ) {

            if(lbBooks.SelectedIndex != -1) {
                books.RemoveAt(lbBooks.SelectedIndex);
                listUpdate( );
            }

        }

        private void listUpdate() {
            lbBooks.DataSource = null;
            lbBooks.DataSource = books;
        }

        private void tbClear() {
            tbTitel.Text = string.Empty;
            tbAutor.Text = string.Empty;
            tbVDatum.Text = string.Empty;
        }

        private void lbBooks_SelectedIndexChanged ( object sender, EventArgs e ) {

        }

        private void tbAutor_TextChanged ( object sender, EventArgs e ) {

        }

        private void tbVDatum_TextChanged ( object sender, EventArgs e ) {

        }

        private void tbTitel_TextChanged ( object sender, EventArgs e ) {

        }
    }
}
