﻿using MyWindowsFormsApp.BLL;
using MyWindowsFormsApp.Model;
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

namespace MyWindowsFormsApp
{
    public partial class ItemUi : Form
    {
        Itemmanager _itemManager = new Itemmanager();
        Item _item = new Item();
       
        public ItemUi()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            _item.Name = nameTextBox.Text;
            //Check UNIQUE
            if (_itemManager.IsNameExists(_item.Name))
            {
                MessageBox.Show(nameTextBox.Text + "Already Exists!");
                return;
            }

            //Set Price as Mandatory
            if (String.IsNullOrEmpty(priceTextBox.Text))            
            {
                MessageBox.Show("Price Can not be Empty!!!");
                return;
            }

            _item.Price = Convert.ToDouble(priceTextBox.Text);

            //Add/Insert Item
            bool isAdded =  _itemManager.Add(_item);

            if (isAdded)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not Saved");
            }

            showDataGridView.DataSource = _itemManager.Display();
            nameTextBox.Clear();
            priceTextBox.Clear();
            idtextBox.Clear();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _itemManager.Display();
            nameTextBox.Clear();
            priceTextBox.Clear();
            idtextBox.Clear();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //Set Id as Mandatory
            if (String.IsNullOrEmpty(idtextBox.Text))
            {
                MessageBox.Show("Id Can not be Empty!!!");
                return;
            }

            //Delete
            if (_itemManager.Delete(Convert.ToInt32(idtextBox.Text)))
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }

            showDataGridView.DataSource = _itemManager.Display();
            nameTextBox.Clear();
            priceTextBox.Clear();
            idtextBox.Clear();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //Set Id as Mandatory
            if (String.IsNullOrEmpty(idtextBox.Text))
            {
                MessageBox.Show("Id Can not be Empty!!!");
                return;
            }
            //Set Price as Mandatory
            if (String.IsNullOrEmpty(priceTextBox.Text))
            {
                MessageBox.Show("Price Can not be Empty!!!");
                return;
            }
            _item.Name = nameTextBox.Text;
            _item.Price = Convert.ToDouble(priceTextBox.Text);
            _item.ItemId = Convert.ToInt32(idtextBox.Text);
            if (_itemManager.Update(_item.Name, Convert.ToDouble(_item.Price), Convert.ToInt32(_item.ItemId)))
            {
                MessageBox.Show("Updated");
                showDataGridView.DataSource = _itemManager.Display();
            }
            else
            {
                MessageBox.Show("Not Updated");
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            //Set Price as Mandatory
            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Eield is Empty!");
                return;
            }

            showDataGridView.DataSource =
           _itemManager.Search(nameTextBox.Text);
            nameTextBox.Clear();
            priceTextBox.Clear();
            idtextBox.Clear();
        }
        
        //Method transfer to repository
        private void ItemUi_Load(object sender, EventArgs e)
        {
            itemComboBox.DataSource =_itemManager.ItemCombobox();
        }
        
    }
}
