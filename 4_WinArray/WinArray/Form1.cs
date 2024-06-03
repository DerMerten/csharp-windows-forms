using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinArray {
    public partial class form1 : Form {

        int [] arrNum = new int [10];
        
        public form1 () {
            InitializeComponent( );
            lbArray.SelectedIndexChanged += lbArray_SelectedIndexChanged;
        }

        private void tbArray_TextChanged ( object sender, EventArgs e ) {

        }

        private void btnAdd_Click ( object sender, EventArgs e ) {
            string [] inputParts = tbArray.Text.Split(',');

            if (inputParts.Length == arrNum.Length) {
                for (int i = 0; i < arrNum.Length; i++) {
                    if (int.TryParse(inputParts [ i ], out int number)) {
                        arrNum [ i ] = number;
                    }
                    else {
                        MessageBox.Show("Ungültige Eingabe. Bitte geben Sie gültige Zahlen durch Komma getrennt ein.");
                        return;
                    }
                }

                lbArray.Items.Clear( );
                foreach (int number in arrNum) {
                    lbArray.Items.Add(number);
                }

                int summe = BerechneSumme( );
                lbArray.Items.Add($"Summe: {summe}");
            }
            else {
                MessageBox.Show("Bitte geben Sie genau 10 Zahlen durch Komma getrennt ein.");
            }
        }

        private void lbArray_SelectedIndexChanged ( object sender, EventArgs e ) {
            lbArray.Items.Clear( ); 

            foreach (int number in arrNum) {
                lbArray.Items.Add(number);
            }

            int summe = BerechneSumme( );
            lbArray.Items.Add($"Summe: {summe}");
        }
        private int BerechneSumme () {
            return arrNum.Sum( );

        }
    }
}
