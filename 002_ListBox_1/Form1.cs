namespace _002_ListBox_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FruitsListBox.Items.Add(txtAddItem.Text);
            txtAddItem.Clear();
            txtAddItem.Focus();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int count = FruitsListBox.Items.Count;
            MessageBox.Show("Total items are " +count.ToString());
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            FruitsListBox.Sorted = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            FruitsListBox.Items.Remove(FruitsListBox.SelectedItem);
            //FruitsListBox.Items.RemoveAt(FruitsListBox.SelectedIndex);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FruitsListBox.Items.Clear();
        }

        private void FruitsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}