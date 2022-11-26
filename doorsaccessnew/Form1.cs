using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doorsaccessnew
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public void ManagerRole(int role)
        {
            switch (role)
            {
                //И в зависимости от того, какая роль (цифра) хранится в поле класса и передана в метод, показываются те или иные кнопки.
                //Вы можете скрыть их и не отображать вообще, здесь они просто выключены
                case 1:
                    label4.Text = "Директор";
                    label4.ForeColor = Color.Green;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    break;
                case 2:
                    label4.Text = "Охрана";
                    label4.ForeColor = Color.YellowGreen;
                    button1.Enabled = false;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    break;
                case 3:
                    label4.Text = "ДТСК";
                    label4.ForeColor = Color.Yellow;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = true;
                    break;
                //Если по какой то причине в классе ничего не содержится, то всё отключается вообще
                default:
                    label4.Text = "Общий доступ";
                    label4.ForeColor = Color.DarkGray;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    break;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //Сокрытие текущей формы
            this.Hide();
            //Инициализируем и вызываем форму диалога авторизации
            FormAuth FormAuth = new FormAuth();
            //Вызов формы в режиме диалога
            FormAuth.ShowDialog();
            //Если авторизации была успешна и в поле класса хранится истина, то делаем движуху:
            if (Auth.auth)
            {
                //Отображаем рабочую форму
                this.Show();
                //Вытаскиваем из класса поля в label'ы
                label1.Text = Convert.ToString(Auth.id);
                label2.Text = Auth.fio;
                label3.Text = "Успешна!";
                //Красим текст в label в зелёный цвет
                label3.ForeColor = Color.Green;
                //Вызываем метод управления ролями
                ManagerRole(Auth.auth_role);
            }
            //иначе
            else
            {
                //Закрываем форму
                this.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Сокрытие текущей формы
            this.Hide();
            //Инициализируем и вызываем форму диалога авторизации
            FormAuth FormAuth = new FormAuth();
            //Вызов формы в режиме диалога
            FormAuth.ShowDialog();
            //Если авторизации была успешна и в поле класса хранится истина, то делаем движуху:
            if (Auth.auth)
            {
                //Отображаем рабочую форму
                this.Show();
                //Вытаскиваем из класса поля в label'ы
                label1.Text = Convert.ToString(Auth.id);
                label2.Text = Auth.fio;
                label3.Text = "Успешна!";
                //Красим текст в label в зелёный цвет
                label3.ForeColor = Color.Green;
                //Вызываем метод управления ролями
                ManagerRole(Auth.auth_role);
            }
            //иначе
            else
            {
                //Закрываем форму
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
