
namespace AWProductViewer
{
    partial class AWProductViewerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.colorFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.sizeFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(4, 271);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.ReadOnly = true;
            this.productNameTextBox.Size = new System.Drawing.Size(287, 22);
            this.productNameTextBox.TabIndex = 1;
            // 
            // colorFlowLayoutPanel
            // 
            this.colorFlowLayoutPanel.Location = new System.Drawing.Point(4, 299);
            this.colorFlowLayoutPanel.Name = "colorFlowLayoutPanel";
            this.colorFlowLayoutPanel.Size = new System.Drawing.Size(287, 67);
            this.colorFlowLayoutPanel.TabIndex = 2;
            // 
            // sizeFlowLayoutPanel
            // 
            this.sizeFlowLayoutPanel.Location = new System.Drawing.Point(4, 372);
            this.sizeFlowLayoutPanel.Name = "sizeFlowLayoutPanel";
            this.sizeFlowLayoutPanel.Size = new System.Drawing.Size(287, 67);
            this.sizeFlowLayoutPanel.TabIndex = 3;
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.Location = new System.Drawing.Point(191, 445);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.ReadOnly = true;
            this.productIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.productIDTextBox.TabIndex = 4;
            // 
            // AWProductViewerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(this.sizeFlowLayoutPanel);
            this.Controls.Add(this.colorFlowLayoutPanel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AWProductViewerControl";
            this.Size = new System.Drawing.Size(295, 472);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.FlowLayoutPanel colorFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel sizeFlowLayoutPanel;
        private System.Windows.Forms.TextBox productIDTextBox;
    }
}
