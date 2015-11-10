namespace WinFormTest
{
    partial class FormGridProperty
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
            this.xPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // xPropertyGrid
            // 
            this.xPropertyGrid.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.xPropertyGrid.Location = new System.Drawing.Point(12, 3);
            this.xPropertyGrid.Name = "xPropertyGrid";
            this.xPropertyGrid.Size = new System.Drawing.Size(260, 256);
            this.xPropertyGrid.TabIndex = 0;
            this.xPropertyGrid.ToolbarVisible = false;
            // 
            // FormGridProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.xPropertyGrid);
            this.Name = "FormGridProperty";
            this.Text = "FormGridProperty";
            this.Load += new System.EventHandler(this.FormGridProperty_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid xPropertyGrid;
    }
}