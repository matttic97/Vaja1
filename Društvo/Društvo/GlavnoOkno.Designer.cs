namespace Društvo
{
    partial class GlavnoOkno
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
            this.vnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prgeldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiskanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaščitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shraniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obnoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vnosToolStripMenuItem,
            this.prgeldToolStripMenuItem,
            this.tiskanjeToolStripMenuItem,
            this.zaščitaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(596, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vnosToolStripMenuItem
            // 
            this.vnosToolStripMenuItem.Name = "vnosToolStripMenuItem";
            this.vnosToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.vnosToolStripMenuItem.Text = "Vnos";
            this.vnosToolStripMenuItem.Click += new System.EventHandler(this.vnosToolStripMenuItem_Click);
            // 
            // prgeldToolStripMenuItem
            // 
            this.prgeldToolStripMenuItem.Name = "prgeldToolStripMenuItem";
            this.prgeldToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.prgeldToolStripMenuItem.Text = "Pregeld";
            this.prgeldToolStripMenuItem.Click += new System.EventHandler(this.prgeldToolStripMenuItem_Click);
            // 
            // tiskanjeToolStripMenuItem
            // 
            this.tiskanjeToolStripMenuItem.Name = "tiskanjeToolStripMenuItem";
            this.tiskanjeToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.tiskanjeToolStripMenuItem.Text = "Tiskanje";
            this.tiskanjeToolStripMenuItem.Click += new System.EventHandler(this.tiskanjeToolStripMenuItem_Click);
            // 
            // zaščitaToolStripMenuItem
            // 
            this.zaščitaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shraniToolStripMenuItem,
            this.obnoviToolStripMenuItem});
            this.zaščitaToolStripMenuItem.Name = "zaščitaToolStripMenuItem";
            this.zaščitaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.zaščitaToolStripMenuItem.Text = "Zaščita";
            // 
            // shraniToolStripMenuItem
            // 
            this.shraniToolStripMenuItem.Name = "shraniToolStripMenuItem";
            this.shraniToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.shraniToolStripMenuItem.Text = "Shrani";
            this.shraniToolStripMenuItem.Click += new System.EventHandler(this.shraniToolStripMenuItem_Click);
            // 
            // obnoviToolStripMenuItem
            // 
            this.obnoviToolStripMenuItem.Name = "obnoviToolStripMenuItem";
            this.obnoviToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.obnoviToolStripMenuItem.Text = "Obnovi";
            this.obnoviToolStripMenuItem.Click += new System.EventHandler(this.obnoviToolStripMenuItem_Click);
            // 
            // GlavnoOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 466);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GlavnoOkno";
            this.Text = "Društvo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prgeldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiskanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaščitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shraniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obnoviToolStripMenuItem;
    }
}