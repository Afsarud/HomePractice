using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop
{
    public partial class StudentIformatioListUi : Form
    {
        
        List<int> ids = new List<int>();
        List<string> names = new List<string>();
        List<string> mobiles = new List<string>();
        List<string> addresses = new List<string>();
        List<int> ages = new List<int>();
        List<double> gpases = new List<double>(); 

        public StudentIformatioListUi()
        {
            InitializeComponent();

            showAllButton.Enabled = false;
            searchButton.Enabled = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string id = stIdTextBox.Text;
            string name = stNameTextBox.Text;
            string mobile = stMobileTextBox.Text;
            string address = staddressTextBox.Text;
            string age = stageTextBox.Text;
            string gpa = stGpaTextBox.Text;

            if (id == "" || name == "" || mobile == "" || address == "" || age == "" || gpa == "") //null field checking
            {
                MessageBox.Show("Fill up all field");
                return;
            }
            if (id.Length != 4)  //field validation
            {
                MessageBox.Show("Enter four digit please");
                return;
            }
            if (name.Length > 30)
            {
                MessageBox.Show("max 30 digit ");
                return;
            }
            if (mobile.Length != 11)
            {
                MessageBox.Show("Enter 11 digit Please");
                return;
            }

            double gpaPoint = Convert.ToDouble(stGpaTextBox.Text);

            if (gpaPoint < 0 || gpaPoint > 4)
            {
                MessageBox.Show("GPA Please");
                return;
            }
            
            else
            {
                ids.Add(Convert.ToInt32(id));
                names.Add(name);
                mobiles.Add(mobile);
                addresses.Add(address);
                try
                {
                    ages.Add(Convert.ToInt32(age));
                }
                catch (Exception sd )
                {

                    MessageBox.Show("Please Enter numeric number!");
                }
               
                gpases.Add(Convert.ToDouble(gpa));
            }
            int index = ids.Count() - 1;
            showAllButton.Enabled = true;
            searchButton.Enabled = true;
            ShowStudentInfoOfDisplay(index,index);
        }
        private void ShowStudentInfoOfDisplay( int startIndex, int endIndex)
        {
            addedRichTextBox.Text = "";
            for (int i = startIndex; i <= endIndex; i++)
            {
                addedRichTextBox.Text += "ID: " + ids[i] + ", " + "Name: " + names[i] + ", " + "Mobile Number: " + mobiles[i] + ", " + "Address: " + "," + addresses[i] +
                    ", " + "Age: " + ages[i] + "," + "GPA: " + gpases[i]+"\n";

            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            ShowStudentInfoOfDisplay(0,ids.Count-1);  //All Added information show

            // Mark check
            double maxgpa = gpases.Max();
            int index = gpases.IndexOf(maxgpa);
            string name = names[index];
            maxGpaTextBox.Text = maxgpa.ToString();
            maxNameTextBox.Text = name.ToString();

            double mingpa = gpases.Min();
            index = gpases.IndexOf(mingpa);
            name = names[index];
            minGpaTextBox.Text = mingpa.ToString();
            minNameTextBox.Text = name.ToString();

            double total = gpases.Sum();
            double avareage = total / gpases.Count();
            avgGpatextBox.Text = avareage.ToString();
            totalMakrsTextBox.Text = total.ToString();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string search = searchTextBox.Text;

            if(search == "") //If Search field empty then show this massage
            {
                MessageBox.Show("Enter searching value");
                return;
            }
            int index = -1;
                if (idForRadioButton.Checked==true) 
            {
                try
                {
                    int searchId = Convert.ToInt32(search);
                    index = ids.IndexOf(searchId);
                }
                catch (Exception)
                {

                    MessageBox.Show("Enter Id Please");
                    return;
                }
                
            }
            else if (nameForRadioButton.Checked == true)
            {

              index = names.IndexOf(search);
              
            }
            else if (mobileForRadioButton.Checked==true)
            {

              index = mobiles.IndexOf(search);
                
            }
            if (index!=-1)
            {
                ShowStudentInfoOfDisplay(index, index);
                MessageBox.Show("Search Successful");
            }
            else
            {
                MessageBox.Show("Search Unsuccessful");
            }
        }
    }
}
