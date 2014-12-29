using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listview_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nametextBox.Text;
            string email = emailtextBox.Text;
            string address = adresstextBox.Text;

            ListViewItem items = new ListViewItem();
            items.Text = name;
            items.SubItems.Add(email);
            items.SubItems.Add(address);
            showlistView.Items.Add(items);


            // List<string> sTudent = new List<string>();
            // List<ListViewItem> n = new List<ListViewItem>();




        }

        
    }
}
