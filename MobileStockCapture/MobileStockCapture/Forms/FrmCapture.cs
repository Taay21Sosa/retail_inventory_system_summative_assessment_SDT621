using MobileStockCapture.Models;

namespace MobileStockCapture
{
    public partial class FrmCapture : Form
    {
        private List<MobilePhone> tblMobilePhones;
        public FrmCapture()
        {
            InitializeComponent();
            tblMobilePhones = new List<MobilePhone>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!IsValidMobilePhoneData()) return;

            MobilePhone mobilePhone = new MobilePhone
            {
                Code = txtCode.Text.Trim(),
                Make = txtMake.Text.Trim(),
                Quantity = int.Parse(txtQuantity.Text.Trim())
            };

            tblMobilePhones.Add(mobilePhone);

            lblOutput.Text = "Record Added";

            ClearFormFeilds();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string mobilePhone = txtCode.Text.Trim();

            var record = tblMobilePhones.FirstOrDefault(inv => inv.Code == mobilePhone);

            if (record == null)
            {
                lblOutput.Text = "Record NOT Found";
                return;
            }
            else
            {
                tblMobilePhones.Remove(record);
                lblOutput.Text = "Record Found";

            }

            ClearFormFeilds();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string mobilePhone = txtCode.Text.Trim();

            var record = tblMobilePhones.FirstOrDefault(inv => inv.Code == mobilePhone);

            if (record == null)
            {
                lblOutput.Text = "Record NOT Found";
                return;
            }
            else
            {
                lblOutput.Text = "Record Deleted";

            }

            ClearFormFeilds();
        }

        private bool IsValidMobilePhoneData()
        {
            // Validate Mobile phone inventory code
            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                MessageBox.Show("Mobile phone code is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCode.Focus();
                return false;
            }

            // Validate Mobile phone inventory code
            if (string.IsNullOrWhiteSpace(txtMake.Text))
            {
                MessageBox.Show("Mobile phone make is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCode.Focus();
                return false;
            }

            // Validate Mobile phone inventory code
            if (!int.TryParse(txtQuantity.Text, out int qty) || qty < 0)
            {
                MessageBox.Show("Mobile phone code is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCode.Focus();
                return false;
            }

            return true;
        }

        private void ClearFormFeilds()
        {
            //lblOutput.Text = string.Empty;
            txtCode.Clear();
            txtMake.Clear();
            txtQuantity.Clear();
            txtCode.Focus();
        }
    }
}
