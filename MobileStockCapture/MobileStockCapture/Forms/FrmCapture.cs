namespace MobileStockCapture
{
    public partial class FrmCapture : Form
    {
        public FrmCapture()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtCode.Clear();
            txtCode.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtCode.Clear();
            txtCode.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            // Clears text
            txtCode.Clear();
            txtCode.Focus();
        }
    }
}
