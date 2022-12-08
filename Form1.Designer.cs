namespace UnZipper
{
    partial class UnZipper
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
            this.label1 = new System.Windows.Forms.Label();
            this.browse = new System.Windows.Forms.Button();
            this.UnZip = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Authored By Spencer Brown";
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(173, 151);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(112, 34);
            this.browse.TabIndex = 1;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // UnZip
            // 
            this.UnZip.Location = new System.Drawing.Point(173, 202);
            this.UnZip.Name = "UnZip";
            this.UnZip.Size = new System.Drawing.Size(112, 34);
            this.UnZip.TabIndex = 2;
            this.UnZip.Text = "UnZip";
            this.UnZip.UseVisualStyleBackColor = true;
            this.UnZip.Click += new System.EventHandler(this.UnZip_Click);
            // 
            // fileName
            // 
            this.fileName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileName.Location = new System.Drawing.Point(291, 155);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(406, 27);
            this.fileName.TabIndex = 3;
            this.fileName.Text = "C:\\";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(291, 202);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(406, 34);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(291, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 5;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // UnZipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.UnZip);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.label1);
            this.Name = "UnZipper";
            this.Text = "UnZipper";
            this.Load += new System.EventHandler(this.UnZipper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button browse;
        private Button UnZip;
        private Label fileName;
        private ProgressBar progressBar1;
        private Label label2;
    }
}