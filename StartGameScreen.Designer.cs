namespace _4opeenrij
{
    partial class StartGameScreen
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
            this.components = new System.ComponentModel.Container();
            this.labelPlayerOne = new System.Windows.Forms.Label();
            this.labelPlayerTwo = new System.Windows.Forms.Label();
            this.comboBoxPlayerOne = new System.Windows.Forms.ComboBox();
            this.comboBoxPlayerTwo = new System.Windows.Forms.ComboBox();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.playerOneOptions = new _4opeenrij.playerOneOptions();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersTableAdapter = new _4opeenrij.playerOneOptionsTableAdapters.playersTableAdapter();
            this.playerTwoOptions = new _4opeenrij.playerTwoOptions();
            this.playersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.playersTableAdapter1 = new _4opeenrij.playerTwoOptionsTableAdapters.playersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.playerOneOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTwoOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPlayerOne
            // 
            this.labelPlayerOne.AutoSize = true;
            this.labelPlayerOne.Location = new System.Drawing.Point(12, 22);
            this.labelPlayerOne.Name = "labelPlayerOne";
            this.labelPlayerOne.Size = new System.Drawing.Size(49, 13);
            this.labelPlayerOne.TabIndex = 0;
            this.labelPlayerOne.Text = "Speler 1:";
            // 
            // labelPlayerTwo
            // 
            this.labelPlayerTwo.AutoSize = true;
            this.labelPlayerTwo.Location = new System.Drawing.Point(183, 22);
            this.labelPlayerTwo.Name = "labelPlayerTwo";
            this.labelPlayerTwo.Size = new System.Drawing.Size(49, 13);
            this.labelPlayerTwo.TabIndex = 1;
            this.labelPlayerTwo.Text = "Speler 2:";
            // 
            // comboBoxPlayerOne
            // 
            this.comboBoxPlayerOne.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.playersBindingSource, "id", true));
            this.comboBoxPlayerOne.DataSource = this.playersBindingSource;
            this.comboBoxPlayerOne.DisplayMember = "name";
            this.comboBoxPlayerOne.FormattingEnabled = true;
            this.comboBoxPlayerOne.Location = new System.Drawing.Point(15, 47);
            this.comboBoxPlayerOne.Name = "comboBoxPlayerOne";
            this.comboBoxPlayerOne.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPlayerOne.TabIndex = 2;
            this.comboBoxPlayerOne.ValueMember = "id";
            // 
            // comboBoxPlayerTwo
            // 
            this.comboBoxPlayerTwo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.playersBindingSource1, "id", true));
            this.comboBoxPlayerTwo.DataSource = this.playersBindingSource1;
            this.comboBoxPlayerTwo.DisplayMember = "name";
            this.comboBoxPlayerTwo.FormattingEnabled = true;
            this.comboBoxPlayerTwo.Location = new System.Drawing.Point(186, 47);
            this.comboBoxPlayerTwo.Name = "comboBoxPlayerTwo";
            this.comboBoxPlayerTwo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPlayerTwo.TabIndex = 3;
            this.comboBoxPlayerTwo.ValueMember = "id";
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(15, 90);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(292, 23);
            this.buttonStartGame.TabIndex = 4;
            this.buttonStartGame.Text = "Start het spel!";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // playerOneOptions
            // 
            this.playerOneOptions.DataSetName = "playerOneOptions";
            this.playerOneOptions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "players";
            this.playersBindingSource.DataSource = this.playerOneOptions;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // playerTwoOptions
            // 
            this.playerTwoOptions.DataSetName = "playerTwoOptions";
            this.playerTwoOptions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playersBindingSource1
            // 
            this.playersBindingSource1.DataMember = "players";
            this.playersBindingSource1.DataSource = this.playerTwoOptions;
            // 
            // playersTableAdapter1
            // 
            this.playersTableAdapter1.ClearBeforeFill = true;
            // 
            // StartGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 125);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.comboBoxPlayerTwo);
            this.Controls.Add(this.comboBoxPlayerOne);
            this.Controls.Add(this.labelPlayerTwo);
            this.Controls.Add(this.labelPlayerOne);
            this.Name = "StartGameScreen";
            this.Text = "4 op een rij";
            this.Load += new System.EventHandler(this.GameStartScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerOneOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTwoOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlayerOne;
        private System.Windows.Forms.Label labelPlayerTwo;
        private System.Windows.Forms.ComboBox comboBoxPlayerOne;
        private System.Windows.Forms.ComboBox comboBoxPlayerTwo;
        private System.Windows.Forms.Button buttonStartGame;
        private playerOneOptions playerOneOptions;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private playerOneOptionsTableAdapters.playersTableAdapter playersTableAdapter;
        private playerTwoOptions playerTwoOptions;
        private System.Windows.Forms.BindingSource playersBindingSource1;
        private playerTwoOptionsTableAdapters.playersTableAdapter playersTableAdapter1;
    }
}

