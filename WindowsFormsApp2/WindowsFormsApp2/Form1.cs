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
            RTB_ContDiscr.Text = applicationDataGridView.Rows[index].Cells[5].Value.ToString(); //предупреждение\ почему такое ограничение

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

        // TB_AuthorsR - текстбокс для измененных данных



        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            TB_AuthorsR1.Visible = true;
            btn.Click -= new EventHandler(button2_Click);
            btn.Click += new EventHandler(button2_Click_1);  
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            TB_AuthorsR2.Visible = true;
            btn.Click -= new EventHandler(button2_Click_1);
            btn.Click += new EventHandler(button2_Click_2);
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            TB_AuthorsR3.Visible = true;
        }

        private void AddIllusButt_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            TB_Illu1.Visible = true;
            btn.Click -= new EventHandler(AddIllusButt_Click);
            btn.Click += new EventHandler(AddIllusButt_Click_1);
        }

        private void AddIllusButt_Click_1(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            TB_Illu2.Visible = true;
            btn.Click -= new EventHandler(AddIllusButt_Click_1);
            btn.Click += new EventHandler(AddIllusButt_Click_2);
        }

        private void AddIllusButt_Click_2(object sender, EventArgs e)
        {
            TB_Illu3.Visible = true;
        }

        private void AddTransButt_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            TB_Trans1.Visible = true;
            btn.Click -= new EventHandler(AddTransButt_Click);
            btn.Click += new EventHandler(AddTransButt_Click_1); 
        }

        private void AddTransButt_Click_1(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            TB_Trans2.Visible = true;
            btn.Click -= new EventHandler(AddTransButt_Click_1);
            btn.Click += new EventHandler(AddTransButt_Click_2);
        }

        private void AddTransButt_Click_2(object sender, EventArgs e)
        {
            TB_Trans3.Visible = true;
        }

        private void AcceptApplButt_Click(object sender, EventArgs e)
        {

            //DialogResult dr = MessageBox.Show("Сохранить запись? Будьте внимательны: данные сохранятся в главную таблицу, а зявка будет удалена.", "Сохранение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            //if (dr == DialogResult.OK)
            //{

            try
            {

            

            string connectionString = "server = localhost; user id = root; password = root; database = mydb; persistsecurityinfo = True";
            using (MySqlConnection connection = new MySqlConnection(connectionString))


            {
                //------------------------------------------------------

                /*  MySqlCommand commandTEST = connection.CreateCommand();

                  string sql1 = "insert into cycle_of_works (Cycle_of_works_Name) Values(@Cycle_of_works_Name)";
                  commandTEST.CommandText = sql1;
                  commandTEST.Parameters.AddWithValue("Cycle_of_works_Name", TB_Cycle.Text);
                  commandTEST.ExecuteNonQuery();
                  //------------------------------------------------------

                  MySqlCommand commandAuthor_Edit = connection.CreateCommand();
                  MySqlCommand commandAuthor_Edit_Id = connection.CreateCommand();
                  MySqlCommand commandAuthor_Edit_SELECT = connection.CreateCommand();



                  string sql2 = "insert into authors_edit (Authors_Edit_Name) Values(@Authors_Edit_Name)";
                  commandAuthor_Edit.CommandText = sql2;
                  commandAuthor_Edit.Parameters.AddWithValue("Authors_Edit_Name", TB_Editor.Text);
                 // string AaA = TB_Editor.Text.ToString();
                  commandAuthor_Edit.ExecuteNonQuery();

                  string sql3 = "select idAuthors_Edit form authors_edit where Authors_Edit_Name = '"+ TB_Editor.Text.ToString() + "' ";

                  string sqlEd = "insert into authors_edit_has_authors (Authors_Edit_idAuthors_Edit, Authors_idAuthors) Values(@idAuthors_Edit, '1')";
                //  string sqlEd2 = "insert into authors_edit_has_authors (Authors_idAuthors) Values('1')";



                  commandAuthor_Edit_Id.CommandText = sqlEd;

                  commandTEST.Parameters.AddWithValue("Authors_Edit_idAuthors_Edit", commandAuthor_Edit_SELECT.CommandText = sql3);
                  commandAuthor_Edit.ExecuteNonQuery(); */

                //------------------------------------------------------
                //string License = "Нет лицензии";

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

                    //----------------------ЗАПОЛНЕНИЕ ТАБЛИЦЫ ЦИКЛ РАБОТ -----------------------------------
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
                    string sqlCycle = "SELECT * FROM cycle_of_works WHERE Cycle_of_works_Name = 'Пиджаки и револьверы' ";


                    MySqlCommand cmdCycle = new MySqlCommand(sqlCycle, connection);
                    cmdCycle.Parameters.AddWithValue("Cycle_of_works_Name", TB_Cycle.Text);
                    object result = cmdCycle.ExecuteScalar();                

                    if (result == null)
                    {
                        string sqlCycle2 = "INSERT INTO cycle_of_works (Cycle_of_works_Name) Values(@Cycle_of_works_Name)";
                        MySqlCommand cmdCycle2 = new MySqlCommand(sqlCycle2, connection);
                        
                          cmdCycle.CommandText = sqlCycle2;
                          cmdCycle.Parameters.AddWithValue("Cycle_of_works_Name", TB_Cycle.Text);
                          cmdCycle.ExecuteNonQuery();
                    }

                    //-----------------------------------------------------------------------------------


                    //-----------------------------------------------------------------------------------
                    MySqlCommand cmdMain = connection.CreateCommand();
                string sqlMAIN = "INSERT INTO main (Name, Main_info, Age_rate,Comics_Info_id) Values(@Name, @Main_info, @Age_rate, @Comics_Info_id)";
                cmdMain.CommandText = sqlMAIN;
                cmdMain.Parameters.AddWithValue("Name", TB_Name.Text);
                cmdMain.Parameters.AddWithValue("Main_info", TB_Type.Text);
                cmdMain.Parameters.AddWithValue("Age_rate", TB_AgeRate.Text);
                cmdMain.Parameters.AddWithValue("Comics_Info_id", idCI);
                cmdMain.ExecuteNonQuery();
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


            // }

            //  this.applicationTableAdapter.Insert(;


        }
    }
}
