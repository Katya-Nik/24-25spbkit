using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Childhood.View
{
    public partial class AddingaChildren : Form
    {
        //Путь к папкам с картинками относительно exe-файла проекта
        string pathPhotoChildrens = Environment.CurrentDirectory + @"\PhotoChildrens\";
        //Строки с названиями файлов из диалогов
        string nameFilePhotoChildrens = null;

        public AddingaChildren()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddingaChildren_Load(object sender, EventArgs e)
        {
            //Получить список родителей из БД
            List<Model.Parents> parents = Helper.DB.Parents.ToList();
            //Загрузить список в элемент ComboBox
            comboBoxPerentChild.DataSource = parents;
            //Настроить список родителей
            comboBoxPerentChild.DisplayMember = "ParentLastname" + " " + "ParentName" + " " + "ParentFathername";
            comboBoxPerentChild.ValueMember = "ParentID";
            comboBoxPerentChild.SelectedIndex = 0;
            //Получить список владельцев из БД
            List<Model.Groups> groups = Helper.DB.Groups.ToList();
            //Загрузить список в элемент ComboBox
            comboBoxGroupChild.DataSource = groups;
            //Настроить список владельцев
            comboBoxGroupChild.DisplayMember = "GroupTypeGroup" + " (" + "GroupNumberGroup" + ")";
            comboBoxGroupChild.ValueMember = "GroupID";
            comboBoxGroupChild.SelectedIndex = 0;
            //Загрузка Заглушек для фото - пока пустые
            pictureBoxPhChild.Load(pathPhotoChildrens + "Заглушка.png");
        }

        private void buttonAddingPhotoChild_Click(object sender, EventArgs e)
        {
            //Открыть диалог выбора файла с картинкой
            if (this.openFileDialogPhChild.ShowDialog() == DialogResult.OK)
            {
                //Выбранный файл с картинкой в диалоге
                nameFilePhotoChildrens = this.openFileDialogPhChild.FileName;
                //Загрузка файла с картинкой в PictureBox
                pictureBoxPhChild.Load(nameFilePhotoChildrens);
            }
        }

        private void buttonAddingChild_Click(object sender, EventArgs e)
        {
            String error = "";   //Строка с возможными ошибками

            //1. Создали пустой объект- квартиры
            Model.Child child = new Model.Child();

            //2. Заполняем все поля созданного объекта из элементов интерфейса
            //ID родителя из списка родителей
            child.ChildParentID = (int)comboBoxPerentChild.SelectedValue;
            //ID группы из списка групп
            child.ChildGroupID = (int)comboBoxGroupChild.SelectedValue;

            //Проверка фамилии на пустое значение
            if (this.textBoxLastnameChild.Text == "")
            {   //Накапливаем фамилии совершенных ошибок
                error += "Вы не ввели фамилию" + Environment.NewLine;
            }
            else
            {   //Заполняем поле фамилии объекта
                child.ChildLastname = this.textBoxLastnameChild.Text;
            }
            //Проверка имени на пустое значение
            if (this.textBoxNameChild.Text == "")
            {   //Накапливаем строку совершенных ошибок
                error += "Вы не ввели имя" + Environment.NewLine;
            }
            else
            {   //Заполняем поле имени объекта
                child.ChildName = this.textBoxNameChild.Text;
            }
            //Проверка отчества на пустое значение
            if (this.textBoxFathChild.Text == "")
            {   //Накапливаем строку совершенных ошибок
                error += "Вы не ввели отчество" + Environment.NewLine;
            }
            else
            {   //Заполняем поле отчества объекта
                child.ChildFathername = this.textBoxFathChild.Text;
            }
            //Проверка города проживания на пустое значение
            if (this.textBoxCityofResChild.Text == "")
            {   //Накапливаем строку совершенных ошибок
                error += "Вы не ввели город проживания" + Environment.NewLine;
            }
            else
            {   //Заполняем поле города проживания объекта
                child.ChildCityofResidence = this.textBoxCityofResChild.Text;
            }
            //Проверка полиса на пустое значение
            if (this.maskedTextBoxPolMedStraxChild.Text == "")
            {   //Накапливаем строку совершенных ошибок
                error += "Вы не ввели полис" + Environment.NewLine;
            }
            else
            {   //Заполняем поле полиса объекта
                child.ChildHealthInsurancePolicy = this.maskedTextBoxPolMedStraxChild.Text;
            }
            //Проверка аллергии на пустое значение
            if (this.textBoxAllergiChild.Text == "")
            {   //Заполняем поле аллергии объекта
                child.ChildAllergies = "Нет";
            }
            else
            {   //Заполняем поле аллергии объекта
                child.ChildAllergies = this.textBoxAllergiChild.Text;
            }

            //Проверка, что совершились ошибки при заполнении
            if (error != "")
            {
                //Выводим весь список накопленных ошибок
                MessageBox.Show(error);
                return;
            }
            else        //Ошибок нет
            {
                //3. Помещаем заполненный объект в виртуальную таблицу
                Helper.DB.Child.Add(child);

                //4. Сохраняем изменения в физической БД
                try //Контроль совершаемых действий
                {
                    Helper.DB.SaveChanges();
                    MessageBox.Show("Ребенок добавлен в базу данных");
                    //Найти номер добавленной квартиры для фото
                    int idMax = Helper.DB.Child.Max(c => c.ChildID);
                    //Имя файла фото документа
                    string nameFilePhotoDocumentDist = pathPhotoChildrens + idMax + ".jpg";
                    //Перенос файла с картинкой документа в папку с картинками документов
                    File.Copy(nameFilePhotoChildrens, nameFilePhotoDocumentDist);

                    ChildrenList childrenList = new ChildrenList();
                    this.Hide();
                    childrenList.ShowDialog();
                    this.Show();
                }
                catch
                {
                    MessageBox.Show("При добавлении ребенка возникли проблемы");
                }
            }
        }
    }
}
