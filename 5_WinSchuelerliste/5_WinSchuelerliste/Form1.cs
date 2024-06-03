using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace _5_WinSchuelerliste {
    public partial class Form1 : Form {

        List<string> schueler = new List<string> {
            "Max,Mustermann,01.01.2024,IA4",
            "Marten,Othman,07.11.2005,IA2B"
        };

        public Form1 () {
            InitializeComponent( );
            updateList( );
        }

        private void btnAddtoList_Click ( object sender, EventArgs e ) {
            if (!string.IsNullOrEmpty(tbVorname.Text) &&
                !string.IsNullOrEmpty(tbNachname.Text) &&
                !string.IsNullOrEmpty(tbGeburtsdatum.Text) &&
                !string.IsNullOrEmpty(tbKlasse.Text)) {

                schueler.Add(tbVorname.Text + ";" + tbNachname.Text + ";" + tbGeburtsdatum.Text + ";" + tbKlasse.Text);
                updateList( );
                clearTB( );
            }
        }

        private void updateList () {
            lbData.DataSource = null;
            lbData.DataSource = schueler;
        }

        private void clearTB () {
            tbVorname.Text = null;
            tbNachname.Text = null;
            tbGeburtsdatum.Text = null;
            tbKlasse.Text = null;
        }

        private void tbVorname_TextChanged ( object sender, EventArgs e ) {

        }

        private void tbGeburtsdatum_TextChanged ( object sender, EventArgs e ) {

        }

        private void tbKlasse_TextChanged ( object sender, EventArgs e ) {

        }

        private void lbDaten_SelectedIndexChanged ( object sender, EventArgs e ) {

        }

        private void tbNachname_TextChanged ( object sender, EventArgs e ) {

        }

        private void tbSearch_TextChanged ( object sender, EventArgs e ) {

            if (!string.IsNullOrEmpty(tbSearch.Text)) {
                lOutVorname.Text = null;
                lOutNachname.Text = null;
                lOutGeburtsdatum.Text = null;
                lOutKlasse.Text = null;
            }

            for (int i = 0; i < schueler.Count; i++) {
                string [] schuelerOut = schueler [ i ].Split(',');

                if (schuelerOut [ 0 ].ToLower( ).Contains(tbSearch.Text.ToLower( ))) {
                    lOutVorname.Text = schuelerOut [ 0 ];
                    lOutNachname.Text = schuelerOut [ 1 ];
                    lOutGeburtsdatum.Text = schuelerOut [ 2 ];
                    lOutKlasse.Text = schuelerOut [ 3 ];
                    return;
                }

                lOutVorname.Text = null;
                lOutNachname.Text = null;
                lOutGeburtsdatum.Text = null;
                lOutKlasse.Text = null;
            }

        }
    }
}
