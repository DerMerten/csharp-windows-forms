namespace _5_WinSchuelerliste {
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
            this.tbVorname = new System.Windows.Forms.TextBox();
            this.btnAddtoList = new System.Windows.Forms.Button();
            this.lbData = new System.Windows.Forms.ListBox();
            this.tbKlasse = new System.Windows.Forms.TextBox();
            this.tbGeburtsdatum = new System.Windows.Forms.TextBox();
            this.tbNachname = new System.Windows.Forms.TextBox();
            this.lVorname = new System.Windows.Forms.Label();
            this.lKlasse = new System.Windows.Forms.Label();
            this.lGeburtsdatum = new System.Windows.Forms.Label();
            this.lNachname = new System.Windows.Forms.Label();
            this.lSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lOutNachname = new System.Windows.Forms.Label();
            this.lOutGeburtsdatum = new System.Windows.Forms.Label();
            this.lOutKlasse = new System.Windows.Forms.Label();
            this.lOutVorname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbVorname
            // 
            this.tbVorname.Location = new System.Drawing.Point(12, 59);
            this.tbVorname.Name = "tbVorname";
            this.tbVorname.Size = new System.Drawing.Size(73, 20);
            this.tbVorname.TabIndex = 0;
            this.tbVorname.TextChanged += new System.EventHandler(this.tbVorname_TextChanged);
            // 
            // btnAddtoList
            // 
            this.btnAddtoList.Location = new System.Drawing.Point(409, 56);
            this.btnAddtoList.Name = "btnAddtoList";
            this.btnAddtoList.Size = new System.Drawing.Size(75, 23);
            this.btnAddtoList.TabIndex = 4;
            this.btnAddtoList.Text = "Hinzufügen";
            this.btnAddtoList.UseVisualStyleBackColor = true;
            this.btnAddtoList.Click += new System.EventHandler(this.btnAddtoList_Click);
            // 
            // lbData
            // 
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.FormattingEnabled = true;
            this.lbData.ItemHeight = 16;
            this.lbData.Location = new System.Drawing.Point(12, 105);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(408, 100);
            this.lbData.TabIndex = 5;
            this.lbData.SelectedIndexChanged += new System.EventHandler(this.lbDaten_SelectedIndexChanged);
            // 
            // tbKlasse
            // 
            this.tbKlasse.Location = new System.Drawing.Point(300, 59);
            this.tbKlasse.Name = "tbKlasse";
            this.tbKlasse.Size = new System.Drawing.Size(73, 20);
            this.tbKlasse.TabIndex = 7;
            this.tbKlasse.TextChanged += new System.EventHandler(this.tbKlasse_TextChanged);
            // 
            // tbGeburtsdatum
            // 
            this.tbGeburtsdatum.Location = new System.Drawing.Point(207, 59);
            this.tbGeburtsdatum.Name = "tbGeburtsdatum";
            this.tbGeburtsdatum.Size = new System.Drawing.Size(73, 20);
            this.tbGeburtsdatum.TabIndex = 8;
            this.tbGeburtsdatum.TextChanged += new System.EventHandler(this.tbGeburtsdatum_TextChanged);
            // 
            // tbNachname
            // 
            this.tbNachname.Location = new System.Drawing.Point(106, 59);
            this.tbNachname.Name = "tbNachname";
            this.tbNachname.Size = new System.Drawing.Size(73, 20);
            this.tbNachname.TabIndex = 9;
            this.tbNachname.TextChanged += new System.EventHandler(this.tbNachname_TextChanged);
            // 
            // lVorname
            // 
            this.lVorname.AutoSize = true;
            this.lVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVorname.Location = new System.Drawing.Point(12, 29);
            this.lVorname.Name = "lVorname";
            this.lVorname.Size = new System.Drawing.Size(62, 16);
            this.lVorname.TabIndex = 10;
            this.lVorname.Text = "Vorname";
            // 
            // lKlasse
            // 
            this.lKlasse.AutoSize = true;
            this.lKlasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lKlasse.Location = new System.Drawing.Point(297, 29);
            this.lKlasse.Name = "lKlasse";
            this.lKlasse.Size = new System.Drawing.Size(48, 16);
            this.lKlasse.TabIndex = 11;
            this.lKlasse.Text = "Klasse";
            // 
            // lGeburtsdatum
            // 
            this.lGeburtsdatum.AutoSize = true;
            this.lGeburtsdatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGeburtsdatum.Location = new System.Drawing.Point(204, 29);
            this.lGeburtsdatum.Name = "lGeburtsdatum";
            this.lGeburtsdatum.Size = new System.Drawing.Size(91, 16);
            this.lGeburtsdatum.TabIndex = 12;
            this.lGeburtsdatum.Text = "Geburtsdatum";
            // 
            // lNachname
            // 
            this.lNachname.AutoSize = true;
            this.lNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNachname.Location = new System.Drawing.Point(103, 29);
            this.lNachname.Name = "lNachname";
            this.lNachname.Size = new System.Drawing.Size(73, 16);
            this.lNachname.TabIndex = 13;
            this.lNachname.Text = "Nachname";
            // 
            // lSearch
            // 
            this.lSearch.AutoSize = true;
            this.lSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSearch.Location = new System.Drawing.Point(12, 231);
            this.lSearch.Name = "lSearch";
            this.lSearch.Size = new System.Drawing.Size(45, 16);
            this.lSearch.TabIndex = 15;
            this.lSearch.Text = "Suche";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(15, 262);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(301, 20);
            this.tbSearch.TabIndex = 14;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lOutNachname
            // 
            this.lOutNachname.AutoSize = true;
            this.lOutNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOutNachname.Location = new System.Drawing.Point(103, 315);
            this.lOutNachname.Name = "lOutNachname";
            this.lOutNachname.Size = new System.Drawing.Size(73, 16);
            this.lOutNachname.TabIndex = 19;
            this.lOutNachname.Text = "Nachname";
            // 
            // lOutGeburtsdatum
            // 
            this.lOutGeburtsdatum.AutoSize = true;
            this.lOutGeburtsdatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOutGeburtsdatum.Location = new System.Drawing.Point(204, 315);
            this.lOutGeburtsdatum.Name = "lOutGeburtsdatum";
            this.lOutGeburtsdatum.Size = new System.Drawing.Size(91, 16);
            this.lOutGeburtsdatum.TabIndex = 18;
            this.lOutGeburtsdatum.Text = "Geburtsdatum";
            // 
            // lOutKlasse
            // 
            this.lOutKlasse.AutoSize = true;
            this.lOutKlasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOutKlasse.Location = new System.Drawing.Point(297, 315);
            this.lOutKlasse.Name = "lOutKlasse";
            this.lOutKlasse.Size = new System.Drawing.Size(48, 16);
            this.lOutKlasse.TabIndex = 17;
            this.lOutKlasse.Text = "Klasse";
            // 
            // lOutVorname
            // 
            this.lOutVorname.AutoSize = true;
            this.lOutVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOutVorname.Location = new System.Drawing.Point(12, 315);
            this.lOutVorname.Name = "lOutVorname";
            this.lOutVorname.Size = new System.Drawing.Size(62, 16);
            this.lOutVorname.TabIndex = 16;
            this.lOutVorname.Text = "Vorname";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lOutNachname);
            this.Controls.Add(this.lOutGeburtsdatum);
            this.Controls.Add(this.lOutKlasse);
            this.Controls.Add(this.lOutVorname);
            this.Controls.Add(this.lSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lNachname);
            this.Controls.Add(this.lGeburtsdatum);
            this.Controls.Add(this.lKlasse);
            this.Controls.Add(this.lVorname);
            this.Controls.Add(this.tbNachname);
            this.Controls.Add(this.tbGeburtsdatum);
            this.Controls.Add(this.tbKlasse);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.btnAddtoList);
            this.Controls.Add(this.tbVorname);
            this.Name = "Form1";
            this.Text = "Schülerliste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbVorname;
        private System.Windows.Forms.Button btnAddtoList;
        private System.Windows.Forms.ListBox lbData;
        private System.Windows.Forms.TextBox tbKlasse;
        private System.Windows.Forms.TextBox tbGeburtsdatum;
        private System.Windows.Forms.TextBox tbNachname;
        private System.Windows.Forms.Label lVorname;
        private System.Windows.Forms.Label lKlasse;
        private System.Windows.Forms.Label lGeburtsdatum;
        private System.Windows.Forms.Label lNachname;
        private System.Windows.Forms.Label lSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lOutNachname;
        private System.Windows.Forms.Label lOutGeburtsdatum;
        private System.Windows.Forms.Label lOutKlasse;
        private System.Windows.Forms.Label lOutVorname;
    }
}

