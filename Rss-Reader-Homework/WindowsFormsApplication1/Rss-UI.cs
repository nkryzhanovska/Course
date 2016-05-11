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

        RssManager CurrentFeed;
        
        

        private void addNewFeedUrlTestBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void getFeedButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(addNewFeedUrlTestBox.Text))
            {
                displayFeedItemsListBox.Items.Clear();
                
                CurrentFeed = new RssManager(addNewFeedUrlTestBox.Text);
               
                for (int i = 0; i < CurrentFeed.Items.Count; i++)
                {
                    if (CurrentFeed.Items[i] != null)
                    {
                        displayFeedItemsListBox.Items.Add(CurrentFeed.Items[i].Title);
                    }
                    
                } 
                displayFeedItemsListBox.SelectedIndex = 0;
                                
            }            

        }

        private void displayFeedItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentFeed.Items[displayFeedItemsListBox.SelectedIndex].Description != null)
            {
                feedDescriptionWebBrowser.DocumentText = CurrentFeed.Items[displayFeedItemsListBox.SelectedIndex].Description;
                //feedItemDescritopnTextBox.Text = CurrentFeed.Items[displayFeedItemsListBox.SelectedIndex].Description;
            }

            if (CurrentFeed.Items[displayFeedItemsListBox.SelectedIndex].Link != null)
            {
                rssLinkLable.Text = "Go To: " + CurrentFeed.Items[displayFeedItemsListBox.SelectedIndex].Title;
            }
            
            
        }

        private void displayFeedItemsListBox_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void rssLinkLable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (CurrentFeed.Items[displayFeedItemsListBox.SelectedIndex].Link != null)
            {
                System.Diagnostics.Process.Start(CurrentFeed.Items[displayFeedItemsListBox.SelectedIndex].Link);
            }
        }


    }
}
