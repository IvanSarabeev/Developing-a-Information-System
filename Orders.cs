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
    public partial class Orders : MetroFramework.Forms.MetroForm
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void заявкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заявкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_Information_System_Pizza2021DataSet);

        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Стоки' table. You can move, or remove it, as needed.
            this.стокиTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Стоки);
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Доставчици' table. You can move, or remove it, as needed.
            this.доставчициTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Доставчици);
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Заявки_Стоки' table. You can move, or remove it, as needed.
            this.заявки_СтокиTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Заявки_Стоки);
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Заявки' table. You can move, or remove it, as needed.
            this.заявкиTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Заявки);
            //CalculateTotal(заявкиMetroGrid, txtTotal, 4, 3);
        }
        public void CalculateTotal(MetroGrid mgr,TextBox tTotal, int qtyInd, int
priceInd, int totalInd)
        {
            double sum = 0;
            double cPrice = 0;
            int cQty = 1;
            for (int i = 0; i < mgr.RowCount - 1; i++)
            {
                if (mgr[qtyInd, i].Value is DBNull) cQty = 1;
                else cQty = Convert.ToInt32(mgr[qtyInd, i].Value.ToString());
                if (mgr[priceInd, i].Value is DBNull) cPrice = 0;
                else cPrice = Convert.ToDouble(mgr[priceInd, i].Value.ToString());
                mgr[totalInd, i].Value = cQty * cPrice;
                sum += cQty * cPrice;
            }
            tTotal.Text = sum.ToString("0.00 лв.");
        }
            private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        }
    }
