using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopAssignmentUI.Repository
{
   public class ItemRepository
    {
        public void AddItem()
        {
            //Connection 
            string connectionString = @"sewrver= DESKTOP-U56OU4N\SA; Database=CoffeeShopAssignmentUI; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //Command
            string sqlcommand = @"INSERT INTO Items Values ('" + nameTextBox.Text + "', " + priceTextBox.Text + ")";
            SqlCommand sqlCommand = new SqlCommand();
        }
    }
}
