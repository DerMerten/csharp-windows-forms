namespace WinTaschenrechner {
    partial class Form1 {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose ( bool disposing ) {
            if (disposing && (components != null)) {
                components.Dispose( );
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent () {
            this.btnClear = new System.Windows.Forms.Button();
            this.btn1Zahl = new System.Windows.Forms.Button();
            this.btn4Zahl = new System.Windows.Forms.Button();
            this.btn0Zahl = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btn2Zahl = new System.Windows.Forms.Button();
            this.btn3Zahl = new System.Windows.Forms.Button();
            this.btn5Zahl = new System.Windows.Forms.Button();
            this.btn6Zahl = new System.Windows.Forms.Button();
            this.btn7Zahl = new System.Windows.Forms.Button();
            this.btn8Zahl = new System.Windows.Forms.Button();
            this.btn9Zahl = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDivid = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(104, 368);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 60);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn1Zahl
            // 
            this.btn1Zahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Zahl.Location = new System.Drawing.Point(104, 302);
            this.btn1Zahl.Name = "btn1Zahl";
            this.btn1Zahl.Size = new System.Drawing.Size(134, 60);
            this.btn1Zahl.TabIndex = 1;
            this.btn1Zahl.Text = "1";
            this.btn1Zahl.UseVisualStyleBackColor = true;
            this.btn1Zahl.Click += new System.EventHandler(this.btn1Zahl_Click);
            // 
            // btn4Zahl
            // 
            this.btn4Zahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4Zahl.Location = new System.Drawing.Point(104, 236);
            this.btn4Zahl.Name = "btn4Zahl";
            this.btn4Zahl.Size = new System.Drawing.Size(134, 60);
            this.btn4Zahl.TabIndex = 2;
            this.btn4Zahl.Text = "4";
            this.btn4Zahl.UseVisualStyleBackColor = true;
            this.btn4Zahl.Click += new System.EventHandler(this.btn4Zahl_Click);
            // 
            // btn0Zahl
            // 
            this.btn0Zahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0Zahl.Location = new System.Drawing.Point(244, 368);
            this.btn0Zahl.Name = "btn0Zahl";
            this.btn0Zahl.Size = new System.Drawing.Size(134, 60);
            this.btn0Zahl.TabIndex = 3;
            this.btn0Zahl.Text = "0";
            this.btn0Zahl.UseVisualStyleBackColor = true;
            this.btn0Zahl.Click += new System.EventHandler(this.btn0Zahl_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(384, 368);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(134, 60);
            this.btnEqual.TabIndex = 4;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btn2Zahl
            // 
            this.btn2Zahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Zahl.Location = new System.Drawing.Point(244, 302);
            this.btn2Zahl.Name = "btn2Zahl";
            this.btn2Zahl.Size = new System.Drawing.Size(134, 60);
            this.btn2Zahl.TabIndex = 5;
            this.btn2Zahl.Text = "2";
            this.btn2Zahl.UseVisualStyleBackColor = true;
            this.btn2Zahl.Click += new System.EventHandler(this.btn2Zahl_Click);
            // 
            // btn3Zahl
            // 
            this.btn3Zahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3Zahl.Location = new System.Drawing.Point(384, 302);
            this.btn3Zahl.Name = "btn3Zahl";
            this.btn3Zahl.Size = new System.Drawing.Size(134, 60);
            this.btn3Zahl.TabIndex = 6;
            this.btn3Zahl.Text = "3";
            this.btn3Zahl.UseVisualStyleBackColor = true;
            this.btn3Zahl.Click += new System.EventHandler(this.btn3Zahl_Click);
            // 
            // btn5Zahl
            // 
            this.btn5Zahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5Zahl.Location = new System.Drawing.Point(244, 236);
            this.btn5Zahl.Name = "btn5Zahl";
            this.btn5Zahl.Size = new System.Drawing.Size(134, 60);
            this.btn5Zahl.TabIndex = 7;
            this.btn5Zahl.Text = "5";
            this.btn5Zahl.UseVisualStyleBackColor = true;
            this.btn5Zahl.Click += new System.EventHandler(this.btn5Zahl_Click);
            // 
            // btn6Zahl
            // 
            this.btn6Zahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6Zahl.Location = new System.Drawing.Point(384, 236);
            this.btn6Zahl.Name = "btn6Zahl";
            this.btn6Zahl.Size = new System.Drawing.Size(134, 60);
            this.btn6Zahl.TabIndex = 8;
            this.btn6Zahl.Text = "6";
            this.btn6Zahl.UseVisualStyleBackColor = true;
            this.btn6Zahl.Click += new System.EventHandler(this.btn6Zahl_Click);
            // 
            // btn7Zahl
            // 
            this.btn7Zahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7Zahl.Location = new System.Drawing.Point(104, 170);
            this.btn7Zahl.Name = "btn7Zahl";
            this.btn7Zahl.Size = new System.Drawing.Size(134, 60);
            this.btn7Zahl.TabIndex = 9;
            this.btn7Zahl.Text = "7";
            this.btn7Zahl.UseVisualStyleBackColor = true;
            this.btn7Zahl.Click += new System.EventHandler(this.btn7Zahl_Click);
            // 
            // btn8Zahl
            // 
            this.btn8Zahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8Zahl.Location = new System.Drawing.Point(244, 170);
            this.btn8Zahl.Name = "btn8Zahl";
            this.btn8Zahl.Size = new System.Drawing.Size(134, 60);
            this.btn8Zahl.TabIndex = 10;
            this.btn8Zahl.Text = "8";
            this.btn8Zahl.UseVisualStyleBackColor = true;
            this.btn8Zahl.Click += new System.EventHandler(this.btn8Zahl_Click);
            // 
            // btn9Zahl
            // 
            this.btn9Zahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9Zahl.Location = new System.Drawing.Point(384, 170);
            this.btn9Zahl.Name = "btn9Zahl";
            this.btn9Zahl.Size = new System.Drawing.Size(134, 60);
            this.btn9Zahl.TabIndex = 11;
            this.btn9Zahl.Text = "9";
            this.btn9Zahl.UseVisualStyleBackColor = true;
            this.btn9Zahl.Click += new System.EventHandler(this.btn9Zahl_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(524, 302);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(134, 60);
            this.btnSub.TabIndex = 12;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.Location = new System.Drawing.Point(524, 236);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(134, 60);
            this.btnMulti.TabIndex = 13;
            this.btnMulti.Text = "x";
            this.btnMulti.UseVisualStyleBackColor = false;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnDivid
            // 
            this.btnDivid.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDivid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivid.Location = new System.Drawing.Point(524, 170);
            this.btnDivid.Name = "btnDivid";
            this.btnDivid.Size = new System.Drawing.Size(134, 60);
            this.btnDivid.TabIndex = 14;
            this.btnDivid.Text = "÷";
            this.btnDivid.UseVisualStyleBackColor = false;
            this.btnDivid.Click += new System.EventHandler(this.btnDivid_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(524, 368);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 60);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMain
            // 
            this.txtMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMain.Location = new System.Drawing.Point(104, 127);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(554, 38);
            this.txtMain.TabIndex = 16;
            this.txtMain.TextChanged += new System.EventHandler(this.txtMain_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMain);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDivid);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btn9Zahl);
            this.Controls.Add(this.btn8Zahl);
            this.Controls.Add(this.btn7Zahl);
            this.Controls.Add(this.btn6Zahl);
            this.Controls.Add(this.btn5Zahl);
            this.Controls.Add(this.btn3Zahl);
            this.Controls.Add(this.btn2Zahl);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btn0Zahl);
            this.Controls.Add(this.btn4Zahl);
            this.Controls.Add(this.btn1Zahl);
            this.Controls.Add(this.btnClear);
            this.Name = "Form1";
            this.Text = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn1Zahl;
        private System.Windows.Forms.Button btn4Zahl;
        private System.Windows.Forms.Button btn0Zahl;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btn2Zahl;
        private System.Windows.Forms.Button btn3Zahl;
        private System.Windows.Forms.Button btn5Zahl;
        private System.Windows.Forms.Button btn6Zahl;
        private System.Windows.Forms.Button btn7Zahl;
        private System.Windows.Forms.Button btn8Zahl;
        private System.Windows.Forms.Button btn9Zahl;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDivid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtMain;
    }
}

