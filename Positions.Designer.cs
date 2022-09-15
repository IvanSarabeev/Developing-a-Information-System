
namespace ПИС_Проект_Пицария
{
    partial class Positions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Positions));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label еГНLabel;
            System.Windows.Forms.Label имеLabel;
            System.Windows.Forms.Label имейлLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label код_длъжностLabel;
            this.project_Information_System_Pizza2021DataSet = new ПИС_Проект_Пицария.Project_Information_System_Pizza2021DataSet();
            this.длъжностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.длъжностиTableAdapter = new ПИС_Проект_Пицария.Project_Information_System_Pizza2021DataSetTableAdapters.ДлъжностиTableAdapter();
            this.tableAdapterManager = new ПИС_Проект_Пицария.Project_Information_System_Pizza2021DataSetTableAdapters.TableAdapterManager();
            this.длъжностиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.длъжностиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.длъжностиMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пекариBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пекариTableAdapter = new ПИС_Проект_Пицария.Project_Information_System_Pizza2021DataSetTableAdapters.ПекариTableAdapter();
            this.управителBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.управителTableAdapter = new ПИС_Проект_Пицария.Project_Information_System_Pizza2021DataSetTableAdapters.УправителTableAdapter();
            this.еГНTextBox = new System.Windows.Forms.TextBox();
            this.имеTextBox = new System.Windows.Forms.TextBox();
            this.имейлTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            еГНLabel = new System.Windows.Forms.Label();
            имеLabel = new System.Windows.Forms.Label();
            имейлLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            код_длъжностLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.project_Information_System_Pizza2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.длъжностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.длъжностиBindingNavigator)).BeginInit();
            this.длъжностиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.длъжностиMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пекариBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.управителBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // project_Information_System_Pizza2021DataSet
            // 
            this.project_Information_System_Pizza2021DataSet.DataSetName = "Project_Information_System_Pizza2021DataSet";
            this.project_Information_System_Pizza2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // длъжностиBindingSource
            // 
            this.длъжностиBindingSource.DataMember = "Длъжности";
            this.длъжностиBindingSource.DataSource = this.project_Information_System_Pizza2021DataSet;
            // 
            // длъжностиTableAdapter
            // 
            this.длъжностиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ПИС_Проект_Пицария.Project_Information_System_Pizza2021DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДлъжностиTableAdapter = this.длъжностиTableAdapter;
            this.tableAdapterManager.Доставки_Фактури_СтокиTableAdapter = null;
            this.tableAdapterManager.Доставки_ФактуриTableAdapter = null;
            this.tableAdapterManager.ДоставчициTableAdapter = null;
            this.tableAdapterManager.Заявки_СтокиTableAdapter = null;
            this.tableAdapterManager.ЗаявкиTableAdapter = null;
            this.tableAdapterManager.КатегорияTableAdapter = null;
            this.tableAdapterManager.ПекариTableAdapter = this.пекариTableAdapter;
            this.tableAdapterManager.ПродукцияTableAdapter = null;
            this.tableAdapterManager.Разходна_нормаTableAdapter = null;
            this.tableAdapterManager.СтатусTableAdapter = null;
            this.tableAdapterManager.Стоки_Разходна_нормаTableAdapter = null;
            this.tableAdapterManager.СтокиTableAdapter = null;
            this.tableAdapterManager.УправителTableAdapter = this.управителTableAdapter;
            // 
            // длъжностиBindingNavigator
            // 
            this.длъжностиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.длъжностиBindingNavigator.BindingSource = this.длъжностиBindingSource;
            this.длъжностиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.длъжностиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.длъжностиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.длъжностиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.длъжностиBindingNavigatorSaveItem});
            this.длъжностиBindingNavigator.Location = new System.Drawing.Point(30, 109);
            this.длъжностиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.длъжностиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.длъжностиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.длъжностиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.длъжностиBindingNavigator.Name = "длъжностиBindingNavigator";
            this.длъжностиBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.длъжностиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.длъжностиBindingNavigator.Size = new System.Drawing.Size(873, 27);
            this.длъжностиBindingNavigator.TabIndex = 0;
            this.длъжностиBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // длъжностиBindingNavigatorSaveItem
            // 
            this.длъжностиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.длъжностиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("длъжностиBindingNavigatorSaveItem.Image")));
            this.длъжностиBindingNavigatorSaveItem.Name = "длъжностиBindingNavigatorSaveItem";
            this.длъжностиBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.длъжностиBindingNavigatorSaveItem.Text = "Save Data";
            this.длъжностиBindingNavigatorSaveItem.Click += new System.EventHandler(this.длъжностиBindingNavigatorSaveItem_Click);
            // 
            // длъжностиMetroGrid
            // 
            this.длъжностиMetroGrid.AllowUserToResizeRows = false;
            this.длъжностиMetroGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.длъжностиMetroGrid.AutoGenerateColumns = false;
            this.длъжностиMetroGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.длъжностиMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.длъжностиMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.длъжностиMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.длъжностиMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.длъжностиMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.длъжностиMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.длъжностиMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.длъжностиMetroGrid.DataSource = this.длъжностиBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.длъжностиMetroGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.длъжностиMetroGrid.EnableHeadersVisualStyles = false;
            this.длъжностиMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.длъжностиMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.длъжностиMetroGrid.Location = new System.Drawing.Point(30, 163);
            this.длъжностиMetroGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.длъжностиMetroGrid.Name = "длъжностиMetroGrid";
            this.длъжностиMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.длъжностиMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.длъжностиMetroGrid.RowHeadersWidth = 51;
            this.длъжностиMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.длъжностиMetroGrid.RowTemplate.Height = 24;
            this.длъжностиMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.длъжностиMetroGrid.Size = new System.Drawing.Size(873, 250);
            this.длъжностиMetroGrid.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_длъжност";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код_длъжност";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Заплата";
            this.dataGridViewTextBoxColumn3.HeaderText = "Заплата";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // пекариBindingSource
            // 
            this.пекариBindingSource.DataMember = "R_8";
            this.пекариBindingSource.DataSource = this.длъжностиBindingSource;
            // 
            // пекариTableAdapter
            // 
            this.пекариTableAdapter.ClearBeforeFill = true;
            // 
            // управителBindingSource
            // 
            this.управителBindingSource.DataMember = "R_25";
            this.управителBindingSource.DataSource = this.длъжностиBindingSource;
            // 
            // управителTableAdapter
            // 
            this.управителTableAdapter.ClearBeforeFill = true;
            // 
            // еГНLabel
            // 
            еГНLabel.AutoSize = true;
            еГНLabel.Location = new System.Drawing.Point(45, 423);
            еГНLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            еГНLabel.Name = "еГНLabel";
            еГНLabel.Size = new System.Drawing.Size(61, 30);
            еГНLabel.TabIndex = 2;
            еГНLabel.Text = "ЕГН:";
            // 
            // еГНTextBox
            // 
            this.еГНTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.управителBindingSource, "ЕГН", true));
            this.еГНTextBox.Location = new System.Drawing.Point(158, 423);
            this.еГНTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.еГНTextBox.Name = "еГНTextBox";
            this.еГНTextBox.Size = new System.Drawing.Size(148, 36);
            this.еГНTextBox.TabIndex = 3;
            // 
            // имеLabel
            // 
            имеLabel.AutoSize = true;
            имеLabel.Location = new System.Drawing.Point(43, 473);
            имеLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            имеLabel.Name = "имеLabel";
            имеLabel.Size = new System.Drawing.Size(63, 30);
            имеLabel.TabIndex = 4;
            имеLabel.Text = "Име:";
            // 
            // имеTextBox
            // 
            this.имеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.управителBindingSource, "Име", true));
            this.имеTextBox.Location = new System.Drawing.Point(158, 482);
            this.имеTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.имеTextBox.Name = "имеTextBox";
            this.имеTextBox.Size = new System.Drawing.Size(148, 36);
            this.имеTextBox.TabIndex = 5;
            // 
            // имейлLabel
            // 
            имейлLabel.AutoSize = true;
            имейлLabel.Location = new System.Drawing.Point(443, 473);
            имейлLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            имейлLabel.Name = "имейлLabel";
            имейлLabel.Size = new System.Drawing.Size(89, 30);
            имейлLabel.TabIndex = 6;
            имейлLabel.Text = "Имейл:";
            // 
            // имейлTextBox
            // 
            this.имейлTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.управителBindingSource, "Имейл", true));
            this.имейлTextBox.Location = new System.Drawing.Point(568, 470);
            this.имейлTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.имейлTextBox.Name = "имейлTextBox";
            this.имейлTextBox.Size = new System.Drawing.Size(148, 36);
            this.имейлTextBox.TabIndex = 7;
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(5, 550);
            телефонLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(101, 30);
            телефонLabel.TabIndex = 8;
            телефонLabel.Text = "Телефон:";
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.управителBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(158, 544);
            this.телефонTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(148, 36);
            this.телефонTextBox.TabIndex = 9;
            // 
            // код_длъжностLabel
            // 
            код_длъжностLabel.AutoSize = true;
            код_длъжностLabel.Location = new System.Drawing.Point(359, 423);
            код_длъжностLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            код_длъжностLabel.Name = "код_длъжностLabel";
            код_длъжностLabel.Size = new System.Drawing.Size(173, 30);
            код_длъжностLabel.TabIndex = 10;
            код_длъжностLabel.Text = "Код длъжност:";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.длъжностиBindingSource, "Код_длъжност", true));
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Location = new System.Drawing.Point(568, 423);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 30);
            this.metroComboBox1.TabIndex = 11;
            this.metroComboBox1.UseSelectable = true;
            // 
            // Positions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 647);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(еГНLabel);
            this.Controls.Add(this.еГНTextBox);
            this.Controls.Add(имеLabel);
            this.Controls.Add(this.имеTextBox);
            this.Controls.Add(имейлLabel);
            this.Controls.Add(this.имейлTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(код_длъжностLabel);
            this.Controls.Add(this.длъжностиMetroGrid);
            this.Controls.Add(this.длъжностиBindingNavigator);
            this.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Positions";
            this.Padding = new System.Windows.Forms.Padding(30, 109, 30, 36);
            this.Text = "Длъжности";
            this.Load += new System.EventHandler(this.Positions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.project_Information_System_Pizza2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.длъжностиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.длъжностиBindingNavigator)).EndInit();
            this.длъжностиBindingNavigator.ResumeLayout(false);
            this.длъжностиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.длъжностиMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пекариBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.управителBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Project_Information_System_Pizza2021DataSet project_Information_System_Pizza2021DataSet;
        private System.Windows.Forms.BindingSource длъжностиBindingSource;
        private Project_Information_System_Pizza2021DataSetTableAdapters.ДлъжностиTableAdapter длъжностиTableAdapter;
        private Project_Information_System_Pizza2021DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator длъжностиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton длъжностиBindingNavigatorSaveItem;
        private Project_Information_System_Pizza2021DataSetTableAdapters.ПекариTableAdapter пекариTableAdapter;
        private MetroFramework.Controls.MetroGrid длъжностиMetroGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource пекариBindingSource;
        private Project_Information_System_Pizza2021DataSetTableAdapters.УправителTableAdapter управителTableAdapter;
        private System.Windows.Forms.BindingSource управителBindingSource;
        private System.Windows.Forms.TextBox еГНTextBox;
        private System.Windows.Forms.TextBox имеTextBox;
        private System.Windows.Forms.TextBox имейлTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
    }
}