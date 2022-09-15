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
    public partial class Refrence_Orders : MetroFramework.Forms.MetroForm
    {
        public Refrence_Orders()
        {
            InitializeComponent();
        }

        private void заявкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заявкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_Information_System_Pizza2021DataSet);

        }

        private void Refrence_Orders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Доставчици' table. You can move, or remove it, as needed.
            this.доставчициTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Доставчици);
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Заявки' table. You can move, or remove it, as needed.
            this.заявкиTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Заявки);

        }

        private void доставчициMetroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void заявкиMetroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
