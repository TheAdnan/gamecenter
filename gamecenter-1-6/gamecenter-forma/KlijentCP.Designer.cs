namespace gamecenter_forma
{
    partial class KlijentCP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KlijentCP));
            this.label1 = new System.Windows.Forms.Label();
            this.tabovi_klijent = new System.Windows.Forms.TabControl();
            this.Home_tab = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabovi_klijent.SuspendLayout();
            this.Home_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Blog the impaler", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "welcome to club of duty!";
            // 
            // tabovi_klijent
            // 
            this.tabovi_klijent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabovi_klijent.Controls.Add(this.Home_tab);
            this.tabovi_klijent.Controls.Add(this.tabPage2);
            this.tabovi_klijent.Location = new System.Drawing.Point(2, 3);
            this.tabovi_klijent.Name = "tabovi_klijent";
            this.tabovi_klijent.SelectedIndex = 0;
            this.tabovi_klijent.Size = new System.Drawing.Size(815, 506);
            this.tabovi_klijent.TabIndex = 1;
            // 
            // Home_tab
            // 
            this.Home_tab.Controls.Add(this.label1);
            this.Home_tab.Location = new System.Drawing.Point(4, 25);
            this.Home_tab.Name = "Home_tab";
            this.Home_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Home_tab.Size = new System.Drawing.Size(807, 477);
            this.Home_tab.TabIndex = 0;
            this.Home_tab.Text = "Home";
            this.Home_tab.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(807, 477);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // KlijentCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 511);
            this.Controls.Add(this.tabovi_klijent);
            this.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KlijentCP";
            this.Text = "Club of duty";
            this.tabovi_klijent.ResumeLayout(false);
            this.Home_tab.ResumeLayout(false);
            this.Home_tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabovi_klijent;
        private System.Windows.Forms.TabPage Home_tab;
        private System.Windows.Forms.TabPage tabPage2;
    }
}