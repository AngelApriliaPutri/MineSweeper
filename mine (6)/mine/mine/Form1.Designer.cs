namespace mine
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.levelPanel = new System.Windows.Forms.Panel();
            this.StartPanel = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.levelPanel.SuspendLayout();
            this.StartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // levelPanel
            // 
            this.levelPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("levelPanel.BackgroundImage")));
            this.levelPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.levelPanel.Controls.Add(this.StartPanel);
            this.levelPanel.Controls.Add(this.btnHard);
            this.levelPanel.Controls.Add(this.btnMedium);
            this.levelPanel.Controls.Add(this.btnEasy);
            this.levelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.levelPanel.Location = new System.Drawing.Point(0, 0);
            this.levelPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.levelPanel.Name = "levelPanel";
            this.levelPanel.Size = new System.Drawing.Size(1200, 692);
            this.levelPanel.TabIndex = 0;
            // 
            // StartPanel
            // 
            this.StartPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartPanel.BackgroundImage")));
            this.StartPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartPanel.Controls.Add(this.btnStart);
            this.StartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartPanel.Location = new System.Drawing.Point(0, 0);
            this.StartPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(1200, 692);
            this.StartPanel.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Location = new System.Drawing.Point(509, 391);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(188, 63);
            this.btnStart.TabIndex = 0;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHard
            // 
            this.btnHard.BackColor = System.Drawing.Color.Transparent;
            this.btnHard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHard.Location = new System.Drawing.Point(705, 769);
            this.btnHard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(660, 151);
            this.btnHard.TabIndex = 2;
            this.btnHard.UseVisualStyleBackColor = false;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.BackColor = System.Drawing.Color.Transparent;
            this.btnMedium.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMedium.Location = new System.Drawing.Point(705, 508);
            this.btnMedium.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(660, 151);
            this.btnMedium.TabIndex = 1;
            this.btnMedium.UseVisualStyleBackColor = false;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnEasy
            // 
            this.btnEasy.BackColor = System.Drawing.Color.Transparent;
            this.btnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEasy.Location = new System.Drawing.Point(705, 249);
            this.btnEasy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(660, 151);
            this.btnEasy.TabIndex = 0;
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.levelPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.levelPanel.ResumeLayout(false);
            this.StartPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel levelPanel;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Panel StartPanel;
        private System.Windows.Forms.Button btnStart;
    }
}

