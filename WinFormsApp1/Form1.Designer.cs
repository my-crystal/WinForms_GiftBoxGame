namespace WinFormsApp1
{
    partial class Form1
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
            btnTry = new Button();
            lblok = new Label();
            txtTry = new TextBox();
            SuspendLayout();
            // 
            // btnTry
            // 
            btnTry.Location = new Point(256, 65);
            btnTry.Name = "btnTry";
            btnTry.Size = new Size(112, 34);
            btnTry.TabIndex = 0;
            btnTry.Text = "模拟开始";
            btnTry.UseVisualStyleBackColor = true;
            btnTry.Click += btnTry_Click;
            // 
            // lblok
            // 
            lblok.BorderStyle = BorderStyle.FixedSingle;
            lblok.Location = new Point(52, 182);
            lblok.Name = "lblok";
            lblok.Size = new Size(213, 85);
            lblok.TabIndex = 1;
            // 
            // txtTry
            // 
            txtTry.Location = new Point(52, 69);
            txtTry.Name = "txtTry";
            txtTry.Size = new Size(150, 30);
            txtTry.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTry);
            Controls.Add(lblok);
            Controls.Add(btnTry);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTry;
        private Label lblok;
        private TextBox txtTry;
    }
}
