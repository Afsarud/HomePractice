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

        public ItemsUi()
        {
            InitializeComponent();
            idTextBox.Hide();
            idLabel.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isUnique = CheckUniqueName(nameTextBox.Text);
            if (isUnique)
            {
                MessageBox.Show("already exsit");
                return;
            }
            try
            {
                bool isAdded = Add(nameTextBox.Text, Convert.ToDouble(priceTextBox.Text));
                if (isAdded)
                {
                    MessageBox.Show("saved");
                }
                else
                {
                    MessageBox.Show("Not Saved");
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
           

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!showResult())
            {
                MessageBox.Show("Data Not found");
            }
            idTextBox.Show();
            idLabel.Show();
            idTextBox.Clear();

        }
        private void button3_Click(object sender, EventArgs e)
        {

            if (searchTextBox.Text == null)
            {
                MessageBox.Show("Field is empty");
            }

            if (searchData(searchTextBox.Text))
            {
                MessageBox.Show("Data found");
            }
            else
            {
                MessageBox.Show("Not Match");
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (deleteData())
            {
                MessageBox.Show("Delete successfull");
            }
            else
            {
                MessageBox.Show("Delete Unsuccessfull");
            }
        }


        private bool CheckUniqueName (string name)
        {
            bool isUnique = false;
            string connectionString = @"server=DESKTOP-U56OU4N\SA; database= CoffeeShop; Integrated Security= True";
            SqlConnection sqlconnection = new SqlConnection(connectionString);

            string sqlcommand = @"Select * from Items Where Name='"+name +"'"; 
            SqlCommand sqlCommand = new SqlCommand(sqlcommand, sqlconnection);

            sqlconnection.Open();
            SqlDataAdapter sqldataadapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            showDataGridView.DataSource = dataTable;
            sqldataadapter.Fill(dataTable);
            sqlconnection.Close();

            if (dataTable.Rows.Count > 0)
            {
                isUnique = true;
            }

            return isUnique;
            
        }
        private bool Add (string name, double Price)
        {
            bool Isadded = true;
            try
            {
                string connectionString = @"server=DESKTOP-U56OU4N\SA; database= CoffeeShop; Integrated Security= True";
                SqlConnection sqlconnection = new SqlConnection(connectionString);

                string sqlcommand = @"insert into Items values ('" + nameTextBox.Text + "', " + priceTextBox.Text + ");";
                SqlCommand sqlCommand = new SqlCommand(sqlcommand, sqlconnection);

                sqlconnection.Open();
                SqlDataAdapter sqldataadapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                showDataGridView.DataSource = dataTable;
                sqldataadapter.Fill(dataTable);
                sqlconnection.Close();


                if (dataTable.Rows.Count > 0)
                {
                    Isadded = true;
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
           
            return Isadded;
        }
        private bool showResult()
        {
            bool isShow = false;
            string connectionString = @"server=DESKTOP-U56OU4N\SA; database= CoffeeShop; Integrated Security= True";
            SqlConnection sqlconnection = new SqlConnection(connectionString);

            string sqlcommand = @"Select * from Items";
            SqlCommand sqlCommand = new SqlCommand(sqlcommand, sqlconnection);

            sqlconnection.Open();
            SqlDataAdapter sqldataadapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            showDataGridView.DataSource = dataTable;
            sqldataadapter.Fill(dataTable);
            sqlconnection.Close();

            if (dataTable.Rows.Count > 0)
            {
                isShow = true;
            }

            return isShow;
        } 
        private bool searchData(string name)
        {
            bool isFound = false;
            string connectionString = @"server=DESKTOP-U56OU4N\SA; database= CoffeeShop; Integrated Security= True";
            SqlConnection sqlconnection = new SqlConnection(connectionString);

            string sqlcommand = @"Select * from Items Where Name='" + name + "'";
            SqlCommand sqlCommand = new SqlCommand(sqlcommand, sqlconnection);

            sqlconnection.Open();
            SqlDataAdapter sqldataadapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            showDataGridView.DataSource = dataTable;
            sqldataadapter.Fill(dataTable);
            sqlconnection.Close();

            if (dataTable.Rows.Count > 0)
            {
                isFound = true;
            }

            return isFound;
        }
        private bool deleteData()
        {
            bool isDelete = true;
            string connectionString = @"server=DESKTOP-U56OU4N\SA; database= CoffeeShop; Integrated Security= True";
            SqlConnection sqlconnection = new SqlConnection(connectionString);
            //CommandStatement
            string sqlcommand = @"Delete Items where ItemId ="+ idTextBox.Text+ "";
            SqlCommand sqlCommand = new SqlCommand(sqlcommand, sqlconnection);

            sqlconnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlconnection.Close();
            return isDelete;
        }
    }
}
