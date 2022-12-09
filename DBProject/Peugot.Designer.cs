namespace DBProject
{
    partial class Peugot
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
            this.P508BT = new System.Windows.Forms.Button();
            this.P208BT = new System.Windows.Forms.Button();
            this.P3008BT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.P508BT);
            this.panel1.Controls.Add(this.P208BT);
            this.panel1.Controls.Add(this.P3008BT);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 528);
            this.panel1.TabIndex = 3;
            // 
            // P508BT
            // 
            this.P508BT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.P508BT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.P508BT.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.P508BT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.P508BT.Location = new System.Drawing.Point(6, 286);
            this.P508BT.Name = "P508BT";
            this.P508BT.Size = new System.Drawing.Size(200, 49);
            this.P508BT.TabIndex = 3;
            this.P508BT.Text = "508";
            this.P508BT.UseVisualStyleBackColor = false;
            // 
            // P208BT
            // 
            this.P208BT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.P208BT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.P208BT.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.P208BT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.P208BT.Location = new System.Drawing.Point(3, 219);
            this.P208BT.Name = "P208BT";
            this.P208BT.Size = new System.Drawing.Size(200, 49);
            this.P208BT.TabIndex = 2;
            this.P208BT.Text = "208";
            this.P208BT.UseVisualStyleBackColor = false;
            // 
            // P3008BT
            // 
            this.P3008BT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.P3008BT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.P3008BT.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.P3008BT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.P3008BT.Location = new System.Drawing.Point(3, 147);
            this.P3008BT.Name = "P3008BT";
            this.P3008BT.Size = new System.Drawing.Size(203, 49);
            this.P3008BT.TabIndex = 0;
            this.P3008BT.Text = "3008";
            this.P3008BT.UseVisualStyleBackColor = false;
            // 
            // Peugot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 528);
            this.Controls.Add(this.panel1);
            this.Name = "Peugot";
            this.Text = "Peugot";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button P508BT;
        private Button P208BT;
        private Button P3008BT;
    }
}