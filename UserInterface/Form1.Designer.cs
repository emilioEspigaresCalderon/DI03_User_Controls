
namespace AWUserInterface
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
            this.awProductViewerControl1 = new AWProductViewer.AWProductViewerControl();
            this.productModelIDTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // awProductViewerControl1
            // 
            this.awProductViewerControl1.Location = new System.Drawing.Point(12, 12);
            this.awProductViewerControl1.Name = "awProductViewerControl1";
            this.awProductViewerControl1.ProductModel = 0;
            this.awProductViewerControl1.Size = new System.Drawing.Size(295, 472);
            this.awProductViewerControl1.TabIndex = 0;
            // 
            // productModelIDTextBox
            // 
            this.productModelIDTextBox.Location = new System.Drawing.Point(12, 554);
            this.productModelIDTextBox.Name = "productModelIDTextBox";
            this.productModelIDTextBox.Size = new System.Drawing.Size(175, 22);
            this.productModelIDTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(193, 554);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(109, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 588);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.productModelIDTextBox);
            this.Controls.Add(this.awProductViewerControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AWProductViewer.AWProductViewerControl awProductViewerControl1;
        private System.Windows.Forms.TextBox productModelIDTextBox;
        private System.Windows.Forms.Button searchButton;
    }
}

