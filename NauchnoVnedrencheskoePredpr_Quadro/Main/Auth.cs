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
using AdditionalFunc_Lib;
using NauchnoVnedrencheskoePredpr_Quadro.Admin;
using NauchnoVnedrencheskoePredpr_Quadro.Main;
using NauchnoVnedrencheskoePredpr_Quadro.User;

namespace NauchnoVnedrencheskoePredpr_Quadro
{
    public partial class Auth : Form
    {
        //Основные параметры
        public int Captcha = WelcomeScreen.isCaptchaGood;
        public int LoggedIn = WelcomeScreen.isLoggedIn;
        private int type;
        public ImageList authimgs = new ImageList();
        public Auth()
        {
            InitializeComponent();
            authimgs.TransparentColor = Color.White;
            Size imgsizeMax = new Size(256, 256);
            authimgs.ImageSize = imgsizeMax;          
            authimgs.Images.Add(Properties.Resources.passon);
            authimgs.Images.Add(Properties.Resources.passoff);
            pb_Icantsee.Image = authimgs.Images[0];
            tb_password.PasswordChar = Char.Parse("*");
        }

        private void Auth_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pb_func_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private AdditionalFunc_Lib.SQLConnection db = new AdditionalFunc_Lib.SQLConnection();
        private int totalticks = 0;
        private void btn_enter_Click(object sender, EventArgs e)
        {
            var nameLogin = tb_login.Text;
            var passLogin = tb_password.Text;
            //Ввод адаптера и запроса.
            string querylogin = $"SELECT ID_User, User_Name, User_Pass, User_Type FROM [auth] WHERE User_Name = '{nameLogin}' and User_Pass = '{passLogin}' ";
            SqlDataAdapter sqlAdapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand(querylogin, db.DBget());
            sqlAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            if (tb_login.Text == "" || tb_password.Text == "")
            {
                MessageBox.Show("Вы не ввели логин или пароль, попробуйте ещё раз!", "Не удалось войти", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (DataRow row in dt.Rows)
                {


                    //Тут определяются типы пользователей a - администратор, u - пользователь.
                    //При отсутствии или несоответствии этого значения у созданных аккаунтов, программа выдаёт ошибку.
                    //
                    if (row.ItemArray[3].ToString() == "a")
                    {
                        LoggedIn = 1;
                        type = 1;
                        CaptchaCheck check = new CaptchaCheck();
                        check.ShowDialog();
                        checktimer.Interval = 1;
                        checktimer.Start();
                    }
                    else if (row.ItemArray[3].ToString() == "u")
                    {
                        LoggedIn = 1;
                        type = 2;
                        CaptchaCheck check = new CaptchaCheck();
                        check.ShowDialog();
                        checktimer.Interval = 10;
                        checktimer.Start();

                    }
                    else
                    {
                        MessageBox.Show("Произошла непредвиденная ошибка, попробуйте ещё раз!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        //Проверка успешного ввода Каптчи кажды 10 миллисекунд
        private void checktimer_Tick(object sender, EventArgs e)
        {
            Captcha = CaptchaCheck.passed;
            if (type == 1)
            {
                if (Captcha == 1)
                {
                    checktimer.Stop();
                    MessageBox.Show("Вы успешно вошли в режим Администратора!", "Успех!", MessageBoxButtons.OK);
                    AdminForm admin = new AdminForm();
                    admin.Show();
                    this.Hide();


                }
            }
            if (type == 2)
            {
                if (Captcha == 1)
                {
                    checktimer.Stop();
                    MessageBox.Show("Вы успешно вошли!", "Успех!", MessageBoxButtons.OK);
                    UserForm user = new UserForm();
                    user.Show();
                    this.Hide();
                }
            }
        }
        //Переменная меняет тип символа
        private bool changer;

        private void pb_Icantsee_Click(object sender, EventArgs e)
        {
            if (changer == false)
            {
                tb_password.PasswordChar = Char.Parse("\0");
                pb_Icantsee.Image = authimgs.Images[1];
                changer = true;
            }
            else if (changer == true)
            {
                tb_password.PasswordChar = Char.Parse("*");
                pb_Icantsee.Image = authimgs.Images[0];
                changer = false;
            }

        }
    }
}
