namespace DBProject
{
    partial class BMW
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BMWM3BT = new System.Windows.Forms.Button();
            this.BMWX6BT = new System.Windows.Forms.Button();
            this.BMWX7BT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.BMWM3BT);
            this.panel1.Controls.Add(this.BMWX6BT);
            this.panel1.Controls.Add(this.BMWX7BT);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 528);
            this.panel1.TabIndex = 2;
            // 
            // BMWM3BT
            // 
            this.BMWM3BT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BMWM3BT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BMWM3BT.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BMWM3BT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BMWM3BT.Location = new System.Drawing.Point(6, 286);
            this.BMWM3BT.Name = "BMWM3BT";
            this.BMWM3BT.Size = new System.Drawing.Size(200, 49);
            this.BMWM3BT.TabIndex = 3;
            this.BMWM3BT.Text = "BMW M3";
            this.BMWM3BT.UseVisualStyleBackColor = false;
            // 
            // BMWX6BT
            // 
            this.BMWX6BT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BMWX6BT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BMWX6BT.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BMWX6BT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BMWX6BT.Location = new System.Drawing.Point(3, 219);
            this.BMWX6BT.Name = "BMWX6BT";
            this.BMWX6BT.Size = new System.Drawing.Size(200, 49);
            this.BMWX6BT.TabIndex = 2;
            this.BMWX6BT.Text = "BMW X6";
            this.BMWX6BT.UseVisualStyleBackColor = false;
            // 
            // BMWX7BT
            // 
            this.BMWX7BT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BMWX7BT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BMWX7BT.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BMWX7BT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BMWX7BT.Location = new System.Drawing.Point(3, 147);
            this.BMWX7BT.Name = "BMWX7BT";
            this.BMWX7BT.Size = new System.Drawing.Size(203, 49);
            this.BMWX7BT.TabIndex = 0;
            this.BMWX7BT.Text = "BMW X7";
            this.BMWX7BT.UseVisualStyleBackColor = false;
            // 
            // BMW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 528);
            this.Controls.Add(this.panel1);
            this.Name = "BMW";
            this.Text = "BMW";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button BMWM3BT;
        private Button BMWX6BT;
        private Button BMWX7BT;
    }
}