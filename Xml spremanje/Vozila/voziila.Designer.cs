namespace Vozila
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtGodinaProizvodnje = new System.Windows.Forms.TextBox();
            this.txtKilometraza = new System.Windows.Forms.TextBox();
            this.txtSortiranaLista = new System.Windows.Forms.TextBox();
            this.cmbSortiranje = new System.Windows.Forms.ComboBox();
            this.lstVozila = new System.Windows.Forms.ListBox();
            this.rbUzlazno = new System.Windows.Forms.RadioButton();
            this.rbSilazno = new System.Windows.Forms.RadioButton();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnSortiraj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnSpremiXML = new System.Windows.Forms.Button();
            this.btnUcitajXML = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(54, 85);
            this.txtMarka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(290, 26);
            this.txtMarka.TabIndex = 0;
            this.txtMarka.TextChanged += new System.EventHandler(this.txtMarka_TextChanged);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(54, 158);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(290, 26);
            this.txtModel.TabIndex = 1;
            // 
            // txtGodinaProizvodnje
            // 
            this.txtGodinaProizvodnje.Location = new System.Drawing.Point(54, 254);
            this.txtGodinaProizvodnje.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGodinaProizvodnje.Name = "txtGodinaProizvodnje";
            this.txtGodinaProizvodnje.Size = new System.Drawing.Size(290, 26);
            this.txtGodinaProizvodnje.TabIndex = 2;
            // 
            // txtKilometraza
            // 
            this.txtKilometraza.Location = new System.Drawing.Point(54, 354);
            this.txtKilometraza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKilometraza.Name = "txtKilometraza";
            this.txtKilometraza.Size = new System.Drawing.Size(290, 26);
            this.txtKilometraza.TabIndex = 3;
            // 
            // txtSortiranaLista
            // 
            this.txtSortiranaLista.Location = new System.Drawing.Point(506, 158);
            this.txtSortiranaLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSortiranaLista.Multiline = true;
            this.txtSortiranaLista.Name = "txtSortiranaLista";
            this.txtSortiranaLista.Size = new System.Drawing.Size(290, 224);
            this.txtSortiranaLista.TabIndex = 4;
            // 
            // cmbSortiranje
            // 
            this.cmbSortiranje.FormattingEnabled = true;
            this.cmbSortiranje.Location = new System.Drawing.Point(522, 82);
            this.cmbSortiranje.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSortiranje.Name = "cmbSortiranje";
            this.cmbSortiranje.Size = new System.Drawing.Size(250, 28);
            this.cmbSortiranje.TabIndex = 5;
            this.cmbSortiranje.SelectedIndexChanged += new System.EventHandler(this.cmbSortiranje_SelectedIndexChanged);
            // 
            // lstVozila
            // 
            this.lstVozila.FormattingEnabled = true;
            this.lstVozila.ItemHeight = 20;
            this.lstVozila.Location = new System.Drawing.Point(880, 85);
            this.lstVozila.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstVozila.Name = "lstVozila";
            this.lstVozila.Size = new System.Drawing.Size(300, 304);
            this.lstVozila.TabIndex = 6;
            // 
            // rbUzlazno
            // 
            this.rbUzlazno.AutoSize = true;
            this.rbUzlazno.Location = new System.Drawing.Point(894, 434);
            this.rbUzlazno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbUzlazno.Name = "rbUzlazno";
            this.rbUzlazno.Size = new System.Drawing.Size(92, 24);
            this.rbUzlazno.TabIndex = 7;
            this.rbUzlazno.TabStop = true;
            this.rbUzlazno.Text = "Uzlazno";
            this.rbUzlazno.UseVisualStyleBackColor = true;
            // 
            // rbSilazno
            // 
            this.rbSilazno.AutoSize = true;
            this.rbSilazno.Location = new System.Drawing.Point(894, 485);
            this.rbSilazno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbSilazno.Name = "rbSilazno";
            this.rbSilazno.Size = new System.Drawing.Size(86, 24);
            this.rbSilazno.TabIndex = 8;
            this.rbSilazno.TabStop = true;
            this.rbSilazno.Text = "Silazno";
            this.rbSilazno.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(54, 449);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(206, 35);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj vozilo";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click_1);
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Location = new System.Drawing.Point(328, 449);
            this.btnSortiraj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(206, 35);
            this.btnSortiraj.TabIndex = 10;
            this.btnSortiraj.Text = "Sortiraj";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            this.btnSortiraj.Click += new System.EventHandler(this.btnSortiraj_Click_1);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(592, 449);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(206, 35);
            this.btnObrisi.TabIndex = 11;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click_1);
            // 
            // btnSpremiXML
            // 
            this.btnSpremiXML.Location = new System.Drawing.Point(180, 552);
            this.btnSpremiXML.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSpremiXML.Name = "btnSpremiXML";
            this.btnSpremiXML.Size = new System.Drawing.Size(206, 35);
            this.btnSpremiXML.TabIndex = 12;
            this.btnSpremiXML.Text = "Spremi u XML";
            this.btnSpremiXML.UseVisualStyleBackColor = true;
            this.btnSpremiXML.Click += new System.EventHandler(this.btnSpremiXML_Click_1);
            // 
            // btnUcitajXML
            // 
            this.btnUcitajXML.Location = new System.Drawing.Point(484, 552);
            this.btnUcitajXML.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUcitajXML.Name = "btnUcitajXML";
            this.btnUcitajXML.Size = new System.Drawing.Size(206, 35);
            this.btnUcitajXML.TabIndex = 13;
            this.btnUcitajXML.Text = " Učitaj iz XML-a ";
            this.btnUcitajXML.UseVisualStyleBackColor = true;
            this.btnUcitajXML.Click += new System.EventHandler(this.btnUcitajXML_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "GodinaProizvodnje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 329);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Kilometraza";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUcitajXML);
            this.Controls.Add(this.btnSpremiXML);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.rbSilazno);
            this.Controls.Add(this.rbUzlazno);
            this.Controls.Add(this.lstVozila);
            this.Controls.Add(this.cmbSortiranje);
            this.Controls.Add(this.txtSortiranaLista);
            this.Controls.Add(this.txtKilometraza);
            this.Controls.Add(this.txtGodinaProizvodnje);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtGodinaProizvodnje;
        private System.Windows.Forms.TextBox txtKilometraza;
        private System.Windows.Forms.TextBox txtSortiranaLista;
        private System.Windows.Forms.ComboBox cmbSortiranje;
        private System.Windows.Forms.ListBox lstVozila;
        private System.Windows.Forms.RadioButton rbUzlazno;
        private System.Windows.Forms.RadioButton rbSilazno;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnSortiraj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnSpremiXML;
        private System.Windows.Forms.Button btnUcitajXML;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

