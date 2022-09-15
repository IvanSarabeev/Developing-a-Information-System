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
    public partial class Positions : MetroFramework.Forms.MetroForm
    {
        public Positions()
        {
            InitializeComponent();
        }

        private void длъжностиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.длъжностиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_Information_System_Pizza2021DataSet);

        }

        private void Positions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Управител' table. You can move, or remove it, as needed.
            this.управителTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Управител);
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Пекари' table. You can move, or remove it, as needed.
            this.пекариTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Пекари);
            // TODO: This line of code loads data into the 'project_Information_System_Pizza2021DataSet.Длъжности' table. You can move, or remove it, as needed.
            this.длъжностиTableAdapter.Fill(this.project_Information_System_Pizza2021DataSet.Длъжности);

        }

        private void код_длъжностLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
