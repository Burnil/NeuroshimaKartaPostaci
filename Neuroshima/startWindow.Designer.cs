namespace Neuroshima {
    partial class StartWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.LabelNazwaBohatera = new System.Windows.Forms.Label();
            this.NazwaBohatera = new System.Windows.Forms.TextBox();
            this.LabelPochodzenie = new System.Windows.Forms.Label();
            this.Pochodzenie = new System.Windows.Forms.ListBox();
            this.LabelProfesja = new System.Windows.Forms.Label();
            this.Profesja = new System.Windows.Forms.ListBox();
            this.LabelPochodzenieCecha = new System.Windows.Forms.Label();
            this.PochodzenieCecha = new System.Windows.Forms.ListBox();
            this.LabelProfesjaCecha = new System.Windows.Forms.Label();
            this.ProfesjaCecha = new System.Windows.Forms.ListBox();
            this.LabelSpec = new System.Windows.Forms.Label();
            this.Spec = new System.Windows.Forms.ComboBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Warning = new System.Windows.Forms.Label();
            this.LabelChoroba = new System.Windows.Forms.Label();
            this.Choroba = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LabelNazwaBohatera
            // 
            this.LabelNazwaBohatera.AutoSize = true;
            this.LabelNazwaBohatera.Location = new System.Drawing.Point(15, 10);
            this.LabelNazwaBohatera.Name = "LabelNazwaBohatera";
            this.LabelNazwaBohatera.Size = new System.Drawing.Size(86, 13);
            this.LabelNazwaBohatera.TabIndex = 0;
            this.LabelNazwaBohatera.Text = "Nazwa Bohatera";
            // 
            // NazwaBohatera
            // 
            this.NazwaBohatera.Location = new System.Drawing.Point(15, 26);
            this.NazwaBohatera.Name = "NazwaBohatera";
            this.NazwaBohatera.Size = new System.Drawing.Size(128, 20);
            this.NazwaBohatera.TabIndex = 1;
            // 
            // LabelPochodzenie
            // 
            this.LabelPochodzenie.AutoSize = true;
            this.LabelPochodzenie.Location = new System.Drawing.Point(15, 53);
            this.LabelPochodzenie.Name = "LabelPochodzenie";
            this.LabelPochodzenie.Size = new System.Drawing.Size(69, 13);
            this.LabelPochodzenie.TabIndex = 2;
            this.LabelPochodzenie.Text = "Pochodzenie";
            // 
            // Pochodzenie
            // 
            this.Pochodzenie.FormattingEnabled = true;
            this.Pochodzenie.Items.AddRange(new object[] {
            "Federacja Apallachów",
            "Nowy Jork",
            "Teksas"});
            this.Pochodzenie.Location = new System.Drawing.Point(15, 69);
            this.Pochodzenie.Name = "Pochodzenie";
            this.Pochodzenie.Size = new System.Drawing.Size(128, 95);
            this.Pochodzenie.TabIndex = 3;
            this.Pochodzenie.SelectedIndexChanged += new System.EventHandler(this.PochodzenieSelectedIndexChanged);
            // 
            // LabelProfesja
            // 
            this.LabelProfesja.AutoSize = true;
            this.LabelProfesja.Location = new System.Drawing.Point(15, 173);
            this.LabelProfesja.Name = "LabelProfesja";
            this.LabelProfesja.Size = new System.Drawing.Size(45, 13);
            this.LabelProfesja.TabIndex = 4;
            this.LabelProfesja.Text = "Profesja";
            // 
            // Profesja
            // 
            this.Profesja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Profesja.FormattingEnabled = true;
            this.Profesja.Items.AddRange(new object[] {
            "Kaznodzieja",
            "Monter"});
            this.Profesja.Location = new System.Drawing.Point(15, 189);
            this.Profesja.Name = "Profesja";
            this.Profesja.Size = new System.Drawing.Size(128, 93);
            this.Profesja.TabIndex = 5;
            this.Profesja.SelectedIndexChanged += new System.EventHandler(this.ProfesjaSelectedIndexChanged);
            // 
            // LabelPochodzenieCecha
            // 
            this.LabelPochodzenieCecha.AutoSize = true;
            this.LabelPochodzenieCecha.Location = new System.Drawing.Point(149, 53);
            this.LabelPochodzenieCecha.Name = "LabelPochodzenieCecha";
            this.LabelPochodzenieCecha.Size = new System.Drawing.Size(110, 13);
            this.LabelPochodzenieCecha.TabIndex = 6;
            this.LabelPochodzenieCecha.Text = "Cecha z pochodzenia";
            // 
            // PochodzenieCecha
            // 
            this.PochodzenieCecha.FormattingEnabled = true;
            this.PochodzenieCecha.Location = new System.Drawing.Point(149, 69);
            this.PochodzenieCecha.Name = "PochodzenieCecha";
            this.PochodzenieCecha.Size = new System.Drawing.Size(200, 43);
            this.PochodzenieCecha.TabIndex = 7;
            // 
            // LabelProfesjaCecha
            // 
            this.LabelProfesjaCecha.AutoSize = true;
            this.LabelProfesjaCecha.Location = new System.Drawing.Point(149, 173);
            this.LabelProfesjaCecha.Name = "LabelProfesjaCecha";
            this.LabelProfesjaCecha.Size = new System.Drawing.Size(82, 13);
            this.LabelProfesjaCecha.TabIndex = 8;
            this.LabelProfesjaCecha.Text = "Cecha z profesji";
            // 
            // ProfesjaCecha
            // 
            this.ProfesjaCecha.FormattingEnabled = true;
            this.ProfesjaCecha.Location = new System.Drawing.Point(149, 189);
            this.ProfesjaCecha.Name = "ProfesjaCecha";
            this.ProfesjaCecha.Size = new System.Drawing.Size(200, 30);
            this.ProfesjaCecha.TabIndex = 9;
            // 
            // LabelSpec
            // 
            this.LabelSpec.AutoSize = true;
            this.LabelSpec.Location = new System.Drawing.Point(149, 9);
            this.LabelSpec.Name = "LabelSpec";
            this.LabelSpec.Size = new System.Drawing.Size(69, 13);
            this.LabelSpec.TabIndex = 10;
            this.LabelSpec.Text = "Specjalizacja";
            // 
            // Spec
            // 
            this.Spec.FormattingEnabled = true;
            this.Spec.Items.AddRange(new object[] {
            "Wojownik",
            "Ranger",
            "Cwaniak",
            "Technik"});
            this.Spec.Location = new System.Drawing.Point(149, 25);
            this.Spec.Name = "Spec";
            this.Spec.Size = new System.Drawing.Size(121, 21);
            this.Spec.TabIndex = 11;
            // 
            // Submit
            // 
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Submit.Location = new System.Drawing.Point(149, 245);
            this.Submit.Name = "Submit";
            this.Submit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Submit.Size = new System.Drawing.Size(200, 39);
            this.Submit.TabIndex = 12;
            this.Submit.Text = "Przejdź dalej";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.SubmitClick);
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Warning.ForeColor = System.Drawing.Color.White;
            this.Warning.Location = new System.Drawing.Point(149, 226);
            this.Warning.Name = "Warning";
            this.Warning.Padding = new System.Windows.Forms.Padding(2);
            this.Warning.Size = new System.Drawing.Size(148, 17);
            this.Warning.TabIndex = 13;
            this.Warning.Text = "Nie wypełniłeś wszytkich pól";
            this.Warning.Visible = false;
            // 
            // LabelChoroba
            // 
            this.LabelChoroba.AutoSize = true;
            this.LabelChoroba.Location = new System.Drawing.Point(149, 126);
            this.LabelChoroba.Name = "LabelChoroba";
            this.LabelChoroba.Size = new System.Drawing.Size(47, 13);
            this.LabelChoroba.TabIndex = 14;
            this.LabelChoroba.Text = "Choroba";
            // 
            // Choroba
            // 
            this.Choroba.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Choroba.FormattingEnabled = true;
            this.Choroba.Items.AddRange(new object[] {
            "Gorączka bostońska"});
            this.Choroba.Location = new System.Drawing.Point(149, 142);
            this.Choroba.Name = "Choroba";
            this.Choroba.Size = new System.Drawing.Size(200, 21);
            this.Choroba.TabIndex = 15;
            // 
            // StartWindow
            // 
            this.AcceptButton = this.Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(360, 304);
            this.Controls.Add(this.Choroba);
            this.Controls.Add(this.LabelChoroba);
            this.Controls.Add(this.Warning);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Spec);
            this.Controls.Add(this.LabelSpec);
            this.Controls.Add(this.ProfesjaCecha);
            this.Controls.Add(this.LabelProfesjaCecha);
            this.Controls.Add(this.PochodzenieCecha);
            this.Controls.Add(this.LabelPochodzenieCecha);
            this.Controls.Add(this.Profesja);
            this.Controls.Add(this.LabelProfesja);
            this.Controls.Add(this.Pochodzenie);
            this.Controls.Add(this.LabelPochodzenie);
            this.Controls.Add(this.NazwaBohatera);
            this.Controls.Add(this.LabelNazwaBohatera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StartWindow";
            this.ShowIcon = false;
            this.Text = "startWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNazwaBohatera;
        private System.Windows.Forms.TextBox NazwaBohatera;
        private System.Windows.Forms.Label LabelPochodzenie;
        private System.Windows.Forms.ListBox Pochodzenie;
        private System.Windows.Forms.Label LabelProfesja;
        private System.Windows.Forms.ListBox Profesja;
        private System.Windows.Forms.Label LabelPochodzenieCecha;
        private System.Windows.Forms.ListBox PochodzenieCecha;
        private System.Windows.Forms.Label LabelProfesjaCecha;
        private System.Windows.Forms.ListBox ProfesjaCecha;
        private System.Windows.Forms.Label LabelSpec;
        private System.Windows.Forms.ComboBox Spec;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label Warning;
        private System.Windows.Forms.Label LabelChoroba;
        private System.Windows.Forms.ComboBox Choroba;
    }
}