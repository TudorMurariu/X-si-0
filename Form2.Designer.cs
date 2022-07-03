namespace X_si_0
{
    partial class MessageBoX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoX));
            this.Joe = new System.Windows.Forms.Button();
            this.NewGame = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Joe
            // 
            this.Joe.BackColor = System.Drawing.Color.Red;
            this.Joe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Joe.Location = new System.Drawing.Point(45, 306);
            this.Joe.Name = "Joe";
            this.Joe.Size = new System.Drawing.Size(124, 49);
            this.Joe.TabIndex = 0;
            this.Joe.Text = "Find out who joe is";
            this.Joe.UseVisualStyleBackColor = false;
            this.Joe.Click += new System.EventHandler(this.Joe_Click);
            // 
            // NewGame
            // 
            this.NewGame.BackColor = System.Drawing.Color.Lime;
            this.NewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NewGame.Location = new System.Drawing.Point(213, 306);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(129, 49);
            this.NewGame.TabIndex = 1;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = false;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Blue;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exit.Location = new System.Drawing.Point(385, 306);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(136, 49);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(134, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 71);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MessageBoX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 429);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.Joe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageBoX";
            this.Text = "So you wanna know how.s Joe";
            this.Load += new System.EventHandler(this.MessageBoX_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Joe;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
    }
}