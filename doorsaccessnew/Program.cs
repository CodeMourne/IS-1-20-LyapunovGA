using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doorsaccessnew
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
    static class Auth
    {
        //Статичное поле, которое хранит значение статуса авторизации
        public static bool auth = false;
        //Статичное поле, которое хранит значения ID пользователя
        public static string auth_login = null;
        //Статичное поле, которое хранит значения ФИО пользователя
        public static string auth_password = null;
        //Статичное поле, которое хранит количество привелегий пользователя
        public static int auth_role = 0;
        //Статичное поле, которое через авторизацию получает ФИО сотрудника
        public static string fio = null;
        //
        public static int id = 0;
    }
}
