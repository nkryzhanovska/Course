using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RssReaderHomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        List<RssManager> CurrFeed = new List<RssManager>();

        private string filepath = "RssFeeds.txt";

        private void view_RssAdded()
        {

            List<string> feedLinks = new List<string>();
            using (StreamReader reader = new StreamReader(filepath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    feedLinks.Add(line);
                }
            }

            if (feedLinks != null)
            {
                RssManager oldFeed = new RssManager();

                for (int i = 0; i < feedLinks.Count; i++)
                {
                    oldFeed = new RssManager(feedLinks[i]);
                    if (oldFeed.Title != null)
                    {
                        CurrFeed.Add(oldFeed);
                    }
                }

                if (CurrFeed != null)
                {
                    for (int i = 0; i < CurrFeed.Count; i++)
                    {
                        dispalyRssFeedsListBox.Items.Add(CurrFeed[i].Title);
                    }
                }
            }
            else
            {
                MessageBox.Show("There were no previous saved feed URLs");
            }


        }

        private void addNewFeedUrlTestBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void getFeedButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(addNewFeedUrlTestBox.Text))
            {
                RefreshBoxes();

                if (!ExistFeed(addNewFeedUrlTestBox.Text))
                {
                    RssManager CurrentFeed;
                    CurrentFeed = new RssManager(addNewFeedUrlTestBox.Text);

                    CurrFeed.Add(CurrentFeed);
                    if (!String.IsNullOrEmpty(CurrentFeed.Title))
                    {
                        dispalyRssFeedsListBox.Items.Add(CurrentFeed.Title);
                    }

                    addNewFeedUrlTestBox.Clear();
                }
                else
                {
                    MessageBox.Show("Entered feed already added. Please add an another feed URL");
                    addNewFeedUrlTestBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please add a feed URL");
            }

        }

        private void displayFeedItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrFeed[dispalyRssFeedsListBox.SelectedIndex].Items[displayFeedItemsListBox.SelectedIndex].Description != null)
            {
                feedDescriptionWebBrowser.DocumentText = CurrFeed[dispalyRssFeedsListBox.SelectedIndex].Items[displayFeedItemsListBox.SelectedIndex].Description;

            }

            if (CurrFeed[dispalyRssFeedsListBox.SelectedIndex].Items[displayFeedItemsListBox.SelectedIndex].Link != null)
            {
                rssLinkLable.Text = "Go To: " + CurrFeed[dispalyRssFeedsListBox.SelectedIndex].Items[displayFeedItemsListBox.SelectedIndex].Title;
            }


        }

        private void displayFeedItemsListBox_DoubleClick(object sender, EventArgs e)
        {

        }

        private void rssLinkLable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (CurrFeed[dispalyRssFeedsListBox.SelectedIndex].Items[displayFeedItemsListBox.SelectedIndex].Link != null)
            {
                System.Diagnostics.Process.Start(CurrFeed[dispalyRssFeedsListBox.SelectedIndex].Items[displayFeedItemsListBox.SelectedIndex].Link);
            }


        }

        private void dispalyRssFeedsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshBoxes();

            if (dispalyRssFeedsListBox.SelectedIndex > -1)
            {
                if (!String.IsNullOrEmpty(CurrFeed[dispalyRssFeedsListBox.SelectedIndex].Title))
                {
                    for (int i = 0; i < CurrFeed[dispalyRssFeedsListBox.SelectedIndex].Items.Count; i++)
                    {
                        if (CurrFeed[dispalyRssFeedsListBox.SelectedIndex].Items[i] != null)
                        {
                            displayFeedItemsListBox.Items.Add(CurrFeed[dispalyRssFeedsListBox.SelectedIndex].Items[i].Title);
                        }
                    }
                    displayFeedItemsListBox.SelectedIndex = 0;
                }
            }
        }

        private void refreshFeedsButton_Click(object sender, EventArgs e)
        {
            if (CurrFeed != null)
            {
                RefreshBoxes();

                for (int i = 0; i < CurrFeed.Count; i++)
                {
                    RssManager refreshFeed;
                    refreshFeed = new RssManager(CurrFeed[i].Url);
                    CurrFeed[i] = refreshFeed;
                }
            }
            else
            {
                MessageBox.Show("Please add at least one feed URL first");
            }
        }

        private void saveFeedsToFileButton_Click(object sender, EventArgs e)
        {
            if (CurrFeed.Count != 0)
            {
                List<string> feedLink = new List<string>();
                for (int i = 0; i < CurrFeed.Count; i++)
                {
                    feedLink.Add(CurrFeed[i].Url);
                }

                using (StreamWriter writer = new StreamWriter(filepath))
                {

                    foreach (var item in feedLink)
                    {
                        writer.WriteLine(item);
                    }
                }
                MessageBox.Show("All added feed URLs are saved");
            }
            else
            {
                MessageBox.Show("Please add at least one feed URL first");
            }
        }

        private void removeFeedButton_Click(object sender, EventArgs e)
        {
            if (CurrFeed.Count != 0)
            {
                RefreshBoxes();

                int a = dispalyRssFeedsListBox.SelectedIndex;
                object tempitem = dispalyRssFeedsListBox.Items[a];
                dispalyRssFeedsListBox.Items.Remove(tempitem);
                CurrFeed.RemoveAt(a);

                dispalyRssFeedsListBox.Refresh();

                MessageBox.Show("Selected feed is removed");
            }
            else
            {
                MessageBox.Show("Please add at least one feed URL first");
            }
        }

        private void RefreshBoxes()
        {
            feedDescriptionWebBrowser.Navigate("about:blank");
            displayFeedItemsListBox.Items.Clear();
            rssLinkLable.ResetText();
        }

        private bool ExistFeed(string url)
        {
            foreach (RssManager checkItem in CurrFeed)
            {
                if (checkItem.Url.Equals(url))
                {
                    return true;
                }
            }
            return false;
        }

        private void rssLoadFromFileButton_Click(object sender, EventArgs e)
        {
            view_RssAdded();
        }

    }
}
