namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mydbDataSet = new WindowsFormsApp2.mydbDataSet();
            this.mydbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mydbDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.applicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicationTableAdapter = new WindowsFormsApp2.mydbDataSetTableAdapters.applicationTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.mydbDataSetTableAdapters.TableAdapterManager();
            this.mainTableAdapter = new WindowsFormsApp2.mydbDataSetTableAdapters.mainTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.AcceptButtAppl = new System.Windows.Forms.Button();
            this.deleteButtonAppl = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.applicationDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.TB_Editor = new System.Windows.Forms.TextBox();
            this.TB_Trans3 = new System.Windows.Forms.TextBox();
            this.TB_Trans2 = new System.Windows.Forms.TextBox();
            this.AddTransButt = new System.Windows.Forms.Button();
            this.TB_Trans1 = new System.Windows.Forms.TextBox();
            this.TB_Trans = new System.Windows.Forms.TextBox();
            this.TB_Illu3 = new System.Windows.Forms.TextBox();
            this.TB_Illu2 = new System.Windows.Forms.TextBox();
            this.AddIllusButt = new System.Windows.Forms.Button();
            this.TB_Illu1 = new System.Windows.Forms.TextBox();
            this.TB_AuthorsR3 = new System.Windows.Forms.TextBox();
            this.TB_AuthorsR2 = new System.Windows.Forms.TextBox();
            this.AddAuthButt = new System.Windows.Forms.Button();
            this.TB_AuthorsR1 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.TB_Illu = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TB_AuthorsR = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.genreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RTB_ContDiscr = new System.Windows.Forms.RichTextBox();
            this.RTB_Genre = new System.Windows.Forms.RichTextBox();
            this.RTB_Authors = new System.Windows.Forms.RichTextBox();
            this.RTB_FullInfo = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.RTB_ShortInfo = new System.Windows.Forms.RichTextBox();
            this.TB_Cycle = new System.Windows.Forms.TextBox();
            this.TB_PrintEd = new System.Windows.Forms.TextBox();
            this.TB_AgeRate = new System.Windows.Forms.TextBox();
            this.TB_PublHouse = new System.Windows.Forms.TextBox();
            this.TB_Year = new System.Windows.Forms.TextBox();
            this.TB_Pages = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_Link = new System.Windows.Forms.TextBox();
            this.TB_Type = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_AppInd = new System.Windows.Forms.TextBox();
            this.AcceptApplButt = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comics_infoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comics_infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveButtMain = new System.Windows.Forms.Button();
            this.deleteButtMain = new System.Windows.Forms.Button();
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genreBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainTableAdapter1 = new WindowsFormsApp2.mydbDataSetTableAdapters.mainTableAdapter();
            this.mainTableAdapter2 = new WindowsFormsApp2.mydbDataSetTableAdapters.mainTableAdapter();
            this.applicationTableAdapter1 = new WindowsFormsApp2.mydbDataSetTableAdapters.applicationTableAdapter();
            this.applicationTableAdapter2 = new WindowsFormsApp2.mydbDataSetTableAdapters.applicationTableAdapter();
            this.applicationTableAdapter3 = new WindowsFormsApp2.mydbDataSetTableAdapters.applicationTableAdapter();
            this.genreTableAdapter = new WindowsFormsApp2.mydbDataSetTableAdapters.genreTableAdapter();
            this.comics_infoTableAdapter = new WindowsFormsApp2.mydbDataSetTableAdapters.comics_infoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comics_infoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comics_infoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mydbDataSetBindingSource
            // 
            this.mydbDataSetBindingSource.DataSource = this.mydbDataSet;
            this.mydbDataSetBindingSource.Position = 0;
            // 
            // mydbDataSetBindingSource1
            // 
            this.mydbDataSetBindingSource1.DataSource = this.mydbDataSet;
            this.mydbDataSetBindingSource1.Position = 0;
            // 
            // applicationBindingSource
            // 
            this.applicationBindingSource.DataMember = "application";
            this.applicationBindingSource.DataSource = this.mydbDataSet;
            // 
            // applicationTableAdapter
            // 
            this.applicationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.applicationTableAdapter = this.applicationTableAdapter;
            this.tableAdapterManager.authors_edit_has_authorsTableAdapter = null;
            this.tableAdapterManager.authors_editTableAdapter = null;
            this.tableAdapterManager.authors_illustration_has_authorsTableAdapter = null;
            this.tableAdapterManager.authors_illustrationTableAdapter = null;
            this.tableAdapterManager.authors_plot_has_authorsTableAdapter = null;
            this.tableAdapterManager.authors_plotTableAdapter = null;
            this.tableAdapterManager.authors_translator_has_authorsTableAdapter = null;
            this.tableAdapterManager.authors_translatorTableAdapter = null;
            this.tableAdapterManager.authorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.comics_infoTableAdapter = null;
            this.tableAdapterManager.cycle_of_worksTableAdapter = null;
            this.tableAdapterManager.genreTableAdapter = null;
            this.tableAdapterManager.main_has_genreTableAdapter = null;
            this.tableAdapterManager.main_has_publishing_houseTableAdapter = null;
            this.tableAdapterManager.mainTableAdapter = this.mainTableAdapter;
            this.tableAdapterManager.publisher_userTableAdapter = null;
            this.tableAdapterManager.publishing_houseTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.mydbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mainTableAdapter
            // 
            this.mainTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1609, 783);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.richTextBox2);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.AcceptButtAppl);
            this.tabPage1.Controls.Add(this.deleteButtonAppl);
            this.tabPage1.Controls.Add(this.saveButton);
            this.tabPage1.Controls.Add(this.applicationDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1601, 757);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Заявки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(460, 534);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Полная информация:";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(32, 531);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Краткое содержание:";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox2.Location = new System.Drawing.Point(463, 550);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(383, 114);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox1.Location = new System.Drawing.Point(32, 550);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(383, 114);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // AcceptButtAppl
            // 
            this.AcceptButtAppl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AcceptButtAppl.Location = new System.Drawing.Point(1335, 683);
            this.AcceptButtAppl.Name = "AcceptButtAppl";
            this.AcceptButtAppl.Size = new System.Drawing.Size(203, 49);
            this.AcceptButtAppl.TabIndex = 3;
            this.AcceptButtAppl.Text = "Принять заявку";
            this.AcceptButtAppl.UseVisualStyleBackColor = true;
            this.AcceptButtAppl.Click += new System.EventHandler(this.AcceptButtAppl_Click);
            // 
            // deleteButtonAppl
            // 
            this.deleteButtonAppl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButtonAppl.Location = new System.Drawing.Point(1126, 683);
            this.deleteButtonAppl.Name = "deleteButtonAppl";
            this.deleteButtonAppl.Size = new System.Drawing.Size(203, 49);
            this.deleteButtonAppl.TabIndex = 2;
            this.deleteButtonAppl.Text = "Удалить заявку";
            this.deleteButtonAppl.UseVisualStyleBackColor = true;
            this.deleteButtonAppl.Click += new System.EventHandler(this.deleteButtonAppl_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(917, 683);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(203, 49);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Сохранить изменения";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // applicationDataGridView
            // 
            this.applicationDataGridView.AllowUserToAddRows = false;
            this.applicationDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applicationDataGridView.AutoGenerateColumns = false;
            this.applicationDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.applicationDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.applicationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.applicationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.applicationDataGridView.DataSource = this.applicationBindingSource;
            this.applicationDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.applicationDataGridView.Location = new System.Drawing.Point(6, 6);
            this.applicationDataGridView.Name = "applicationDataGridView";
            this.applicationDataGridView.RowHeadersVisible = false;
            this.applicationDataGridView.Size = new System.Drawing.Size(1556, 493);
            this.applicationDataGridView.TabIndex = 0;
            this.applicationDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.applicationDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idApplication";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер заявки";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 96;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Application_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 82;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Application_type";
            this.dataGridViewTextBoxColumn3.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 51;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Application_link_on_pages";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ссылка на тайтл";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 82;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Application_wishful_age_rating";
            this.dataGridViewTextBoxColumn5.HeaderText = "Возрастное ограничение";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 145;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Application_why_this_rating";
            this.dataGridViewTextBoxColumn6.HeaderText = "Предупреждения";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 119;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Application_Printed_Edition";
            this.dataGridViewTextBoxColumn7.HeaderText = "Печатное издание";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 114;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Application_Publ_house";
            this.dataGridViewTextBoxColumn8.HeaderText = "Издательство";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 104;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Application_info_short";
            this.dataGridViewTextBoxColumn9.HeaderText = "Краткое содержание";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 127;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Application_info_full";
            this.dataGridViewTextBoxColumn11.HeaderText = "Информация";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Application_info_year";
            this.dataGridViewTextBoxColumn12.HeaderText = "Год";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 50;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Application_pages";
            this.dataGridViewTextBoxColumn13.HeaderText = "Кол-во страниц";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 101;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Application_genre";
            this.dataGridViewTextBoxColumn14.HeaderText = "Жанр";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Application_authors";
            this.dataGridViewTextBoxColumn15.HeaderText = "Авторы";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Application_cycle_of_works";
            this.dataGridViewTextBoxColumn16.HeaderText = "Цикл работ";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.TB_Editor);
            this.tabPage2.Controls.Add(this.TB_Trans3);
            this.tabPage2.Controls.Add(this.TB_Trans2);
            this.tabPage2.Controls.Add(this.AddTransButt);
            this.tabPage2.Controls.Add(this.TB_Trans1);
            this.tabPage2.Controls.Add(this.TB_Trans);
            this.tabPage2.Controls.Add(this.TB_Illu3);
            this.tabPage2.Controls.Add(this.TB_Illu2);
            this.tabPage2.Controls.Add(this.AddIllusButt);
            this.tabPage2.Controls.Add(this.TB_Illu1);
            this.tabPage2.Controls.Add(this.TB_AuthorsR3);
            this.tabPage2.Controls.Add(this.TB_AuthorsR2);
            this.tabPage2.Controls.Add(this.AddAuthButt);
            this.tabPage2.Controls.Add(this.TB_AuthorsR1);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.TB_Illu);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.TB_AuthorsR);
            this.tabPage2.Controls.Add(this.checkedListBox1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.AcceptApplButt);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1601, 757);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Редакция заявки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(25, 310);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(250, 13);
            this.label22.TabIndex = 60;
            this.label22.Text = "Пожалуйста, введите следующую информацию!";
            // 
            // TB_Editor
            // 
            this.TB_Editor.Location = new System.Drawing.Point(937, 367);
            this.TB_Editor.Name = "TB_Editor";
            this.TB_Editor.Size = new System.Drawing.Size(188, 20);
            this.TB_Editor.TabIndex = 59;
            // 
            // TB_Trans3
            // 
            this.TB_Trans3.Location = new System.Drawing.Point(686, 485);
            this.TB_Trans3.Name = "TB_Trans3";
            this.TB_Trans3.Size = new System.Drawing.Size(188, 20);
            this.TB_Trans3.TabIndex = 58;
            this.TB_Trans3.Visible = false;
            // 
            // TB_Trans2
            // 
            this.TB_Trans2.Location = new System.Drawing.Point(686, 459);
            this.TB_Trans2.Name = "TB_Trans2";
            this.TB_Trans2.Size = new System.Drawing.Size(188, 20);
            this.TB_Trans2.TabIndex = 57;
            this.TB_Trans2.Visible = false;
            // 
            // AddTransButt
            // 
            this.AddTransButt.Location = new System.Drawing.Point(770, 393);
            this.AddTransButt.Name = "AddTransButt";
            this.AddTransButt.Size = new System.Drawing.Size(104, 23);
            this.AddTransButt.TabIndex = 56;
            this.AddTransButt.Text = "Добавить графу";
            this.AddTransButt.UseVisualStyleBackColor = true;
            this.AddTransButt.Click += new System.EventHandler(this.AddTransButt_Click);
            // 
            // TB_Trans1
            // 
            this.TB_Trans1.Location = new System.Drawing.Point(686, 433);
            this.TB_Trans1.Name = "TB_Trans1";
            this.TB_Trans1.Size = new System.Drawing.Size(188, 20);
            this.TB_Trans1.TabIndex = 55;
            this.TB_Trans1.Visible = false;
            // 
            // TB_Trans
            // 
            this.TB_Trans.Location = new System.Drawing.Point(686, 367);
            this.TB_Trans.Name = "TB_Trans";
            this.TB_Trans.Size = new System.Drawing.Size(188, 20);
            this.TB_Trans.TabIndex = 54;
            // 
            // TB_Illu3
            // 
            this.TB_Illu3.Location = new System.Drawing.Point(438, 485);
            this.TB_Illu3.Name = "TB_Illu3";
            this.TB_Illu3.Size = new System.Drawing.Size(188, 20);
            this.TB_Illu3.TabIndex = 53;
            this.TB_Illu3.Visible = false;
            // 
            // TB_Illu2
            // 
            this.TB_Illu2.Location = new System.Drawing.Point(438, 459);
            this.TB_Illu2.Name = "TB_Illu2";
            this.TB_Illu2.Size = new System.Drawing.Size(188, 20);
            this.TB_Illu2.TabIndex = 52;
            this.TB_Illu2.Visible = false;
            // 
            // AddIllusButt
            // 
            this.AddIllusButt.Location = new System.Drawing.Point(528, 393);
            this.AddIllusButt.Name = "AddIllusButt";
            this.AddIllusButt.Size = new System.Drawing.Size(98, 23);
            this.AddIllusButt.TabIndex = 51;
            this.AddIllusButt.Text = "Добавить графу";
            this.AddIllusButt.UseVisualStyleBackColor = true;
            this.AddIllusButt.Click += new System.EventHandler(this.AddIllusButt_Click);
            // 
            // TB_Illu1
            // 
            this.TB_Illu1.Location = new System.Drawing.Point(438, 433);
            this.TB_Illu1.Name = "TB_Illu1";
            this.TB_Illu1.Size = new System.Drawing.Size(188, 20);
            this.TB_Illu1.TabIndex = 50;
            this.TB_Illu1.Visible = false;
            // 
            // TB_AuthorsR3
            // 
            this.TB_AuthorsR3.Location = new System.Drawing.Point(196, 485);
            this.TB_AuthorsR3.Name = "TB_AuthorsR3";
            this.TB_AuthorsR3.Size = new System.Drawing.Size(188, 20);
            this.TB_AuthorsR3.TabIndex = 49;
            this.TB_AuthorsR3.Visible = false;
            // 
            // TB_AuthorsR2
            // 
            this.TB_AuthorsR2.Location = new System.Drawing.Point(196, 459);
            this.TB_AuthorsR2.Name = "TB_AuthorsR2";
            this.TB_AuthorsR2.Size = new System.Drawing.Size(188, 20);
            this.TB_AuthorsR2.TabIndex = 48;
            this.TB_AuthorsR2.Visible = false;
            // 
            // AddAuthButt
            // 
            this.AddAuthButt.Location = new System.Drawing.Point(276, 393);
            this.AddAuthButt.Name = "AddAuthButt";
            this.AddAuthButt.Size = new System.Drawing.Size(108, 23);
            this.AddAuthButt.TabIndex = 47;
            this.AddAuthButt.Text = "Добавить графу";
            this.AddAuthButt.UseVisualStyleBackColor = true;
            this.AddAuthButt.Click += new System.EventHandler(this.button2_Click);
            // 
            // TB_AuthorsR1
            // 
            this.TB_AuthorsR1.Location = new System.Drawing.Point(196, 433);
            this.TB_AuthorsR1.Name = "TB_AuthorsR1";
            this.TB_AuthorsR1.Size = new System.Drawing.Size(188, 20);
            this.TB_AuthorsR1.TabIndex = 46;
            this.TB_AuthorsR1.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(435, 349);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 13);
            this.label21.TabIndex = 45;
            this.label21.Text = "Художник:";
            // 
            // TB_Illu
            // 
            this.TB_Illu.Location = new System.Drawing.Point(438, 367);
            this.TB_Illu.Name = "TB_Illu";
            this.TB_Illu.Size = new System.Drawing.Size(188, 20);
            this.TB_Illu.TabIndex = 44;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(683, 349);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 13);
            this.label20.TabIndex = 43;
            this.label20.Text = "Переводчик:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(934, 349);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 41;
            this.label19.Text = "Редактор:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(193, 349);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 13);
            this.label18.TabIndex = 39;
            this.label18.Text = "Автор сценария:";
            // 
            // TB_AuthorsR
            // 
            this.TB_AuthorsR.Location = new System.Drawing.Point(196, 367);
            this.TB_AuthorsR.Name = "TB_AuthorsR";
            this.TB_AuthorsR.Size = new System.Drawing.Size(188, 20);
            this.TB_AuthorsR.TabIndex = 38;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.genreBindingSource1, "Genre_name", true));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.HorizontalExtent = 1;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Комедия",
            "Ужасы",
            "Историческое",
            "Романтика",
            "Драма",
            "Фентези",
            "Повседневность",
            "Мифология",
            "Политическое",
            "Супергероика",
            "Паранормальное",
            "Боевик"});
            this.checkedListBox1.Location = new System.Drawing.Point(23, 339);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(147, 184);
            this.checkedListBox1.TabIndex = 37;
            // 
            // genreBindingSource1
            // 
            this.genreBindingSource1.DataMember = "genre";
            this.genreBindingSource1.DataSource = this.mydbDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RTB_ContDiscr);
            this.groupBox1.Controls.Add(this.RTB_Genre);
            this.groupBox1.Controls.Add(this.RTB_Authors);
            this.groupBox1.Controls.Add(this.RTB_FullInfo);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.RTB_ShortInfo);
            this.groupBox1.Controls.Add(this.TB_Cycle);
            this.groupBox1.Controls.Add(this.TB_PrintEd);
            this.groupBox1.Controls.Add(this.TB_AgeRate);
            this.groupBox1.Controls.Add(this.TB_PublHouse);
            this.groupBox1.Controls.Add(this.TB_Year);
            this.groupBox1.Controls.Add(this.TB_Pages);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TB_Link);
            this.groupBox1.Controls.Add(this.TB_Type);
            this.groupBox1.Controls.Add(this.TB_Name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_AppInd);
            this.groupBox1.Location = new System.Drawing.Point(22, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1546, 271);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Содержимое заявки:";
            // 
            // RTB_ContDiscr
            // 
            this.RTB_ContDiscr.Location = new System.Drawing.Point(1162, 202);
            this.RTB_ContDiscr.Name = "RTB_ContDiscr";
            this.RTB_ContDiscr.Size = new System.Drawing.Size(364, 50);
            this.RTB_ContDiscr.TabIndex = 39;
            this.RTB_ContDiscr.Text = "";
            // 
            // RTB_Genre
            // 
            this.RTB_Genre.Location = new System.Drawing.Point(1162, 120);
            this.RTB_Genre.Name = "RTB_Genre";
            this.RTB_Genre.Size = new System.Drawing.Size(364, 48);
            this.RTB_Genre.TabIndex = 38;
            this.RTB_Genre.Text = "";
            // 
            // RTB_Authors
            // 
            this.RTB_Authors.Location = new System.Drawing.Point(786, 120);
            this.RTB_Authors.Name = "RTB_Authors";
            this.RTB_Authors.Size = new System.Drawing.Size(364, 132);
            this.RTB_Authors.TabIndex = 35;
            this.RTB_Authors.Text = "";
            // 
            // RTB_FullInfo
            // 
            this.RTB_FullInfo.Location = new System.Drawing.Point(401, 120);
            this.RTB_FullInfo.Name = "RTB_FullInfo";
            this.RTB_FullInfo.Size = new System.Drawing.Size(364, 132);
            this.RTB_FullInfo.TabIndex = 34;
            this.RTB_FullInfo.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(398, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Краткое содержание";
            // 
            // RTB_ShortInfo
            // 
            this.RTB_ShortInfo.Location = new System.Drawing.Point(18, 120);
            this.RTB_ShortInfo.Name = "RTB_ShortInfo";
            this.RTB_ShortInfo.Size = new System.Drawing.Size(364, 132);
            this.RTB_ShortInfo.TabIndex = 32;
            this.RTB_ShortInfo.Text = "";
            // 
            // TB_Cycle
            // 
            this.TB_Cycle.Location = new System.Drawing.Point(1035, 53);
            this.TB_Cycle.Multiline = true;
            this.TB_Cycle.Name = "TB_Cycle";
            this.TB_Cycle.Size = new System.Drawing.Size(209, 38);
            this.TB_Cycle.TabIndex = 31;
            // 
            // TB_PrintEd
            // 
            this.TB_PrintEd.Location = new System.Drawing.Point(609, 63);
            this.TB_PrintEd.Name = "TB_PrintEd";
            this.TB_PrintEd.Size = new System.Drawing.Size(61, 20);
            this.TB_PrintEd.TabIndex = 29;
            // 
            // TB_AgeRate
            // 
            this.TB_AgeRate.Location = new System.Drawing.Point(153, 63);
            this.TB_AgeRate.Name = "TB_AgeRate";
            this.TB_AgeRate.Size = new System.Drawing.Size(100, 20);
            this.TB_AgeRate.TabIndex = 27;
            // 
            // TB_PublHouse
            // 
            this.TB_PublHouse.Location = new System.Drawing.Point(825, 63);
            this.TB_PublHouse.Name = "TB_PublHouse";
            this.TB_PublHouse.Size = new System.Drawing.Size(118, 20);
            this.TB_PublHouse.TabIndex = 26;
            // 
            // TB_Year
            // 
            this.TB_Year.Location = new System.Drawing.Point(1035, 27);
            this.TB_Year.Name = "TB_Year";
            this.TB_Year.Size = new System.Drawing.Size(67, 20);
            this.TB_Year.TabIndex = 25;
            // 
            // TB_Pages
            // 
            this.TB_Pages.Location = new System.Drawing.Point(388, 63);
            this.TB_Pages.Name = "TB_Pages";
            this.TB_Pages.Size = new System.Drawing.Size(100, 20);
            this.TB_Pages.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(964, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Цикл работ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(783, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Авторы";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(272, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Количество страниц";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1159, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Жанры";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1004, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Год";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Полное описание";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(740, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Издательство";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(503, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Печатное издание";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1159, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Предупреждения";
            // 
            // TB_Link
            // 
            this.TB_Link.Location = new System.Drawing.Point(843, 27);
            this.TB_Link.Name = "TB_Link";
            this.TB_Link.Size = new System.Drawing.Size(132, 20);
            this.TB_Link.TabIndex = 11;
            // 
            // TB_Type
            // 
            this.TB_Type.Location = new System.Drawing.Point(630, 27);
            this.TB_Type.Name = "TB_Type";
            this.TB_Type.Size = new System.Drawing.Size(100, 20);
            this.TB_Type.TabIndex = 10;
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(232, 19);
            this.TB_Name.Multiline = true;
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(351, 28);
            this.TB_Name.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Номер заявки:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Возрастное ограничение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(745, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ссылка на тайтл";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Тип:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название:";
            // 
            // TB_AppInd
            // 
            this.TB_AppInd.Location = new System.Drawing.Point(98, 27);
            this.TB_AppInd.Name = "TB_AppInd";
            this.TB_AppInd.Size = new System.Drawing.Size(45, 20);
            this.TB_AppInd.TabIndex = 3;
            // 
            // AcceptApplButt
            // 
            this.AcceptApplButt.Location = new System.Drawing.Point(974, 659);
            this.AcceptApplButt.Name = "AcceptApplButt";
            this.AcceptApplButt.Size = new System.Drawing.Size(240, 65);
            this.AcceptApplButt.TabIndex = 23;
            this.AcceptApplButt.Text = "Сохранить изменения";
            this.AcceptApplButt.UseVisualStyleBackColor = true;
            this.AcceptApplButt.Click += new System.EventHandler(this.AcceptApplButt_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comics_infoDataGridView);
            this.tabPage3.Controls.Add(this.saveButtMain);
            this.tabPage3.Controls.Add(this.deleteButtMain);
            this.tabPage3.Controls.Add(this.mainDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1601, 757);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Записи";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comics_infoDataGridView
            // 
            this.comics_infoDataGridView.AutoGenerateColumns = false;
            this.comics_infoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comics_infoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29});
            this.comics_infoDataGridView.DataSource = this.comics_infoBindingSource;
            this.comics_infoDataGridView.Location = new System.Drawing.Point(561, 403);
            this.comics_infoDataGridView.Name = "comics_infoDataGridView";
            this.comics_infoDataGridView.Size = new System.Drawing.Size(300, 220);
            this.comics_infoDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "idComics_Info";
            this.dataGridViewTextBoxColumn24.HeaderText = "idComics_Info";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Comics_Info_short_description";
            this.dataGridViewTextBoxColumn25.HeaderText = "Comics_Info_short_description";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Comics_Info_Full_description";
            this.dataGridViewTextBoxColumn26.HeaderText = "Comics_Info_Full_description";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Comics_Info_year";
            this.dataGridViewTextBoxColumn27.HeaderText = "Comics_Info_year";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Comics_Info_pages";
            this.dataGridViewTextBoxColumn28.HeaderText = "Comics_Info_pages";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "Comics_Info_License";
            this.dataGridViewTextBoxColumn29.HeaderText = "Comics_Info_License";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // comics_infoBindingSource
            // 
            this.comics_infoBindingSource.DataMember = "comics_info";
            this.comics_infoBindingSource.DataSource = this.mydbDataSet;
            // 
            // saveButtMain
            // 
            this.saveButtMain.Location = new System.Drawing.Point(266, 331);
            this.saveButtMain.Name = "saveButtMain";
            this.saveButtMain.Size = new System.Drawing.Size(225, 89);
            this.saveButtMain.TabIndex = 2;
            this.saveButtMain.Text = "Сохранить изменения";
            this.saveButtMain.UseVisualStyleBackColor = true;
            this.saveButtMain.Click += new System.EventHandler(this.saveButtMain_Click);
            // 
            // deleteButtMain
            // 
            this.deleteButtMain.Location = new System.Drawing.Point(25, 331);
            this.deleteButtMain.Name = "deleteButtMain";
            this.deleteButtMain.Size = new System.Drawing.Size(225, 89);
            this.deleteButtMain.TabIndex = 1;
            this.deleteButtMain.Text = "Удалить запись";
            this.deleteButtMain.UseVisualStyleBackColor = true;
            this.deleteButtMain.Click += new System.EventHandler(this.deleteButtMain_Click);
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.AllowUserToAddRows = false;
            this.mainDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainDataGridView.AutoGenerateColumns = false;
            this.mainDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23});
            this.mainDataGridView.DataSource = this.mainBindingSource;
            this.mainDataGridView.Location = new System.Drawing.Point(0, 0);
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.Size = new System.Drawing.Size(1071, 310);
            this.mainDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "idMain";
            this.dataGridViewTextBoxColumn10.HeaderText = "idMain";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 63;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Main_info";
            this.dataGridViewTextBoxColumn17.HeaderText = "Main_info";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 78;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Comics_Info_id";
            this.dataGridViewTextBoxColumn18.HeaderText = "Comics_Info_id";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 104;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Age_rate";
            this.dataGridViewTextBoxColumn19.HeaderText = "Age_rate";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 75;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Cycle_of_works_id";
            this.dataGridViewTextBoxColumn20.HeaderText = "Cycle_of_works_id";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 121;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Publisher_User_id";
            this.dataGridViewTextBoxColumn21.HeaderText = "Publisher_User_id";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 117;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn22.HeaderText = "Name";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 60;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Authors_idAuthors";
            this.dataGridViewTextBoxColumn23.HeaderText = "Authors_idAuthors";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 118;
            // 
            // mainBindingSource
            // 
            this.mainBindingSource.DataMember = "main";
            this.mainBindingSource.DataSource = this.mydbDataSet;
            // 
            // genreBindingSource2
            // 
            this.genreBindingSource2.DataMember = "genre";
            this.genreBindingSource2.DataSource = this.mydbDataSetBindingSource;
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataMember = "genre";
            this.genreBindingSource.DataSource = this.mydbDataSetBindingSource1;
            // 
            // mainTableAdapter1
            // 
            this.mainTableAdapter1.ClearBeforeFill = true;
            // 
            // mainTableAdapter2
            // 
            this.mainTableAdapter2.ClearBeforeFill = true;
            // 
            // applicationTableAdapter1
            // 
            this.applicationTableAdapter1.ClearBeforeFill = true;
            // 
            // applicationTableAdapter2
            // 
            this.applicationTableAdapter2.ClearBeforeFill = true;
            // 
            // applicationTableAdapter3
            // 
            this.applicationTableAdapter3.ClearBeforeFill = true;
            // 
            // genreTableAdapter
            // 
            this.genreTableAdapter.ClearBeforeFill = true;
            // 
            // comics_infoTableAdapter
            // 
            this.comics_infoTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1612, 785);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comics_infoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comics_infoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource mydbDataSetBindingSource1;
        private mydbDataSet mydbDataSet;
        private System.Windows.Forms.BindingSource mydbDataSetBindingSource;
        private System.Windows.Forms.BindingSource applicationBindingSource;
        private mydbDataSetTableAdapters.applicationTableAdapter applicationTableAdapter;
        private mydbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView applicationDataGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private mydbDataSetTableAdapters.mainTableAdapter mainTableAdapter;
        private System.Windows.Forms.BindingSource mainBindingSource;
        private System.Windows.Forms.Button AcceptButtAppl;
        private System.Windows.Forms.Button deleteButtonAppl;
        private System.Windows.Forms.TabPage tabPage3;
        private mydbDataSetTableAdapters.mainTableAdapter mainTableAdapter1;
        private mydbDataSetTableAdapters.mainTableAdapter mainTableAdapter2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private mydbDataSetTableAdapters.applicationTableAdapter applicationTableAdapter1;
        private mydbDataSetTableAdapters.applicationTableAdapter applicationTableAdapter2;
        private System.Windows.Forms.Button deleteButtMain;
        private System.Windows.Forms.Button saveButtMain;
        private mydbDataSetTableAdapters.applicationTableAdapter applicationTableAdapter3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_AppInd;
        private System.Windows.Forms.TextBox TB_PublHouse;
        private System.Windows.Forms.TextBox TB_Year;
        private System.Windows.Forms.TextBox TB_Pages;
        private System.Windows.Forms.Button AcceptApplButt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_Link;
        private System.Windows.Forms.TextBox TB_Type;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RTB_ShortInfo;
        private System.Windows.Forms.TextBox TB_Cycle;
        private System.Windows.Forms.TextBox TB_PrintEd;
        private System.Windows.Forms.TextBox TB_AgeRate;
        private System.Windows.Forms.RichTextBox RTB_FullInfo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private mydbDataSetTableAdapters.genreTableAdapter genreTableAdapter;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox RTB_Authors;
        private System.Windows.Forms.RichTextBox RTB_Genre;
        private System.Windows.Forms.RichTextBox RTB_ContDiscr;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.BindingSource genreBindingSource1;
        private System.Windows.Forms.BindingSource genreBindingSource2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox TB_Illu;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TB_AuthorsR;
        private System.Windows.Forms.TextBox TB_Editor;
        private System.Windows.Forms.TextBox TB_Trans3;
        private System.Windows.Forms.TextBox TB_Trans2;
        private System.Windows.Forms.Button AddTransButt;
        private System.Windows.Forms.TextBox TB_Trans1;
        private System.Windows.Forms.TextBox TB_Trans;
        private System.Windows.Forms.TextBox TB_Illu3;
        private System.Windows.Forms.TextBox TB_Illu2;
        private System.Windows.Forms.Button AddIllusButt;
        private System.Windows.Forms.TextBox TB_Illu1;
        private System.Windows.Forms.TextBox TB_AuthorsR3;
        private System.Windows.Forms.TextBox TB_AuthorsR2;
        private System.Windows.Forms.Button AddAuthButt;
        private System.Windows.Forms.TextBox TB_AuthorsR1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.BindingSource comics_infoBindingSource;
        private mydbDataSetTableAdapters.comics_infoTableAdapter comics_infoTableAdapter;
        private System.Windows.Forms.DataGridView comics_infoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
    }
}

