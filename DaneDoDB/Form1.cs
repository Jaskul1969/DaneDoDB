using MySql.Data.MySqlClient;
namespace DaneDoDB
{
    public partial class Form1 : Form
    {
        //inicjalizacja formularza
        public Form1()
        {
            InitializeComponent();
        }
        //inicjalizacja elementów formularza
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtImie_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNazwisko_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataUrodzenia_ValueChanged(object sender, EventArgs e)
        {
            //sprawdzanie poprawnoœci PESELu w razie zmiany daty urodzenia
            if (SprawdzPesel(textBox1.Text, dataUrodzenia))
            {
                lblPoprPESEL.ForeColor = Color.Green;//zmiana koloru tekstu na zielony
                lblPoprPESEL.Text = "PESEL poprawny";
            }
            else
            {
                lblPoprPESEL.ForeColor = Color.Red;//zmiana koloru tekstu na czerwony
                lblPoprPESEL.Text = "PESEL niepoprawny";
            }
        }


        //sprawdzanie numeru przy wpisywaniu go do pola tekstowego
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //wypisywanie czy PESEL jest poprawny
            if (SprawdzPesel(textBox1.Text, dataUrodzenia))
            {
                lblPoprPESEL.ForeColor = Color.Green;//zmiana koloru tekstu na zielony
                lblPoprPESEL.Text = "PESEL poprawny";
            }
            else
            {
                lblPoprPESEL.ForeColor = Color.Red;//zmiana koloru tekstu na czerwony
                lblPoprPESEL.Text = "PESEL niepoprawny";
            }
        }


        //funkcja sprawdzaj¹ca poprawnoœæ numeru PESEL
        static bool SprawdzPesel(string pesel, DateTimePicker dataUrodzenia)
        {
            if (pesel.Length != 11)//przerwanie dzia³ania fukcji je¿eli wpisany ci¹g znaków nie ma 11 znaków
                return false;
            //wyci¹ganie daty urodzenia
            string rok = pesel.Substring(0, 2);
            string miesiac = pesel.Substring(2, 2);
            string j;
            j = miesiac.Substring(0, 1);
            int a = int.Parse(j);
            string rokDokladnie = "0";
            //sprawdzanie dok³adnego roku urodzenia
            if (a == 0)
            {
                rokDokladnie = "19" + rok;
            }
            else if (a == 2)
            {
                rokDokladnie = "20" + rok;
            }
            int rokDok = int.Parse(rokDokladnie);

            DateTime data = dataUrodzenia.Value;
            int year = data.Year;

            int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 }; //wagi poszczególnych cyfr numeru PESEL
            int sumaKontrolna = 0;
            for (int i = 0; i < 10; i++)
            {
                if (!char.IsDigit(pesel[i])) //sprawdzanie czy ka¿dy znak to cyfra
                    return false;

                sumaKontrolna += (pesel[i] - '0') * wagi[i];//obliczanie sumy kontrolnej
            }
            //wyliczanie cyfry kontrolnej
            int reszta = sumaKontrolna % 10;//wyci¹ganie drugiej cyfry z sumy kontrolnej
            int kontrolna = 10 - reszta;//odejmowanie drugiej cyfry sumy kontrolnej od 10 aby uzyskaæ ostatni¹ cyfrê numeru

            if (kontrolna == 10)//zapobieganie problemom z wynikiem 10
                kontrolna = 0;

            return kontrolna == (pesel[10] - '0') & rokDok == year;//konwersja na liczbê ca³kowit¹ ostatniej cyfry
                                                                   //peselu i sprawdzanie jej zgodnoœci z ostatni¹ liczb¹ numeru
                                                                   //sprawdzanie 
        }

        //przycisk czyszcz¹cy formularz
        private void btnWyczysc_Click(object sender, EventArgs e)
        {
            txtImie.Clear();
            txtNazwisko.Clear();
            textBox1.Clear();
            dataUrodzenia.Value = DateTime.Today;

        }
        //przycisk wysy³aj¹cy dane
        private void btnPrzeslij_Click(object sender, EventArgs e)
        {
            //³¹czenie z baz¹ danych
            string conStr = "server=localhost; user=visual;database=ideal;";
            MySqlConnection con = new MySqlConnection(conStr);//tworzenie po³¹czenia
            bool polaczono;
            try//próba ³¹czenia z baz¹ danych
            {
                con.Open();//otwieranie po³¹czenia
                polaczono = true;
            }
            catch (Exception ex)//nieudana próba ³¹czenia
            {
                MessageBox.Show("B³¹d ³¹czenia z baz¹ danych. Zg³oœ problem do administratora systemu", "B³¹d ³¹czenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                polaczono = false;
            }
            if (polaczono)//uda³o siê po³¹czyæ
            {
                string data = dataUrodzenia.Value.Date.ToString("yyyy-MM-dd");//przekszta³canie daty urodzenia na odczytywaln¹ dla SQL


                string sql = "INSERT INTO `csharp`(`imie`,`nazwisko`,`data-urodzenia`,`PESEL`)" +
                    $" VALUES('{txtImie.Text}','{txtNazwisko.Text}','{data}','{textBox1.Text}')";//zapytanie SQL

                MySqlCommand cmd = new MySqlCommand(sql, con);//tworzenie zapytania
                cmd.ExecuteNonQuery();//wywo³anie zapytania
            }


        }

        private void lblPoprPESEL_Click(object sender, EventArgs e)
        {

        }

       
    }
}