namespace Društvo
{
    partial class Pregled
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pregled));
            this.dgwPodatki = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnShrani = new System.Windows.Forms.ToolStripButton();
            this.btnIzbriši = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.prgStatus = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPodatki)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwPodatki
            // 
            this.dgwPodatki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPodatki.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwPodatki.Location = new System.Drawing.Point(0, 0);
            this.dgwPodatki.Name = "dgwPodatki";
            this.dgwPodatki.Size = new System.Drawing.Size(609, 516);
            this.dgwPodatki.TabIndex = 0;
            this.dgwPodatki.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPodatki_CellValueChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShrani,
            this.btnIzbriši,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(609, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnShrani
            // 
            this.btnShrani.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShrani.Image = ((System.Drawing.Image)(resources.GetObject("btnShrani.Image")));
            this.btnShrani.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShrani.Name = "btnShrani";
            this.btnShrani.Size = new System.Drawing.Size(23, 22);
            this.btnShrani.Text = "toolStripButton1";
            this.btnShrani.Click += new System.EventHandler(this.btnShrani_Click);
            // 
            // btnIzbriši
            // 
            this.btnIzbriši.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnIzbriši.Image = ((System.Drawing.Image)(resources.GetObject("btnIzbriši.Image")));
            this.btnIzbriši.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIzbriši.Name = "btnIzbriši";
            this.btnIzbriši.Size = new System.Drawing.Size(23, 22);
            this.btnIzbriši.Text = "toolStripButton2";
            this.btnIzbriši.Click += new System.EventHandler(this.btnIzbriši_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Društvo.Properties.Resources.help;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prgStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 494);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(609, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // prgStatus
            // 
            this.prgStatus.Name = "prgStatus";
            this.prgStatus.Size = new System.Drawing.Size(100, 16);
            // 
            // Pregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 516);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgwPodatki);
            this.Name = "Pregled";
            this.Text = "Pregled";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pregled_FormClosing);
            this.Load += new System.EventHandler(this.Pregled_Load);
            this.Shown += new System.EventHandler(this.Pregled_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPodatki)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPodatki;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnShrani;
        private System.Windows.Forms.ToolStripButton btnIzbriši;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar prgStatus;
    }
}