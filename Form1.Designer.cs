
namespace ПИС_Проект_Пицария
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroOrders = new MetroFramework.Controls.MetroTile();
            this.metroStocks = new MetroFramework.Controls.MetroTile();
            this.metroDelivery = new MetroFramework.Controls.MetroTile();
            this.metroOtherNomenclatures = new MetroFramework.Controls.MetroTile();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.разходнаНормаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пекариToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управителToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.длъжностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroRefrence_Orders = new MetroFramework.Controls.MetroTile();
            this.metroRefrence_Delivery = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroOrders
            // 
            this.metroOrders.ActiveControl = null;
            this.metroOrders.BackColor = System.Drawing.Color.Crimson;
            this.metroOrders.Location = new System.Drawing.Point(23, 63);
            this.metroOrders.Name = "metroOrders";
            this.metroOrders.Size = new System.Drawing.Size(331, 134);
            this.metroOrders.TabIndex = 0;
            this.metroOrders.Text = "Заявки";
            this.metroOrders.TileImage = ((System.Drawing.Image)(resources.GetObject("metroOrders.TileImage")));
            this.metroOrders.TileImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroOrders.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroOrders.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroOrders.UseCustomBackColor = true;
            this.metroOrders.UseSelectable = true;
            this.metroOrders.UseTileImage = true;
            this.metroOrders.Click += new System.EventHandler(this.metroOrders_Click);
            // 
            // metroStocks
            // 
            this.metroStocks.ActiveControl = null;
            this.metroStocks.BackColor = System.Drawing.Color.DarkCyan;
            this.metroStocks.Location = new System.Drawing.Point(181, 206);
            this.metroStocks.Name = "metroStocks";
            this.metroStocks.Size = new System.Drawing.Size(307, 124);
            this.metroStocks.TabIndex = 1;
            this.metroStocks.Text = "Стоки";
            this.metroStocks.TileImage = ((System.Drawing.Image)(resources.GetObject("metroStocks.TileImage")));
            this.metroStocks.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroStocks.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroStocks.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroStocks.UseCustomBackColor = true;
            this.metroStocks.UseSelectable = true;
            this.metroStocks.UseTileImage = true;
            this.metroStocks.Click += new System.EventHandler(this.metroStocks_Click);
            // 
            // metroDelivery
            // 
            this.metroDelivery.ActiveControl = null;
            this.metroDelivery.BackColor = System.Drawing.Color.DarkGreen;
            this.metroDelivery.Location = new System.Drawing.Point(360, 63);
            this.metroDelivery.Name = "metroDelivery";
            this.metroDelivery.Size = new System.Drawing.Size(335, 134);
            this.metroDelivery.TabIndex = 3;
            this.metroDelivery.Text = "Доставки & Фактури";
            this.metroDelivery.TileImage = ((System.Drawing.Image)(resources.GetObject("metroDelivery.TileImage")));
            this.metroDelivery.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroDelivery.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroDelivery.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroDelivery.UseCustomBackColor = true;
            this.metroDelivery.UseSelectable = true;
            this.metroDelivery.UseTileImage = true;
            this.metroDelivery.Click += new System.EventHandler(this.metroDelivery_Click);
            // 
            // metroOtherNomenclatures
            // 
            this.metroOtherNomenclatures.ActiveControl = null;
            this.metroOtherNomenclatures.BackColor = System.Drawing.Color.DarkOrange;
            this.metroOtherNomenclatures.ContextMenuStrip = this.metroContextMenu1;
            this.metroOtherNomenclatures.Location = new System.Drawing.Point(494, 206);
            this.metroOtherNomenclatures.Name = "metroOtherNomenclatures";
            this.metroOtherNomenclatures.Size = new System.Drawing.Size(201, 124);
            this.metroOtherNomenclatures.TabIndex = 4;
            this.metroOtherNomenclatures.Text = "Други Номенклатури";
            this.metroOtherNomenclatures.TileImage = ((System.Drawing.Image)(resources.GetObject("metroOtherNomenclatures.TileImage")));
            this.metroOtherNomenclatures.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroOtherNomenclatures.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroOtherNomenclatures.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroOtherNomenclatures.UseCustomBackColor = true;
            this.metroOtherNomenclatures.UseSelectable = true;
            this.metroOtherNomenclatures.UseTileImage = true;
            this.metroOtherNomenclatures.Click += new System.EventHandler(this.metroOtherNomenclatures_Click);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.разходнаНормаToolStripMenuItem,
            this.пекариToolStripMenuItem,
            this.управителToolStripMenuItem,
            this.длъжностиToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(193, 100);
            // 
            // разходнаНормаToolStripMenuItem
            // 
            this.разходнаНормаToolStripMenuItem.Name = "разходнаНормаToolStripMenuItem";
            this.разходнаНормаToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.разходнаНормаToolStripMenuItem.Text = "Разходна норма";
            // 
            // пекариToolStripMenuItem
            // 
            this.пекариToolStripMenuItem.Name = "пекариToolStripMenuItem";
            this.пекариToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.пекариToolStripMenuItem.Text = "Пекари";
            this.пекариToolStripMenuItem.Click += new System.EventHandler(this.пекариToolStripMenuItem_Click);
            // 
            // управителToolStripMenuItem
            // 
            this.управителToolStripMenuItem.Name = "управителToolStripMenuItem";
            this.управителToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.управителToolStripMenuItem.Text = "Управител";
            this.управителToolStripMenuItem.Click += new System.EventHandler(this.управителToolStripMenuItem_Click);
            // 
            // длъжностиToolStripMenuItem
            // 
            this.длъжностиToolStripMenuItem.Name = "длъжностиToolStripMenuItem";
            this.длъжностиToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.длъжностиToolStripMenuItem.Text = "Длъжности";
            this.длъжностиToolStripMenuItem.Click += new System.EventHandler(this.длъжностиToolStripMenuItem_Click);
            // 
            // metroRefrence_Orders
            // 
            this.metroRefrence_Orders.ActiveControl = null;
            this.metroRefrence_Orders.BackColor = System.Drawing.Color.Crimson;
            this.metroRefrence_Orders.Location = new System.Drawing.Point(360, 336);
            this.metroRefrence_Orders.Name = "metroRefrence_Orders";
            this.metroRefrence_Orders.Size = new System.Drawing.Size(335, 74);
            this.metroRefrence_Orders.TabIndex = 6;
            this.metroRefrence_Orders.Text = "Справки за заявки";
            this.metroRefrence_Orders.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroRefrence_Orders.TileImage = ((System.Drawing.Image)(resources.GetObject("metroRefrence_Orders.TileImage")));
            this.metroRefrence_Orders.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroRefrence_Orders.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroRefrence_Orders.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroRefrence_Orders.UseCustomBackColor = true;
            this.metroRefrence_Orders.UseSelectable = true;
            this.metroRefrence_Orders.UseTileImage = true;
            this.metroRefrence_Orders.Click += new System.EventHandler(this.metroRefrence_Orders_Click);
            // 
            // metroRefrence_Delivery
            // 
            this.metroRefrence_Delivery.ActiveControl = null;
            this.metroRefrence_Delivery.BackColor = System.Drawing.Color.DarkGreen;
            this.metroRefrence_Delivery.Location = new System.Drawing.Point(23, 336);
            this.metroRefrence_Delivery.Name = "metroRefrence_Delivery";
            this.metroRefrence_Delivery.Size = new System.Drawing.Size(331, 74);
            this.metroRefrence_Delivery.TabIndex = 7;
            this.metroRefrence_Delivery.Text = "Справки за доставки";
            this.metroRefrence_Delivery.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroRefrence_Delivery.TileImage = ((System.Drawing.Image)(resources.GetObject("metroRefrence_Delivery.TileImage")));
            this.metroRefrence_Delivery.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroRefrence_Delivery.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroRefrence_Delivery.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroRefrence_Delivery.UseCustomBackColor = true;
            this.metroRefrence_Delivery.UseSelectable = true;
            this.metroRefrence_Delivery.UseTileImage = true;
            this.metroRefrence_Delivery.Click += new System.EventHandler(this.metroRefrence_Delivery_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.DarkOrange;
            this.metroTile1.Location = new System.Drawing.Point(23, 206);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(152, 124);
            this.metroTile1.TabIndex = 8;
            this.metroTile1.Text = "Продукция";
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 445);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroRefrence_Delivery);
            this.Controls.Add(this.metroRefrence_Orders);
            this.Controls.Add(this.metroOtherNomenclatures);
            this.Controls.Add(this.metroDelivery);
            this.Controls.Add(this.metroStocks);
            this.Controls.Add(this.metroOrders);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Rage Italic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Пицария 2021 (главно меню)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroOrders;
        private MetroFramework.Controls.MetroTile metroStocks;
        private MetroFramework.Controls.MetroTile metroDelivery;
        private MetroFramework.Controls.MetroTile metroOtherNomenclatures;
        private MetroFramework.Controls.MetroTile metroRefrence_Orders;
        private MetroFramework.Controls.MetroTile metroRefrence_Delivery;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem разходнаНормаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пекариToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управителToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem длъжностиToolStripMenuItem;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}

