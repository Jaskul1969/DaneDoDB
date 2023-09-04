namespace DaneDoDB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtImie = new TextBox();
            lblImie = new Label();
            txtNazwisko = new TextBox();
            lblNazwisko = new Label();
            label1 = new Label();
            dataUrodzenia = new DateTimePicker();
            textBox1 = new TextBox();
            label2 = new Label();
            btnWyczysc = new Button();
            btnPrzeslij = new Button();
            lblPoprPESEL = new Label();
            SuspendLayout();
            // 
            // txtImie
            // 
            txtImie.BorderStyle = BorderStyle.FixedSingle;
            txtImie.Location = new Point(12, 27);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(140, 23);
            txtImie.TabIndex = 0;
            txtImie.TextChanged += txtImie_TextChanged;
            // 
            // lblImie
            // 
            lblImie.AutoSize = true;
            lblImie.Location = new Point(12, 9);
            lblImie.Name = "lblImie";
            lblImie.Size = new Size(30, 15);
            lblImie.TabIndex = 1;
            lblImie.Text = "Imię";
            // 
            // txtNazwisko
            // 
            txtNazwisko.BorderStyle = BorderStyle.FixedSingle;
            txtNazwisko.Location = new Point(158, 27);
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(252, 23);
            txtNazwisko.TabIndex = 2;
            txtNazwisko.TextChanged += txtNazwisko_TextChanged;
            // 
            // lblNazwisko
            // 
            lblNazwisko.AutoSize = true;
            lblNazwisko.Location = new Point(158, 9);
            lblNazwisko.Name = "lblNazwisko";
            lblNazwisko.Size = new Size(57, 15);
            lblNazwisko.TabIndex = 3;
            lblNazwisko.Text = "Nazwisko";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 4;
            label1.Text = "Data urodzenia";
            // 
            // dataUrodzenia
            // 
            dataUrodzenia.CustomFormat = "yyyy-MM-dd";
            dataUrodzenia.Format = DateTimePickerFormat.Custom;
            dataUrodzenia.Location = new Point(12, 71);
            dataUrodzenia.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dataUrodzenia.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dataUrodzenia.Name = "dataUrodzenia";
            dataUrodzenia.RightToLeft = RightToLeft.No;
            dataUrodzenia.Size = new Size(200, 23);
            dataUrodzenia.TabIndex = 5;
            dataUrodzenia.Value = new DateTime(2023, 9, 4, 0, 0, 0, 0);
            dataUrodzenia.ValueChanged += dataUrodzenia_ValueChanged;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(218, 71);
            textBox1.MaxLength = 11;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 23);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 53);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 7;
            label2.Text = "PESEL";
            // 
            // btnWyczysc
            // 
            btnWyczysc.Location = new Point(12, 109);
            btnWyczysc.Name = "btnWyczysc";
            btnWyczysc.Size = new Size(203, 24);
            btnWyczysc.TabIndex = 8;
            btnWyczysc.Text = "Wyczyść formularz";
            btnWyczysc.UseVisualStyleBackColor = true;
            btnWyczysc.Click += btnWyczysc_Click;
            // 
            // btnPrzeslij
            // 
            btnPrzeslij.Location = new Point(207, 109);
            btnPrzeslij.Name = "btnPrzeslij";
            btnPrzeslij.Size = new Size(203, 24);
            btnPrzeslij.TabIndex = 9;
            btnPrzeslij.Text = "Prześlij dane";
            btnPrzeslij.UseVisualStyleBackColor = true;
            btnPrzeslij.Click += btnPrzeslij_Click;
            // 
            // lblPoprPESEL
            // 
            lblPoprPESEL.AutoSize = true;
            lblPoprPESEL.Location = new Point(307, 53);
            lblPoprPESEL.Name = "lblPoprPESEL";
            lblPoprPESEL.Size = new Size(0, 15);
            lblPoprPESEL.TabIndex = 10;
            lblPoprPESEL.Click += lblPoprPESEL_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 145);
            Controls.Add(lblPoprPESEL);
            Controls.Add(btnPrzeslij);
            Controls.Add(btnWyczysc);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(dataUrodzenia);
            Controls.Add(label1);
            Controls.Add(lblNazwisko);
            Controls.Add(txtNazwisko);
            Controls.Add(lblImie);
            Controls.Add(txtImie);
            Name = "Form1";
            Text = "Wstaw dane";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtImie;
        private Label lblImie;
        private TextBox txtNazwisko;
        private Label lblNazwisko;
        private Label label1;
        private DateTimePicker dataUrodzenia;
        private TextBox textBox1;
        private Label label2;
        private Button btnWyczysc;
        private Button btnPrzeslij;
        private Label lblPoprPESEL;
    }
}