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
        const string databaseName = @"BD.db";
        SQLiteConnection connection;
        SQLiteCommand command;
        Random rnd = new Random();
        int a = 0;
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
            label2.Text = "Таблицы созданы";
        }

        private void bGetSP_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            connection.Open();
            command = new SQLiteCommand("SELECT name FROM sqlite_master WHERE type='table' ORDER BY name;", connection);
            SQLiteDataReader reader = command.ExecuteReader();
            foreach (DbDataRecord record in reader)              
            label4.Text +="' " + record["name"]+ " '" + " ";
            connection.Close();
        }

        private void bZapolnenie_Click(object sender, EventArgs e)
        {
            
            int streets = Convert.ToInt32(tStreets.Text); //заданное колво улиц
            int houses = Convert.ToInt32(tHouses.Text);  // заданное колво домов

            List <string> name = new List<string>();
            for (int i = 1; i <= streets; i++)
            {
                name.Add("name" + i);
            }
            List<int> floor = new List<int>();
            List<int> entrance = new List<int>();
            List<int> flat = new List<int>();
            List<string> randstreet = new List<string>();
            for (int i = 0; i < houses; i++)
            {
                floor.Add(rnd.Next(1, 20));
                entrance.Add(rnd.Next(1, 6));
                flat.Add(rnd.Next(10, 500));
                randstreet.Add("name"+rnd.Next(1, streets + 1));
            }//создание и заполнение списков значениями для вставки в таблицы
            DateTime dt = DateTime.Now;
            connection.Open();
            for (int i = 0; i < streets; i++)//заполнение улиц
            {
                command =
            new SQLiteCommand("INSERT INTO 'streets' (name_street) VALUES ('name[i]');", connection);
                command.ExecuteNonQuery();
                //timer1.Enabled = false;
                //label11.Text = a.ToString();
            }
            
            for (int i = 0; i < houses; i++)//заполнение домов
            {
                command =
            new SQLiteCommand("INSERT INTO 'houses' (name_street, count_floor, count_entrance, count_flat) VALUES ('randstreet[i]', 'floor[i]', 'entrance[i]', 'flat[i]');", connection);
                command.ExecuteNonQuery();
            }
            
            connection.Close();
            label9.Text = "Готово";
            TimeSpan sp = DateTime.Now - dt;
            label11.Text = sp.ToString();
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
            label6.Text = "Таблицы удалены";
        }

        private void bZapros_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            connection.Open();
            int rand_id_str = rnd.Next(1, Convert.ToInt32(tStreets.Text)+1);
            string namestr = "name" + rand_id_str;
            command =
            new SQLiteCommand("SELECT houses.* FROM streets, houses where houses.name_street = streets.name_street AND streets.name_street='namestr';", connection); //Выводим всю информацию о домах, которые находятся на определнной улице
            command.ExecuteNonQuery();
            connection.Close();
            label10.Text = "Готово";
            TimeSpan sp = DateTime.Now - dt;
            label11.Text = sp.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
