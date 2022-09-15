using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПИС_Проект_Пицария
{
    public partial class Delivery_Refrence : MetroFramework.Forms.MetroForm
    {
        public Delivery_Refrence()
        {
            InitializeComponent();
        }

        private void доставки_ФактуриBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.доставки_ФактуриBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_Information_System_Pizza2021DataSet);

        }

        private void Delivery_Refrence_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Статус' table. You can move, or remove it, as needed.
            this.статусTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Статус);
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Доставчици' table. You can move, or remove it, as needed.
            this.доставчициTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Доставчици);
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Доставки_Фактури_Стоки' table. You can move, or remove it, as needed.
            this.доставки_Фактури_СтокиTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Доставки_Фактури_Стоки);
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Доставки_Фактури' table. You can move, or remove it, as needed.
            this.доставки_ФактуриTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Доставки_Фактури);

        }
    }
}
