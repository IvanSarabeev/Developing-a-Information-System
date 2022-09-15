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
    public partial class DeliveryFactures : MetroFramework.Forms.MetroForm
    {
        public DeliveryFactures()
        {
            InitializeComponent();
        }

        private void доставки_ФактуриBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.доставки_ФактуриBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_Information_System_Pizza2021DataSet);

        }

        private void Delivery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Доставчици' table. You can move, or remove it, as needed.
            this.доставчициTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Доставчици);
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Статус' table. You can move, or remove it, as needed.
            this.статусTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Статус);
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Длъжности' table. You can move, or remove it, as needed.
            this.длъжностиTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Длъжности);
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Доставки_Фактури_Стоки' table. You can move, or remove it, as needed.
            this.доставки_Фактури_СтокиTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Доставки_Фактури_Стоки);
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Доставки_Фактури' table. You can move, or remove it, as needed.
            this.доставки_ФактуриTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Доставки_Фактури);

        }

        private void датаLabel_Click(object sender, EventArgs e)
        {

        }

        private void стойностLabel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (
           MessageBox.Show(this, "Сигурни ли сте ?", "Изход", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
           == DialogResult.Yes) Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.доставки_ФактуриBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_Information_System_Pizza2021DataSet);
        }

        private void доставки_Фактури_СтокиMetroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void стойностTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void код_доставчикLabel_Click(object sender, EventArgs e)
        {

        }

        private void код_доставчикTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void код_статусLabel_Click(object sender, EventArgs e)
        {

        }

        private void код_статусTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void еГНLabel_Click(object sender, EventArgs e)
        {

        }

        private void еГНTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.доставки_ФактуриBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_Information_System_Pizza2021DataSet);
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            if (
            MessageBox.Show(this, "Сигурни ли сте ?", "Изход", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes) Close();
        }

        private void доставки_ФактуриMetroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
