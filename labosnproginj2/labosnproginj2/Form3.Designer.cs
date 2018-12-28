namespace labosnproginj2
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьФормуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьРисунокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rTFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьФормуToolStripMenuItem,
            this.добавитьРисунокToolStripMenuItem,
            this.rTFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьФормуToolStripMenuItem
            // 
            this.добавитьФормуToolStripMenuItem.Name = "добавитьФормуToolStripMenuItem";
            this.добавитьФормуToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.добавитьФормуToolStripMenuItem.Text = "Добавить форму";
            this.добавитьФормуToolStripMenuItem.Click += new System.EventHandler(this.добавитьФормуToolStripMenuItem_Click);
            // 
            // добавитьРисунокToolStripMenuItem
            // 
            this.добавитьРисунокToolStripMenuItem.Name = "добавитьРисунокToolStripMenuItem";
            this.добавитьРисунокToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.добавитьРисунокToolStripMenuItem.Text = "Добавить рисунок";
            this.добавитьРисунокToolStripMenuItem.Click += new System.EventHandler(this.добавитьРисунокToolStripMenuItem_Click);
            // 
            // rTFToolStripMenuItem
            // 
            this.rTFToolStripMenuItem.Name = "rTFToolStripMenuItem";
            this.rTFToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.rTFToolStripMenuItem.Text = "RTF";
            this.rTFToolStripMenuItem.Click += new System.EventHandler(this.rTFToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "labosninj";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьФормуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьРисунокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rTFToolStripMenuItem;
    }
}