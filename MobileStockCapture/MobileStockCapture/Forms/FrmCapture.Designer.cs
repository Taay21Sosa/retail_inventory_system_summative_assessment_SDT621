namespace MobileStockCapture
{
    partial class FrmCapture
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblOutput = new Label();
            lblCode = new Label();
            lblMake = new Label();
            lblQuantity = new Label();
            txtCode = new TextBox();
            txtMake = new TextBox();
            txtQuantity = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnFind = new Button();
            SuspendLayout();
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Font = new Font("Segoe UI", 15F);
            lblOutput.Location = new Point(122, 44);
            lblOutput.MinimumSize = new Size(550, 0);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(550, 35);
            lblOutput.TabIndex = 0;
            lblOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Font = new Font("Segoe UI", 11F);
            lblCode.Location = new Point(140, 140);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(120, 25);
            lblCode.TabIndex = 1;
            lblCode.Text = "Mobile Code";
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Font = new Font("Segoe UI", 11F);
            lblMake.Location = new Point(140, 220);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(58, 25);
            lblMake.TabIndex = 2;
            lblMake.Text = "Make";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 11F);
            lblQuantity.Location = new Point(140, 300);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(84, 25);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Quantity";
            // 
            // txtCode
            // 
            txtCode.Font = new Font("Segoe UI", 11F);
            txtCode.Location = new Point(350, 140);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(225, 32);
            txtCode.TabIndex = 4;
            // 
            // txtMake
            // 
            txtMake.Font = new Font("Segoe UI", 11F);
            txtMake.Location = new Point(350, 220);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(225, 32);
            txtMake.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 11F);
            txtQuantity.Location = new Point(350, 300);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(225, 32);
            txtQuantity.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAdd.Location = new Point(110, 380);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 45);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDelete.Location = new Point(312, 380);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(145, 45);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFind
            // 
            btnFind.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnFind.Location = new Point(516, 380);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(145, 45);
            btnFind.TabIndex = 9;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 465);
            Controls.Add(btnFind);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtQuantity);
            Controls.Add(txtMake);
            Controls.Add(txtCode);
            Controls.Add(lblQuantity);
            Controls.Add(lblMake);
            Controls.Add(lblCode);
            Controls.Add(lblOutput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOutput;
        private Label lblCode;
        private Label lblMake;
        private Label lblQuantity;
        private TextBox txtCode;
        private TextBox txtMake;
        private TextBox txtQuantity;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnFind;
    }
}
