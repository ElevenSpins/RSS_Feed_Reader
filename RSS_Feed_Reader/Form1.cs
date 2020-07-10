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
            //für jedes item wird die passende Discription abgerufen und dargestellt
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
            //beim erneten laden alte Items "löschen"
            titlesComboBox.Items.Clear();
            
            //Methoden aufruf mit URL
            fc.fillFeed(URLtextBox.Text);

            //befüllen der titlesComboBox
            foreach (var item in fc.filledFeed.Items)
            {
                titlesComboBox.Items.Add(item.Title);
            }



        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //fügt die URL in die List Box hinzu
            SavedListBox.Items.Add(URLtextBox.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
