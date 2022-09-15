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
    public partial class Bakers : MetroFramework.Forms.MetroForm
    {
        public Bakers()
        {
            InitializeComponent();
        }

        private void пекариBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пекариBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_Information_System_Pizza2021DataSet);

        }

        private void Bakers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Пекари' table. You can move, or remove it, as needed.
            this.пекариTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Пекари);

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
            this.пекариBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_Information_System_Pizza2021DataSet);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}
