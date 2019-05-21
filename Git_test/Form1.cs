using System;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Git_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bCreateBD_Click(object sender, EventArgs e)
        {
            string databaseName = @"БАЗА_ДАННЫХ.db";
            SQLiteConnection.CreateFile(databaseName);
            label1.Text=(File.Exists(databaseName) ? "База данных создана" : "Возникла ошибка при создании базы данных");
        }

        private void bCreateT_Click(object sender, EventArgs e)
        {
            const string databaseName = @"БАЗА_ДАННЫХ.db";
            SQLiteConnection connection =
            new SQLiteConnection(string.Format("Data Source={0};", databaseName));
            SQLiteCommand command =
            new SQLiteCommand("CREATE TABLE ДОМ (id INTEGER PRIMARY KEY, floor INTEGER, entrance INTEGER, flat INTEGER);", connection); //НОМЕР ДОМА, КОЛ ЭТАЖЕЙ, КОЛ ПОДЪЕЗДОВ, КОЛ КВАРТИР
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void bGetSP_Click(object sender, EventArgs e)
        {
            const string databaseName = @"BD.db";
            SQLiteConnection connection =
            new SQLiteConnection(string.Format("Data Source={0};", databaseName));
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("SELECT name FROM sqlite_master WHERE type='table' ORDER BY name;", connection);
            SQLiteDataReader reader = command.ExecuteReader();
            foreach (DbDataRecord record in reader)              
            label3.Text = "Таблица: " + record["name"];
            connection.Close();
            label4.Text = "Готово";
        }
    }
}
