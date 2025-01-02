using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Childhood.View
{
    public partial class AddingaParent : Form
    {
        public AddingaParent()
        {
            InitializeComponent();
        }

        private void AddingaParent_Load(object sender, EventArgs e)
        {
            // Скрываем элемент управления tlpaddindPer при загрузке формы
            tlpaddindPer.Visible = false;
            //Получить список УЗ из БД
            List<Model.User> users = Helper.DB.User.ToList();
            //Получить список родителей из БД
            List<Model.Parents> parents = Helper.DB.Parents.ToList();
        }

        private void NextChild_Click(object sender, EventArgs e)
        {            
            //Создали пустой объект - родителя
            Model.Parents parents = new Model.Parents();

            if (string.IsNullOrWhiteSpace(textBoxLasPer.Text) || string.IsNullOrWhiteSpace(textBoxNamePer.Text) ||
                string.IsNullOrWhiteSpace(textBoxFathPer.Text) || string.IsNullOrWhiteSpace(maskedTextBoxPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBoxNumPassportdata.Text) || string.IsNullOrWhiteSpace(maskedTextBoxSeriaPassportdata.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmailPer.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Завершаем выполнение метода, если есть пустые поля
            }else {
                //Получаем данные родителя из текстовых полей
                parents.ParentLastname = textBoxLasPer.Text;
                parents.ParentName = textBoxNamePer.Text;
                parents.ParentFathername = textBoxFathPer.Text;
                parents.ParentTelephoneNumber = maskedTextBoxPhoneNumber.Text;
                parents.ParentNumPassportdata = Convert.ToInt32(maskedTextBoxNumPassportdata.Text);
                parents.ParentSeriaPassportdata = Convert.ToInt32(maskedTextBoxSeriaPassportdata.Text); 
                parents.ParentEmaile = textBoxEmailPer.Text;
                // Получаем последнего пользователя из базы данных
                var lastUser = Helper.DB.User.OrderByDescending(u => u.UserID).FirstOrDefault();
                if (lastUser != null)
                {
                    parents.ParentUserID = lastUser.UserID; // Присваиваем ID последнего пользователя
                }
                else
                {
                    MessageBox.Show("Нет пользователей в базе данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Завершаем выполнение метода, если нет пользователей
                }

                // Добавляем родителя в контекст базы данных
                Helper.DB.Parents.Add(parents);

                try
                {
                    // Сохраняем изменения в базе данных
                    Helper.DB.SaveChanges();
                    MessageBox.Show("Учетная запись родителя добавлена", "Валидация пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Открыть форму для добавления ребенка
                    View.AddingaChildren addingaChildren = new View.AddingaChildren();
                    this.Hide();
                    addingaChildren.ShowDialog();
                    this.Show();
                }
                catch (Exception ex)
                {
                    // Обработка ошибок при сохранении
                    MessageBox.Show($"Ошибка при добавлении родителя: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddLogPasswPer_Click(object sender, EventArgs e)
        {
            String error = ""; //Строка с возможными ошибками
            //Создали пустой объект - пользователя
            Model.User user = new Model.User();
            //Получаем данные для УЗ родителя
            user.UserLogin = textBoxLogPer.ToString();
            user.UserPassword = textBoxPasswPer.ToString();
            //Проверка логина или пароля на пустое значение
            if (this.textBoxLogPer.Text == "" && this.textBoxPasswPer.Text == "")
            {
                //Накапливаем строку совершенных ошибок
                error += "Вы не ввели логин или пароль" + Environment.NewLine;
            }
            else
            {
                //Заполняем поля пользователя
                user.UserLogin = this.textBoxLogPer.Text;
                user.UserPassword = this.textBoxPasswPer.Text;
                Helper.DB.SaveChanges();
                MessageBox.Show("Пользователь добавлен", "Валидация пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tlpaddindPer.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Открыть форму для добавления ребенка
            View.AddingaChildren addingaChildren = new View.AddingaChildren();
            this.Hide();
            addingaChildren.ShowDialog();
            this.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
