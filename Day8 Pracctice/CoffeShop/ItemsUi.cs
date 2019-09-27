using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop
{
    public partial class ItemsUi : Form
    {
        private SqlConnection sqlConnection;

        public ItemsUi()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            //Connection
            string connectionString = @"Server=DESKTOP-U56OU4N\SA; DataBase=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
           
            //Command
            string commandString = @"INSERT INTO Items VALUES ('" + nametextBox.Text + "','" + priceTextBox.Text + "')";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //sqlCommand.CommandText = commandString;
            //sqlCommand.Connection = sqlConnection;


            sqlConnection.Open();
            
            sqlCommand.ExecuteNonQuery();

            idTextBox.Hide();
            label3.Hide();
            nametextBox.Clear();
            priceTextBox.Clear();

            sqlConnection.Close();
            
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            //Connection
            string connectionString = @"Server=DESKTOP-U56OU4N\SA; DataBase=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandString = @"SELECT * FROM Items";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Show All Data
            sqlConnection.Open();
            SqlDataAdapter sqldataadapter = new SqlDataAdapter(sqlCommand);
            DataTable datatable = new DataTable();
            resultDataGridView.DataSource = datatable;
            sqldataadapter.Fill(datatable);

            idTextBox.Show();
            label3.Show();
            idTextBox.Clear();
            label1.Hide();
            label2.Hide();
            nametextBox.Hide();
            priceTextBox.Hide();

            sqlConnection.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //Connection
            string connectionString = @"Server=DESKTOP-U56OU4N\SA; DataBase=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandString = @"DELETE FROM Items where ItemId = "+idTextBox.Text+"";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //sqlCommand.CommandText = commandString;
            //sqlCommand.Connection = sqlConnection;


            sqlConnection.Open();


            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
