namespace Assignment_11._3_FrontEnd
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvGames = new DataGridView();
            btnAddGame = new Button();
            btnDeleteGame = new Button();
            btnUpdateGame = new Button();
            btnGetGames = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTitle = new TextBox();
            txtDeveloper = new TextBox();
            txtReleaseYear = new TextBox();
            txtPublisher = new TextBox();
            txtID = new TextBox();
            label5 = new Label();
            btnClearFields = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGames).BeginInit();
            SuspendLayout();
            // 
            // dgvGames
            // 
            dgvGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGames.Location = new Point(15, 12);
            dgvGames.Name = "dgvGames";
            dgvGames.Size = new Size(569, 244);
            dgvGames.TabIndex = 0;
            dgvGames.TabStop = false;
            dgvGames.SelectionChanged += dgvGames_SelectionChanged;
            // 
            // btnAddGame
            // 
            btnAddGame.Location = new Point(395, 297);
            btnAddGame.Name = "btnAddGame";
            btnAddGame.Size = new Size(100, 23);
            btnAddGame.TabIndex = 1;
            btnAddGame.TabStop = false;
            btnAddGame.Text = "Add Game";
            btnAddGame.UseVisualStyleBackColor = true;
            btnAddGame.Click += btnAddGame_Click;
            // 
            // btnDeleteGame
            // 
            btnDeleteGame.Location = new Point(395, 356);
            btnDeleteGame.Name = "btnDeleteGame";
            btnDeleteGame.Size = new Size(100, 23);
            btnDeleteGame.TabIndex = 2;
            btnDeleteGame.TabStop = false;
            btnDeleteGame.Text = "Delete Game";
            btnDeleteGame.UseVisualStyleBackColor = true;
            btnDeleteGame.Click += btnDeleteGame_Click;
            // 
            // btnUpdateGame
            // 
            btnUpdateGame.Location = new Point(395, 326);
            btnUpdateGame.Name = "btnUpdateGame";
            btnUpdateGame.Size = new Size(100, 23);
            btnUpdateGame.TabIndex = 3;
            btnUpdateGame.TabStop = false;
            btnUpdateGame.Text = "Update Game";
            btnUpdateGame.UseVisualStyleBackColor = true;
            btnUpdateGame.Click += btnUpdateGame_Click;
            // 
            // btnGetGames
            // 
            btnGetGames.Location = new Point(395, 267);
            btnGetGames.Name = "btnGetGames";
            btnGetGames.Size = new Size(100, 23);
            btnGetGames.TabIndex = 4;
            btnGetGames.TabStop = false;
            btnGetGames.Text = "Get Games";
            btnGetGames.UseVisualStyleBackColor = true;
            btnGetGames.Click += btnGetGames_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 299);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 5;
            label1.Text = "Title:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 329);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 6;
            label2.Text = "Developer:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 358);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 7;
            label3.Text = "Publisher:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(104, 388);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 8;
            label4.Text = "Release Year:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(184, 296);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(196, 23);
            txtTitle.TabIndex = 1;
            // 
            // txtDeveloper
            // 
            txtDeveloper.Location = new Point(184, 326);
            txtDeveloper.Name = "txtDeveloper";
            txtDeveloper.Size = new Size(196, 23);
            txtDeveloper.TabIndex = 2;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(184, 385);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(196, 23);
            txtReleaseYear.TabIndex = 4;
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(184, 355);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(196, 23);
            txtPublisher.TabIndex = 3;
            // 
            // txtID
            // 
            txtID.Location = new Point(184, 267);
            txtID.Name = "txtID";
            txtID.Size = new Size(196, 23);
            txtID.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(157, 270);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 14;
            label5.Text = "ID:";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // btnClearFields
            // 
            btnClearFields.Location = new Point(395, 385);
            btnClearFields.Name = "btnClearFields";
            btnClearFields.Size = new Size(100, 23);
            btnClearFields.TabIndex = 15;
            btnClearFields.TabStop = false;
            btnClearFields.Text = "Clear Fields";
            btnClearFields.UseVisualStyleBackColor = true;
            btnClearFields.Click += btnClearFields_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 423);
            Controls.Add(btnClearFields);
            Controls.Add(label5);
            Controls.Add(txtID);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPublisher);
            Controls.Add(txtDeveloper);
            Controls.Add(txtTitle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGetGames);
            Controls.Add(btnUpdateGame);
            Controls.Add(btnDeleteGame);
            Controls.Add(btnAddGame);
            Controls.Add(dgvGames);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Video Games";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGames).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvGames;
        private Button btnAddGame;
        private Button btnDeleteGame;
        private Button btnUpdateGame;
        private Button btnGetGames;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTitle;
        private TextBox txtDeveloper;
        private TextBox txtReleaseYear;
        private TextBox txtPublisher;
        private TextBox txtID;
        private Label label5;
        private Button btnClearFields;
    }
}
