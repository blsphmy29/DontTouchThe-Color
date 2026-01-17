namespace DontTouchThe_Color
{
    partial class mainMenu
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.screenPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(0, 112);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(180, 80);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Play";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonOptions
            // 
            this.buttonOptions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonOptions.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOptions.Location = new System.Drawing.Point(0, 284);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonOptions.Size = new System.Drawing.Size(180, 80);
            this.buttonOptions.TabIndex = 1;
            this.buttonOptions.Text = "Options";
            this.buttonOptions.UseVisualStyleBackColor = false;
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(0, 370);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(180, 80);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.UseWaitCursor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuPanel.Controls.Add(this.button1);
            this.menuPanel.Controls.Add(this.buttonExit);
            this.menuPanel.Controls.Add(this.buttonStart);
            this.menuPanel.Controls.Add(this.buttonOptions);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(180, 450);
            this.menuPanel.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 80);
            this.button1.TabIndex = 4;
            this.button1.Text = "Time Mode";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // screenPanel
            // 
            this.screenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenPanel.Location = new System.Drawing.Point(180, 0);
            this.screenPanel.Name = "screenPanel";
            this.screenPanel.Size = new System.Drawing.Size(620, 450);
            this.screenPanel.TabIndex = 4;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.screenPanel);
            this.Controls.Add(this.menuPanel);
            this.MaximizeBox = false;
            this.Name = "mainMenu";
            this.Text = "Don\'t touch the color";
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel screenPanel;
        private System.Windows.Forms.Button button1;
    }
}

