namespace DBProject
{
    partial class Mini
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
            this.CountrymanBT = new System.Windows.Forms.Button();
            this.ClubmanBT = new System.Windows.Forms.Button();
            this.MiniHatchBT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.CountrymanBT);
            this.panel1.Controls.Add(this.ClubmanBT);
            this.panel1.Controls.Add(this.MiniHatchBT);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 528);
            this.panel1.TabIndex = 1;
            // 
            // CountrymanBT
            // 
            this.CountrymanBT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CountrymanBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CountrymanBT.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CountrymanBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CountrymanBT.Location = new System.Drawing.Point(6, 286);
            this.CountrymanBT.Name = "CountrymanBT";
            this.CountrymanBT.Size = new System.Drawing.Size(200, 49);
            this.CountrymanBT.TabIndex = 3;
            this.CountrymanBT.Text = "Countryman";
            this.CountrymanBT.UseVisualStyleBackColor = false;
            // 
            // ClubmanBT
            // 
            this.ClubmanBT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClubmanBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClubmanBT.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClubmanBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClubmanBT.Location = new System.Drawing.Point(3, 219);
            this.ClubmanBT.Name = "ClubmanBT";
            this.ClubmanBT.Size = new System.Drawing.Size(200, 49);
            this.ClubmanBT.TabIndex = 2;
            this.ClubmanBT.Text = "Clubman";
            this.ClubmanBT.UseVisualStyleBackColor = false;
            // 
            // MiniHatchBT
            // 
            this.MiniHatchBT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MiniHatchBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MiniHatchBT.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MiniHatchBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MiniHatchBT.Location = new System.Drawing.Point(3, 147);
            this.MiniHatchBT.Name = "MiniHatchBT";
            this.MiniHatchBT.Size = new System.Drawing.Size(203, 49);
            this.MiniHatchBT.TabIndex = 0;
            this.MiniHatchBT.Text = "Mini Hatch";
            this.MiniHatchBT.UseVisualStyleBackColor = false;
            // 
            // Mini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 528);
            this.Controls.Add(this.panel1);
            this.Name = "Mini";
            this.Text = "Mini";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button CountrymanBT;
        private Button ClubmanBT;
        private Button MiniHatchBT;
    }
}