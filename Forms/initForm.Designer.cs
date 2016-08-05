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
            this.btnEnglish = new System.Windows.Forms.Button();
            this.btnSwedish = new System.Windows.Forms.Button();
            this.btnQuitGame = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblGameName = new System.Windows.Forms.Label();
            this.chckBoxNormal = new System.Windows.Forms.CheckBox();
            this.chckBoxHardmode = new System.Windows.Forms.CheckBox();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.cBoxOpponent = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnEnglish
            // 
            this.btnEnglish.Image = ((System.Drawing.Image)(resources.GetObject("btnEnglish.Image")));
            this.btnEnglish.Location = new System.Drawing.Point(12, 26);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(204, 108);
            this.btnEnglish.TabIndex = 0;
            this.btnEnglish.UseVisualStyleBackColor = true;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click);
            // 
            // btnSwedish
            // 
            this.btnSwedish.Image = ((System.Drawing.Image)(resources.GetObject("btnSwedish.Image")));
            this.btnSwedish.Location = new System.Drawing.Point(237, 26);
            this.btnSwedish.Margin = new System.Windows.Forms.Padding(0);
            this.btnSwedish.Name = "btnSwedish";
            this.btnSwedish.Size = new System.Drawing.Size(204, 108);
            this.btnSwedish.TabIndex = 1;
            this.btnSwedish.UseVisualStyleBackColor = true;
            this.btnSwedish.Click += new System.EventHandler(this.btnSwedish_Click);
            // 
            // btnQuitGame
            // 
            this.btnQuitGame.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnQuitGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitGame.Location = new System.Drawing.Point(237, 285);
            this.btnQuitGame.Name = "btnQuitGame";
            this.btnQuitGame.Size = new System.Drawing.Size(117, 46);
            this.btnQuitGame.TabIndex = 2;
            this.btnQuitGame.Text = "Q U I T";
            this.btnQuitGame.UseVisualStyleBackColor = false;
            this.btnQuitGame.Click += new System.EventHandler(this.btnQuitGame_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(99, 285);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(117, 46);
            this.btnStartGame.TabIndex = 3;
            this.btnStartGame.Text = "P L A Y";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.Location = new System.Drawing.Point(46, 137);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(373, 50);
            this.lblGameName.TabIndex = 4;
            this.lblGameName.Text = "B u m C h e s s  v.2";
            // 
            // chckBoxNormal
            // 
            this.chckBoxNormal.AutoSize = true;
            this.chckBoxNormal.Location = new System.Drawing.Point(156, 202);
            this.chckBoxNormal.Name = "chckBoxNormal";
            this.chckBoxNormal.Size = new System.Drawing.Size(88, 17);
            this.chckBoxNormal.TabIndex = 5;
            this.chckBoxNormal.Text = "Normal mode";
            this.chckBoxNormal.UseVisualStyleBackColor = true;
            this.chckBoxNormal.CheckedChanged += new System.EventHandler(this.chckBoxNormal_CheckedChanged);
            // 
            // chckBoxHardmode
            // 
            this.chckBoxHardmode.AutoSize = true;
            this.chckBoxHardmode.Location = new System.Drawing.Point(156, 225);
            this.chckBoxHardmode.Name = "chckBoxHardmode";
            this.chckBoxHardmode.Size = new System.Drawing.Size(164, 17);
            this.chckBoxHardmode.TabIndex = 6;
            this.chckBoxHardmode.Text = "SUPERDUPERHARDMODE";
            this.chckBoxHardmode.UseVisualStyleBackColor = true;
            this.chckBoxHardmode.CheckedChanged += new System.EventHandler(this.chckBoxHardmode_CheckedChanged);
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMsg.Location = new System.Drawing.Point(96, 337);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(0, 18);
            this.lblErrorMsg.TabIndex = 7;
            // 
            // cBoxOpponent
            // 
            this.cBoxOpponent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cBoxOpponent.FormattingEnabled = true;
            this.cBoxOpponent.Location = new System.Drawing.Point(156, 249);
            this.cBoxOpponent.Name = "cBoxOpponent";
            this.cBoxOpponent.Size = new System.Drawing.Size(145, 21);
            this.cBoxOpponent.TabIndex = 8;
            this.cBoxOpponent.SelectedIndexChanged += new System.EventHandler(this.cBoxOpponent_SelectedIndexChanged);
            // 
            // initForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(459, 364);
            this.ControlBox = false;
            this.Controls.Add(this.cBoxOpponent);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.chckBoxHardmode);
            this.Controls.Add(this.chckBoxNormal);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnQuitGame);
            this.Controls.Add(this.btnSwedish);
            this.Controls.Add(this.btnEnglish);
            this.Name = "initForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BumChess v.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.Button btnSwedish;
        private System.Windows.Forms.Button btnQuitGame;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.CheckBox chckBoxNormal;
        private System.Windows.Forms.CheckBox chckBoxHardmode;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.ComboBox cBoxOpponent;
    }
}