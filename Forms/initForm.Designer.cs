namespace BumChessV2.Forms
{
    partial class initForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(initForm));
            this.btnQuitGame = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblGameName = new System.Windows.Forms.Label();
            this.cBoxOpponent = new System.Windows.Forms.ComboBox();
            this.cBoxBoardSize = new System.Windows.Forms.ComboBox();
            this.cBoxLang = new System.Windows.Forms.ComboBox();
            this.cBoxMode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnQuitGame
            // 
            resources.ApplyResources(this.btnQuitGame, "btnQuitGame");
            this.btnQuitGame.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnQuitGame.Name = "btnQuitGame";
            this.btnQuitGame.UseVisualStyleBackColor = false;
            this.btnQuitGame.Click += new System.EventHandler(this.btnQuitGame_Click);
            // 
            // btnStartGame
            // 
            resources.ApplyResources(this.btnStartGame, "btnStartGame");
            this.btnStartGame.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // lblGameName
            // 
            resources.ApplyResources(this.lblGameName, "lblGameName");
            this.lblGameName.Name = "lblGameName";
            // 
            // cBoxOpponent
            // 
            resources.ApplyResources(this.cBoxOpponent, "cBoxOpponent");
            this.cBoxOpponent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cBoxOpponent.FormattingEnabled = true;
            this.cBoxOpponent.Name = "cBoxOpponent";
            this.cBoxOpponent.SelectedIndexChanged += new System.EventHandler(this.cBoxOpponent_SelectedIndexChanged);
            // 
            // cBoxBoardSize
            // 
            resources.ApplyResources(this.cBoxBoardSize, "cBoxBoardSize");
            this.cBoxBoardSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cBoxBoardSize.FormattingEnabled = true;
            this.cBoxBoardSize.Name = "cBoxBoardSize";
            this.cBoxBoardSize.SelectedIndexChanged += new System.EventHandler(this.cBoxBoardSize_SelectedIndexChanged);
            // 
            // cBoxLang
            // 
            resources.ApplyResources(this.cBoxLang, "cBoxLang");
            this.cBoxLang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cBoxLang.FormattingEnabled = true;
            this.cBoxLang.Name = "cBoxLang";
            this.cBoxLang.SelectedIndexChanged += new System.EventHandler(this.cBoxLang_SelectedIndexChanged);
            // 
            // cBoxMode
            // 
            resources.ApplyResources(this.cBoxMode, "cBoxMode");
            this.cBoxMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cBoxMode.FormattingEnabled = true;
            this.cBoxMode.Name = "cBoxMode";
            // 
            // initForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ControlBox = false;
            this.Controls.Add(this.cBoxMode);
            this.Controls.Add(this.cBoxLang);
            this.Controls.Add(this.cBoxBoardSize);
            this.Controls.Add(this.cBoxOpponent);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnQuitGame);
            this.Name = "initForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnQuitGame;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.ComboBox cBoxOpponent;
        private System.Windows.Forms.ComboBox cBoxBoardSize;
        private System.Windows.Forms.ComboBox cBoxLang;
        private System.Windows.Forms.ComboBox cBoxMode;
    }
}