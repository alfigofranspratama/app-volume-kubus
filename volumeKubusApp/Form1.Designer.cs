namespace volumeKubusApp
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
            btnApply = new Button();
            lblSisi = new Label();
            lblVolume = new Label();
            txtSisi = new TextBox();
            txtVolume = new TextBox();
            SuspendLayout();
            // 
            // btnApply
            // 
            btnApply.Location = new Point(258, 12);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 54);
            btnApply.TabIndex = 0;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // lblSisi
            // 
            lblSisi.AutoSize = true;
            lblSisi.Location = new Point(12, 15);
            lblSisi.Name = "lblSisi";
            lblSisi.Size = new Size(60, 15);
            lblSisi.TabIndex = 1;
            lblSisi.Text = "Sisi Kubus";
            // 
            // lblVolume
            // 
            lblVolume.AutoSize = true;
            lblVolume.Location = new Point(12, 44);
            lblVolume.Name = "lblVolume";
            lblVolume.Size = new Size(83, 15);
            lblVolume.TabIndex = 2;
            lblVolume.Text = "Volume Kubus";
            // 
            // txtSisi
            // 
            txtSisi.Location = new Point(97, 12);
            txtSisi.Name = "txtSisi";
            txtSisi.Size = new Size(155, 23);
            txtSisi.TabIndex = 3;
            // 
            // txtVolume
            // 
            txtVolume.Location = new Point(97, 41);
            txtVolume.Name = "txtVolume";
            txtVolume.ReadOnly = true;
            txtVolume.Size = new Size(155, 23);
            txtVolume.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 114);
            Controls.Add(txtVolume);
            Controls.Add(txtSisi);
            Controls.Add(lblVolume);
            Controls.Add(lblSisi);
            Controls.Add(btnApply);
            Name = "Form1";
            Text = "Calculator Volume Kubus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnApply;
        private Label lblSisi;
        private Label lblVolume;
        private TextBox txtSisi;
        private TextBox txtVolume;
    }
}