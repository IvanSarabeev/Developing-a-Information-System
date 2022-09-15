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
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            new Products().ShowDialog();
        }

        private void metroStocks_Click(object sender, EventArgs e)
        {
            new Stocks().ShowDialog();
        }

        private void пекариToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Bakers().ShowDialog();
        }

        private void metroOtherNomenclatures_Click(object sender, EventArgs e)
        {
            new Others().ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
   
        }

        private void metroDelivery_Click(object sender, EventArgs e)
        {
            new DeliveryFactures().ShowDialog();
        }

        private void управителToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Owner().ShowDialog();
        }

        private void длъжностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Positions().ShowDialog();
        }

        private void metroOrders_Click(object sender, EventArgs e)
        {
            new Orders().Show();
        }

        private void metroRefrence_Delivery_Click(object sender, EventArgs e)
        {
            new Delivery_Refrence().ShowDialog();
        }

        private void metroRefrence_Orders_Click(object sender, EventArgs e)
        {
            new Refrence_Orders().ShowDialog();
        }
    }
}
