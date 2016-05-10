using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        RssManager reader = new RssManager();
        Collection<Rss.Items> list;
        ListViewItem row;

        private void addNewFeedUrlTestBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void getFeedButton_Click(object sender, EventArgs e)
        {
            try
            {
                reader.RssUrl = addNewFeedUrlTestBox.Text;
                reader.GetFeed();
                list = reader.RssItems;
                
                for(int i = 0; i < list.Count;i++)
                {
                    row = new ListViewItem();
                    row.Text = list[i].Title;
                    row.SubItems.Add(list[i].Link);
                    row.SubItems.Add(list[i].Date.ToShortDateString());
                    displayFeedItemsListBox.Items.Add(row);
                }  
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("You must provide a feed URL");
            }         

        }

        private void displayFeedItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (displayFeedItemsListBox.SelectedItems.Count == 1)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Title == (displayFeedItemsListBox.SelectedItems[0].ToString()))
                    {
                        feedItemDescritopnTextBox.Text = list[i].Description.Substring(0, 250);
                    }
                }
            }

        }

        private void displayFeedItemsListBox_DoubleClick(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(displayFeedItemsListBox.SelectedItems[0]);
        }


    }
}
