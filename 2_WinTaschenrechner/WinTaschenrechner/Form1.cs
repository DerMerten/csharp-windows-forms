using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTaschenrechner {
    public partial class Form1 : Form {

        double firstNum = 0;
        string operation;
        public Form1 () {
            InitializeComponent( );
        }

        private void btnClear_Click ( object sender, EventArgs e ) {
            txtMain.Text = "0";
        }

        private void btn0Zahl_Click ( object sender, EventArgs e ) {
            txtMain.Text = "0";
        }

        private void btn1Zahl_Click ( object sender, EventArgs e ) {
            if (txtMain.Text == "1" && txtMain.Text != null) {
                txtMain.Text = "1";
            }
            else {
                txtMain.Text += "1";
            }
        }

        private void btn2Zahl_Click ( object sender, EventArgs e ) {
            if (txtMain.Text == "2" && txtMain.Text != null) {
                txtMain.Text = "2";
            }
            else {
                txtMain.Text += "2";
            }
        }

        private void btn3Zahl_Click ( object sender, EventArgs e ) {
            if (txtMain.Text == "3" && txtMain.Text != null) {
                txtMain.Text = "3";
            }
            else {
                txtMain.Text += "3";
            }
        }

        private void btn4Zahl_Click ( object sender, EventArgs e ) {
            if (txtMain.Text == "4" && txtMain.Text != null) {
                txtMain.Text = "4";
            }
            else {
                txtMain.Text += "4";
            }
        }

        private void btn5Zahl_Click ( object sender, EventArgs e ) {
            if (txtMain.Text == "5" && txtMain.Text != null) {
                txtMain.Text = "5";
            }
            else {
                txtMain.Text += "5";
            }
        }

        private void btn6Zahl_Click ( object sender, EventArgs e ) {
            if (txtMain.Text == "6" && txtMain.Text != null) {
                txtMain.Text = "6";
            }
            else {
                txtMain.Text += "6";
            }
        }

        private void btn7Zahl_Click ( object sender, EventArgs e ) {
            if (txtMain.Text == "7" && txtMain.Text != null) {
                txtMain.Text = "7";
            }
            else {
                txtMain.Text += "7";
            }
        }

        private void btn8Zahl_Click ( object sender, EventArgs e ) {
            if (txtMain.Text == "8" && txtMain.Text != null) {
                txtMain.Text = "8";
            }
            else {
                txtMain.Text += "8";
            }
        }

        private void btn9Zahl_Click ( object sender, EventArgs e ) {
            if (txtMain.Text == "9" && txtMain.Text != null) {
                txtMain.Text = "9";
            }
            else {
                txtMain.Text += "9";
            }
        }

        private void btnAdd_Click ( object sender, EventArgs e ) {
            firstNum = Convert.ToDouble(txtMain.Text);
            txtMain.Text = "0";
            operation = "+";
        }

        private void btnSub_Click ( object sender, EventArgs e ) {
            firstNum = Convert.ToDouble(txtMain.Text);
            txtMain.Text = "0";
            operation = "-";
        }

        private void btnMulti_Click ( object sender, EventArgs e ) {
            firstNum = Convert.ToDouble(txtMain.Text);
            txtMain.Text = "0";
            operation = "*";
        }

        private void btnDivid_Click ( object sender, EventArgs e ) {
            firstNum = Convert.ToDouble(txtMain.Text);
            txtMain.Text = "0";
            operation = "/";
        }

        private void btnEqual_Click ( object sender, EventArgs e ) {
            double secNum = 0;
            double result = 0;

            secNum = Convert.ToDouble(txtMain.Text);

            if( operation == "+") {
                result = (firstNum + secNum);
                txtMain.Text = Convert.ToString(result);
                firstNum = result;
            }

            if (operation == "-") {
                result = (firstNum - secNum);
                txtMain.Text = Convert.ToString(result);
                firstNum = result;
            }

            if (operation == "*") {
                result = (firstNum * secNum);
                txtMain.Text = Convert.ToString(result);
                firstNum = result;
            }

            if (operation == "/") {
                if(secNum == 0) {
                    txtMain.Text = "Teilen durch 0 nicht möglich";
                }
                else {
                    result = (firstNum / secNum);
                    txtMain.Text = Convert.ToString(result);
                    firstNum = result;
                }
            }
        }

        private void txtMain_TextChanged ( object sender, EventArgs e ) {

        }
    }
}
