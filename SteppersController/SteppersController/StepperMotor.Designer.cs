namespace SteppersController
{
    partial class StepperMotor
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
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(38, 96);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(46, 20);
            this.txtPosition.TabIndex = 2;
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUp.Location = new System.Drawing.Point(24, 48);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(74, 42);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "UP";
            this.btnUp.UseVisualStyleBackColor = false;
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDown.Location = new System.Drawing.Point(24, 122);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(74, 45);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "DOWN";
            this.btnDown.UseVisualStyleBackColor = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(32, 12);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(66, 24);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "label1";
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(3, 194);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(35, 13);
            this.lblTag.TabIndex = 1;
            this.lblTag.Text = "label2";
            // 
            // StepperMotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.lblId);
            this.Name = "StepperMotor";
            this.Size = new System.Drawing.Size(127, 207);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTag;
    }
}
