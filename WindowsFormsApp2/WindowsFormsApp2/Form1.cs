using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int index = -1; 
        public Form1()
        {
            InitializeComponent();
           // applicationDataGridView.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mydbDataSet.comics_info". При необходимости она может быть перемещена или удалена.
            this.comics_infoTableAdapter.Fill(this.mydbDataSet.comics_info);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mydbDataSet.genre". При необходимости она может быть перемещена или удалена.
            this.genreTableAdapter.Fill(this.mydbDataSet.genre);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mydbDataSet.main". При необходимости она может быть перемещена или удалена.
            this.mainTableAdapter.Fill(this.mydbDataSet.main);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mydbDataSet.application". При необходимости она может быть перемещена или удалена.
            this.applicationTableAdapter.Fill(this.mydbDataSet.application);

        }

        private void saveButton_Click(object sender, EventArgs e) // сохранение таблицы заявок
        {
            applicationTableAdapter.Update(mydbDataSet.application);
        }

        private void deleteButtonAppl_Click(object sender, EventArgs e) // удаление заявки
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                int a = applicationDataGridView.CurrentRow.Index;
                applicationDataGridView.Rows.Remove(applicationDataGridView.Rows[a]);
                //  applicationTableAdapter.Update(mydbDataSet.application); 
            }
        }

        private void deleteButtMain_Click(object sender, EventArgs e) //удаление на мейне
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                int a = mainDataGridView.CurrentRow.Index;
                mainDataGridView.Rows.Remove(mainDataGridView.Rows[a]);
               
            }
        }

        private void saveButtMain_Click(object sender, EventArgs e) //сохранение мейна
        {
            mainTableAdapter.Update(mydbDataSet.main);
        }

        private void AcceptButtAppl_Click(object sender, EventArgs e)
        {
            // index = applicationDataGridView.CurrentCell.RowIndex; // получает номер записи

            index = applicationDataGridView.CurrentRow.Index;  //принимает номер строки и чтобы по ней искать данные дальше

            //if (index < 0)
            //{
            //    DialogResult al = MessageBox.Show("Пожалуйста, выберите запись", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            //}

            tabControl1.SelectedTab = tabControl1.TabPages["TabPage2"]; //переход на вкладку для редакции

            // dataGridView1.FirstDisplayedScrollingRowIndex = index; //открывает первой строкой принятую 


            TB_AppInd.Text = applicationDataGridView.Rows[index].Cells[0].Value.ToString();     //номер
            TB_Name.Text = applicationDataGridView.Rows[index].Cells[1].Value.ToString();       // название тайтла
            TB_Type.Text = applicationDataGridView.Rows[index].Cells[2].Value.ToString();       // тип
            TB_Link.Text = applicationDataGridView.Rows[index].Cells[3].Value.ToString();       //ссылка 
            TB_AgeRate.Text = applicationDataGridView.Rows[index].Cells[4].Value.ToString();    //возрастное ограничение

          //  string a = applicationDataGridView.Rows[index].Cells[6].Value.ToString();

            if (applicationDataGridView.Rows[index].Cells[6].Value.ToString() == "1")  //проверка на наличие печатного издания
            {
                TB_PrintEd.Text = "есть";    //есть ли печатное издание
                TB_PublHouse.Text = applicationDataGridView.Rows[index].Cells[7].Value.ToString();  //издательство
            }
            else
            {
                TB_PrintEd.Text = "нет";
                TB_PublHouse.Text = "нет";
            };
            
            RTB_ShortInfo.Text = applicationDataGridView.Rows[index].Cells[8].Value.ToString(); //краткое описание
            RTB_FullInfo.Text = applicationDataGridView.Rows[index].Cells[9].Value.ToString();  //полное описание
            TB_Year.Text = applicationDataGridView.Rows[index].Cells[10].Value.ToString();      //год
            TB_Pages.Text = applicationDataGridView.Rows[index].Cells[11].Value.ToString();     //странциы
            RTB_Genre.Text = applicationDataGridView.Rows[index].Cells[12].Value.ToString();    //жанры
            RTB_Authors.Text = applicationDataGridView.Rows[index].Cells[13].Value.ToString();  //авторы
            TB_Cycle.Text = applicationDataGridView.Rows[index].Cells[14].Value.ToString();     //цикл


        }


        private void applicationDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = applicationDataGridView.CurrentRow.Index;

            richTextBox1.Text = applicationDataGridView.Rows[index].Cells[8].Value.ToString();

            richTextBox2.Text = applicationDataGridView.Rows[index].Cells[9].Value.ToString();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.genreTableAdapter.FillBy(this.mydbDataSet.genre);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            TB_AuthorsR1.Visible = true;
            AddAuthButt.Visible = false;
            btn.Click -= new EventHandler(button2_Click);
           // btn.Click += new EventHandler(button2_Click_1);  

        }

        //private void button2_Click_1(object sender, EventArgs e)
        //{
        //    Button btn = sender as Button;
        //    TB_AuthorsR2.Visible = true;
        //    btn.Click -= new EventHandler(button2_Click_1);
        //    btn.Click += new EventHandler(button2_Click_2);
        //}

        //private void button2_Click_2(object sender, EventArgs e)
        //{
        //    TB_AuthorsR3.Visible = true;
        //}

        private void AddIllusButt_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            TB_Illu1.Visible = true;
            AddIllusButt.Visible = false;
            btn.Click -= new EventHandler(AddIllusButt_Click);
          //  btn.Click += new EventHandler(AddIllusButt_Click_1);
        }

        //private void AddIllusButt_Click_1(object sender, EventArgs e)
        //{
        //    Button btn = sender as Button;
        //    TB_Illu2.Visible = true;
        //    btn.Click -= new EventHandler(AddIllusButt_Click_1);
        //    btn.Click += new EventHandler(AddIllusButt_Click_2);
        //}

        //private void AddIllusButt_Click_2(object sender, EventArgs e)
        //{
        //    TB_Illu3.Visible = true;
        //}

        private void AddTransButt_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            TB_Trans1.Visible = true;
            AddTransButt.Visible = false;
            btn.Click -= new EventHandler(AddTransButt_Click);
          //  btn.Click += new EventHandler(AddTransButt_Click_1); 
        }

        //private void AddTransButt_Click_1(object sender, EventArgs e)
        //{
        //    Button btn = sender as Button;
        //    TB_Trans2.Visible = true;
        //    btn.Click -= new EventHandler(AddTransButt_Click_1);
        //    btn.Click += new EventHandler(AddTransButt_Click_2);
        //}

        //private void AddTransButt_Click_2(object sender, EventArgs e)
        //{
        //    TB_Trans3.Visible = true;
        //}

        private void AcceptApplButt_Click(object sender, EventArgs e)
        {

            try
            {
            string connectionString = "server = localhost; user id = root; password = root; database = mydb; persistsecurityinfo = True";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    //------------------------------------------------------
                    connection.Open();
                    //------------------------ЗАПОЛНЕНИЕ ТАБЛИЦЫ КОМИКС ИНФО------------------------------------
                    MySqlCommand cmdInfo = connection.CreateCommand();
                    string sqlINFO = "INSERT INTO comics_info (Comics_Info_short_description, Comics_Info_Full_description, Comics_Info_year, Comics_Info_pages) Values(@Comics_Info_short_description, @Comics_Info_Full_description, @Comics_Info_year, @Comics_Info_pages)";
                    cmdInfo.CommandText = sqlINFO;
                    cmdInfo.Parameters.AddWithValue("Comics_Info_short_description", RTB_ShortInfo.Text);
                    cmdInfo.Parameters.AddWithValue("Comics_Info_Full_description", RTB_FullInfo.Text);
                    cmdInfo.Parameters.AddWithValue("Comics_Info_year", TB_Year.Text);
                    cmdInfo.Parameters.AddWithValue("Comics_Info_pages", TB_Pages.Text);
                    cmdInfo.ExecuteNonQuery();

                    //-------------------------------ПОЛУЧЕНИЕ АЙДИ НОВОЙ ЗАПИСИ В КОМИКС ИНФО---------------------------------------
                    MySqlCommand cmdInfo_ID = connection.CreateCommand();
                    string sqlINFO_ID = "SELECT idComics_Info FROM comics_info WHERE Comics_Info_short_description = '" + RTB_ShortInfo.Text.ToString() + "' ";
                    cmdInfo_ID.CommandText = sqlINFO_ID;
                    int idCI = (int)cmdInfo_ID.ExecuteScalar();

                    { //----------------------ЗАПОЛНЕНИЕ ТАБЛИЦЫ ЦИКЛ РАБОТ -----------------------------------
                    //MySqlCommand cmdCycle = connection.CreateCommand();
                    //// string sqlCycle = "INSERT INTO cycle_of_works (Cycle_of_works_Name) Values(@Cycle_of_works_Name)"; 
                    //string sqlCycle = "INSERT INTO cycle_of_works (Cycle_of_works_Name) Values(@Cycle_of_works_Name) WHERE NOT EXISTS(SELECT 1 FROM cycle_of_works WHERE(Cycle_of_works_Name) IN(SELECT Cycle_of_works_Name FROM cycle_of_works WHERE result = Values(@Cycle_of_works_Name)))";

                    ////  string sqlCycle = "INSERT INTO cycle_of_works (Cycle_of_works_Name) Values(@Cycle_of_works_Name) WHERE NOT EXISTS (SELECT * FROM cycle_of_works WHERE(Cycle_of_works_Name) 'Пиджаки и револьверы')";
                    //cmdCycle.CommandText = sqlCycle;
                    //cmdCycle.Parameters.AddWithValue("Cycle_of_works_Name", TB_Cycle.Text);
                    //cmdCycle.ExecuteNonQuery();


                    //MySqlCommand cmdCycle = connection.CreateCommand();
                    //string sqlCycle = "Select COUNT(*) From cycle_of_works WHERE (Cycle_of_works_Name) = Value(@Cycle_of_works_Name) ";
                    //cmdCycle.CommandText = sqlCycle;
                    ////   int result = (int)cmdCycle.ExecuteScalar();
                    //object result = cmdCycle.ExecuteScalar();
                    //if (result == 0)
                    //{
                    //    string sqlCycle2 = "INSERT INTO cycle_of_works (Cycle_of_works_Name) Values(@Cycle_of_works_Name)";
                    //    cmdCycle.CommandText = sqlCycle2;
                    //    cmdCycle.Parameters.AddWithValue("Cycle_of_works_Name", TB_Cycle.Text);
                    //    cmdCycle.ExecuteNonQuery();
                    //}

                    // string sqlCycle = "Select COUNT(*) From cycle_of_works WHERE Cycle_of_works_Name = '" + TB_Cycle.Text + "' ";
                    //  string sqlCycle = "SELECT * FROM cycle_of_works WHERE Cycle_of_works_Name = ' " + TB_Cycle.Text.ToString() + "'";

                    //string sqlCycle = "SELECT * FROM cycle_of_works WHERE (Cycle_of_works_Name) Value (@Cycle_of_works_Name) ";
                    //      string sqlCycle = "SELECT * FROM cycle_of_works WHERE NOT EXISTS Cycle_of_works_Name = ' " + TB_Cycle.Text.ToString() + "'";
                    //string sqlCycle = "SELECT * FROM cycle_of_works WHERE NOT EXISTS Cycle_of_works_Name = ' " + TB_Cycle.Text.ToString() + " ' ";


                    //MySqlCommand cmdCycle = new MySqlCommand(sqlCycle, connection);
                    ////   cmdCycle.Parameters.AddWithValue("Cycle_of_works_Name", TB_Cycle.Text);
                    //bool i = (bool)cmdCycle.ExecuteScalar();

                    //if (i == false)
                    //{
                    //    string sqlCycle2 = "INSERT INTO cycle_of_works (Cycle_of_works_Name) Values(@Cycle_of_works_Name)";
                    //    MySqlCommand cmdCycle2 = new MySqlCommand(sqlCycle2, connection);

                    //    cmdCycle.CommandText = sqlCycle2;
                    //    cmdCycle.Parameters.AddWithValue("Cycle_of_works_Name", TB_Cycle.Text);
                    //    cmdCycle.ExecuteNonQuery();
                    //}

                    //-----------------------------------------------------------------------------------
                    //MySqlCommand cmdCycle1 = connection.CreateCommand();
                    //MySqlCommand cmdCycle2 = connection.CreateCommand();
                    //string sqlCycleFind = "SELECT COUNT(*) FROM cycle_of_works WHERE (Cycle_of_works_Name) Value(@Cycle_of_works_Name1)";
                    //string sqlCycleAdd = "INSERT INTO cycle_of_works (Cycle_of_works_Name) Value(@Cycle_of_works_Name2)";
                    //cmdCycle1.CommandText = sqlCycleFind;
                    //cmdCycle1.Parameters.AddWithValue("Cycle_of_works_Name1", TB_Cycle.Text);
                    //MySqlDataReader reader = cmdCycle1.ExecuteReader();

                    //if (reader.Read())
                    //{
                    //    cmdCycle2.CommandText = sqlCycleAdd;
                    //    cmdCycle2.Parameters.AddWithValue("Cycle_of_works_Name2", TB_Cycle.Text);
                    //    cmdCycle2.ExecuteNonQuery();
                    }

                    //------------------------------ДОБАВЛЕНИЕ В ТАБЛИЦУ ЦИКЛА-----------------------------------------------------
                        MySqlCommand cmdCycle = connection.CreateCommand();
                        string sqlCYCLE = "INSERT INTO cycle_of_works (Cycle_of_works_Name) Values(@Cycle_of_works_Name)";
                        cmdCycle.CommandText = sqlCYCLE;
                        cmdCycle.Parameters.AddWithValue("Cycle_of_works_Name", TB_Cycle.Text);
                        cmdCycle.ExecuteNonQuery();

                        //-------------------------------ПОЛУЧЕНИЕ АЙДИ НОВОЙ ЗАПИСИ В ЦИКЛЕ---------------------------------------
                        MySqlCommand cmdCycle_ID = connection.CreateCommand();
                        string sqlCYCLE_ID = "SELECT idCycle_of_works FROM cycle_of_works WHERE Cycle_of_works_Name = '" + TB_Cycle.Text.ToString() + "' ";
                        cmdCycle_ID.CommandText = sqlCYCLE_ID;
                        int idCycle = (int)cmdCycle_ID.ExecuteScalar();
                   
                    //----------------------------------ДОБАВЛЕНИЕ АВТОРОВ-------------------------------------------------
                    
                        MySqlCommand cmdAuthors = connection.CreateCommand();
                        string sqlAuthors = "INSERT INTO authors DEFAULT VALUES";
                        cmdAuthors.CommandText = sqlAuthors;
                        cmdAuthors.ExecuteNonQuery();

                        //-------------------------------ПОЛУЧЕНИЕ АЙДИ КОМАНДЫ АВТОРОВ----------------------------------------------------
                        MySqlCommand cmdAuthorsID = connection.CreateCommand();
                        string sqlAuth_ID = "SELECT * FROM authors WHERE idAuthors=LAST_INSERT_ID();";
                        cmdAuthorsID.CommandText = sqlAuth_ID;
                        int idAuthors = (int)cmdAuthorsID.ExecuteScalar();


                    //--------------------------------ДОБАВЛЕНИЕ РЕДАКТОРА---------------------------------------------------
                     MySqlCommand cmdEditor = connection.CreateCommand();
                        string sqlEditor = "INSERT INTO authors_edit (Authors_Edit_Name) Values(@Edit)";
                        cmdEditor.CommandText = sqlEditor;
                        cmdEditor.Parameters.AddWithValue("Edit", TB_Editor.Text);
                        cmdEditor.ExecuteNonQuery();

                        //-------------------------------ПОЛУЧЕНИЕ АЙДИ РЕДАКТОРА----------------------------------------------------
                        MySqlCommand cmdEditorID = connection.CreateCommand();
                        string sqlEdit_ID = "SELECT idAuthors_Edit FROM authors_edit WHERE Authors_Edit_Name = '" + TB_Editor.Text.ToString() + "'";
                        cmdEditorID.CommandText = sqlEdit_ID;
                        int idEditor = (int)cmdEditorID.ExecuteScalar();

                        //-------------------------------ЗАПОЛНЕНИЕ КРОСС ТАБЛИЦЫ----------------------------------------------------
                        MySqlCommand cmdAhasE = connection.CreateCommand();
                        string sqlAhasE = "INSERT INTO authors_edit_has_authors (Authors_Edit_idAuthors_Edit, Authors_idAuthors) Values(@Authors_Edit_idAuthors_Edit, @Authors_idAuthors)";
                        cmdAhasE.CommandText = sqlAhasE;
                        cmdAhasE.Parameters.AddWithValue("Authors_Edit_idAuthors_Edit", idEditor);
                        cmdAhasE.Parameters.AddWithValue("Authors_idAuthors", idAuthors);
                        cmdAhasE.ExecuteNonQuery();
                   
                    //--------------------------------ДОБАВЛЕНИЕ СЦЕНАРИСТА ---------------------------------------------------

              
                        MySqlCommand cmdPlotAu = connection.CreateCommand();
                    string sqlPlotAu = "INSERT INTO authors_plot (Authors_Plot_Name) Values(@SW)";
                    cmdPlotAu.CommandText = sqlPlotAu;
                    cmdPlotAu.Parameters.AddWithValue("SW", TB_AuthorsR.Text);
                    cmdPlotAu.ExecuteNonQuery();

                    //-------------------------------ПОЛУЧЕНИЕ АЙДИ СЦЕНАРИСТА----------------------------------------------------
                    MySqlCommand cmdScriptWriterID = connection.CreateCommand();
                    string sqlSW_ID = "SELECT idAuthors_Plot FROM authors_plot WHERE Authors_Plot_Name = '" + TB_AuthorsR.Text.ToString() + "'";
                    cmdScriptWriterID.CommandText = sqlSW_ID;
                    int idScriptWriter = (int)cmdScriptWriterID.ExecuteScalar();

                    //-------------------------------ЗАПОЛНЕНИЕ КРОСС ТАБЛИЦЫ----------------------------------------------------
                    MySqlCommand cmdAhasSW = connection.CreateCommand();
                    string sqlAhasSW = "INSERT INTO authors_plot_has_authors (Authors_Plot_idAuthors_Plot, Authors_idAuthors) Values(@Authors_Plot_idAuthors_Plot, @Authors_idAuthors)";
                    cmdAhasSW.CommandText = sqlAhasSW;
                    cmdAhasSW.Parameters.AddWithValue("Authors_Plot_idAuthors_Plot", idScriptWriter);
                    cmdAhasSW.Parameters.AddWithValue("Authors_idAuthors", idAuthors);
                    cmdAhasSW.ExecuteNonQuery();
                
                    //--------------------------------ДОБАВЛЕНИЕ ИЛЛЮСТРАТОРА ---------------------------------------------------
                       MySqlCommand cmdIllu = connection.CreateCommand();
                        string sqlIllu = "INSERT INTO authors_illustration (Authors_illustration_Name) Values(@I)";
                        cmdIllu.CommandText = sqlIllu;
                        cmdIllu.Parameters.AddWithValue("I", TB_Illu.Text);
                        cmdIllu.ExecuteNonQuery();

                        //-------------------------------ПОЛУЧЕНИЕ АЙДИ ИЛЛЮСТРАТОРА----------------------------------------------------
                        MySqlCommand cmdIlluID = connection.CreateCommand();
                        string sqlIllu_ID = "SELECT idAuthors_illustration FROM authors_illustration WHERE Authors_illustration_Name = '" + TB_Illu.Text.ToString() + "'";
                        cmdIlluID.CommandText = sqlIllu_ID;
                        int idIllustator = (int)cmdIlluID.ExecuteScalar();

                        //-------------------------------ЗАПОЛНЕНИЕ КРОСС ТАБЛИЦЫ----------------------------------------------------
                        MySqlCommand cmdAhasI = connection.CreateCommand();
                        string sqlAhasI = "INSERT INTO authors_illustration_has_authors (Authors_illustration_idAuthors_illustration, Authors_idAuthors) Values(@Ill, @Au)";
                        cmdAhasI.CommandText = sqlAhasI;
                        cmdAhasI.Parameters.AddWithValue("Ill", idIllustator);
                        cmdAhasI.Parameters.AddWithValue("Au", idAuthors);
                        cmdAhasI.ExecuteNonQuery();
                   
                    //-------------------------------ПРОВЕРКА ЧТО У НАС ЕСТЬ ПЕРЕВОДЧИК+ДОБАВЛЕНИЕ----------------------------------------------------
                    
                        if (TB_Trans.Text != "")
                        {
                            //--------------------------------ДОБАВЛЕНИЕ ПЕРЕВОДЧИКА ---------------------------------------------------
                            MySqlCommand cmdTrans = connection.CreateCommand();
                            string sqlTrans = "INSERT INTO authors_translator (Authors_Translator_Name) Values(@Tr)";
                            cmdTrans.CommandText = sqlTrans;
                            cmdTrans.Parameters.AddWithValue("Tr", TB_Trans.Text);
                            cmdTrans.ExecuteNonQuery();

                            //-------------------------------ПОЛУЧЕНИЕ АЙДИ ПЕРЕВОДЧИКА----------------------------------------------------
                            MySqlCommand cmdTransID = connection.CreateCommand();
                            string sqlTrans_ID = "SELECT idAuthors_Translator FROM authors_translator WHERE Authors_Translator_Name = '" + TB_Trans.Text.ToString() + "'";
                            cmdTransID.CommandText = sqlTrans_ID;
                            int idTranslator = (int)cmdTransID.ExecuteScalar();

                            //-------------------------------ЗАПОЛНЕНИЕ КРОСС ТАБЛИЦЫ----------------------------------------------------
                            MySqlCommand cmdAhasT = connection.CreateCommand();
                            string sqlAhasT = "INSERT INTO authors_translator_has_authors (idauthors_translator_has_authors_authors_translator, idauthors_translator_has_authors_idAuthors) Values(@Trans, @Au)";
                            cmdAhasT.CommandText = sqlAhasT;
                            cmdAhasT.Parameters.AddWithValue("Trans", idTranslator);
                            cmdAhasT.Parameters.AddWithValue("Au", idAuthors);
                            cmdAhasT.ExecuteNonQuery();
                        }
                   

                    //--------------------------------ДОПОЛНИТЕЛЬНЫЕ АВТОРЫ------------------------------------------------------------
                    {
                        if (TB_AuthorsR1.Visible == true && TB_AuthorsR1.Text != "")
                        {
                            MySqlCommand cmdPlotAu1 = connection.CreateCommand();
                            string sqlPlotAu1 = "INSERT INTO authors_plot (Authors_Plot_Name) Values(@SW)";
                            cmdPlotAu1.CommandText = sqlPlotAu1;
                            cmdPlotAu1.Parameters.AddWithValue("SW", TB_AuthorsR1.Text);
                            cmdPlotAu1.ExecuteNonQuery();

                            //-------------------------------ПОЛУЧЕНИЕ АЙДИ СЦЕНАРИСТА----------------------------------------------------
                            MySqlCommand cmdScriptWriterID1 = connection.CreateCommand();
                            string sqlSW_ID1 = "SELECT idAuthors_Plot FROM authors_plot WHERE Authors_Plot_Name = '" + TB_AuthorsR1.Text.ToString() + "'";
                            cmdScriptWriterID1.CommandText = sqlSW_ID1;
                            int idScriptWriter1 = (int)cmdScriptWriterID1.ExecuteScalar();

                            //-------------------------------ЗАПОЛНЕНИЕ КРОСС ТАБЛИЦЫ----------------------------------------------------
                            MySqlCommand cmdAhasSW1 = connection.CreateCommand();
                            string sqlAhasSW1 = "INSERT INTO authors_plot_has_authors (Authors_Plot_idAuthors_Plot, Authors_idAuthors) Values(@Authors_Plot_idAuthors_Plot, @Authors_idAuthors)";
                            cmdAhasSW1.CommandText = sqlAhasSW1;
                            cmdAhasSW1.Parameters.AddWithValue("Authors_Plot_idAuthors_Plot", idScriptWriter1);
                            cmdAhasSW1.Parameters.AddWithValue("Authors_idAuthors", idAuthors);
                            cmdAhasSW1.ExecuteNonQuery();

                        }

                        if (TB_Illu1.Visible == true && TB_Illu.Text != "")
                        {
                            //--------------------------------ДОБАВЛЕНИЕ ИЛЛЮСТРАТОРА ---------------------------------------------------
                            MySqlCommand cmdIllu1 = connection.CreateCommand();
                            string sqlIllu1 = "INSERT INTO authors_illustration (Authors_illustration_Name) Values(@I)";
                            cmdIllu1.CommandText = sqlIllu1;
                            cmdIllu1.Parameters.AddWithValue("I", TB_Illu1.Text);
                            cmdIllu1.ExecuteNonQuery();

                            //-------------------------------ПОЛУЧЕНИЕ АЙДИ ИЛЛЮСТРАТОРА----------------------------------------------------
                            MySqlCommand cmdIlluID1 = connection.CreateCommand();
                            string sqlIllu_ID1 = "SELECT idAuthors_illustration FROM authors_illustration WHERE Authors_illustration_Name = '" + TB_Illu1.Text.ToString() + "'";
                            cmdIlluID1.CommandText = sqlIllu_ID1;
                            int idIllustator1 = (int)cmdIlluID1.ExecuteScalar();

                            //-------------------------------ЗАПОЛНЕНИЕ КРОСС ТАБЛИЦЫ----------------------------------------------------
                            MySqlCommand cmdAhasI1 = connection.CreateCommand();
                            string sqlAhasI1 = "INSERT INTO authors_illustration_has_authors (Authors_illustration_idAuthors_illustration, Authors_idAuthors) Values(@Ill, @Au)";
                            cmdAhasI1.CommandText = sqlAhasI1;
                            cmdAhasI1.Parameters.AddWithValue("Ill", idIllustator1);
                            cmdAhasI1.Parameters.AddWithValue("Au", idAuthors);
                            cmdAhasI1.ExecuteNonQuery();
                        }    

                        if (TB_Trans1.Visible ==true && TB_Trans1.Text != "")
                        {
                            //--------------------------------ДОБАВЛЕНИЕ ПЕРЕВОДЧИКА ---------------------------------------------------
                            MySqlCommand cmdTrans1 = connection.CreateCommand();
                            string sqlTrans1 = "INSERT INTO authors_translator (Authors_Translator_Name) Values(@Tr)";
                            cmdTrans1.CommandText = sqlTrans1;
                            cmdTrans1.Parameters.AddWithValue("Tr", TB_Trans1.Text);
                            cmdTrans1.ExecuteNonQuery();

                            //-------------------------------ПОЛУЧЕНИЕ АЙДИ ПЕРЕВОДЧИКА----------------------------------------------------
                            MySqlCommand cmdTransID1 = connection.CreateCommand();
                            string sqlTrans_ID1 = "SELECT idAuthors_Translator FROM authors_translator WHERE Authors_Translator_Name = '" + TB_Trans1.Text.ToString() + "'";
                            cmdTransID1.CommandText = sqlTrans_ID1;
                            int idTranslator1 = (int)cmdTransID1.ExecuteScalar();

                            //-------------------------------ЗАПОЛНЕНИЕ КРОСС ТАБЛИЦЫ----------------------------------------------------
                            MySqlCommand cmdAhasT1 = connection.CreateCommand();
                            string sqlAhasT1 = "INSERT INTO authors_translator_has_authors (idauthors_translator_has_authors_authors_translator, idauthors_translator_has_authors_idAuthors) Values(@Trans, @Au)";
                            cmdAhasT1.CommandText = sqlAhasT1;
                            cmdAhasT1.Parameters.AddWithValue("Trans", idTranslator1);
                            cmdAhasT1.Parameters.AddWithValue("Au", idAuthors);
                            cmdAhasT1.ExecuteNonQuery();
                        }

                    }


                    //--------------------------------ДОБАВЛЕНИЕ В МЕЙН---------------------------------------------------
                    MySqlCommand cmdMain = connection.CreateCommand();
                    string sqlMAIN = "INSERT INTO main (Name, Main_info, Age_rate, Comics_Info_id, Cycle_of_works_id, Authors_idAuthors) Values(@Name, @Main_info, @Age_rate, @Comics_Info_id, @Cycle_of_works_id, @Authors_idAuthors)";
                    cmdMain.CommandText = sqlMAIN;
                    cmdMain.Parameters.AddWithValue("Name", TB_Name.Text);
                    cmdMain.Parameters.AddWithValue("Main_info", TB_Type.Text);
                    cmdMain.Parameters.AddWithValue("Age_rate", TB_AgeRate.Text);
                    cmdMain.Parameters.AddWithValue("Comics_Info_id", idCI);
                    cmdMain.Parameters.AddWithValue("Cycle_of_works_id", idCycle);
                    cmdMain.Parameters.AddWithValue("Authors_idAuthors", idAuthors);
                    cmdMain.ExecuteNonQuery();

                    //-----------------------------ПОИСК АЙДИ НОВОЙ ЗАПИСИ МЕЙНА------------------------------------------------------
                    MySqlCommand cmdMain_ID = connection.CreateCommand();
                    string sqlMAIN_ID = "SELECT idMain FROM main WHERE Name = '" + TB_Name.Text.ToString() + "' ";
                    cmdMain_ID.CommandText = sqlMAIN_ID;
                    int idMain = (int)cmdMain_ID.ExecuteScalar();

                    //--------------------------------ЗАПИСЬ ЖАНРОВ---------------------------------------------------

                 
                    foreach (string s in checkedListBox1.CheckedItems.OfType<string>())
                    {
                        MySqlCommand cmdGenres = connection.CreateCommand();

                        string sqlGENRES = "INSERT INTO main_has_genre(Main_idMain, Genre_idGenre) Values(@Main, @Genre)";
                        cmdGenres.CommandText = sqlGENRES;
                        MySqlCommand cmdGenres_ID = connection.CreateCommand();
                        string sqlGENRES_ID = "SELECT idGenre FROM genre WHERE Genre_name = '" + s.ToString() + "' ";
                        cmdGenres_ID.CommandText = sqlGENRES_ID;
                        int idGenre = (int)cmdGenres_ID.ExecuteScalar();

                        cmdGenres.Parameters.AddWithValue("Main", idMain);
                        cmdGenres.Parameters.AddWithValue("Genre", idGenre);
                        cmdGenres.ExecuteNonQuery();

                    }
                    //-----------------------------------------------------------------------------------


                    connection.Close();

            }

            }
            catch
            {

            }
            finally
            {
                DialogResult dr2 = MessageBox.Show("Данные сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
            };



        }

        private void NextAppButt_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage1"];
        }
    }
}
