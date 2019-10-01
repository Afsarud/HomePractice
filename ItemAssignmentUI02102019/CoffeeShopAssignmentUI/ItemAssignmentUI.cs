using CoffeeShopAssignmentUI.BLL;
using CoffeeShopAssignmentUI.Model;
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

namespace CoffeeShopAssignmentUI
{
    public partial class ItemAssignmentUI : Form
    {
        ItemManager _itemManager = new ItemManager();
        Item _item = new Item();
        public ItemAssignmentUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            _itemManager.AddItem();
        }
       

    }
}
