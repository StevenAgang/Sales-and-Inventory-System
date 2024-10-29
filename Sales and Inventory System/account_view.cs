using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_and_Inventory_System
{
    public partial class account_view : Form
    {
        public static account_view instance;
        public int ids = 0;
        user_information users = new user_information();
        new string Location = "";
        private bool click = false;
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public MySqlConnection connection = new MySqlConnection(ConnectionString);
        public account_view()
        {
            InitializeComponent();
            instance = this;
            users.GetID = Login.instance._login_id;
            ids = users.GetID;
        }

        private void account_view_Load(object sender, EventArgs e)
        {
            Profile();
        }

        private void Profile()
        {
            if (Internet.CheckInternet() != false)
            {
                string commandString = @"SELECT profile_picture.picture_data,tbl_staff.staff_email,staff_information.staff_firstname,staff_information.staff_lastname,staff_information.staff_contact,staff_information.staff_address FROM staff_information RIGHT JOIN tbl_staff ON tbl_staff.staff_id_fk = staff_information.staff_id RIGHT JOIN profile_picture ON profile_picture.staff_id_fk3 = staff_information.staff_id WHERE staff_information.staff_id = ?id";
                string commandString1 = @"SELECT staff_id_fk3 FROM profile_picture WHERE staff_id_fk3 = ?id";
                string commmandString2 = @"SELECT tbl_staff.staff_email,staff_information.staff_firstname,staff_information.staff_lastname,staff_information.staff_contact,staff_information.staff_address FROM staff_information RIGHT JOIN tbl_staff ON tbl_staff.staff_id_fk = staff_information.staff_id WHERE staff_information.staff_id = ?id";
                MySqlCommand command = new MySqlCommand(commandString, connection);
                MySqlCommand command1 = new MySqlCommand(commandString1, connection);
                MySqlCommand command2 = new MySqlCommand(commmandString2, connection);
                command.Parameters.Add(new MySqlParameter("?id", MySqlDbType.Int32)).Value = ids;
                command1.Parameters.Add(new MySqlParameter("?id", MySqlDbType.Int32)).Value = ids;
                command2.Parameters.Add(new MySqlParameter("?id", MySqlDbType.Int32)).Value = ids;

                try
                {
                    connection.Open();
                    var n = command1.ExecuteScalar();

                    if (n != null)
                    {
                        browse.Visible = false;
                        upload_image.Visible = false;
                        change.Visible = true;
                        MySqlDataReader reader = command.ExecuteReader();
                        reader.Read();
                        if (reader.HasRows)
                        {
                            byte[] image = (byte[])reader[0];
                            email.Text = reader.GetString(1);
                            firstname.Text = reader.GetString(2);
                            lastname.Text = reader.GetString(3);
                            contact.Text = reader.GetString(4);
                            address.Text = reader.GetString(5);

                            MemoryStream stream = new MemoryStream(image);
                            profile_pic.Image = Image.FromStream(stream);
                        }
                        reader.Close();
                    }
                    else
                    {
                        browse.Visible = true;
                        upload_image.Visible = false;
                        change.Visible = false;
                        MySqlDataReader reader = command2.ExecuteReader();
                        reader.Read();
                        if (reader.HasRows)
                        {
                            email.Text = reader.GetString(0);
                            firstname.Text = reader.GetString(1);
                            lastname.Text = reader.GetString(2);
                            contact.Text = reader.GetString(3);
                            address.Text = reader.GetString(4);
                        }
                        reader.Close();
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please check your internet connectin and try again");
            }
        }

        private void replace_astk()
        {
            /*password.Text = string.Format("");
            for (int i = 0; i < passwords.Length; i++)
            {
                passwords = passwords.Replace($"[a-zA-Z]","*");
            }
            password.Text = passwords;
            return passwords;*/
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Browse()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = $"png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (open.ShowDialog().Equals(DialogResult.OK))
            {
                Location = open.FileName.ToString();
                profile_pic.ImageLocation = Location;
                browse.Visible = false;
                upload_image.Visible = true;
                change.Visible = false;
            }
          
        }

        private void Update_picture()
        {
            if (Internet.CheckInternet() != false)
            {
                byte[] image = null;
                FileStream stream = new FileStream(Location, FileMode.Open, FileAccess.Read);
                BinaryReader reader = new BinaryReader(stream);
                image = reader.ReadBytes((int)stream.Length);
                string connectionString = @"UPDATE profile_picture SET picture_data = ?image WHERE staff_id_fk3 = ?data";
                MySqlCommand command = new MySqlCommand(connectionString, connection);
                command.Parameters.Add(new MySqlParameter("?data", MySqlDbType.Int32)).Value = users.GetID;
                command.Parameters.Add(new MySqlParameter("?image", MySqlDbType.Blob)).Value = image;
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    Profile();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please check your internet connectin and try again");
            }
        }

        private void Upload()
        {
            if (click == false)
            {
                if (Internet.CheckInternet() != false)
                {
                    byte[] image = null;
                    FileStream stream = new FileStream(Location, FileMode.Open, FileAccess.Read);
                    BinaryReader reader = new BinaryReader(stream);
                    image = reader.ReadBytes((int)stream.Length);
                    string connectionString = @"INSERT INTO profile_picture(staff_id_fk3,picture_data)VALUES(?data,?image)";
                    MySqlCommand command = new MySqlCommand(connectionString, connection);
                    command.Parameters.Add(new MySqlParameter("?data", MySqlDbType.Int32)).Value = users.GetID;
                    command.Parameters.Add(new MySqlParameter("?image", MySqlDbType.Blob)).Value = image;
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        Profile();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please check your internet connectin and try again");
                }
            }
            else
            {
                Update_picture();
            }
          
        }
  
        private void browse_Click(object sender, EventArgs e)
        {
            click = false;
            Browse();
        }

        private void browse_MouseLeave(object sender, EventArgs e)
        {
            browse.Image = Properties.Resources.upload_208px;
            browse.ForeColor = Color.White;
        }

        private void upload_image_Click_1(object sender, EventArgs e)
        {
            Upload();
        }

        private void change_Click(object sender, EventArgs e)
        {
            click = true;
            Browse();
        }
    }
}
