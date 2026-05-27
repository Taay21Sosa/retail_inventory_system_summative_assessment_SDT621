namespace GreetingFormApp
{
    partial class FrmGreet
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
            lblName = new Label();
            txtName = new TextBox();
            btnGreet = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 11F);
            lblName.Location = new Point(139, 120);
            lblName.Name = "lblName";
            lblName.Size = new Size(155, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Enter your name:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11F);
            txtName.Location = new Point(311, 117);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 32);
            txtName.TabIndex = 1;
            // 
            // btnGreet
            // 
            btnGreet.Font = new Font("Segoe UI", 11F);
            btnGreet.Location = new Point(260, 187);
            btnGreet.Name = "btnGreet";
            btnGreet.Size = new Size(150, 45);
            btnGreet.TabIndex = 2;
            btnGreet.Text = "Greeting";
            btnGreet.UseVisualStyleBackColor = true;
            btnGreet.Click += btnGreet_Click;
            // 
            // FrmGreet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGreet);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "FrmGreet";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Button btnGreet;
    }
}
