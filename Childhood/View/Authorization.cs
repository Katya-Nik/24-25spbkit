using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Childhood
{
    public partial class Avtorizachiya : Form
    {
        public Avtorizachiya()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            //Получить логин и пароль от пользователя
            string login = this.Login.Text;
            string password = this.Password.Text;
            //Получить всех пользователей из БД
            List<Model.User> users = Helper.DB.User.ToList();
            //Получить список отфильтрованных пользователей по логину и паролю
            List<Model.User> usersLoginPassword = users.Where(u => u.UserLogin == login && u.UserPassword == password).ToList();
            //Получить единственного пользователя или его отсутствие
            Helper.user = usersLoginPassword.FirstOrDefault();
            //Проверка наличия единственного пользователя
            if (Helper.user != null) //Есть такой пользователь
            {
                MessageBox.Show("Пользователь найден. Вы вошли с ролью " + Helper.user.Role.RoleName, "Валидация пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);


                ChildrenList childrenList = new ChildrenList();
                this.Hide();
                childrenList.ShowDialog();
                this.Show();
            }
            else //Отсутствует пользователь
            {
                MessageBox.Show("Пользователь не найден", "Валидация пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private void Exit_Click(object sender, EventArgs e)
            {
                this.Close();
            }

        private void Login_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Helper.DB = new Model.DBKindergarden();	//Создание объекта подключения к БД
            }
            catch
            {
                MessageBox.Show("Ошибка при подключении к БД", "Валидация подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(-1);
            }
        }

        private void Avtorizachiya_Load(object sender, EventArgs e)
        {

        }
    }
}
