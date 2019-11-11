namespace RibbonKutuphanesi.Formlar
{
    partial class Form_Grafik
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
            this.propertyGrid_Olcek = new System.Windows.Forms.PropertyGrid();
            this.textBox_Grafik = new System.Windows.Forms.TextBox();
            this.label_Grafik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // propertyGrid_Olcek
            // 
            this.propertyGrid_Olcek.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.propertyGrid_Olcek.Location = new System.Drawing.Point(0, 47);
            this.propertyGrid_Olcek.Name = "propertyGrid_Olcek";
            this.propertyGrid_Olcek.Size = new System.Drawing.Size(228, 250);
            this.propertyGrid_Olcek.TabIndex = 1;
            this.propertyGrid_Olcek.ToolbarVisible = false;
            // 
            // textBox_Grafik
            // 
            this.textBox_Grafik.Location = new System.Drawing.Point(77, 12);
            this.textBox_Grafik.Name = "textBox_Grafik";
            this.textBox_Grafik.Size = new System.Drawing.Size(139, 20);
            this.textBox_Grafik.TabIndex = 2;
            // 
            // label_Grafik
            // 
            this.label_Grafik.AutoSize = true;
            this.label_Grafik.Location = new System.Drawing.Point(12, 15);
            this.label_Grafik.Name = "label_Grafik";
            this.label_Grafik.Size = new System.Drawing.Size(59, 13);
            this.label_Grafik.TabIndex = 3;
            this.label_Grafik.Text = "Grafik Adı :";
            // 
            // Form_Grafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 297);
            this.Controls.Add(this.label_Grafik);
            this.Controls.Add(this.textBox_Grafik);
            this.Controls.Add(this.propertyGrid_Olcek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Grafik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ölçek Ayar Penceresi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Grafik_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid_Olcek;
        private System.Windows.Forms.TextBox textBox_Grafik;
        private System.Windows.Forms.Label label_Grafik;
    }
}