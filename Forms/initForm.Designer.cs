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
            this.chckBoxNormal = new System.Windows.Forms.CheckBox();
            this.chckBoxHardmode = new System.Windows.Forms.CheckBox();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.cBoxOpponent = new System.Windows.Forms.ComboBox();
            this.cBoxBoardSize = new System.Windows.Forms.ComboBox();
            this.cBoxLang = new System.Windows.Forms.ComboBox();
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
            // chckBoxNormal
            // 
            resources.ApplyResources(this.chckBoxNormal, "chckBoxNormal");
            this.chckBoxNormal.Name = "chckBoxNormal";
            this.chckBoxNormal.UseVisualStyleBackColor = true;
            this.chckBoxNormal.CheckedChanged += new System.EventHandler(this.chckBoxNormal_CheckedChanged);
            // 
            // chckBoxHardmode
            // 
            resources.ApplyResources(this.chckBoxHardmode, "chckBoxHardmode");
            this.chckBoxHardmode.Name = "chckBoxHardmode";
            this.chckBoxHardmode.UseVisualStyleBackColor = true;
            this.chckBoxHardmode.CheckedChanged += new System.EventHandler(this.chckBoxHardmode_CheckedChanged);
            // 
            // lblErrorMsg
            // 
            resources.ApplyResources(this.lblErrorMsg, "lblErrorMsg");
            this.lblErrorMsg.Name = "lblErrorMsg";
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
            // 
            // cBoxLang
            // 
            resources.ApplyResources(this.cBoxLang, "cBoxLang");
            this.cBoxLang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cBoxLang.FormattingEnabled = true;
            this.cBoxLang.Name = "cBoxLang";
            this.cBoxLang.SelectedIndexChanged += new System.EventHandler(this.cBoxLang_SelectedIndexChanged);
            // 
            // initForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ControlBox = false;
            this.Controls.Add(this.cBoxLang);
            this.Controls.Add(this.cBoxBoardSize);
            this.Controls.Add(this.cBoxOpponent);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.chckBoxHardmode);
            this.Controls.Add(this.chckBoxNormal);
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
        private System.Windows.Forms.CheckBox chckBoxNormal;
        private System.Windows.Forms.CheckBox chckBoxHardmode;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.ComboBox cBoxOpponent;
        private System.Windows.Forms.ComboBox cBoxBoardSize;
        private System.Windows.Forms.ComboBox cBoxLang;
    }
}