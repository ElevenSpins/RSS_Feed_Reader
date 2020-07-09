using CodeHollow.FeedReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSS_Feed_Reader
{
    public partial class Form1 : Form
    {
        FeedContent fc = new FeedContent();

        public Form1()
        {
            InitializeComponent();
            
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in fc.filledFeed.Items)
            {
                if (item.Title == titlesComboBox.SelectedItem.ToString())
                {
                    contentRichTextBox.Text = item.Description;
                }
                
            }
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            fc.fillFeed(URLtextBox.Text);


            foreach (var item in fc.filledFeed.Items)
            {
                titlesComboBox.Items.Add(item.Title);
            }



        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SavedListBox.Items.Add(URLtextBox.Text);
        }
    }
}
