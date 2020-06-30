namespace _4opeenrij
{
    partial class LandingScreen
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
            this.buttonGoInToGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGoInToGame
            // 
            this.buttonGoInToGame.Location = new System.Drawing.Point(12, 12);
            this.buttonGoInToGame.Name = "buttonGoInToGame";
            this.buttonGoInToGame.Size = new System.Drawing.Size(222, 23);
            this.buttonGoInToGame.TabIndex = 0;
            this.buttonGoInToGame.Text = "Ga naar het spel!";
            this.buttonGoInToGame.UseVisualStyleBackColor = true;
            this.buttonGoInToGame.Click += new System.EventHandler(this.buttonGoInToGame_Click);
            // 
            // LandingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGoInToGame);
            this.Name = "LandingScreen";
            this.Text = "LandingScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGoInToGame;
    }
}