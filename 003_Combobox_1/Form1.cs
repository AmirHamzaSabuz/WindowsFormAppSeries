using System.Globalization;

namespace _003_Combobox_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAddItem.Text != "")
            {
                if (District_Combobox.Items.Contains(txtAddItem.Text))
                {
                    MessageBox.Show("Item already exists");
                    txtAddItem.Clear();
                    txtAddItem.Focus();
                }
                else 
                {
                    District_Combobox.Items.Add(txtAddItem.Text);
                    txtAddItem.Clear();
                    txtAddItem.Focus();
                }
                
            }
            else 
            {
                MessageBox.Show("Please fill the textbox");
            }
            
        }

        private void btnCountItems_Click(object sender, EventArgs e)
        {
            int count = District_Combobox.Items.Count;
            MessageBox.Show("District items are : " + count);
        }

        private void btnSortItems_Click(object sender, EventArgs e)
        {
            District_Combobox.Sorted = true;
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            District_Combobox.Items.Remove(District_Combobox.SelectedItem);
        }

        private void btnClearItems_Click(object sender, EventArgs e)
        {
            District_Combobox.Items.Clear();
        }
    }
}