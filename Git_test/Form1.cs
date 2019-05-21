using System;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Git_test
{
    public partial class Form1 : Form
    {
        const string databaseName = @"BD.db";
        SQLiteConnection connection;
        SQLiteCommand command;

        public Form1()
        {
            InitializeComponent();
            connection =
            new SQLiteConnection(string.Format("Data Source={0};", databaseName));
        }
       

        private void bCreateBD_Click(object sender, EventArgs e)
        {

            SQLiteConnection.CreateFile(databaseName);
            label1.Text=(File.Exists(databaseName) ? "База данных создана" : "Возникла ошибка при создании базы данных");

        }

        private void bCreateT_Click(object sender, EventArgs e)
        {
            connection.Open();

            //СОЗДАНИЕ ТАБЛ УЛИЦЫ
            command =
            new SQLiteCommand("CREATE TABLE streets (id INTEGER PRIMARY KEY, name_street TEXT);", connection); //НОМЕР  УЛИЦЫ, ИМЯ УЛИЦЫ (name+id: 1 name1, 2 name2)
            command.ExecuteNonQuery();

            //СОЗДАНИЕ ТАБЛ ДОМА
            command =
            new SQLiteCommand("CREATE TABLE houses (id INTEGER PRIMARY KEY, name_street TEXT, count_floor INTEGER, count_entrance INTEGER, count_flat INTEGER,  FOREIGN KEY(name_street) REFERENCES streets(name_street));", connection); //НОМЕР ДОМА, Имя улицы, КОЛ ЭТАЖЕЙ, КОЛ ПОДЪЕЗДОВ, КОЛ КВАРТИР
            command.ExecuteNonQuery();

            connection.Close();
        }

        private void bGetSP_Click(object sender, EventArgs e)
        {
           
            connection.Open();
            command = new SQLiteCommand("SELECT name FROM sqlite_master WHERE type='table' ORDER BY name;", connection);
            SQLiteDataReader reader = command.ExecuteReader();
            foreach (DbDataRecord record in reader)              
            label3.Text +=record["name"]+ " ";
            connection.Close();
            label4.Text = "Готово";
        }

   
    }
}
