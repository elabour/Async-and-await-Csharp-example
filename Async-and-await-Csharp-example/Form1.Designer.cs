namespace Async_and_await_Csharp_example
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnProcessFile = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnProcessFile
            // 
            this.BtnProcessFile.Location = new System.Drawing.Point(115, 15);
            this.BtnProcessFile.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnProcessFile.Name = "BtnProcessFile";
            this.BtnProcessFile.Size = new System.Drawing.Size(322, 98);
            this.BtnProcessFile.TabIndex = 0;
            this.BtnProcessFile.Text = "Get Character\'s Count";
            this.BtnProcessFile.UseVisualStyleBackColor = true;
            this.BtnProcessFile.Click += new System.EventHandler(this.BtnProcessFile_Click);
            // 
            // lblCount
            // 
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCount.Location = new System.Drawing.Point(115, 138);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(366, 43);
            this.lblCount.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 302);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.BtnProcessFile);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnProcessFile;
        private System.Windows.Forms.Label lblCount;
    }
}

