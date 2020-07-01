namespace _4opeenrij
{
    partial class InGameScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelMoveUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(222, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 600);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Beurt van:";
            // 
            // labelMoveUsername
            // 
            this.labelMoveUsername.AutoSize = true;
            this.labelMoveUsername.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoveUsername.Location = new System.Drawing.Point(13, 102);
            this.labelMoveUsername.Name = "labelMoveUsername";
            this.labelMoveUsername.Size = new System.Drawing.Size(46, 24);
            this.labelMoveUsername.TabIndex = 2;
            this.labelMoveUsername.Text = "Gast";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_4opeenrij.Properties.Resources.rsz_5efca67b86cac;
            this.pictureBox1.Location = new System.Drawing.Point(12, 511);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // InGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 623);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelMoveUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "InGameScreen";
            this.Text = "InGameScreen";
            this.Load += new System.EventHandler(this.InGameScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMoveUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}