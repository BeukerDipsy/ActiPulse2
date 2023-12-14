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
using Test;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ActiPulse
{
    public partial class SignUpCompany : Form
    {
        DBAccess objDbAccess = new DBAccess();

        public SignUpCompany()
        {
            InitializeComponent();
        }

        private void SignUpCompany_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_Register_Click(object sender, EventArgs e)
        {
            string companyCheck = "";
            string companyId = "";
            string companyName = tb_CompanyName.Text;
            string companyPassword = tb_Password.Text;
            string companyReenter = tb_ReenterPassword.Text;

            if (string.IsNullOrEmpty(companyName) || string.IsNullOrEmpty(companyPassword) || string.IsNullOrEmpty(companyReenter))
            {
                MessageBox.Show("Please fill in all required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string allCompanyNames = "SELECT company_name FROM company";
            using (SqlCommand companyOphalen = new SqlCommand(allCompanyNames))
            {
                SqlDataReader companyReader = objDbAccess.ExecuteReader(companyOphalen);
                if (companyReader.HasRows)
                {
                    while (companyReader.Read())
                    {
                        int fieldCountUsernames = companyReader.FieldCount;
                        for (int i = 0; i < fieldCountUsernames; i++)
                        {
                            companyCheck = $"{companyReader.GetValue(i)}";
                            if (companyCheck == companyName)
                            {
                                MessageBox.Show("This company already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                objDbAccess.CloseConnection();
                                return;
                            }
                        }
                    }
                }
                objDbAccess.CloseConnection();
            }

            if (companyPassword != companyReenter)
            {
                MessageBox.Show("Your passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            byte[] salt = Encrypt.GenerateSalt();
            byte[] password = Encoding.Default.GetBytes(companyPassword);
            byte[] encryptedPassword = Encrypt.CreateHash(password, salt);

            string companyQuery = "INSERT INTO company (company_name, company_password, standing_time, sitting_time) " +
               "VALUES (@company, @Password, 10, 6)";

            using (SqlCommand cmd = new SqlCommand(companyQuery))
            {
                cmd.Parameters.AddWithValue("@company", companyName);
                cmd.Parameters.AddWithValue("@Password", $"{Convert.ToBase64String(salt)}:{Convert.ToBase64String(encryptedPassword)}");

                int rowsAffected = objDbAccess.ExecuteNonQuery(cmd);

                if (rowsAffected > 0)
                {
                    string companyIDQuery = "SELECT company_id FROM company WHERE company_id = (SELECT company_id FROM company WHERE company_name = @company)";
                    using (SqlCommand cmd2 = new SqlCommand(companyIDQuery))
                    {
                        cmd2.Parameters.AddWithValue("@company", companyName);
                        SqlDataReader companyIdReader = objDbAccess.ExecuteReader(cmd2);
                        if (companyIdReader.HasRows)
                        {
                            while (companyIdReader.Read())
                            {
                                int idCount = companyIdReader.FieldCount;

                                for (int i = 0; i < idCount; i++)
                                {
                                    companyId = $"{companyIdReader.GetValue(i)}";
                                }
                            }
                        }
                        objDbAccess.CloseConnection();
                    }
                    MessageBox.Show($"Account creation succesfull! Your Company-ID is: {companyId}", "ActiPulse", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error during the registration!", "ActiPulse", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                SignInCompany companySignIn = new SignInCompany();
                companySignIn.Show();
            }
        }

        private void lb_SignUpToYourAccount_Click(object sender, EventArgs e)
        {

        }

        private void bt_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            SignInCompany signInCompanyForm = new SignInCompany();
            signInCompanyForm.Show();

            this.Close();
        }
    }
}
