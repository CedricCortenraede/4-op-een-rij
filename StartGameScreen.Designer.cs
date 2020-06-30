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
            this.b2D4_CasusDataSetUsers = new _4opeenrij.B2D4_CasusDataSetUsers();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new _4opeenrij.B2D4_CasusDataSetUsersTableAdapters.usersTableAdapter();
            this.b2D4_CasusDataSetUsers2 = new _4opeenrij.B2D4_CasusDataSetUsers2();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter1 = new _4opeenrij.B2D4_CasusDataSetUsers2TableAdapters.usersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.b2D4_CasusDataSetUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2D4_CasusDataSetUsers2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
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
            this.comboBoxPlayerOne.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usersBindingSource, "id", true));
            this.comboBoxPlayerOne.DataSource = this.usersBindingSource;
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
            this.comboBoxPlayerTwo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usersBindingSource1, "id", true));
            this.comboBoxPlayerTwo.DataSource = this.usersBindingSource1;
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
            // b2D4_CasusDataSetUsers
            // 
            this.b2D4_CasusDataSetUsers.DataSetName = "B2D4_CasusDataSetUsers";
            this.b2D4_CasusDataSetUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.b2D4_CasusDataSetUsers;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // b2D4_CasusDataSetUsers2
            // 
            this.b2D4_CasusDataSetUsers2.DataSetName = "B2D4_CasusDataSetUsers2";
            this.b2D4_CasusDataSetUsers2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "users";
            this.usersBindingSource1.DataSource = this.b2D4_CasusDataSetUsers2;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // GameStartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 125);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.comboBoxPlayerTwo);
            this.Controls.Add(this.comboBoxPlayerOne);
            this.Controls.Add(this.labelPlayerTwo);
            this.Controls.Add(this.labelPlayerOne);
            this.Name = "GameStartScreen";
            this.Text = "4 op een rij";
            this.Load += new System.EventHandler(this.GameStartScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.b2D4_CasusDataSetUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2D4_CasusDataSetUsers2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlayerOne;
        private System.Windows.Forms.Label labelPlayerTwo;
        private System.Windows.Forms.ComboBox comboBoxPlayerOne;
        private System.Windows.Forms.ComboBox comboBoxPlayerTwo;
        private System.Windows.Forms.Button buttonStartGame;
        private B2D4_CasusDataSetUsers b2D4_CasusDataSetUsers;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private B2D4_CasusDataSetUsersTableAdapters.usersTableAdapter usersTableAdapter;
        private B2D4_CasusDataSetUsers2 b2D4_CasusDataSetUsers2;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private B2D4_CasusDataSetUsers2TableAdapters.usersTableAdapter usersTableAdapter1;
    }
}

