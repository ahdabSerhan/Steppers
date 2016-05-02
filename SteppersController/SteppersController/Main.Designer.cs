namespace SteppersController
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnConnect = new System.Windows.Forms.ToolStripButton();
            this.toolComboPort = new System.Windows.Forms.ToolStripComboBox();
            this.btnAllUp = new System.Windows.Forms.ToolStripButton();
            this.panelSteppers = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 357);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(543, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConnect,
            this.toolComboPort,
            this.btnAllUp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(543, 61);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnConnect
            // 
            this.btnConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.Image")));
            this.btnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(56, 58);
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // toolComboPort
            // 
            this.toolComboPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolComboPort.Name = "toolComboPort";
            this.toolComboPort.Size = new System.Drawing.Size(121, 61);
            // 
            // btnAllUp
            // 
            this.btnAllUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAllUp.Image = ((System.Drawing.Image)(resources.GetObject("btnAllUp.Image")));
            this.btnAllUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAllUp.Name = "btnAllUp";
            this.btnAllUp.Size = new System.Drawing.Size(26, 58);
            this.btnAllUp.Text = "UP";
            // 
            // panelSteppers
            // 
            this.panelSteppers.BackColor = System.Drawing.Color.White;
            this.panelSteppers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSteppers.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSteppers.Enabled = false;
            this.panelSteppers.Location = new System.Drawing.Point(0, 61);
            this.panelSteppers.Name = "panelSteppers";
            this.panelSteppers.Size = new System.Drawing.Size(543, 279);
            this.panelSteppers.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 379);
            this.Controls.Add(this.panelSteppers);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Main";
            this.Text = "VisiDome Steppers";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnConnect;
        private System.Windows.Forms.ToolStripComboBox toolComboPort;
        private System.Windows.Forms.ToolStripButton btnAllUp;
        private System.Windows.Forms.Panel panelSteppers;
    }
}

