﻿using System;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Git_test
{
    public partial class Form1 : Form
    {
        const string databaseName = @"BD.db"; //НАЗВАНИЕ БД
        SQLiteConnection connection;
        SQLiteCommand command;
        Random rnd = new Random();
        List<string> name = new List<string>();
        List<int> floor = new List<int>();
        List<int> entrance = new List<int>();
        List<int> flat = new List<int>();
        List<string> randstreet = new List<string>();
        int streets;
        int houses;
        public Form1()
        {
            InitializeComponent();
            connection =
            new SQLiteConnection(string.Format("Data Source={0};", databaseName));
        }
       
        private void bCreateBD_Click(object sender, EventArgs e) //СОЗДАНИЕ БАЗЫ ДАННЫХ
        {
            SQLiteConnection.CreateFile(databaseName);
            label1.Text=(File.Exists(databaseName) ? "База данных создана" : "Возникла ошибка при создании базы данных");
        }

        private void bCreateT_Click(object sender, EventArgs e) //СОЗДАНИЕ ТАБЛИЦ
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
            label2.Text = "Таблицы созданы";
        }

        private void bGetSP_Click(object sender, EventArgs e) //ПРОВЕРКА НА СУЩЕСТВОВАНИЕ ТАБЛИЦ
        {
            label4.Text = "";
            connection.Open();
            command = new SQLiteCommand("SELECT name FROM sqlite_master WHERE type='table' ORDER BY name;", connection);
            SQLiteDataReader reader = command.ExecuteReader();
            foreach (DbDataRecord record in reader)              
            label4.Text +="' " + record["name"]+ " '" + " ";
            connection.Close();
        }

        private void bZapolnenie_Click(object sender, EventArgs e) //ЗАПОЛНЕНИЕ ТАБЛИЦ (INSERT)
        {
            l_InfoZapoln.Text = "";
            DateTime dt = DateTime.Now;
            connection.Open();
            for (int i = 0; i < streets; i++)//заполнение улиц
            {
                command =
            new SQLiteCommand("INSERT INTO 'streets' (name_street) VALUES ('"+name[i]+"');", connection);
                command.ExecuteNonQuery();
            }
            
            for (int i = 0; i < houses; i++)//заполнение домов
            {
                string z = randstreet[i];
                command =
                new SQLiteCommand("INSERT INTO 'houses' ('name_street', 'count_floor', 'count_entrance', 'count_flat') VALUES ('"+z+"', '"+floor[i]+"', '"+entrance[i]+"', '"+flat[i]+"');", connection);
                command.ExecuteNonQuery();
            }
            connection.Close();
            l_InfoZapoln.Text = "Готово";
            TimeSpan sp = DateTime.Now - dt;
            lZapoln.Text = sp.ToString();
        }

        private void bDeleteT_Click(object sender, EventArgs e) //удаление всех таблиц
        {
            label6.Text = "";
            connection.Open();
            command =
            new SQLiteCommand("DROP TABLE IF EXISTS 'houses';", connection);
            command.ExecuteNonQuery();
            
            command =
            new SQLiteCommand("DROP TABLE IF EXISTS 'streets';", connection);
            command.ExecuteNonQuery();
            connection.Close();
            label6.Text = "Таблицы удалены";
        }

        private void bZapros_Click(object sender, EventArgs e) // ЗАПРОС СЛУЧАЙНО СГЕНЕРИРОВАВШЕЙСЯ УЛИЦЫ (ВЫВОДИМ НОМЕР ДОМА, НОМЕР УЛИЦЫ, ДАННЫЕ О ДОМЕ)
        {
            l_InfoSelect.Text = "";
            listBox1.Items.Clear();
            DateTime dt = DateTime.Now;
            connection.Open();
            int rand_id_str = rnd.Next(1, Convert.ToInt32(tStreets.Text)+1);
            string namestr = "name" + rand_id_str;
            command =
            new SQLiteCommand("SELECT houses.* FROM  houses, streets where houses.name_street = streets.name_street AND streets.name_street='"+namestr+"';", connection); //Выводим всю информацию о домах, которые находятся на определнной улице
            command.ExecuteNonQuery();
            SQLiteDataReader reader = command.ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                string id = record["id"].ToString();
                string name_street = record["name_street"].ToString();
                string count_floor = record["count_floor"].ToString();
                string count_entrance = record["count_entrance"].ToString();
                string count_flat = record["count_flat"].ToString();
                string result = id + "    ";
                result += name_street + "    ";
                result += count_floor + "    ";
                result += count_entrance + "    ";
                result += count_flat + "    ";

                listBox1.Items.Add(result);
            }
            connection.Close();
            l_InfoSelect.Text = "Готово";
            TimeSpan sp = DateTime.Now - dt;
            lSelect.Text = sp.ToString();
        }

        
        private void bGeneration_Click(object sender, EventArgs e) //ГЕНЕРАЦИЯ ДЛЯ ГРУППЫ ЗАПРОСОВ
        {
            lGener.Text = "";
            l_InfoGener.Text = "";
            streets = Convert.ToInt32(tStreets.Text); //заданное колво улиц
            houses = Convert.ToInt32(tHouses.Text);  // заданное колво домов
            randstreet.Clear();
            DateTime dt = DateTime.Now;
            Generate();
            TimeSpan sp = DateTime.Now - dt;
            l_InfoGener.Text = "Готово";
            lGener.Text = sp.ToString();
        }
        public void Generate()//создание и заполнение списков значениями для вставки в таблицы
        {
            name.Clear();
            floor.Clear();
            entrance.Clear();
            flat.Clear();
            //randstreet.Clear();
            for (int i = 1; i <= streets; i++)
            {
                name.Add("name" + i);
            }
            for (int i = 0; i < houses; i++)
            {
                floor.Add(rnd.Next(1, 20));
                entrance.Add(rnd.Next(1, 6));
                flat.Add(rnd.Next(10, 500));
                randstreet.Add("name" + rnd.Next(1, streets + 1));
            }
        }

        private void bUpdate_Click(object sender, EventArgs e) //ИЗМЕНЯЕМ ДАННЫЕ ДЛЯ КАЖДОГО ДОМА
        {
            l_InfoUpdate.Text = "";
            Generate();
            DateTime dt = DateTime.Now;
            connection.Open();
            int id1;
            for (int i = 0; i < houses; i++)//заполнение домов
            {
                id1 = i + 1;
                string z = randstreet[i];
                command =
                new SQLiteCommand("UPDATE 'houses' SET 'name_street'='" + z + "', 'count_floor'='" + floor[i] + "', 'count_entrance'='" + entrance[i] + "', 'count_flat'='" + flat[i]+"' WHERE id='"+ id1 +"';", connection);
                command.ExecuteNonQuery();
            }
            connection.Close();
            l_InfoUpdate.Text = "Готово";
            TimeSpan sp = DateTime.Now - dt;
            lUpdate.Text = sp.ToString();
        }
    }
}
