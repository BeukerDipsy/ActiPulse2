using System.Data;
using System.Data.SqlClient;

namespace ActiPulse
{
    public partial class PuntenOverzicht : Form
    {
        private readonly DBAccess objDbAccess = new DBAccess();
        public string userName { get; internal set; }
        int Points;

        public PuntenOverzicht()
        {
            InitializeComponent();
        }

        private void VoegDataToe()//Insert data in database
        {
            int MinPoints = (int)HoeveelMinpunten.Value;
            string insert = "INSERT into scores(account_id, date_time, points, change) values ((SELECT account_id from accounts WHERE username = @Username), @DateTime, @MinPoints, '-');";
            using (SqlCommand cmd2 = new SqlCommand(insert))
            {
                DateTime now = DateTime.Now;
                string formattedDateTime = now.ToString("yyyy-MM-dd HH:mm:ss");
                cmd2.Parameters.AddWithValue("@Username", userName);
                cmd2.Parameters.AddWithValue("@DateTime", formattedDateTime);
                cmd2.Parameters.AddWithValue("@Minpoints", MinPoints);
                DataTable adapter = objDbAccess.ExecuteAdapter(cmd2);
            }
        }

        private void UpdatePunten() //Selecteert pluspunten/minpunten en haalt minpunten van pluspunten af, voegt uiteindelijk de waarde toe aan label.text
        {
            string minPunten = "0";
            string plusPunten = "0";

            string PluspuntenQuery = "SELECT SUM(points) FROM [dbo].[scores] Where change = '+' AND account_id = (SELECT account_id FROM accounts WHERE username = @Username)";
            using (SqlCommand cmd3 = new SqlCommand(PluspuntenQuery))
            {
                cmd3.Parameters.AddWithValue("@Username", userName);
                SqlDataReader reader1 = objDbAccess.ExecuteReader(cmd3);
                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {
                        int countReader1 = reader1.FieldCount;
                        for (int i = 0; i < countReader1; i++)
                        {
                            plusPunten += $"{reader1.GetValue(i)} ";
                        }
                    }
                }
                objDbAccess.CloseConnection();
            }
            string MinpuntenQuery = "SELECT SUM(points) FROM [dbo].[scores] Where change = '-' AND account_id = (SELECT account_id FROM accounts WHERE username = @Username)";
            using (SqlCommand cmd4 = new SqlCommand(MinpuntenQuery))
            {
                cmd4.Parameters.AddWithValue("@Username", userName);
                SqlDataReader reader2 = objDbAccess.ExecuteReader(cmd4);
                if (reader2.HasRows)
                {
                    while (reader2.Read())
                    {
                        int countReader2 = reader2.FieldCount;

                        for (int i = 0; i < countReader2; i++)
                        {
                            minPunten += $"{reader2.GetValue(i)} ";
                        }
                    }
                }
                objDbAccess.CloseConnection();
            }
            Points = Convert.ToInt16(plusPunten) - Convert.ToInt16(minPunten);
            PuntenTotaal.Text = $"Aantal punten: {Points}";
        }

        private void VoegDataInListbox()//Voegt data toe aan listbox
        {
            string query = "SELECT change, points, date_time FROM scores WHERE account_id = (SELECT account_id FROM accounts WHERE username = @Username) ORDER BY date_time desc";
            using (SqlCommand cmd = new SqlCommand(query))
            {
                cmd.Parameters.AddWithValue("@Username", userName);
                SqlDataReader reader = objDbAccess.ExecuteReader(cmd);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int count = reader.FieldCount;
                        string zin = "";
                        string PlusOfMin = "";
                        for (int i = 0; i < count; i++)
                        {
                            if (i == 2)
                            {
                                PlusOfMin = $"{reader.GetValue(0)}";
                                if (PlusOfMin == "-")
                                {
                                    zin += "  punten ingeleverd  ";
                                }
                                else
                                {
                                    zin += "Pauze genomen      ";
                                }
                            }
                            zin += $"{reader.GetValue(i)} ";
                        }
                        listBox.Items.Add(zin);
                    }
                }
                objDbAccess.CloseConnection();
            }
        }

        private void bt_X_Click(object sender, EventArgs e) //Exit
        {
            Application.Exit();
        }

        private void bt_Back_Click(object sender, EventArgs e) //Back
        {
            this.Hide();
            MainScreenActiPulse main = new MainScreenActiPulse();
            main.userName = userName;
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e) //Voegt Data toe, update punten en voegt een item toe aan de listbox
        {
            int MinPoints = (int)HoeveelMinpunten.Value;

            if (Points - MinPoints >= 0)
            {
                if (MinPoints > 0)
                {
                    DateTime now = DateTime.Now;
                    string formattedDateTime = now.ToString("dd/MM/yyy HH:mm:ss");
                    listBox.Items.Insert(0,
                           $"-  {MinPoints} pauze genomen      {formattedDateTime}");
                    VoegDataToe();
                    UpdatePunten();
                }
                else
                {
                    MessageBox.Show("Enter the amount of points you want to redeem!", "ActiPulse", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) //Houdt gebruiker tegen meer punten uit te geven dan dat hij/zij heeft
        {
            if (HoeveelMinpunten.Value > Points)
            {
                HoeveelMinpunten.Value = Points;
                MessageBox.Show("You can't spend more points than you have!", "ActiPulse", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void PuntenOverzicht_Shown(object sender, EventArgs e) //RUNT CODE ALS DIT SCHERM GESHOWED WORD
        {
            InlogGegevens.Text = userName;
            VoegDataInListbox();
            UpdatePunten();
        }
    }
}
