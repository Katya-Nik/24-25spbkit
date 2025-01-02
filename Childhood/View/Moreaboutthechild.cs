using Childhood.Model;
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
    using System.IO;
    using System.Xml.Linq;

    public partial class Moreaboutthechild : Form
    {
        Model.Child child;
        //Путь к папкам с картинками относительно exe-файла проекта
        string pathPhotoChildrens = Environment.CurrentDirectory + @"\PhotoChildrens\";

        public Moreaboutthechild()
        {
            InitializeComponent();
        }

        public Moreaboutthechild(int idChild)
        {
            InitializeComponent();
            //По idChild получить полную информацию о ребенке из БД 
            child = Helper.DB.Child.Where(f => f.ChildID == idChild).FirstOrDefault();
        }


        private void Moreaboutthechild_Load(object sender, EventArgs e)
        {
            //Информация о ребенке
            tbFIOC.Text = child.ChildLastname.ToString() + " " + child.ChildName.ToString() + " " + child.ChildFathername.ToString();
            tbMR.Text = child.ChildCityofResidence.ToString();
            tbPMS.Text = child.ChildHealthInsurancePolicy.ToString();
            tbALERG.Text = child.ChildAllergies.ToString();

            //Информация о родителе
            tbFIOP.Text = child.Parents.ParentLastname.ToString() + " " + child.Parents.ParentName.ToString() + " " + child.Parents.ParentFathername.ToString();
            tbPHONE.Text = child.Parents.ParentTelephoneNumber.ToString();
            tbEMAIL.Text = child.Parents.ParentEmaile.ToString();

            //Информация о группе
            tbNUMGR.Text = child.Groups.GroupNumberGroup.ToString();
            tbTUPEGR.Text = child.Groups.GroupTypeGroup.ToString();
            tbGroupName.Text = child.Groups.GroupNameGroup.ToString();

            int idGroup = child.Groups.GroupID;

            List<Model.Educator> educators = Helper.DB.Educator.Where(ed => ed.Groups.GroupID == idGroup).ToList();
            List<string> listName = new List<string>();

            if (educators.Any()) // Проверка на наличие записей
            {
                var item = educators.FirstOrDefault(); // Получаем первую запись
                var employee = Helper.DB.Employee.FirstOrDefault(em => em.EmployeeID == item.EducatorEmployeeID);

                if (employee != null) // Проверка на наличие сотрудника
                {
                    string lastName = employee.EmployeeLastname;
                    string name = employee.EmployeeName;
                    listName.Add(lastName + " " + name);
                }

                // Присваиваем значение текстовому полю, если есть имя
                if (listName.Count > 0)
                {
                    tbVOSONE.Text = listName[0];
                }
                else
                {
                    tbVOSONE.Text = "Нет записей";
                }
            }
            else
            {
                // Обработка случая, когда нет записей
                tbVOSONE.Text = "Нет записей";
            }

            string filePhotoChildrens = pathPhotoChildrens + child.ChildID + ".jpg";
            if (!File.Exists(filePhotoChildrens))
            {
                filePhotoChildrens = pathPhotoChildrens + "Заглушка.png";
            }
            pbChild.Load(filePhotoChildrens);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
