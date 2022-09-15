
namespace ПИС_Проект_Пицария
{
    partial class Stocks
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
            System.Windows.Forms.Label код_стокаLabel;
            System.Windows.Forms.Label име_стокаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stocks));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.project_Information_System_Pizza2021DataSet = new ПИС_Проект_Пицария.Project_Information_System_Pizza2021DataSet();
            this.стокиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.стокиTableAdapter = new ПИС_Проект_Пицария.Project_Information_System_Pizza2021DataSetTableAdapters.СтокиTableAdapter();
            this.tableAdapterManager = new ПИС_Проект_Пицария.Project_Information_System_Pizza2021DataSetTableAdapters.TableAdapterManager();
            this.стокиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.стокиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.код_стокаTextBox = new System.Windows.Forms.TextBox();
            this.име_стокаTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.заявки_СтокиMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.заявки_СтокиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.заявки_СтокиTableAdapter = new ПИС_Проект_Пицария.Project_Information_System_Pizza2021DataSetTableAdapters.Заявки_СтокиTableAdapter();
            this.категорияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.категорияTableAdapter = new ПИС_Проект_Пицария.Project_Information_System_Pizza2021DataSetTableAdapters.КатегорияTableAdapter();
            код_стокаLabel = new System.Windows.Forms.Label();
            име_стокаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.project_Information_System_Pizza2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стокиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стокиBindingNavigator)).BeginInit();
            this.стокиBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заявки_СтокиMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявки_СтокиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорияBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // код_стокаLabel
            // 
            код_стокаLabel.AutoSize = true;
            код_стокаLabel.Location = new System.Drawing.Point(48, 116);
            код_стокаLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            код_стокаLabel.Name = "код_стокаLabel";
            код_стокаLabel.Size = new System.Drawing.Size(100, 25);
            код_стокаLabel.TabIndex = 1;
            код_стокаLabel.Text = "Код стока:";
            // 
            // име_стокаLabel
            // 
            име_стокаLabel.AutoSize = true;
            име_стокаLabel.Location = new System.Drawing.Point(40, 157);
            име_стокаLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            име_стокаLabel.Name = "име_стокаLabel";
            име_стокаLabel.Size = new System.Drawing.Size(105, 25);
            име_стокаLabel.TabIndex = 3;
            име_стокаLabel.Text = "Име стока:";
            // 
            // project_Information_System_Pizza2021DataSet
            // 
            this.project_Information_System_Pizza2021DataSet.DataSetName = "Project_Information_System_Pizza2021DataSet";
            this.project_Information_System_Pizza2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // стокиBindingSource
            // 
            this.стокиBindingSource.DataMember = "Стоки";
            this.стокиBindingSource.DataSource = this.project_Information_System_Pizza2021DataSet;
            // 
            // стокиTableAdapter
            // 
            this.стокиTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ПродукцияTableAdapter = null;
            this.tableAdapterManager.Разходна_нормаTableAdapter = null;
            this.tableAdapterManager.СтатусTableAdapter = null;
            this.tableAdapterManager.Стоки_Разходна_нормаTableAdapter = null;
            this.tableAdapterManager.СтокиTableAdapter = this.стокиTableAdapter;
            this.tableAdapterManager.УправителTableAdapter = null;
            // 
            // стокиBindingNavigator
            // 
            this.стокиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.стокиBindingNavigator.BindingSource = this.стокиBindingSource;
            this.стокиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.стокиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.стокиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.стокиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.стокиBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.стокиBindingNavigator.Location = new System.Drawing.Point(17, 60);
            this.стокиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.стокиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.стокиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.стокиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.стокиBindingNavigator.Name = "стокиBindingNavigator";
            this.стокиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.стокиBindingNavigator.Size = new System.Drawing.Size(548, 27);
            this.стокиBindingNavigator.TabIndex = 0;
            this.стокиBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(42, 27);
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
            // стокиBindingNavigatorSaveItem
            // 
            this.стокиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.стокиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("стокиBindingNavigatorSaveItem.Image")));
            this.стокиBindingNavigatorSaveItem.Name = "стокиBindingNavigatorSaveItem";
            this.стокиBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.стокиBindingNavigatorSaveItem.Text = "Save Data";
            this.стокиBindingNavigatorSaveItem.Click += new System.EventHandler(this.стокиBindingNavigatorSaveItem_Click);
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
            // код_стокаTextBox
            // 
            this.код_стокаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.стокиBindingSource, "Код_стока", true));
            this.код_стокаTextBox.Location = new System.Drawing.Point(170, 111);
            this.код_стокаTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.код_стокаTextBox.Name = "код_стокаTextBox";
            this.код_стокаTextBox.Size = new System.Drawing.Size(84, 31);
            this.код_стокаTextBox.TabIndex = 2;
            // 
            // име_стокаTextBox
            // 
            this.име_стокаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.стокиBindingSource, "Име_стока", true));
            this.име_стокаTextBox.Location = new System.Drawing.Point(170, 157);
            this.име_стокаTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.име_стокаTextBox.Name = "име_стокаTextBox";
            this.име_стокаTextBox.Size = new System.Drawing.Size(84, 31);
            this.име_стокаTextBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.заявки_СтокиMetroGrid);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.стокиBindingSource, "Име_стока", true));
            this.groupBox1.Location = new System.Drawing.Point(19, 208);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(522, 255);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // заявки_СтокиMetroGrid
            // 
            this.заявки_СтокиMetroGrid.AllowUserToResizeRows = false;
            this.заявки_СтокиMetroGrid.AutoGenerateColumns = false;
            this.заявки_СтокиMetroGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.заявки_СтокиMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.заявки_СтокиMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.заявки_СтокиMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.заявки_СтокиMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.заявки_СтокиMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.заявки_СтокиMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.заявки_СтокиMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.заявки_СтокиMetroGrid.DataSource = this.заявки_СтокиBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.заявки_СтокиMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.заявки_СтокиMetroGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.заявки_СтокиMetroGrid.EnableHeadersVisualStyles = false;
            this.заявки_СтокиMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.заявки_СтокиMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.заявки_СтокиMetroGrid.Location = new System.Drawing.Point(2, 27);
            this.заявки_СтокиMetroGrid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.заявки_СтокиMetroGrid.Name = "заявки_СтокиMetroGrid";
            this.заявки_СтокиMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.заявки_СтокиMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.заявки_СтокиMetroGrid.RowHeadersWidth = 51;
            this.заявки_СтокиMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.заявки_СтокиMetroGrid.RowTemplate.Height = 24;
            this.заявки_СтокиMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.заявки_СтокиMetroGrid.Size = new System.Drawing.Size(518, 225);
            this.заявки_СтокиMetroGrid.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_заявка";
            this.dataGridViewTextBoxColumn1.HeaderText = "№ на заявка";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Код_стока";
            this.dataGridViewTextBoxColumn2.DataSource = this.стокиBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Име_стока";
            this.dataGridViewTextBoxColumn2.HeaderText = "Име на стока";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "Код_стока";
            // 
            // заявки_СтокиBindingSource
            // 
            this.заявки_СтокиBindingSource.DataMember = "R_20";
            this.заявки_СтокиBindingSource.DataSource = this.стокиBindingSource;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.стокиBindingSource;
            this.listBox1.DisplayMember = "Име_стока";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(265, 98);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(276, 104);
            this.listBox1.TabIndex = 8;
            this.listBox1.ValueMember = "Име_стока";
            // 
            // заявки_СтокиTableAdapter
            // 
            this.заявки_СтокиTableAdapter.ClearBeforeFill = true;
            // 
            // категорияBindingSource
            // 
            this.категорияBindingSource.DataMember = "Категория";
            this.категорияBindingSource.DataSource = this.project_Information_System_Pizza2021DataSet;
            // 
            // категорияTableAdapter
            // 
            this.категорияTableAdapter.ClearBeforeFill = true;
            // 
            // Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 391);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(код_стокаLabel);
            this.Controls.Add(this.код_стокаTextBox);
            this.Controls.Add(име_стокаLabel);
            this.Controls.Add(this.име_стокаTextBox);
            this.Controls.Add(this.стокиBindingNavigator);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Stocks";
            this.Padding = new System.Windows.Forms.Padding(17, 60, 17, 17);
            this.Text = "Стоки";
            this.Load += new System.EventHandler(this.Stocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.project_Information_System_Pizza2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стокиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стокиBindingNavigator)).EndInit();
            this.стокиBindingNavigator.ResumeLayout(false);
            this.стокиBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.заявки_СтокиMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявки_СтокиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорияBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Project_Information_System_Pizza2021DataSet project_Information_System_Pizza2021DataSet;
        private System.Windows.Forms.BindingSource стокиBindingSource;
        private Project_Information_System_Pizza2021DataSetTableAdapters.СтокиTableAdapter стокиTableAdapter;
        private Project_Information_System_Pizza2021DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator стокиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton стокиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_стокаTextBox;
        private System.Windows.Forms.TextBox име_стокаTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource заявки_СтокиBindingSource;
        private Project_Information_System_Pizza2021DataSetTableAdapters.Заявки_СтокиTableAdapter заявки_СтокиTableAdapter;
        private MetroFramework.Controls.MetroGrid заявки_СтокиMetroGrid;
        private System.Windows.Forms.BindingSource категорияBindingSource;
        private Project_Information_System_Pizza2021DataSetTableAdapters.КатегорияTableAdapter категорияTableAdapter;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
    }
}