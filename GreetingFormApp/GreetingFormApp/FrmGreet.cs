namespace GreetingFormApp
{
    public partial class FrmGreet : Form
    {
        public FrmGreet()
        {
            InitializeComponent();
        }

        private void btnGreet_Click(object sender, EventArgs e)
        {
            string username = txtName.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a valid name and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Hello {username}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
