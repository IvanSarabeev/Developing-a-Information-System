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
    public partial class Products : MetroFramework.Forms.MetroForm
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Пекари' table. You can move, or remove it, as needed.
            this.пекариTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Пекари);
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Продукция' table. You can move, or remove it, as needed.
            this.продукцияTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Продукция);

        }

        private void продукцияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.продукцияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_Information_System_Pizza2021DataSet);

        }

        private void количествоTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void име_продукцияLabel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (
           MessageBox.Show(this, "Сигурни ли сте ?", "Изход", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
           == DialogResult.Yes) Close();
        }
    }
}
