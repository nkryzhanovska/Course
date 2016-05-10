using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson15
{
    public partial class FilterControls : UserControl, IFilterView
    {
        private string filterName = String.Empty;
        private List<string> filteritems;

        public FilterControls()
        {
            InitializeComponent();
        }

        public event FilterItemAddedEventHandler ItemAdded;
        public event FilterItemRemovedEventHandler ItemRemoved;

        public event ConfigFileSelectedEventHandler ConfigFileSelected;

        public string FilterName
        {
            get
            {
                return filterName;
            }
            set
            {
                filterName = value;
                commonFilterBox.Text = String.Format("{0} Settings", filterName);
            }
        }

        public string FilePath
        {
            get
            {
                return commonFilterFileTextBox.Text;
            }
            set
            {
                commonFilterFileTextBox.Text = value;
            }
        }

       

        private void commonFilterFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            //fileDialog.Filter = "(*.txt)";
            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                commonFilterFileTextBox.Text = fileDialog.FileName;
                OnFileSelected();
            }

        }

        private void OnFileSelected()
        {
            if (ConfigFileSelected != null)
            {
                ConfigFileSelected(this, FilePath);
            }
        }

        private void addItemToCommonListButton_Click(object sender, EventArgs e)
        {
            OnItemAdded();

        }

        private void OnItemAdded()
        {
            if (ItemAdded != null)
            {
                ItemAdded(this, newCommonListItemTextBox.Text);
            }
        }



        public List<string> FilterItems
        {
            get
            {
                return filteritems;
            }
            set
            {
                filteritems = value;
                commonFilterListBox.DataSource = null;
                commonFilterListBox.DataSource = filteritems;
            }
        }

        private void removeItemFromCommonListButton_Click(object sender, EventArgs e)
        {
            OnItemRemove();
        }

        private void OnItemRemove()
        {
            //string curItem = commonFilterListBox.SelectedItem.ToString();
            //int index = commonFilterListBox.FindString(curItem);
            //if (index != -1)
            //{
            //   commonFilterListBox.SetSelected(index, true);

            //}

            if (ItemRemoved != null)
            {
                ItemRemoved(this, commonFilterListBox.ToString());
            }
        }

        private void newCommonListItemTextBox_TextChanged(object sender, EventArgs e)
        {
            addItemToCommonListButton.Enabled = !String.IsNullOrEmpty(newCommonListItemTextBox.Text);
        }

        private void commonFilterListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeItemFromCommonListButton.Enabled = commonFilterListBox.Created;
            
                
        }
    }
}
