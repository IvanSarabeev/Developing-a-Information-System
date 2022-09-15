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
    public partial class Stocks : MetroFramework.Forms.MetroForm
    {
        public Stocks()
        {
            InitializeComponent();
        }

        private void стокиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.стокиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_Information_System_Pizza2021DataSet);

        }

        private void Stocks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Категория' table. You can move, or remove it, as needed.
            this.категорияTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Категория);
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Заявки_Стоки' table. You can move, or remove it, as needed.
            this.заявки_СтокиTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Заявки_Стоки);
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Стоки' table. You can move, or remove it, as needed.
            this.стокиTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Стоки);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (
           MessageBox.Show(this, "Сигурни ли сте ?", "Изход", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
           == DialogResult.Yes) Close();
        }
    }
}
