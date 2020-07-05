namespace ExSharpBase.Menu
{
    partial class BasePlate
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DrawRangeCheckBox = new System.Windows.Forms.CheckBox();
            this.MoveToMouseCheckBox = new System.Windows.Forms.CheckBox();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(299, 30);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // DrawRangeCheckBox
            // 
            this.DrawRangeCheckBox.AutoSize = true;
            this.DrawRangeCheckBox.Checked = true;
            this.DrawRangeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DrawRangeCheckBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawRangeCheckBox.ForeColor = System.Drawing.Color.White;
            this.DrawRangeCheckBox.Location = new System.Drawing.Point(26, 64);
            this.DrawRangeCheckBox.Name = "DrawRangeCheckBox";
            this.DrawRangeCheckBox.Size = new System.Drawing.Size(125, 22);
            this.DrawRangeCheckBox.TabIndex = 1;
            this.DrawRangeCheckBox.Text = "Draw Range";
            this.DrawRangeCheckBox.UseVisualStyleBackColor = true;
            this.DrawRangeCheckBox.CheckedChanged += new System.EventHandler(this.DrawRangeCheckBox_CheckedChanged);
            // 
            // MoveToMouseCheckBox
            // 
            this.MoveToMouseCheckBox.AutoSize = true;
            this.MoveToMouseCheckBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveToMouseCheckBox.ForeColor = System.Drawing.Color.White;
            this.MoveToMouseCheckBox.Location = new System.Drawing.Point(26, 109);
            this.MoveToMouseCheckBox.Name = "MoveToMouseCheckBox";
            this.MoveToMouseCheckBox.Size = new System.Drawing.Size(141, 22);
            this.MoveToMouseCheckBox.TabIndex = 2;
            this.MoveToMouseCheckBox.Text = "MoveToMouse";
            this.MoveToMouseCheckBox.UseVisualStyleBackColor = true;
            this.MoveToMouseCheckBox.CheckedChanged += new System.EventHandler(this.MoveToMouseCheckBox_CheckedChanged);
            // 
            // BasePlate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(33)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(299, 384);
            this.Controls.Add(this.MoveToMouseCheckBox);
            this.Controls.Add(this.DrawRangeCheckBox);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BasePlate";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.BasePlate_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox DrawRangeCheckBox;
        private System.Windows.Forms.CheckBox MoveToMouseCheckBox;
    }
}