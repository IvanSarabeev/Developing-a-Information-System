
namespace ПИС_Проект_Пицария
{
    partial class Products
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
            System.Windows.Forms.Label код_пекариLabel;
            System.Windows.Forms.Label код_продукцияLabel;
            System.Windows.Forms.Label име_продукцияLabel;
            System.Windows.Forms.Label количествоLabel;
            System.Windows.Forms.Label код_разходна_нормаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.project_Information_System_Pizza2021DataSet = new ПИС_Проект_Пицария.Project_Information_System_Pizza2021DataSet();
            this.продукцияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продукцияTableAdapter = new ПИС_Проект_Пицария.Project_Information_System_Pizza2021DataSetTableAdapters.ПродукцияTableAdapter();
            this.tableAdapterManager = new ПИС_Проект_Пицария.Project_Information_System_Pizza2021DataSetTableAdapters.TableAdapterManager();
            this.продукцияBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.продукцияBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.код_продукцияTextBox = new System.Windows.Forms.TextBox();
            this.име_продукцияTextBox = new System.Windows.Forms.TextBox();
            this.код_разходна_нормаTextBox = new System.Windows.Forms.TextBox();
            this.количествоTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.пекариBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пекариTableAdapter = new ПИС_Проект_Пицария.Project_Information_System_Pizza2021DataSetTableAdapters.ПекариTableAdapter();
            код_пекариLabel = new System.Windows.Forms.Label();
            код_продукцияLabel = new System.Windows.Forms.Label();
            име_продукцияLabel = new System.Windows.Forms.Label();
            количествоLabel = new System.Windows.Forms.Label();
            код_разходна_нормаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.project_Information_System_Pizza2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продукцияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продукцияBindingNavigator)).BeginInit();
            this.продукцияBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пекариBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // код_пекариLabel
            // 
            код_пекариLabel.AutoSize = true;
            код_пекариLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_пекариLabel.Location = new System.Drawing.Point(72, 189);
            код_пекариLabel.Name = "код_пекариLabel";
            код_пекариLabel.Size = new System.Drawing.Size(135, 25);
            код_пекариLabel.TabIndex = 1;
            код_пекариLabel.Text = "Име на пекар:";
            // 
            // код_продукцияLabel
            // 
            код_продукцияLabel.AutoSize = true;
            код_продукцияLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_продукцияLabel.Location = new System.Drawing.Point(59, 237);
            код_продукцияLabel.Name = "код_продукцияLabel";
            код_продукцияLabel.Size = new System.Drawing.Size(146, 25);
            код_продукцияLabel.TabIndex = 3;
            код_продукцияLabel.Text = "Код продукция:";
            // 
            // име_продукцияLabel
            // 
            име_продукцияLabel.AutoSize = true;
            име_продукцияLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            име_продукцияLabel.Location = new System.Drawing.Point(56, 374);
            име_продукцияLabel.Name = "име_продукцияLabel";
            име_продукцияLabel.Size = new System.Drawing.Size(151, 25);
            име_продукцияLabel.TabIndex = 5;
            име_продукцияLabel.Text = "Име продукция:";
            име_продукцияLabel.Click += new System.EventHandler(this.име_продукцияLabel_Click);
            // 
            // количествоLabel
            // 
            количествоLabel.AutoSize = true;
            количествоLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            количествоLabel.Location = new System.Drawing.Point(87, 330);
            количествоLabel.Name = "количествоLabel";
            количествоLabel.Size = new System.Drawing.Size(118, 25);
            количествоLabel.TabIndex = 7;
            количествоLabel.Text = "Количество:";
            // 
            // код_разходна_нормаLabel
            // 
            код_разходна_нормаLabel.AutoSize = true;
            код_разходна_нормаLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_разходна_нормаLabel.Location = new System.Drawing.Point(13, 285);
            код_разходна_нормаLabel.Name = "код_разходна_нормаLabel";
            код_разходна_нормаLabel.Size = new System.Drawing.Size(194, 25);
            код_разходна_нормаLabel.TabIndex = 9;
            код_разходна_нормаLabel.Text = "Код разходна норма:";
            // 
            // project_Information_System_Pizza2021DataSet
            // 
            this.project_Information_System_Pizza2021DataSet.DataSetName = "Project_Information_System_Pizza2021DataSet";
            this.project_Information_System_Pizza2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // продукцияBindingSource
            // 
            this.продукцияBindingSource.DataMember = "Продукция";
            this.продукцияBindingSource.DataSource = this.project_Information_System_Pizza2021DataSet;
            // 
            // продукцияTableAdapter
            // 
            this.продукцияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ПИС_Проект_Пицария.Project_Information_System_Pizza2021DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДлъжностиTableAdapter = null;
            this.tableAdapterManager.Доставки_Фактури_СтокиTableAdapter = null;
            this.tableAdapterManager.Доставки_ФактуриTableAdapter = null;
            this.tableAdapterManager.ДоставчициTableAdapter = null;
            this.tableAdapterManager.Заявки_СтокиTableAdapter = null;
            this.tableAdapterManager.ЗаявкиTableAdapter = null;
            this.tableAdapterManager.КатегорияTableAdapter = null;
            this.tableAdapterManager.ПекариTableAdapter = null;
            this.tableAdapterManager.ПродукцияTableAdapter = this.продукцияTableAdapter;
            this.tableAdapterManager.Разходна_нормаTableAdapter = null;
            this.tableAdapterManager.СтатусTableAdapter = null;
            this.tableAdapterManager.Стоки_Разходна_нормаTableAdapter = null;
            this.tableAdapterManager.СтокиTableAdapter = null;
            this.tableAdapterManager.УправителTableAdapter = null;
            // 
            // продукцияBindingNavigator
            // 
            this.продукцияBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.продукцияBindingNavigator.BindingSource = this.продукцияBindingSource;
            this.продукцияBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.продукцияBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.продукцияBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.продукцияBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.продукцияBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.продукцияBindingNavigator.Location = new System.Drawing.Point(30, 116);
            this.продукцияBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.продукцияBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.продукцияBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.продукцияBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.продукцияBindingNavigator.Name = "продукцияBindingNavigator";
            this.продукцияBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.продукцияBindingNavigator.Size = new System.Drawing.Size(569, 27);
            this.продукцияBindingNavigator.TabIndex = 0;
            this.продукцияBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // продукцияBindingNavigatorSaveItem
            // 
            this.продукцияBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.продукцияBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("продукцияBindingNavigatorSaveItem.Image")));
            this.продукцияBindingNavigatorSaveItem.Name = "продукцияBindingNavigatorSaveItem";
            this.продукцияBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.продукцияBindingNavigatorSaveItem.Text = "Save Data";
            this.продукцияBindingNavigatorSaveItem.Click += new System.EventHandler(this.продукцияBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // код_продукцияTextBox
            // 
            this.код_продукцияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.продукцияBindingSource, "Код_продукция", true));
            this.код_продукцияTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_продукцияTextBox.Location = new System.Drawing.Point(249, 237);
            this.код_продукцияTextBox.Name = "код_продукцияTextBox";
            this.код_продукцияTextBox.Size = new System.Drawing.Size(71, 31);
            this.код_продукцияTextBox.TabIndex = 4;
            // 
            // име_продукцияTextBox
            // 
            this.име_продукцияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.продукцияBindingSource, "Име_продукция", true));
            this.име_продукцияTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.име_продукцияTextBox.Location = new System.Drawing.Point(249, 374);
            this.име_продукцияTextBox.Name = "име_продукцияTextBox";
            this.име_продукцияTextBox.Size = new System.Drawing.Size(217, 31);
            this.име_продукцияTextBox.TabIndex = 6;
            // 
            // код_разходна_нормаTextBox
            // 
            this.код_разходна_нормаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.продукцияBindingSource, "Код_разходна_норма", true));
            this.код_разходна_нормаTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_разходна_нормаTextBox.Location = new System.Drawing.Point(249, 282);
            this.код_разходна_нормаTextBox.Name = "код_разходна_нормаTextBox";
            this.код_разходна_нормаTextBox.Size = new System.Drawing.Size(71, 31);
            this.код_разходна_нормаTextBox.TabIndex = 10;
            // 
            // количествоTextBox
            // 
            this.количествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.продукцияBindingSource, "Количество", true));
            this.количествоTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.количествоTextBox.Location = new System.Drawing.Point(249, 327);
            this.количествоTextBox.Name = "количествоTextBox";
            this.количествоTextBox.Size = new System.Drawing.Size(71, 31);
            this.количествоTextBox.TabIndex = 8;
            this.количествоTextBox.TextChanged += new System.EventHandler(this.количествоTextBox_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.продукцияBindingSource, "Код_пекари", true));
            this.comboBox1.DataSource = this.пекариBindingSource;
            this.comboBox1.DisplayMember = "Име_фамилия";
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(249, 186);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 33);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "Код_пекари";
            // 
            // пекариBindingSource
            // 
            this.пекариBindingSource.DataMember = "Пекари";
            this.пекариBindingSource.DataSource = this.project_Information_System_Pizza2021DataSet;
            // 
            // пекариTableAdapter
            // 
            this.пекариTableAdapter.ClearBeforeFill = true;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 501);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(код_пекариLabel);
            this.Controls.Add(код_продукцияLabel);
            this.Controls.Add(this.код_продукцияTextBox);
            this.Controls.Add(име_продукцияLabel);
            this.Controls.Add(this.име_продукцияTextBox);
            this.Controls.Add(количествоLabel);
            this.Controls.Add(this.количествоTextBox);
            this.Controls.Add(код_разходна_нормаLabel);
            this.Controls.Add(this.код_разходна_нормаTextBox);
            this.Controls.Add(this.продукцияBindingNavigator);
            this.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Products";
            this.Padding = new System.Windows.Forms.Padding(30, 116, 30, 39);
            this.Text = "Продукция";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.project_Information_System_Pizza2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продукцияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продукцияBindingNavigator)).EndInit();
            this.продукцияBindingNavigator.ResumeLayout(false);
            this.продукцияBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пекариBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Project_Information_System_Pizza2021DataSet project_Information_System_Pizza2021DataSet;
        private System.Windows.Forms.BindingSource продукцияBindingSource;
        private Project_Information_System_Pizza2021DataSetTableAdapters.ПродукцияTableAdapter продукцияTableAdapter;
        private Project_Information_System_Pizza2021DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator продукцияBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton продукцияBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_продукцияTextBox;
        private System.Windows.Forms.TextBox име_продукцияTextBox;
        private System.Windows.Forms.TextBox код_разходна_нормаTextBox;
        private System.Windows.Forms.TextBox количествоTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource пекариBindingSource;
        private Project_Information_System_Pizza2021DataSetTableAdapters.ПекариTableAdapter пекариTableAdapter;
    }
}