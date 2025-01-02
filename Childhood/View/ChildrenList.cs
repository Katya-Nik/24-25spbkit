using Childhood.Model;
using Childhood.View;
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
    public partial class ChildrenList : Form
    {
        public ChildrenList()
        {
            InitializeComponent();
            if (Helper.user != null && (Helper.user.UserRoleID == 5))
            {
                comboBoxGroup.Visible = false;
                Addingachild.Visible = false;
                labelFG.Visible = false;
            }
            if (Helper.user != null && (Helper.user.UserRoleID == 6) || (Helper.user.UserRoleID == 4)) 
            { 
                Addingachild.Visible = false;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowChildren()
        {
            List<Model.Child> children = Helper.DB.Child.ToList();
            List<Model.Groups> group = Helper.DB.Groups.ToList();
            List<Model.Educator> educator = Helper.DB.Educator.ToList();
            //Поиск по ФИО
            if (textBoxSearchChild.Text != "")
            {
                string search = textBoxSearchChild.Text;
                children = children.Where(x => x.ChildLastname.Contains(search)).ToList();
            }
            //Поиск по имени
            if (textBoxSearchNameChild.Text != "")
            {
                string search = textBoxSearchNameChild.Text;
                children = children.Where(x => x.ChildName.Contains(search)).ToList();
            }
            //Фильтр по группе
            int selectedGroupId = (int)comboBoxGroup.SelectedValue;
            if (selectedGroupId > 0 && Helper.user.UserRoleID != 5 && Helper.user.UserRoleID != 6)
            {
                    children = children.Where(x => x.ChildGroupID == selectedGroupId).ToList();
            }
            int uid = Convert.ToInt32(Helper.user.UserID);
            if (Helper.user.UserRoleID == 5)
            {
                int grnum = educator.Where(gn => gn.Employee.EmployeeUserID == uid).Select(gn => gn.Groups.GroupNumberGroup).FirstOrDefault();
                children = children.Where(x => x.Groups.GroupNumberGroup == grnum).ToList();
            }
            if (Helper.user.UserRoleID == 6)
            {
                children = children.Where(c => c.Parents.ParentUserID == uid).ToList();
            }

            labelCountChild.Text = "Количество детей в детском саду: " + children.Count.ToString();
            dataGridViewChildren.Rows.Clear();
            int numberRow = 0;

            foreach (Model.Child Child in children)
            {
                dataGridViewChildren.Rows.Add();

                dataGridViewChildren.Rows[numberRow].Cells[0].Value = Child.ChildID.ToString();
                dataGridViewChildren.Rows[numberRow].Cells[1].Value = Child.ChildLastname.ToString();
                dataGridViewChildren.Rows[numberRow].Cells[2].Value = Child.ChildName.ToString();
                dataGridViewChildren.Rows[numberRow].Cells[3].Value = Child.ChildFathername.ToString();
                dataGridViewChildren.Rows[numberRow].Cells[4].Value = Child.ChildAllergies.ToString();
                dataGridViewChildren.Rows[numberRow].Cells[5].Value = Child.Groups.GroupNumberGroup.ToString();
                numberRow++;
            }
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Children_Load(object sender, EventArgs e)
        {
            List<Model.Groups> groups = Helper.DB.Groups.ToList();

            Model.Groups group = new Model.Groups();
            group.GroupTypeGroup = "Любая группа";
            group.GroupID = 0;
            groups.Insert(0, group);
            comboBoxGroup.DataSource = groups;
            comboBoxGroup.DisplayMember = "GroupTypeGroup";
            comboBoxGroup.ValueMember = "GroupID";

            if (comboBoxGroup.Items.Count > 0)
            {
                comboBoxGroup.SelectedIndex = 0; 
            }

            comboBoxGroup.SelectedIndexChanged += comboBoxGroup_SelectedIndexChanged;

            ShowChildren();
        }

        private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowChildren();
        }

        private void tableLayoutPanel6_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBoxSearchCild_TextChanged(object sender, EventArgs e)
        {
            ShowChildren();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearchNameChild_TextChanged(object sender, EventArgs e)
        {
            ShowChildren();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewChildren.SelectedRows.Count > 0)
            {
                //Получить Id этой квартиры
                //Обратится к левому столбцу (индекс 0) выделенной строки
                string temp = dataGridViewChildren.CurrentRow.Cells[0].Value.ToString();
                int idChild = Convert.ToInt32(temp);
                //Открыть окно просмотра одной квартиры с передачей id выбранной квартиры
                //В окне View.Moreaboutthechild надо будет создать конструктор с параметром Child
                View.Moreaboutthechild ChildInfo = new View.Moreaboutthechild(idChild);
                this.Hide();
                ChildInfo.ShowDialog();
                this.Show();
            }
        }

        private void Addingachild_Click(object sender, EventArgs e)
        {
            View.AddingaParent addingaParent = new View.AddingaParent();
            this.Hide();
            addingaParent.ShowDialog();
            this.Show();
        }
    }
}
