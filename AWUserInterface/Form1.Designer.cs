
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
            this.showMoreButton = new System.Windows.Forms.Button();
            this.userControlsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // showMoreButton
            // 
            this.showMoreButton.Location = new System.Drawing.Point(557, 553);
            this.showMoreButton.Name = "showMoreButton";
            this.showMoreButton.Size = new System.Drawing.Size(109, 23);
            this.showMoreButton.TabIndex = 2;
            this.showMoreButton.Text = "Show more";
            this.showMoreButton.UseVisualStyleBackColor = true;
            this.showMoreButton.Click += new System.EventHandler(this.showMoreButton_Click);
            // 
            // userControlsFlowLayoutPanel
            // 
            this.userControlsFlowLayoutPanel.AutoScroll = true;
            this.userControlsFlowLayoutPanel.Location = new System.Drawing.Point(13, 13);
            this.userControlsFlowLayoutPanel.Name = "userControlsFlowLayoutPanel";
            this.userControlsFlowLayoutPanel.Size = new System.Drawing.Size(653, 526);
            this.userControlsFlowLayoutPanel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 588);
            this.Controls.Add(this.userControlsFlowLayoutPanel);
            this.Controls.Add(this.showMoreButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button showMoreButton;
        private System.Windows.Forms.FlowLayoutPanel userControlsFlowLayoutPanel;
    }
}

