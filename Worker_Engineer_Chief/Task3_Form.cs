using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worker_Engineer_Chief
{
    public partial class Task3_Form : Form
    {
        //Т.к. я не могу создавать объекты абстр.класса и интерфейса, мой списочек будет только из экземпляров
        //класса Шеф. Компания, состоящая только из руководителей, как иронично... :)
        List<IWorker> corporation = new List<IWorker>();
        int index = -1;
        public Task3_Form()
        {
            InitializeComponent();
        }
        
        private void addButton_Click(object sender, EventArgs e)
        {
            corporation.Add(new Chief(surnameTextBox.Text, nameTextBox.Text, patronymicTextBox.Text,
                (int)salaryNumericUpDown.Value, new List<IWorker>((int)subsNumericUpDown.Value)));
        }
        private void ClearFields()
        {
            surnameChangeTextBox.Text = "";
            nameChangeTextBox.Text = "";
            patronymicChangeTextBox.Text = "";
            salaryChangeNumericUpDown.Value = 0;
            subsChangeNumericUpDown.Value = 0;
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (corporation.Count == 0)
            {
                ClearFields();
                return;
            }
            index = index < corporation.Count - 1 ? index + 1 : 0;

            surnameChangeTextBox.Text = corporation[index].FullName[0];
            nameChangeTextBox.Text = corporation[index].FullName[1];
            patronymicChangeTextBox.Text = corporation[index].FullName[2];
            salaryChangeNumericUpDown.Value = corporation[index].Salary;
            if (corporation[index] is Chief)
            {
                Chief c = corporation[index] as Chief;
                subsChangeNumericUpDown.Value = c.subordinates.Count;
            }
            else subsChangeNumericUpDown.Value = 10;
        }

        private void changingsAcceptButton_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                ClearFields();
                return;
            }
            corporation[index].FullName[0] = surnameChangeTextBox.Text;
            corporation[index].FullName[1] = nameChangeTextBox.Text;
            corporation[index].FullName[2] = patronymicChangeTextBox.Text;
            corporation[index].Salary = (int)salaryChangeNumericUpDown.Value;
            if (corporation[index] is Chief)
            {
                Chief c = corporation[index] as Chief;
                c.subordinates.Clear();
                c.subordinates = new List<IWorker>((int)subsChangeNumericUpDown.Value);
            }
            else if (subsChangeNumericUpDown.Value != 0)
                subsChangeNumericUpDown.Value = 0;
        }

        private void fireButton_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                ClearFields();
                return;
            }
            corporation.RemoveAt(index);
            index--;
            searchButton_Click(sender, e);
        }
    }
}
