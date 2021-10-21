namespace BeTechTest
{
    partial class BarCodeViewerForm
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
            this.drawerPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.drawerPB)).BeginInit();
            this.SuspendLayout();
            // 
            // drawerPB
            // 
            this.drawerPB.Location = new System.Drawing.Point(12, 12);
            this.drawerPB.Name = "drawerPB";
            this.drawerPB.Size = new System.Drawing.Size(192, 86);
            this.drawerPB.TabIndex = 0;
            this.drawerPB.TabStop = false;
            // 
            // BarCodeViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 110);
            this.Controls.Add(this.drawerPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BarCodeViewerForm";
            this.Load += new System.EventHandler(this.BarCodeViewerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawerPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox drawerPB;
    }
}