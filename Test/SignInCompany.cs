using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ActiPulse
{
    public partial class SignInCompany : Form
    {
        private readonly DBAccess objDbAccess = new DBAccess();

        public string companyName { get; internal set; }
        public SignInCompany()
        {
            InitializeComponent();
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            string companyName = tb_CompanyName.Text;
            string companyPassword = tb_Password.Text;

            if (string.IsNullOrEmpty(companyName))
            {
                MessageBox.Show("Please enter the company's name", "ActiPulse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(companyPassword))
            {
                MessageBox.Show("Please enter the company's password" + "", "ActiPulse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string companyQuery = "SELECT * FROM company WHERE company_name = @companyName";

            using (SqlCommand cmd = new SqlCommand(companyQuery))
            {
                cmd.Parameters.AddWithValue("@companyName", companyName);
                SqlDataReader companyReader = objDbAccess.ExecuteReader(cmd);

                if (companyReader.HasRows)
                {
                    if (companyReader.Read())
                    {
                        byte[] password = Encoding.Default.GetBytes(companyPassword);
                        string full_hash = (string)companyReader.GetValue(2);
                        string shash = (string)full_hash.Split(":")[1];
                        string ssalt = (string)full_hash.Split(":")[0];
                        byte[] hash = Convert.FromBase64String(shash);
                        byte[] salt = Convert.FromBase64String(ssalt);
                        byte[] hashed = Encrypt.CreateHash(password, salt);
                        string shashed = Convert.ToBase64String(hashed);

                        //if (Encrypt.VerifyHash(password, hash, salt))
                        if (shashed != null && shash == shashed)
                        {
                            MessageBox.Show("Successful login! Click 'OK' to open the Main window.", "ActiPulse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            CompanySettings CompanySettingsForm = new CompanySettings();
                            CompanySettingsForm.companyName = companyName;
                            CompanySettingsForm.Show(); // Show the main screen
                        }
                        else
                        {
                            MessageBox.Show("Ouch, was that the wrong login?", "ActiPulse", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ouch, was that the wrong login?", "ActiPulse", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                objDbAccess.CloseConnection();
            }
        }

        private void bt_NewUser_Click(object sender, EventArgs e)
        {
            SignUpCompany SignUpCompanyForm = new SignUpCompany();
            SignUpCompanyForm.Show();
            this.Hide();
        }

        private void bt_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignInCompany_Load(object sender, EventArgs e)
        {

        }

        private void bt_NewUser_Click_1(object sender, EventArgs e)
        {
            SignUpCompany SignUpCompanyForm = new SignUpCompany();
            SignUpCompanyForm.Show();
            this.Hide();
        }

        private void bt_user_Click(object sender, EventArgs e)
        {
            SignIn signInForm = new SignIn();
            signInForm.Show();
            this.Close();
        }
    }
}
