using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Font;
using iText.Kernel.Font;

namespace DaneDoDB
{
    public partial class FormRaport : Form
    {
        public FormRaport()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox1.BorderStyle = BorderStyle.None;
                textBox2.BorderStyle = BorderStyle.None;
                textBox3.BorderStyle = BorderStyle.None;
            }
            else
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox1.BorderStyle = BorderStyle.FixedSingle;
                textBox2.BorderStyle = BorderStyle.FixedSingle;
                textBox3.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //łączenie nowego okna z bazą danych
            string conStr = "server=localhost; user=root;database=ideal;";
            MySqlConnection con = new MySqlConnection(conStr);//tworzenie połączenia
            bool polaczono;
            try//próba łączenia z bazą danych
            {
                con.Open();//otwieranie połączenia
                polaczono = true;
            }
            catch (Exception ex)//nieudana próba łączenia
            {
                MessageBox.Show("Błąd łączenia z bazą danych. Zgłoś problem do administratora systemu", "Błąd łączenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                polaczono = false;
            }
            if (polaczono)
            {
                //tworzenie dokumentu pdf
                string sciezka = "C:/projekt/Raport.pdf";//scieżka pliku
                //wywoływanie parametrów dokumentu
                PdfWriter writer = new PdfWriter(sciezka);
                PdfDocument pdfDok = new PdfDocument(writer);
                Document dok = new Document(pdfDok);
                //nagłówek dokumentu
                PdfFont font = PdfFontFactory.CreateFont("C:\\Windows\\Fonts\\Calibri.ttf",PdfEncodings.IDENTITY_H);
                dok.SetFont(font);
                Paragraph naglowek = new Paragraph("Raport pracowników").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER).SetFontSize(28);
                dok.Add(naglowek);
                string sql;
                    if (checkBox1.Checked)
                    {
                        sql = "SELECT * FROM `csharp`;";
                    }
                    else
                    {
                        sql = $"SELECT * FROM `csharp` WHERE `imie` = '{textBox1.Text}' AND `nazwisko` = '{textBox2.Text}'" +
                            $" AND `PESEL` = '{textBox3.Text}';";//komenda na wybranie jednego użytkownika
                    }
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Paragraph tresc = new Paragraph($"Imie:{reader[1]}; Nazwisko:{reader[2]}; Data urodzenia:{reader[3]}; PESEL:{reader[4]}");
                    dok.Add(tresc);

                    }
                dok.Close();
                MessageBox.Show("Raport PDF utworzony pomyślnie", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
    }
}
