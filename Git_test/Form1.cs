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
        Random rnd = new Random();
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
            new SQLiteCommand("CREATE TABLE streets (id INTEGER PRIMARY KEY , name_street TEXT);", connection); //НОМЕР  УЛИЦЫ, ИМЯ УЛИЦЫ (name+id: 1 name1, 2 name2)
            command.ExecuteNonQuery();

            //СОЗДАНИЕ ТАБЛ ДОМА
            command =
            new SQLiteCommand("CREATE TABLE houses (id INTEGER PRIMARY KEY , name_street TEXT, count_floor INTEGER, count_entrance INTEGER, count_flat INTEGER,  FOREIGN KEY(name_street) REFERENCES streets(name_street));", connection); //НОМЕР ДОМА, Имя улицы, КОЛ ЭТАЖЕЙ, КОЛ ПОДЪЕЗДОВ, КОЛ КВАРТИР
            command.ExecuteNonQuery();

            connection.Close();
        }

        private void bGetSP_Click(object sender, EventArgs e)
        {
            label3.Text = "";

            connection.Open();
            command = new SQLiteCommand("SELECT name FROM sqlite_master WHERE type='table' ORDER BY name;", connection);
            SQLiteDataReader reader = command.ExecuteReader();
            foreach (DbDataRecord record in reader)              
            label3.Text +=record["name"]+ " ";
            connection.Close();
            label4.Text = "Готово";
        }

        private void bZapolnenie_Click(object sender, EventArgs e)
        {
            connection.Open();
            int streets = Convert.ToInt32(tStreets.Text);
            int houses = Convert.ToInt32(tHouses.Text);
            string name;
            for (int i = 1; i <= streets; i++)//заполнение улиц
            {
                name = "name" + i;
                command =
            new SQLiteCommand("INSERT INTO 'streets' (name_street) VALUES ('name');", connection);
                command.ExecuteNonQuery();
            }
            
            
            int floor, entrance, flat;
            int randstreet;
            for (int i = 1; i <= houses; i++)
            {
                floor = rnd.Next(1,20);
                entrance = rnd.Next(1, 6);
                flat = rnd.Next(10, 500);
                randstreet = rnd.Next(1, streets + 1);
                name = "name" + i;
                command =
            new SQLiteCommand("INSERT INTO 'houses' (name_street, count_floor, count_entrance, count_flat) VALUES ('name', 'floor', 'entrance', 'flat');", connection);
                command.ExecuteNonQuery();
            }
            
            connection.Close();
        }

        private void bDeleteT_Click(object sender, EventArgs e) //удаление всех таблиц
        {
            connection.Open();
            command =
            new SQLiteCommand("DROP TABLE IF EXISTS 'houses';", connection);
            command.ExecuteNonQuery();
            
            command =
            new SQLiteCommand("DROP TABLE IF EXISTS 'streets';", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void bZapros_Click(object sender, EventArgs e)
        {
            connection.Open();
            int rand_id_str = rnd.Next(1, Convert.ToInt32(tStreets.Text)+1);
            string namestr = "name" + rand_id_str;
            command =
            new SQLiteCommand("SELECT houses.* FROM streets, houses where houses.name_street = streets.name_street AND streets.name_street='namestr';", connection);
            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
