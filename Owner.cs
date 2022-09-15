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
    public partial class Owner : MetroFramework.Forms.MetroForm
    {
        public Owner()
        {
            InitializeComponent();
        }

        private void управителBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.управителBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_Information_System_Pizza2021DataSet);

        }

        private void Owner_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Доставки_Фактури' table. You can move, or remove it, as needed.
            this.доставки_ФактуриTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Доставки_Фактури);
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Управител' table. You can move, or remove it, as needed.
            this.управителTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Управител);

        }

        private void управителMetroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            this.Validate();
            this.управителBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_Information_System_Pizza2021DataSet);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (
            MessageBox.Show(this, "Сигурни ли сте ?", "Изход", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes) Close();
        }
    }
}
