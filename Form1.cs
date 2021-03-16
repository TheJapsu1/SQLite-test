using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace sqlite_testi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "SQLite test";
            CreateTable();
            ReadData();
            debugLabel.Text = "initialized successfully";
        }

        SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source= database.db; Version = 3; New = True; Compress = True; ");

            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return sqlite_conn;
        }

        void CreateTable()
        {
            try
            {
                SQLiteConnection conn = CreateConnection();
                SQLiteCommand sqlite_cmd;
                string Table = "CREATE TABLE People(FirstName VARCHAR(20), LastName VARCHAR(20), Address VARCHAR(20))";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = Table;
                sqlite_cmd.ExecuteNonQuery();
                debugLabel.Text = "table created";
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        void RemoveTable()
        {
            try
            {
                SQLiteConnection conn = CreateConnection();
                SQLiteCommand sqlite_cmd;
                string Table = "DROP TABLE People";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = Table;
                sqlite_cmd.ExecuteNonQuery();
                debugLabel.Text = "table removed";
                contentsView.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void InsertData()
        {
            SQLiteConnection conn = CreateConnection();
            CreateTable();
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = $"INSERT INTO People (FirstName, LastName, Address) VALUES('{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}'); ";
            sqlite_cmd.ExecuteNonQuery();
            debugLabel.Text = "data inserted";
        }

        void ReadData()
        {
            try
            {
                SQLiteConnection conn = CreateConnection();
                SQLiteDataReader sqlite_datareader;
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM People";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                debugLabel.Text = "data read";

                contentsView.Clear();

                contentsView.Columns.Add("Etunimet", -2, HorizontalAlignment.Left);
                contentsView.Columns.Add("Sukunimet", -2, HorizontalAlignment.Left);
                contentsView.Columns.Add("Osoitteet", -2, HorizontalAlignment.Left);

                List<ListViewItem> items = new List<ListViewItem>();

                while (sqlite_datareader.Read())
                {
                    ListViewItem item = new ListViewItem(sqlite_datareader.GetString(0));
                    item.SubItems.Add(sqlite_datareader.GetString(1));
                    item.SubItems.Add(sqlite_datareader.GetString(2));
                    items.Add(item);
                }

                contentsView.Items.AddRange(items.ToArray());
                contentsView.Columns[0].Width = 90;
                contentsView.Columns[1].Width = 90;
                contentsView.Columns[2].Width = 90;

                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        string targets;
        void ReadData(string target)
        {
            targets = target;
            try
            {
                SQLiteConnection conn = CreateConnection();
                SQLiteDataReader sqlite_datareader;
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM People WHERE FirstName LIKE '%" + target + "%' OR LastName LIKE '%" + target + "%'  OR Address LIKE '%" + target + "%'";
                sqlite_datareader = sqlite_cmd.ExecuteReader();

                contentsView.Clear();

                contentsView.Columns.Add("Etunimet", -2, HorizontalAlignment.Left);
                contentsView.Columns.Add("Sukunimet", -2, HorizontalAlignment.Left);
                contentsView.Columns.Add("Osoitteet", -2, HorizontalAlignment.Left);

                List<ListViewItem> items = new List<ListViewItem>();

                while (sqlite_datareader.Read())
                {
                    ListViewItem item = new ListViewItem(sqlite_datareader.GetString(0));
                    item.SubItems.Add(sqlite_datareader.GetString(1));
                    item.SubItems.Add(sqlite_datareader.GetString(2));
                    items.Add(item);
                }

                contentsView.Items.AddRange(items.ToArray());
                contentsView.Columns[0].Width = 90;
                contentsView.Columns[1].Width = 90;
                contentsView.Columns[2].Width = 90;
                debugLabel.Text = searchField.Text;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            InsertData();
            ReadData();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            RemoveTable();
        }

        private void deleteResultButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItems = contentsView.SelectedItems;
                if (selectedItems == null)
                    return;

                SQLiteConnection conn = CreateConnection();
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                for (int i = selectedItems.Count - 1; i > -1; i--)
                {
                    sqlite_cmd.CommandText = "DELETE FROM People WHERE FirstName = '" + selectedItems[i].Text + "' OR LastName = '" + selectedItems[i].Text + "'  OR Address = '" + selectedItems[i].Text + "'";
                    sqlite_cmd.ExecuteNonQuery();
                    contentsView.SelectedItems[i].Remove();
                }
                

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void searchField_TextChanged(object sender, EventArgs e)
        {
            if (searchField.Text != "")
                ReadData(searchField.Text);
            else
                ReadData();
        }
    }
}
