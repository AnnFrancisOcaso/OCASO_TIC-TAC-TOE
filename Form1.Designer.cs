
namespace ocaso_tic_tac_toe
{
    partial class TICTACTOE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TICTACTOE));
            this.R1 = new System.Windows.Forms.Button();
            this.R2 = new System.Windows.Forms.Button();
            this.R3 = new System.Windows.Forms.Button();
            this.S3 = new System.Windows.Forms.Button();
            this.S2 = new System.Windows.Forms.Button();
            this.S1 = new System.Windows.Forms.Button();
            this.T3 = new System.Windows.Forms.Button();
            this.T2 = new System.Windows.Forms.Button();
            this.T1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheCreatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // R1
            // 
            resources.ApplyResources(this.R1, "R1");
            this.R1.Name = "R1";
            this.R1.UseVisualStyleBackColor = true;
            this.R1.Click += new System.EventHandler(this.button1_Click);
            // 
            // R2
            // 
            resources.ApplyResources(this.R2, "R2");
            this.R2.Name = "R2";
            this.R2.UseVisualStyleBackColor = true;
            this.R2.Click += new System.EventHandler(this.button1_Click);
            // 
            // R3
            // 
            resources.ApplyResources(this.R3, "R3");
            this.R3.Name = "R3";
            this.R3.UseVisualStyleBackColor = true;
            this.R3.Click += new System.EventHandler(this.button1_Click);
            // 
            // S3
            // 
            resources.ApplyResources(this.S3, "S3");
            this.S3.Name = "S3";
            this.S3.UseVisualStyleBackColor = true;
            this.S3.Click += new System.EventHandler(this.button1_Click);
            // 
            // S2
            // 
            resources.ApplyResources(this.S2, "S2");
            this.S2.Name = "S2";
            this.S2.UseVisualStyleBackColor = true;
            this.S2.Click += new System.EventHandler(this.button1_Click);
            // 
            // S1
            // 
            resources.ApplyResources(this.S1, "S1");
            this.S1.Name = "S1";
            this.S1.UseVisualStyleBackColor = true;
            this.S1.Click += new System.EventHandler(this.button1_Click);
            // 
            // T3
            // 
            resources.ApplyResources(this.T3, "T3");
            this.T3.Name = "T3";
            this.T3.UseVisualStyleBackColor = true;
            this.T3.Click += new System.EventHandler(this.button1_Click);
            // 
            // T2
            // 
            resources.ApplyResources(this.T2, "T2");
            this.T2.Name = "T2";
            this.T2.UseVisualStyleBackColor = true;
            this.T2.Click += new System.EventHandler(this.button1_Click);
            // 
            // T1
            // 
            resources.ApplyResources(this.T1, "T1");
            this.T1.Name = "T1";
            this.T1.UseVisualStyleBackColor = true;
            this.T1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTheCreatorToolStripMenuItem,
            this.howToPlayToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutTheCreatorToolStripMenuItem
            // 
            this.aboutTheCreatorToolStripMenuItem.Name = "aboutTheCreatorToolStripMenuItem";
            resources.ApplyResources(this.aboutTheCreatorToolStripMenuItem, "aboutTheCreatorToolStripMenuItem");
            this.aboutTheCreatorToolStripMenuItem.Click += new System.EventHandler(this.aboutTheCreatorToolStripMenuItem_Click);
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            resources.ApplyResources(this.howToPlayToolStripMenuItem, "howToPlayToolStripMenuItem");
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.CadetBlue;
            resources.ApplyResources(this.Exit, "Exit");
            this.Exit.Name = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // TICTACTOE
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.T3);
            this.Controls.Add(this.T2);
            this.Controls.Add(this.T1);
            this.Controls.Add(this.S3);
            this.Controls.Add(this.S2);
            this.Controls.Add(this.S1);
            this.Controls.Add(this.R3);
            this.Controls.Add(this.R2);
            this.Controls.Add(this.R1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TICTACTOE";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button R1;
        private System.Windows.Forms.Button R2;
        private System.Windows.Forms.Button R3;
        private System.Windows.Forms.Button S3;
        private System.Windows.Forms.Button S2;
        private System.Windows.Forms.Button S1;
        private System.Windows.Forms.Button T3;
        private System.Windows.Forms.Button T2;
        private System.Windows.Forms.Button T1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTheCreatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        private System.Windows.Forms.Button Exit;
    }
}

