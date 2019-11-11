namespace RibbonKutuphanesi.Formlar
{
    partial class Form_Seriport
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
            this.propertyGrid_Seriport = new System.Windows.Forms.PropertyGrid();
            this.numericUpDown_Veri = new System.Windows.Forms.NumericUpDown();
            this.label_Veri = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Veri)).BeginInit();
            this.SuspendLayout();
            // 
            // propertyGrid_Seriport
            // 
            this.propertyGrid_Seriport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.propertyGrid_Seriport.Location = new System.Drawing.Point(0, 33);
            this.propertyGrid_Seriport.Name = "propertyGrid_Seriport";
            this.propertyGrid_Seriport.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.propertyGrid_Seriport.Size = new System.Drawing.Size(319, 273);
            this.propertyGrid_Seriport.TabIndex = 1;
            this.propertyGrid_Seriport.ToolbarVisible = false;
            // 
            // numericUpDown_Veri
            // 
            this.numericUpDown_Veri.Location = new System.Drawing.Point(79, 7);
            this.numericUpDown_Veri.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown_Veri.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Veri.Name = "numericUpDown_Veri";
            this.numericUpDown_Veri.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_Veri.TabIndex = 2;
            this.numericUpDown_Veri.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label_Veri
            // 
            this.label_Veri.AutoSize = true;
            this.label_Veri.Location = new System.Drawing.Point(12, 9);
            this.label_Veri.Name = "label_Veri";
            this.label_Veri.Size = new System.Drawing.Size(61, 13);
            this.label_Veri.TabIndex = 3;
            this.label_Veri.Text = "Veri Sayısı :";
            // 
            // Form_Seriport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 306);
            this.Controls.Add(this.label_Veri);
            this.Controls.Add(this.numericUpDown_Veri);
            this.Controls.Add(this.propertyGrid_Seriport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Seriport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seriport Ayar Penceresi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Seriport_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Veri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid_Seriport;
        private System.Windows.Forms.NumericUpDown numericUpDown_Veri;
        private System.Windows.Forms.Label label_Veri;
    }
}