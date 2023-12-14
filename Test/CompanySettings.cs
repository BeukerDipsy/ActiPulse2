using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ActiPulse
{
    public partial class CompanySettings : Form
    {

        private readonly DBAccess objDbAccess = new DBAccess();

        public string companyName { get; internal set; }

        public CompanySettings()
        {
            InitializeComponent();
        }

        public (string companyId, string standingTime, string sittingTime) GetCompanyInfo()
        {
            string companyId = "";
            string standingTime = "";
            string sittingTime = "";

            string companyInfo = "SELECT company_id, standing_time, sitting_time FROM company WHERE company_name = @companyName";
            using SqlCommand cmd = new SqlCommand(companyInfo);
            {
                cmd.Parameters.AddWithValue("@companyName", companyName);
                SqlDataReader companyInfoReader = objDbAccess.ExecuteReader(cmd);
                if (companyInfoReader.HasRows)
                {
                    if (companyInfoReader.HasRows && companyInfoReader.Read())
                    {
                        companyId = companyInfoReader["company_id"].ToString();
                        standingTime = companyInfoReader["standing_time"].ToString();
                        sittingTime = companyInfoReader["sitting_time"].ToString();
                    }
                }
                objDbAccess.CloseConnection();
            }
            DisplayData(companyName, companyId, standingTime, sittingTime);
            return (companyId, standingTime, sittingTime);
        }

        public void DisplayData(string companyName, string companyId, string standingTime, string sittingTime)
        {
            label_companyName.Text = $"Company: {companyName}";
            label_companyId.Text = companyId;
            nud_standingTime.Value = Convert.ToDecimal(standingTime);
            nud_sittingTime.Value = Convert.ToDecimal(sittingTime);
        }

        private void AddUsers(string companyId)
        {
            int companyIdInt = Convert.ToInt16(companyId);
            string userQuery = "SELECT username FROM accounts WHERE company_id = @companyId ORDER BY username DESC";
            using (SqlCommand addUsers = new SqlCommand(userQuery))
            {
                addUsers.Parameters.AddWithValue("@companyId", companyId);
                SqlDataReader companyUsersReader = objDbAccess.ExecuteReader(addUsers);
                if (companyUsersReader.HasRows)
                {
                    while (companyUsersReader.Read())
                    {
                        int countReader2 = companyUsersReader.FieldCount;
                        for (int i = 0; i < countReader2; i++)
                        {
                            string username = companyUsersReader["username"].ToString();
                            cb_users.Items.Add(username);
                        }
                    }
                }
                objDbAccess.CloseConnection();
            }

        }

        private void VoegDataInListbox(string userName)
        {
            string query = "SELECT change, points, date_time FROM scores WHERE account_id = (SELECT account_id FROM accounts WHERE username = @Username) ORDER BY date_time desc";
            using (SqlCommand DataAdd = new SqlCommand(query))
            {
                DataAdd.Parameters.AddWithValue("@Username", userName);
                SqlDataReader reader = objDbAccess.ExecuteReader(DataAdd);
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
                        lb_overview.Items.Add(zin);
                    }
                }
                objDbAccess.CloseConnection();
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CompanySettings_Load(object sender, EventArgs e)
        {
            (string companyId, string standingTime, string sittingTime) = GetCompanyInfo();
            AddUsers(companyId);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_overview.Items.Clear();
            string userName = cb_users.Text;
            VoegDataInListbox(userName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string companyId = label_companyId.Text; //onderstaande moet ik eigenlijk op een andere manier zien te verkrijgen
            string standingTime = Convert.ToString(nud_standingTime.Value);
            string sittingTime = Convert.ToString(nud_sittingTime.Value);
            string insert = "UPDATE company SET sitting_time = @sittingTime, standing_time = @standingTime WHERE company_id = @companyID";
            using (SqlCommand cmd3 = new SqlCommand(insert))
            {
                cmd3.Parameters.AddWithValue("@companyID", companyId);
                cmd3.Parameters.AddWithValue("@sittingTime", sittingTime);
                cmd3.Parameters.AddWithValue("@standingTime", standingTime);
                DataTable adapter = objDbAccess.ExecuteAdapter(cmd3);
            }
        }

        private void bt_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_users_Click(object sender, EventArgs e)
        {

        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            SignInCompany signInCompany = new SignInCompany();
            signInCompany.Show();
            this.Hide();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            SignInCompany signInCompany = new SignInCompany();
            signInCompany.Show();
            this.Hide();
        }
    }
}
