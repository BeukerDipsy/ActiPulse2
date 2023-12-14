using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ActiPulse
{
    public partial class MainScreenActiPulse : Form
    {
        private readonly DBAccess objDbAccess = new DBAccess();

        public string userName { get; internal set; }
        public MainScreenActiPulse()
        {
            InitializeComponent();
        }

        private void UpdateStatusEnTijd()
        {
            string input = "";
            bool isRunning = true;
            Stopwatch ZitStopwatch = new Stopwatch(); //Maakt stopwatch aan
            Stopwatch StaStopwatch = new Stopwatch();
            //VANAF HIER CREEERT HIJ EEN INT HOELANGMOETJEZITTEN DIE GELIJK STAAT AAN DE SITTING TIME VAN DE COMPANY 
            string StringHoelangMoetJeZitten = "";
            string HoelangMoetJeZittenQuery = "SELECT sitting_time FROM company"; //werkt nog zolang er maar 1 company is
            using (SqlCommand TijdZit = new SqlCommand(HoelangMoetJeZittenQuery))
            {
                SqlDataReader reader4 = objDbAccess.ExecuteReader(TijdZit);
                if (reader4.HasRows)
                {
                    while (reader4.Read())
                    {
                        StringHoelangMoetJeZitten = $"{reader4.GetValue(0)}";
                    }
                }
                objDbAccess.CloseConnection();
            }
            int HoelangMoetJeZitten = Convert.ToInt32(StringHoelangMoetJeZitten);
            //EINDE BESCHRIJVIJNG

            //VANAF HIER CREEERT HIJ EEN INT HOELANGMOETJESTAAN DIE GELIJK STAAT AAN DE SITTING TIME VAN DE COMPANY
            string StringHoelangMoetJeStaan = "";
            string HoelangMoetJeStaanQuery = "SELECT standing_time FROM company"; //werkt nog zolang er maar 1 company is
            using (SqlCommand TijdSta = new SqlCommand(HoelangMoetJeStaanQuery))
            {
                SqlDataReader reader4 = objDbAccess.ExecuteReader(TijdSta);
                if (reader4.HasRows)
                {
                    while (reader4.Read())
                    {
                        StringHoelangMoetJeStaan = $"{reader4.GetValue(0)}";
                    }
                }
                objDbAccess.CloseConnection();
            }
            int HoelangMoetJeStaan = Convert.ToInt32(StringHoelangMoetJeStaan);
            //EINDE BESCHRIJVIJNG

            Task.Run(() =>
            {
                while (isRunning == true)
                {
                    string Status = "SELECT input FROM accounts WHERE account_id = (SELECT account_id FROM accounts WHERE username = @Username)";
                    using (SqlCommand StatusQuery = new SqlCommand(Status))
                    {
                        StatusQuery.Parameters.AddWithValue("@Username", userName);
                        SqlDataReader reader3 = objDbAccess.ExecuteReader(StatusQuery);
                        if (reader3.HasRows)
                        {
                            while (reader3.Read())
                            {
                                input = $"{reader3.GetValue(0)}";
                            }
                        }
                        objDbAccess.CloseConnection();
                    }
                    Thread.Sleep(500);
                }
            });


            Thread.Sleep(1000);
            bool ZitGreet = false;
            bool StaGreet = false;
            bool StopWhile = false;
            bool JeZitTeLang = false;
            string ZitToevoeging = "seconds"; //in de database staat het als seconden dus het is standaard seconden
            string StaToevoeging = "seconds"; //in de database staat het als seconden dus het is standaard seconden

            if (HoelangMoetJeZitten >= 60)
            {
                HoelangMoetJeZitten = 60 / 60;
                ZitToevoeging = "minute(s)";
            } //verandert info naar minuten

            if (HoelangMoetJeStaan >= 60)
            {
                HoelangMoetJeStaan = 60 / 60;
                StaToevoeging = "minute(s)";
            } //verandert info naar minuten


            bool disableSitTillOk = false;
            bool disableStandTillOk = false;
            Task.Run(() =>
            {
                while (isRunning == true)
                {
                    if (input == "LOW" && disableSitTillOk == false) //ALS INPUT GELIJK STAAT AAN ), MISSCHIEN MOET DIT 1 WORDEN, LIGT AAN DE DATABASE
                    {
                        ZitStopwatch.Start();
                        StaStopwatch.Stop();
                        if (ZitGreet == false)
                        {
                            StaStopwatch.Stop();
                            ZitStopwatch.Start();
                            if (JeZitTeLang == false)
                            {
                                if (HoelangText.InvokeRequired)
                                {
                                    try
                                    {
                                        HoelangText.Invoke(new MethodInvoker(() =>
                                        {
                                            HoelangText.Text = $"You have to sit for {HoelangMoetJeZitten} {ZitToevoeging}";
                                        }));
                                    }
                                    catch { }
                                }
                            }
                            ZitGreet = true;
                            StaGreet = false;
                        }
                        string LastInput = input;
                        StopWhile = false;
                        while (ZitStopwatch.Elapsed.TotalSeconds <= HoelangMoetJeZitten && StopWhile == false && JeZitTeLang == false)
                        {
                            StaStopwatch.Reset();
                            try
                            {
                                ZitTimer.Invoke(new MethodInvoker(() =>//invoke (maak het label hier ook toegankelijk)
                                {
                                    ZitTimer.Text = String.Format("You have been sitting for {0:00}:{1:00}:{2:00}", ZitStopwatch.Elapsed.Hours, ZitStopwatch.Elapsed.Minutes, ZitStopwatch.Elapsed.Seconds);
                                }));
                            }
                            catch { }
                            if (LastInput != input)
                            {
                                StopWhile = true;
                                LastInput = input;
                            }
                        }
                        if (ZitStopwatch.Elapsed.TotalSeconds >= HoelangMoetJeZitten && JeZitTeLang == false)
                        {
                            JeZitTeLang = true;
                            DialogResult result = MessageBox.Show($"You've sat for {HoelangMoetJeZitten} {ZitToevoeging}, take a {HoelangMoetJeStaan} {StaToevoeging} break", "ActiPulse", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            disableStandTillOk = true;
                            if (result == DialogResult.OK)
                            {
                                disableStandTillOk = false;
                            }
                        }
                    }

                    if (input == "HIGH" && disableStandTillOk == false)
                    {
                        ZitStopwatch.Stop();
                        if (JeZitTeLang == true)
                        {
                            if (StaGreet == false)
                            {
                                ZitStopwatch.Reset();
                                StaStopwatch.Start();
                                StaGreet = true;
                                ZitGreet = false;
                                if (HoelangText.InvokeRequired)
                                {
                                    try
                                    {
                                        HoelangText.Invoke(new MethodInvoker(() =>
                                        {
                                            HoelangText.Text = $"You have to stand for {HoelangMoetJeStaan} {StaToevoeging}";
                                        }));
                                    }
                                    catch { }

                                }
                            }
                            string LastInput = input;
                            StopWhile = false;
                            while (StaStopwatch.Elapsed.TotalSeconds < HoelangMoetJeStaan && StopWhile == false)
                            {
                                try
                                {
                                    ZitTimer.Invoke(new MethodInvoker(() =>
                                    {
                                        ZitTimer.Text = String.Format("You have been standing for {0:00}:{1:00}:{2:00}", StaStopwatch.Elapsed.Hours, StaStopwatch.Elapsed.Minutes, StaStopwatch.Elapsed.Seconds);
                                    }));
                                }
                                catch
                                { }

                                if (LastInput != input)
                                {
                                    StopWhile = true;
                                    LastInput = input;
                                }
                            }
                            if (StaStopwatch.Elapsed.TotalSeconds >= HoelangMoetJeStaan)
                            {
                                DialogResult result2 = MessageBox.Show($"You've stood for {HoelangMoetJeStaan} seconds, you earned 1 point!", "ActiPulse", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); //NU IS HET ALLEEN NOG MAAR SECONDS
                                disableSitTillOk = true;
                                if (result2 == DialogResult.OK)
                                {
                                    disableSitTillOk = false;
                                }
                                JeZitTeLang = false;
                                VoegDataToe();
                                UpdatePunten();
                            }
                        }
                        else
                        {
                            try
                            {
                                ZitTimer.Invoke(new MethodInvoker(() =>
                                {
                                    ZitTimer.Text = "Go back to work to earn points.";
                                }));
                            }
                            catch { }
                            try
                            {
                                HoelangText.Invoke(new MethodInvoker(() =>
                                {
                                    HoelangText.Text = "";
                                }));
                            }
                            catch { }

                        }
                    }
                }
            });
        }

        private void VoegDataToe()//Insert data in database
        {
            DateTime nu = DateTime.Now;
            string formattedDateTijd = nu.ToString("yyyy-MM-dd HH:mm:ss");
            string formattedDateTijd2 = nu.ToString("dd/MM/yyyy HH:mm:ss");

            string insert = "INSERT into scores(account_id, date_time, points, change) values ((SELECT account_id from accounts WHERE username = @Username), @DateTime, 1, '+');";
            using (SqlCommand cmd5 = new SqlCommand(insert))
            {
                cmd5.Parameters.AddWithValue("@Username", userName);
                cmd5.Parameters.AddWithValue("@DateTime", formattedDateTijd);
                DataTable Pluspunten = objDbAccess.ExecuteAdapter(cmd5);
            }
            objDbAccess.CloseConnection();
            try
            {
                listBox.Invoke(new MethodInvoker(() =>
                {
                    listBox.Items.Insert(0, $"+ 1 Pauze genomen      {formattedDateTijd2}");
                }));
            }
            catch { }
        }

        private void ThreadStarter()
        {
            ThreadStart ts = new ThreadStart(UpdateStatusEnTijd);
            Thread t = new Thread(ts);
            t.IsBackground = false;
            t.Start();
        }

        private void UpdatePunten() //Selecteert pluspunten/minpunten en haalt minpunten van pluspunten af, voegt uiteindelijk de waarde toe aan label.text
        {
            int Points;
            string minPunten = "";
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
                            plusPunten += $"{reader1.GetValue(i)}";
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
                            minPunten += $"{reader2.GetValue(i)}";
                        }
                    }
                }
                objDbAccess.CloseConnection();
            }
            if (plusPunten == "")
            {
                plusPunten = "0";
            }
            if (minPunten == "")
            {
                minPunten = "0";
            }
            Points = Convert.ToInt16(plusPunten) - Convert.ToInt16(minPunten);
            Punten.Invoke(new MethodInvoker(() =>
            {
                Punten.Text = $"Points: {Points}";
            }));

        }

        private void VoegDataInListbox()
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
                                    zin += " punten ingeleverd  ";
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

        private void getSensorId()
        {
            string sensorUsed = "";
            string getSensorId = "SELECT sensor_id FROM [dbo].[accounts] Where account_id = (SELECT account_id FROM accounts WHERE username = @Username)";
            using (SqlCommand cmdSensor = new SqlCommand(getSensorId))
            {
                cmdSensor.Parameters.AddWithValue("@Username", userName);
                SqlDataReader sensorReader = objDbAccess.ExecuteReader(cmdSensor);
                if (sensorReader.HasRows)
                {
                    
                    while (sensorReader.Read())
                    {
                        int countReader3 = sensorReader.FieldCount;
                        for (int i = 0; i < countReader3; i++)
                        {
                            sensorUsed = $"{sensorReader.GetValue(i)}";
                        }
                    }
                }
                objDbAccess.CloseConnection();
            }
            nud_SensorID.Value = Convert.ToDecimal(sensorUsed);
        }

        private void bt_X_Click(object sender, EventArgs e) //Exit
        {
            Application.Exit();
        }

        private void bt_SignOut_Click(object sender, EventArgs e) //Sign Out
        {
            SignIn signInForm = new SignIn();
            signInForm.Show();
            this.Close();
        }

        private void bt_puntenoverzicht_Click(object sender, EventArgs e) //Puntenoverzicht
        {
            PuntenOverzicht PuntenOverzicht = new PuntenOverzicht();
            PuntenOverzicht.userName = userName;
            PuntenOverzicht.Show();
            this.Close();
        }

        private void MainScreenActiPulse_Shown(object sender, EventArgs e)
        {
            Inloggegevens.Text = userName;
            VoegDataInListbox();
            UpdatePunten();
            ThreadStarter();
            getSensorId();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            int idSensor = (int)nud_SensorID.Value;
            string updateSensorId = "UPDATE accounts SET sensor_id = @sensor_id WHERE account_id = (SELECT account_id FROM accounts WHERE username = @Username)";

            using (SqlCommand cmdSensor = new SqlCommand(updateSensorId))
            {
                cmdSensor.Parameters.AddWithValue("@sensor_id", idSensor);
                cmdSensor.Parameters.AddWithValue("@Username", userName);
                DataTable adapter = objDbAccess.ExecuteAdapter(cmdSensor);
            }
        }
    }
}
