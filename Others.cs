using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace ПИС_Проект_Пицария
{
    public partial class Others : MetroFramework.Forms.MetroForm
    {
        public Others()
        {
            InitializeComponent();
        }

        private void разходна_нормаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.разходна_нормаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_Information_System_Pizza2021DataSet);

        }

        private void Others_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Стоки_Разходна_норма' table. You can move, or remove it, as needed.
            //this.стоки_Разходна_нормаTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Стоки_Разходна_норма);
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Длъжности' table. You can move, or remove it, as needed.
            this.длъжностиTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Длъжности);
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Управител' table. You can move, or remove it, as needed.
            this.управителTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Управител);
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Пекари' table. You can move, or remove it, as needed.
            this.пекариTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Пекари);
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Разходна_норма' table. You can move, or remove it, as needed.
            this.разходна_нормаTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Разходна_норма);
            //CalculateTotal(длъжностиMetroGrid, textBox1, 0,1,2);
        }
        public void CalculateTotal(MetroGrid mgr, TextBox tTotal, int qtyInd, int
priceInd, int totalInd)
        {
            double sum = 0;
            double cPrice = 0;
            int cQty = 0;
            for (int i = 0; i < mgr.RowCount - 1; i++)
            {
                if (mgr[qtyInd, i].Value is DBNull) cQty = 0;
                else cQty = Convert.ToInt32(mgr[qtyInd, i].Value.ToString());
                if (mgr[priceInd, i].Value is DBNull) cPrice = 0;
                else cPrice = Convert.ToDouble(mgr[priceInd, i].Value.ToString());
                mgr[totalInd, i].Value = cQty * cPrice;
                sum += cQty * cPrice;
            }
            tTotal.Text = sum.ToString("0.00 лв.");
        }
        private void разходна_нормаBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void разходна_нормаMetroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пекариBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_Information_System_Pizza2021DataSet);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пекариBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_Information_System_Pizza2021DataSet);
        }

        private void управителMetroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пекариBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_Information_System_Pizza2021DataSet);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(this, "Сигурни ли сте ?", "Изход", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes) Close();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (
           MessageBox.Show(this, "Сигурни ли сте ?", "Изход", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
           == DialogResult.Yes) Close();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (
            MessageBox.Show(this, "Сигурни ли сте ?", "Изход", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes) Close();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (
            MessageBox.Show(this, "Сигурни ли сте ?", "Изход", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes) Close();
        }
    }
}
