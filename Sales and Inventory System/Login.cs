    using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mail;
using System.Net;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using System.IO;
using System.Drawing.Text;
using System.Data.Common;
using System.Threading.Tasks;
using System.Configuration;

namespace Sales_and_Inventory_System
{
    public partial class Login : Form
    {
        private string email;
        private bool staff_link_clicked = true;
        private bool Recover_Logic = false;
        private bool Code_panel_Logic = false;
        private bool Code_remove_Logic = false;
        private int Code = 0;
        public int _id = 0, _login_id;
        public static Login instance;
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public MySqlConnection connection = new MySqlConnection(ConnectionString);
        public Login()
        { 
            InitializeComponent();
            instance = this;
        }
        private void Login_Load(object sender, EventArgs e)
        {
        }

        // Recover_Panel Transition LINK
        private void ForgotPass_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recover_panel.Visible = true;
            transition.HideSync(Sign_panel);
            Email_txtbox.Text = "";
            Password_txtbox.Text = "";
        }

        // Admin Link
        private void admin_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Email_txtbox.Text = "";
            Password_txtbox.Text = "";
            Register_link.Visible = false;
            admin_link.Visible = false;
            staff_link.Visible = true;
            staff_link_clicked = false;
        }

        // Staff Link
        private void staff_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Email_txtbox.Text = "";
            Password_txtbox.Text = "";
            Register_link.Visible = true;
            admin_link.Visible = true;
            staff_link.Visible = false;
            staff_link_clicked = true;
        }

        private void Register_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recover_panel.Visible = false;
            transition.HideSync(Sign_panel);
            Email_txtbox.Text = "";
            Password_txtbox.Text = "";

        }

        // RECOVER PANEL BACK BUTTON
        private void Back_btn_Click(object sender, EventArgs e)
        {
            transition2.HideSync(change_panel);
            transition2.HideSync(Code_panel);
            transition.ShowSync(Sign_panel);
            Email_Address_txtbox.Text = "";
        }


        private void Back_btn1_Click(object sender, EventArgs e)
        {
            switch (Code_panel_Logic)
            {
                case true:
                    code_txtbox.Text = string.Format("");
                    Back_btn.Visible = true;
                    Back_btn1.Visible = false;
                    Code_timer.Stop();
                    Code_timer.Enabled = false;
                    Code_panel_Logic = false;
                    Code_remove_Logic = false;
                    delete_code();
                    transition2.HideSync(change_panel);
                    transition2.HideSync(Code_panel);
                    transition.ShowSync(Sign_panel);
                    break;

                case false:
                    code_txtbox.Text = string.Format("");
                    Email_Address_txtbox.Text = "";
                    transition2.HideSync(change_panel);
                    transition2.HideSync(Code_panel);
                    transition.ShowSync(Sign_panel);
                    break;
            }

        }

        // RECOVER PANEL EXIT BUTTON
        private void Exit2_btn_Click(object sender, EventArgs e)
        {
            switch (Code_panel_Logic)
            {
                case true:
                    delete_code();
                    Code_timer.Enabled = false;
                    Code_timer.Stop();
                    Application.Exit();
                    break;

                case false:
                    Code_timer.Enabled = false;
                    Code_timer.Stop();
                    Application.Exit();
                    break;
            }
        }

        // SIGN UP EXIT BUTTON
        private void Exit_panel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Instruction when Password Textbox Value is change
        private void Password_txtbox_OnValueChanged(object sender, EventArgs e)
        {
            Password_txtbox.isPassword = true;
            Pass_indicator.Text = string.Format("");
        }

        // Instruction When user hit Enter
        private void Email_txtbox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Password_txtbox.Focus();
                    break;
            }
        }

        // Instruction When user hit Enter
        private void Password_txtbox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    CheckEmptyBox();
                    break;
            }
        }

        private void Email_Address_txtbox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Recover_CheckEmpty();
                    break;
            }
        }

        // Database Connection
        private void Connection()
        {
            if (Internet.CheckInternet() != false)
            {
                if (staff_link_clicked == true)
                {
                    string CommandString = @"SELECT staff_id_fk FROM tbl_staff WHERE staff_email=@staff_email AND staff_password=@staff_password LIMIT 1";
                    MySqlCommand command = new MySqlCommand(CommandString,connection);
                    command.Parameters.Add(new MySqlParameter("@staff_email", MySqlDbType.VarChar)).Value = Email_txtbox.Text;
                    command.Parameters.Add(new MySqlParameter("@staff_password", MySqlDbType.VarChar)).Value = Password_txtbox.Text;
                    command.CommandTimeout = 60;

                    int is_true = 0;
                    try
                    {
                        email = Email_txtbox.Text;
                        connection.Open();

                        MySqlDataReader datareader = command.ExecuteReader();

                        if (datareader.HasRows)
                        {
                            while (datareader.Read())
                            {
                                _login_id = datareader.GetInt32(0);
                                is_true = 1;
                            }
                        }
                        else
                        {
                            Email_txtbox.Focus();
                            Sign_timer1.Enabled = true;
                            Sign_timer1.Start();
                            Email_txtbox.Text = "";
                            Password_txtbox.Text = "";
                            Pass_indicator.Text = "";
                            datareader.Close();
                            connection.Close();
                        }
                        datareader.Close();
                        connection.Close();
                        if (is_true == 1)
                        {
                            login_history();
                            staff staff = new staff();
                            staff.Show();
                            Close();
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        connection.Close();
                    }
                }
                else
                {
                    string CommandString = @"SELECT * FROM tbl_admin WHERE admin_email=@admin_email AND admin_password=@admin_password";
                    MySqlCommand command = new MySqlCommand(CommandString, connection);
                    command.Parameters.Add(new MySqlParameter("@admin_email", MySqlDbType.VarChar)).Value = Email_txtbox.Text;
                    command.Parameters.Add(new MySqlParameter("@admin_password", MySqlDbType.VarChar)).Value = Password_txtbox.Text;
                    command.CommandTimeout = 60;

                    int is_true = 0;
                    try
                    {
                        email = Email_txtbox.Text;
                        connection.Open();
                        MySqlDataReader datareader = command.ExecuteReader();

                        if (datareader.HasRows)
                        {
                            while (datareader.Read())
                            {
                                _login_id = datareader.GetInt32(0);
                                is_true = 1;
                            }
                        }
                        else
                        {
                            is_true = 0;
                            Email_txtbox.Focus();
                            Sign_timer1.Enabled = true;
                            Sign_timer1.Start();
                            Email_txtbox.Text = "";
                            Password_txtbox.Text = "";
                            Pass_indicator.Text = "";
                            datareader.Dispose();
                            connection.Close();
                        }
                        datareader.Close();
                        connection.Close();
                        if (is_true == 1)
                        {
                            login_history();
                            Admin main = new Admin();
                            main.Show();
                            Close();
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please check your internet connection and try again");
            } 
        }

        // This will check if the Email and Password textbox is empty
        private void CheckEmptyBox()
        {
            if (Internet.CheckInternet() != false)
            {
                if (Email_txtbox.Text == "")
                {
                    Email_txtbox.Focus();
                    Pass_indicator.Text = string.Format("E-mail and password required");
                }
                else if (Password_txtbox.Text == "")
                {
                    Password_txtbox.Focus();
                    Pass_indicator.Text = string.Format("E-mail and password required");
                }
                else
                {
                    Connection();
                }
            }
            else
            {
                MessageBox.Show("Please check your internet connection and try again");
            }
        }

        // Instruction When Email textbox value is change
        private void Email_txtbox_OnValueChanged(object sender, EventArgs e)
        {
            Pass_indicator.Text = string.Format("");
        }

        // Recover Database Connection/Function
        private async void Recover_Connection()
        {
            if (Internet.CheckInternet() != false)
            {
                Random random = new Random();
                int code = random.Next(10000, 90000);
                Code = code;

                if (staff_link_clicked == true)
                {
                    string CommandString = @"SELECT staff_id_fk,staff_email FROM tbl_staff WHERE staff_email=@staff_email";
                    string CommandString1 = @"INSERT INTO auth_code (staff_id_fk1,verification_code,date_time)VALUES((SELECT staff_id_fk FROM tbl_staff WHERE staff_email = ?email limit 1),@verification_code,?date)";
                    MySqlCommand command = new MySqlCommand(CommandString, connection);
                    MySqlCommand command1 = new MySqlCommand(CommandString1, connection);
                    command.Parameters.Add(new MySqlParameter("@staff_email", MySqlDbType.VarChar)).Value = Email_Address_txtbox.Text;
                    command1.Parameters.Add(new MySqlParameter("?email", MySqlDbType.VarChar)).Value = Email_Address_txtbox.Text;
                    command1.Parameters.Add(new MySqlParameter("?date", MySqlDbType.DateTime)).Value = DateTime.Now;
                    command1.Parameters.Add(new MySqlParameter("@verification_code", MySqlDbType.Int64)).Value = code;
                    command.CommandTimeout = 60;
                    command1.CommandTimeout = 60;
                    try
                    {
                        connection.Open();

                        MySqlDataReader datareader = command.ExecuteReader();

                        if (datareader.HasRows)
                        {
                            Code_remove_Logic = true;
                            Recover_timer.Enabled = true;
                            Recover_timer.Start();
                            while (datareader.Read())
                            {
                                _id = (int)datareader.GetValue(0);
                            }
                            datareader.Close();
                            await Task.Run(() => SendMail(code, command1));
                        }
                        else
                        {
                            datareader.Close();
                            connection.Close();
                            Recover_timer.Enabled = true;
                            Recover_timer.Start();
                        }
                        connection.Close();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        connection.Close();
                    }
                }
                else
                {
                    string CommandString = @"SELECT admin_id, admin_email FROM tbl_admin WHERE admin_email=@admin_email";
                    string CommandString1 = @"INSERT INTO auth_code (admin_fk,verification_code,date_time)VALUES((SELECT admin_id FROM tbl_admin WHERE admin_email = ?email),@verification_code,?date)";
                    MySqlCommand command = new MySqlCommand(CommandString, connection);
                    MySqlCommand command1 = new MySqlCommand(CommandString1, connection);
                    command.Parameters.Add(new MySqlParameter("@admin_email", MySqlDbType.VarChar)).Value = Email_Address_txtbox.Text;
                    command1.Parameters.Add(new MySqlParameter("?email", MySqlDbType.VarChar)).Value = Email_Address_txtbox.Text;
                    command1.Parameters.Add(new MySqlParameter("?date", MySqlDbType.DateTime)).Value = DateTime.Now;
                    command1.Parameters.Add(new MySqlParameter("@verification_code", MySqlDbType.Int64)).Value = code;
                    command.CommandTimeout = 60;
                    command1.CommandTimeout = 60;

                    try
                    {
                        connection.Open();

                        MySqlDataReader datareader = command.ExecuteReader();

                        if (datareader.HasRows)
                        {
                            Code_remove_Logic = true;
                            Recover_timer.Enabled = true;
                            Recover_timer.Start();
                            while (datareader.Read())
                            {
                                _id = (int)datareader.GetValue(0);
                            }
                            datareader.Close();
                            await Task.Run(() => SendMail(code, command1));
                        }
                        else
                        {
                            Recover_timer.Enabled = true;
                            Recover_timer.Start();
                            datareader.Close();
                            connection.Close();
                        }
                        connection.Close();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please check your internet connection and try again");
            }
        }

        private void SendMail(int code, MySqlCommand command1)
        {
            try
            {
                Thread.Sleep(1000);
                SmtpClient Client = new SmtpClient()
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential()
                    {
                        UserName = ConfigurationManager.AppSettings["email"],
                        Password = ConfigurationManager.AppSettings["password"]
                    }
                };

                MailAddress Sender = new MailAddress(ConfigurationManager.AppSettings["email"],ConfigurationManager.AppSettings["name"]);
                MailAddress Receiver = new MailAddress(Email_Address_txtbox.Text, "Dear User");
                MailMessage Message = new MailMessage()
                {
                    From = Sender,
                    Subject = "Account Recovery",
                    Body = "<b> We received your request, and in response, here's your recovery code: <h1> '" + code + "' </h1> </b> "
                };

                Message.IsBodyHtml = true;
                Message.To.Add(Receiver);

                Client.SendCompleted += Client_SendCompleted;
                Client.SendMailAsync(Message);
                command1.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
           
        }

        private void Client_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
        }

        private void Code_delete_after3min()
        {
            if (Internet.CheckInternet() != false)
            {
                string CommandString = "DELETE FROM auth_code WHERE date_time < NOW() - INTERVAL 3 MINUTE";
                MySqlCommand command = new MySqlCommand(CommandString, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please check your internet connection and try again");
            }
        }
         
        private void Verify_Code()
        {
            if (Internet.CheckInternet() != false)
            {
                string CommandString = @"SELECT * FROM auth_code WHERE verification_code = @code";
                MySqlCommand command = new MySqlCommand(CommandString, connection);
                command.Parameters.Add(new MySqlParameter("@code", MySqlDbType.VarChar)).Value = Convert.ToInt32(code_txtbox.Text);
                command.CommandTimeout = 60;

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            transition2.ShowSync(change_panel);
                            Code_panel_Logic = false;
                        }
                        reader.Close();
                        connection.Close();
                    }
                    else
                    {
                        reader.Close();
                        connection.Close();
                        Code_error_timer.Enabled = true;
                        Code_error_timer.Start();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please check your internet connection and try again");
            }
        }

        private void delete_code()
        {
            if (Internet.CheckInternet() != false)
            {
                if (staff_link_clicked == true)
                {
                    string CommandString = @"DELETE FROM auth_code WHERE staff_id_fk1 = ?id";
                    MySqlCommand command = new MySqlCommand(CommandString, connection);
                    command.Parameters.Add(new MySqlParameter("?id", MySqlDbType.Int32)).Value = _id;
                    command.CommandTimeout = 60;

                    try
                    {
                        connection.Open();
                        MySqlDataReader reader = command.ExecuteReader();
                        reader.Close();
                        connection.Close();
                        _id = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        connection.Close();
                    }

                }
                else
                {
                    string CommandString = @"DELETE FROM auth_code WHERE  admin_fk = ?id";
                    MySqlCommand command = new MySqlCommand(CommandString, connection);
                    command.Parameters.Add(new MySqlParameter("?id", MySqlDbType.Int32)).Value = _id;
                    command.CommandTimeout = 60;

                    try
                    {
                        connection.Open();
                        MySqlDataReader reader = command.ExecuteReader();
                        reader.Close();
                        connection.Close();
                        _id = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please check your internet connection and try again");
            }
        }

        private void Check_empty()
        {
            if (code_txtbox.Text == string.Format(""))
            {
                Code_timer1.Enabled = true;
                Code_timer1.Start();
            }
            else
            {
                Verify_Code();
            }
        }

        private void verify_code_btn_Click(object sender, EventArgs e)
        {
            Check_empty();
        }

        // Register Connection
        private void Register_connection()
        {
            if (Internet.CheckInternet() != false)
            {
                string CommandString = @"INSERT INTO account_request (email,password,firstname,lastname,number,address)VALUES(?email,?password,?name,?lastname,?contact,?address)";
                string CommandString2 = @"SELECT staff_email FROM tbl_staff where staff_email = @email";
                MySqlCommand command = new MySqlCommand(CommandString, connection);
                MySqlCommand command2 = new MySqlCommand(CommandString2, connection);
                command.Parameters.Add(new MySqlParameter("?email",MySqlDbType.VarChar)).Value = Register_email.Text;
                command.Parameters.Add(new MySqlParameter("?password", MySqlDbType.VarChar)).Value = Register_pass.Text;
                command.Parameters.Add(new MySqlParameter("?name", MySqlDbType.VarChar)).Value = Register_name.Text;
                command.Parameters.Add(new MySqlParameter("?lastname", MySqlDbType.VarChar)).Value = Register_lastname.Text;
                command.Parameters.Add(new MySqlParameter("?contact", MySqlDbType.Text)).Value = Register_contact.Text;
                command.Parameters.Add(new MySqlParameter("?address", MySqlDbType.VarChar)).Value = Register_address.Text;
                command2.Parameters.Add(new MySqlParameter("?email", MySqlDbType.VarChar)).Value = Register_email.Text;

                try
                {
                    int count = 0;
                    connection.Open();
                    MySqlDataReader reader2 = command2.ExecuteReader();
                    if (reader2.HasRows)
                    {
                        while (reader2.Read())
                        {
                            count++;
                        }
                    }
                    reader2.Close();
                    if (count > 0)
                    {
                        email_indi.ForeColor = Color.FromArgb(255, 128, 128);
                        email_indi.Text = string.Format("Email already registered");
                        Register_btn.Enabled = true;
                        connection.Close();
                    }
                    else
                    {
                        MySqlDataReader reader = command.ExecuteReader();
                        reader.Close();
                        connection.Close();

                        DialogResult result = MessageBox.Show("Contact admin for account approval", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            transition.ShowSync(Sign_panel);
                            transition.Show(Register_panel);
                            Register_btn.Enabled = true;
                            Register_name.Text = string.Format("");
                            Register_lastname.Text = string.Format("");
                            Register_contact.Text = string.Format("");
                            Register_address.Text = string.Format("");
                            Register_email.Text = String.Format("");
                            Register_pass.Text = String.Format("");
                            validatepass.Text = String.Format("");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please check your internet connection and try again");
            }           
        }

        
        private void Recover_CheckEmpty()
        {
            if (Internet.CheckInternet() != false)
            {
                string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                if (Email_Address_txtbox.Text == "")
                {
                    Recover_timer2.Enabled = true;
                    Recover_timer2.Start();
                    return;
                }
                else
                {
                    if (Regex.IsMatch(Email_Address_txtbox.Text, pattern))
                    {
                        Recover_Connection();
                        Recover_btn.Enabled = false;
                    }
                    else
                    {
                        Recover_timer3.Enabled = true;
                        Recover_timer3.Start();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please check your internet connection and try again");
            }
        }

        private void Recover_btn_Click_1(object sender, EventArgs e)
        {
            Recover_CheckEmpty();
        }

        private void nextpage_btn_Click(object sender, EventArgs e)
        {
            first_page_checkempty();
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            second_page_Checkempty();
        }

        private void Recover_timer_Tick(object sender, EventArgs e)
        {
            Recover_Indicator.Text = string.Format("Sent Successfully, Please Check your E-mail");
            Recover_Indicator.ForeColor = Color.LightGreen;
            Recover_timer4.Enabled = true;
            Recover_timer4.Start();
            Recover_timer.Enabled = false;
            Recover_timer.Stop();
        }

        private void Recover_timer1_Tick(object sender, EventArgs e)
        {
            Recover_Indicator.Text = string.Format("We will sent you your password if the input E-Mail Address is valid");
            Recover_Indicator.ForeColor = Color.DimGray;
            if (Recover_Logic == true) Email_Address_txtbox.Text = "";
            Recover_timer1.Enabled = false;
            Recover_timer1.Stop();
        }

        private void Recover_timer2_Tick(object sender, EventArgs e)
        {
            Recover_Indicator.Text = string.Format("E-mail address required");
            Recover_Indicator.ForeColor = Color.FromArgb(255,128,128);
            Recover_Logic = false;
            Recover_timer1.Enabled = true;
            Recover_timer1.Start();
            Recover_timer2.Enabled = false;
            Recover_timer2.Stop();
        }

        private void Recover_timer3_Tick(object sender, EventArgs e)
        {
            Recover_Indicator.Text = string.Format("Please Provide a Valid E-mail Address");
            Recover_Indicator.ForeColor = Color.FromArgb(255, 128, 128);
            Recover_Logic = false;
            Recover_timer1.Enabled = true;
            Recover_timer1.Start();
            Recover_timer3.Enabled = false;
            Recover_timer3.Stop();
        }

        private void Recover_timer4_Tick(object sender, EventArgs e)
        {
            switch (Code_remove_Logic)
            {
                case true:
                    Back_btn1.Visible = true;
                    Back_btn.Visible = false;
                    Recover_btn.Enabled = true;
                    Recover_Logic = true;
                    Code_panel_Logic = true;
                    transition2.ShowSync(Code_panel);
                    Code_timer.Enabled = true;
                    Code_timer.Start();
                    Recover_timer1.Enabled = true;
                    Recover_timer1.Start();
                    Recover_timer4.Enabled = false;
                    Recover_timer4.Stop();
                    break;

                case false:
                    Recover_timer4.Stop();
                    Back_btn1.Visible = true;
                    Back_btn.Visible = false;
                    Recover_btn.Enabled = true;
                    transition2.ShowSync(Code_panel);
                    Recover_Logic = true;
                    Code_panel_Logic = false;
                    Recover_timer1.Enabled = true;
                    Recover_timer1.Start();
                    Recover_timer4.Enabled = false;
                    break;
            }
        }

        private void Code_timer_Tick(object sender, EventArgs e)
        {
            Code_delete_after3min();
            Code = 0;
            Code_remove_Logic = false;
            Code_timer.Enabled = false;
            Code_timer.Stop();
        }

        private void Code_error_timer_Tick(object sender, EventArgs e)
        {
            Code_indi.Text = string.Format("Invalid Code");
            Code_indi.ForeColor = Color.FromArgb(255, 128, 128);
            Code_text_timer.Enabled = true;
            Code_text_timer.Start();
            Code_error_timer.Enabled = false;
            Code_error_timer.Stop();
        }

        private void Code_text_timer_Tick(object sender, EventArgs e)
        {
            Code_indi.Text = string.Format("Enter the code we sent to your E-mail address");
            Code_indi.ForeColor = Color.DimGray;
            Code_text_timer.Enabled = false;
            Code_text_timer.Stop();
        }

        private void Code_timer1_Tick(object sender, EventArgs e)
        {
            Code_indi.Text = string.Format("Code required");
            Code_indi.ForeColor = Color.FromArgb(255, 128, 128);
            Code_text_timer.Enabled = true;
            Code_text_timer.Start();
            Code_timer1.Enabled = false;
            Code_timer1.Stop();
        }

        private void Sign_timer1_Tick(object sender, EventArgs e)
        {
            Pass_indicator.Text = string.Format("E-mail or Password is wrong ");
            Sign_timer1.Enabled = false;
            Sign_timer1.Stop();
        }

        // Sign in btn
        private void Signin_btn_Click(object sender, EventArgs e)
        {
            CheckEmptyBox();
        }

        // Register back button
        private void Register_back_Click(object sender, EventArgs e)
        {
            Register_Back_Function();
        }
        private void second_page_back_Click(object sender, EventArgs e)
        {
            secondpage_back();
        }

        private void Register_Back_Function()
        {
            transition.ShowSync(Sign_panel);
            Recover_panel.Enabled = true;
            Recover_panel.Visible = true;
            Register_name.Text = string.Format("");
            Register_lastname.Text = string.Format(""); 
            Register_contact.Text = string.Format("");
            Register_address.Text = string.Format("");
        }

        private void secondpage_back()
        {
            transition.ShowSync(Register_panel);
            Register_email.Text = string.Format("");
            Register_pass.Text = string.Format("");
            validatepass.Text = string.Format("");
        }
        private void Register_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void second_page_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Register_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Register_lastname.Focus();
            }
        }

        private void Register_lastname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Register_contact.Focus();
            }
        }

        private void Register_contact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Register_address.Focus();
            }
        }

        private void Register_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validatepass.Focus();
            }
        }

        private void Register_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Register_pass.Focus();
            }
        }

        private void Register_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validatepass.Focus();
            }
        }

        private void validatepass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                second_page_Checkempty();
            }
        }

        private void Register_address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                second_page_Checkempty();
            }
        }

        private void Register_password_OnValueChanged(object sender, EventArgs e)
        {
            Register_address.isPassword = true;
            address_indi.Text = string.Format("");
        }

        private void first_page_checkempty()
        {
            if (Register_name.Text == "")
            {
                Register_name.Focus();
                name_indi.ForeColor = Color.FromArgb(255, 128, 128);
                name_indi.Text = string.Format("First Name Required");

            }else if (Register_lastname.Text == "")
            {
                Register_lastname.Focus();
                lastname_indi.ForeColor = Color.FromArgb(255, 128, 128);
                lastname_indi.Text = string.Format("Last Name Required");
            }
            else if (Register_contact.Text == "")
            {
                Register_contact.Focus();
                contact_indi.ForeColor = Color.FromArgb(255, 128, 128);
                contact_indi.Text = string.Format("Contact Number Required");
            }
            else if (Register_address.Text == "")
            {
                Register_address.Focus();
                address_indi.ForeColor = Color.FromArgb(255, 128, 128);
                address_indi.Text = string.Format("Address Required");
            }
            else
            {
                if (Register_contact.Text[0].Equals('0') && Register_contact.Text[1].Equals('9') && Register_contact.Text.Length == 11)
                {
                    transition.HideSync(Register_panel);
                }
                else
                {

                    contact_indi.ForeColor = Color.FromArgb(255, 128, 128);
                    contact_indi.Text = String.Format("Please provide a valid phone number");
                }
            }
        }

        private void second_page_Checkempty()
        {

            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Register_email.Text == "")
            {
                Register_email.Focus();
                email_indi.ForeColor = Color.FromArgb(255, 128, 128);
                email_indi.Text = string.Format("Email Required");
            }
            else if (Register_pass.Text == "")
            {
                Register_pass.Focus();
                password_indi.ForeColor = Color.FromArgb(255, 128, 128);
                password_indi.Text = string.Format("Password Required");
            }
            else if (validatepass.Text == "")
            {
                validatepass.Focus();
                conpass_indi.ForeColor = Color.FromArgb(255, 128, 128);
                conpass_indi.Text = string.Format("Confirmation Password Required");
            }
            else if (password_indi.Text.Equals("Weak") || password_indi.Text.Equals("Very Weak"))
            {
                MessageBox.Show("Cant create account with weak password");
                Register_pass.Focus();
            }
            else
            {
                if (Register_pass.Text != validatepass.Text)
                {
                    validatepass.Focus();
                    conpass_indi.ForeColor = Color.FromArgb(255, 128, 128);
                    conpass_indi.Text = string.Format("Password not match");
                }
                else
                {
                    if (Regex.IsMatch(Register_email.Text, pattern))
                    {
                        Register_btn.Enabled = false;
                        Register_connection();
                    }
                    else
                    {
                        Register_email.Focus();
                        email_indi.ForeColor = Color.FromArgb(255, 128, 128);
                        email_indi.Text = string.Format("Please Provide a Valid E-mail Address");
                    }
                }
            }
        }

        private void RegisterPasswordIsvalid(string password)
        {
            if (password.Length > 10 && password.Length < 16)
            {
                base1.Image = Properties.Resources._base;
                base2.Image = Properties.Resources.moderately_strong;
                base3.Image = Properties.Resources._base;
                password_indi.ForeColor = Color.FromArgb(225, 223, 141);
                password_indi.Text = string.Format("Moderately Strong");
                return;
            }
             else if (password.Length > 15)
            {
                base1.Image = Properties.Resources._base;
                base2.Image = Properties.Resources._base;
                base3.Image = Properties.Resources.strong;
                password_indi.ForeColor = Color.FromArgb(123, 225, 136);
                password_indi.Text = string.Format("Strong");
                return;
            }
            else if (password.Contains("123456789"))
            {
                base1.Image = Properties.Resources.weak;
                base2.Image = Properties.Resources._base;
                base3.Image = Properties.Resources._base;
                password_indi.ForeColor = Color.FromArgb(255, 128, 128);
                password_indi.Text = string.Format("Very Weak");
                return;
            }
            else if (password.Length < 8 && Uppercase_Count(password) > 0 && LoweCase_Count(password) > 0 && Numeric_Count(password) > 0 && NonAlpha_Count(password) > 0)
            {
                base1.Image = Properties.Resources._base;
                base2.Image = Properties.Resources.moderately_strong;
                base3.Image = Properties.Resources._base;
                password_indi.ForeColor = Color.FromArgb(225, 223, 141);
                password_indi.Text = string.Format("Moderately Strong");
                return;
            }
            else if (password.Length > 7 && Uppercase_Count(password) > 0 && LoweCase_Count(password) > 0 && Numeric_Count(password) > 0 && NonAlpha_Count(password) > 0)
            {
                base1.Image = Properties.Resources._base;
                base2.Image = Properties.Resources._base;
                base3.Image = Properties.Resources.strong;
                password_indi.ForeColor = Color.FromArgb(123, 225, 136);
                password_indi.Text = string.Format("Strong");
                return;
            }
            else
            {
                base1.Image = Properties.Resources.weak;
                base2.Image = Properties.Resources._base;
                base3.Image = Properties.Resources._base;
                password_indi.ForeColor = Color.FromArgb(255, 128, 128);
                password_indi.Text = string.Format("Weak");
                return;
            }
        }

        private void ChangePasswordIsvalid(string password)
        {
            if (password.Length > 10 && password.Length < 16)
            {
                base1_1.Image = Properties.Resources._base;
                base1_2.Image = Properties.Resources.moderately_strong;
                base1_3.Image = Properties.Resources._base;
                change_pass_indi.ForeColor = Color.FromArgb(225, 223, 141);
                change_pass_indi.Text = string.Format("Moderately Strong");
                return;
            }
            else if (password.Length > 15)
            {
                base1_2.Image = Properties.Resources._base;
                base1_2.Image = Properties.Resources._base;
                base1_3.Image = Properties.Resources.strong;
                change_pass_indi.ForeColor = Color.FromArgb(123, 225, 136);
                change_pass_indi.Text = string.Format("Strong");
                return; 
            }
            else if (password.Contains("123456789"))
            {
                base1_1.Image = Properties.Resources.weak;
                base1_2.Image = Properties.Resources._base;
                base1_3.Image = Properties.Resources._base;
                change_pass_indi.ForeColor = Color.FromArgb(255, 128, 128);
                change_pass_indi.Text = string.Format("Very Weak");
                return;
            }
            else if (password.Length < 8 && Uppercase_Count1(password) > 0 && LoweCase_Count1(password) > 0 && Numeric_Count1(password) > 0 && NonAlpha_Count1(password) > 0)
            {
                base1_1.Image = Properties.Resources._base;
                base1_2.Image = Properties.Resources.moderately_strong;
                base1_3.Image = Properties.Resources._base;
                change_pass_indi.ForeColor = Color.FromArgb(225, 223, 141);
                change_pass_indi.Text = string.Format("Moderately Strong");
                return;
            }
            else if (password.Length > 7 && Uppercase_Count1(password) > 0 && LoweCase_Count1(password) > 0 && Numeric_Count1(password) > 0 && NonAlpha_Count1(password) > 0)
            {
                base1_1.Image = Properties.Resources._base;
                base1_2.Image = Properties.Resources._base;
                base1_3.Image = Properties.Resources.strong;
                change_pass_indi.ForeColor = Color.FromArgb(123, 225, 136);
                change_pass_indi.Text = string.Format("Strong");
                return;
            }
            else
            {
                base1_1.Image = Properties.Resources.weak;
                base1_2.Image = Properties.Resources._base;
                base1_3.Image = Properties.Resources._base;
                change_pass_indi.ForeColor = Color.FromArgb(255, 128, 128);
                change_pass_indi.Text = string.Format("Weak");
                return;
            }
        }

        private int Uppercase_Count(string password)
        {
            return Regex.Matches(Register_pass.Text.ToString(), "[A-Z]").Count;
        }

        private int LoweCase_Count(string password)
        {
            return Regex.Matches(Register_pass.Text.ToString(), "[a-z]").Count;
        }

        private int Numeric_Count(string password)
        {
            return Regex.Matches(Register_pass.Text.ToString(), "[0-9]").Count;
        }

        private int NonAlpha_Count(string password)
        {
            return Regex.Matches(Register_pass.Text.ToString(), @"[^0-9a-zA-Z\._]").Count;
        }

        private int Uppercase_Count1(string password)
        {
            return Regex.Matches(change_pass_txtbox.Text.ToString(), "[A-Z]").Count;
        }

        private int LoweCase_Count1(string password)
        {
            return Regex.Matches(change_pass_txtbox.Text.ToString(), "[a-z]").Count;
        }

        private int Numeric_Count1(string password)
        {
            return Regex.Matches(change_pass_txtbox.Text.ToString(), "[0-9]").Count;
        }

        private int NonAlpha_Count1(string password)
        {
            return Regex.Matches(change_pass_txtbox.Text.ToString(), @"[^0-9a-zA-Z\._]").Count;
        }

        private void Register_name_OnValueChanged(object sender, EventArgs e)
        {
            name_indi.Text = string.Format("");
        }

        private void Register_lastname_OnValueChanged(object sender, EventArgs e)
        {
            lastname_indi.Text = string.Format("");
        }

        private void Register_contact_OnValueChanged(object sender, EventArgs e)
        {
            contact_indi.Text = string.Format("");
        }

        private void Register_address_OnValueChanged(object sender, EventArgs e)
        {
            address_indi.Text = string.Format("");
        }

        private void Register_email_OnValueChanged(object sender, EventArgs e)
        {
            email_indi.Text = string.Format("");
        }

        private void Register_pass_OnValueChanged(object sender, EventArgs e)
        {
            if (Register_pass.Text.Length != 0)
            {
                Register_pass.isPassword = true;
                base1.Visible = true;
                base2.Visible = true;
                base3.Visible = true;
                password_indi.Location = new Point(24, 291);
                RegisterPasswordIsvalid(Register_pass.Text);
            }
            else
            {
                password_indi.Text = string.Format("");
                password_indi.Location = new Point(24, 273);
                base1.Visible = false;
                base2.Visible = false;
                base3.Visible = false;
            }
            
            
        }

        private void validatepass_OnValueChanged(object sender, EventArgs e)
        {
            validatepass.isPassword = true;
            conpass_indi.Text = string.Format("");
        }

        private void Register_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void code_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void code_txtbox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Check_empty();
                    break;
            }
        }

        private void change_pass_txtbox_OnValueChanged(object sender, EventArgs e)
        {
            if (change_pass_txtbox.Text.Length != 0)
            {
                base1_1.Visible = true;
                base1_2.Visible = true;
                base1_3.Visible = true;
                change_pass_txtbox.isPassword = true;
                ChangePasswordIsvalid(change_pass_txtbox.Text);
            }
            else
            {
                base1_1.Visible = false;
                base1_2.Visible = false;
                base1_3.Visible = false;
                change_indicator.Text = string.Format("");
                change_pass_indi.Text = string.Format("");
            }
            
        }

        private void change_pass_confirm_OnValueChanged(object sender, EventArgs e)
        {
            change_pass_confirm.isPassword = true;
            change_indicator.Text = string.Format("");

        }

        

        private void Change_password_check_empty()
        {
            if (change_pass_txtbox.Text == string.Format(""))
            {
                change_indicator.Text = string.Format("New Password required");
                change_pass_txtbox.Focus();
            }
            else if (change_pass_confirm.Text == string.Format(""))
            {
                change_indicator.Text = string.Format("Confirmation Password required");
                change_pass_confirm.Focus();
            }
            else if (change_pass_indi.Text.Equals("Weak") || change_pass_indi.Text.Equals("Very Weak"))
            {
                MessageBox.Show("Cant create account with weak password");
                change_pass_txtbox.Focus();
            }
            else
            {
                if (change_pass_txtbox.Text != change_pass_confirm.Text)
                {
                    change_indicator.Text = string.Format("Password not match");
                }
                else
                {
                    Update_password();
                }
            }
        }

        private void change_pass_txtbox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    change_pass_confirm.Focus();
                    break;
            }
        }

        private void change_pass_confirm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Change_password_check_empty();
                    break;
            }
        }

        private void Update_password()
        {
            if (Internet.CheckInternet() != false)
            {
                if (staff_link_clicked == true)
                {
                    string CommandString = @"UPDATE `tbl_staff` SET `staff_password`=@password WHERE (SELECT staff_id_fk1 from auth_code WHERE staff_id_fk = staff_id_fk1)";
                    MySqlCommand command = new MySqlCommand(CommandString, connection);
                    command.Parameters.Add(new MySqlParameter("@password", MySqlDbType.VarChar)).Value = change_pass_confirm.Text;
                    command.CommandTimeout = 60;

                    try
                    {
                        connection.Open();
                        MySqlDataReader reader = command.ExecuteReader();
                        reader.Read();
                        reader.Close();
                        connection.Close();
                        DialogResult result = MessageBox.Show("New password set successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        switch (result)
                        {
                            case DialogResult.OK:
                                transition.ShowSync(Sign_panel);
                                transition2.HideSync(change_panel);
                                transition2.HideSync(Code_panel);
                                break;
                        }
                        delete_code();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        connection.Close();
                    }
                }
                else
                {
                    string CommandString = @"UPDATE tbl_admin SET admin_password = @code";
                    MySqlCommand command = new MySqlCommand(CommandString, connection);
                    command.Parameters.Add(new MySqlParameter("@code", MySqlDbType.VarChar)).Value = change_pass_confirm.Text;
                    command.CommandTimeout = 60;

                    try
                    {
                        connection.Open();
                        MySqlDataReader reader = command.ExecuteReader();
                        reader.Close();
                        connection.Close();
                        DialogResult result = MessageBox.Show("New password set successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        switch (result)
                        {
                            case DialogResult.OK:
                                transition.ShowSync(Sign_panel);
                                transition2.HideSync(change_panel);
                                transition2.HideSync(Code_panel);
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please check your internet connection and try again");
            }
        }

        private void Change_password_btn_Click(object sender, EventArgs e)
        {
            Change_password_check_empty();
        }

        private void login_history()
        {
            if (Internet.CheckInternet() != false)
            {
                string logs = "System: User  '" + email + "'  is login at  " + DateTime.Now;
                string Command = @"INSERT INTO login_history(staff_id_fk2,admin_id_fk,log)VALUES((SELECT staff_id_fk FROM tbl_staff WHERE staff_email = '" + email + "'),(SELECT admin_id FROM tbl_admin WHERE admin_email = '" + email + "'),?logs)";
                MySqlCommand command = new MySqlCommand(Command, connection);
                command.Parameters.Add(new MySqlParameter("?logs", MySqlDbType.VarChar)).Value = logs;
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                    connection.Close();
                    email = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please check your internet connection and try again");
            }
        }
    }
}