
namespace DifficultySettings
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.easyButton = new System.Windows.Forms.Button();
            this.normalButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.beginButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel.Location = new System.Drawing.Point(26, 67);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(208, 29);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Enter Your Name:";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(240, 71);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(299, 26);
            this.nameInput.TabIndex = 1;
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.Font = new System.Drawing.Font("Maiandra GD", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.difficultyLabel.Location = new System.Drawing.Point(128, 137);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(289, 43);
            this.difficultyLabel.TabIndex = 2;
            this.difficultyLabel.Text = "Select Difficulty Level:";
            // 
            // easyButton
            // 
            this.easyButton.BackColor = System.Drawing.Color.Black;
            this.easyButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.easyButton.FlatAppearance.BorderSize = 3;
            this.easyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.easyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.easyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easyButton.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyButton.ForeColor = System.Drawing.Color.White;
            this.easyButton.Location = new System.Drawing.Point(53, 224);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(111, 77);
            this.easyButton.TabIndex = 3;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = false;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // normalButton
            // 
            this.normalButton.BackColor = System.Drawing.Color.Black;
            this.normalButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.normalButton.FlatAppearance.BorderSize = 3;
            this.normalButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.normalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.normalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.normalButton.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalButton.ForeColor = System.Drawing.Color.White;
            this.normalButton.Location = new System.Drawing.Point(231, 224);
            this.normalButton.Name = "normalButton";
            this.normalButton.Size = new System.Drawing.Size(111, 77);
            this.normalButton.TabIndex = 4;
            this.normalButton.Text = "Normal";
            this.normalButton.UseVisualStyleBackColor = false;
            this.normalButton.Click += new System.EventHandler(this.normalButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.BackColor = System.Drawing.Color.Black;
            this.hardButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.hardButton.FlatAppearance.BorderSize = 3;
            this.hardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.hardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardButton.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardButton.ForeColor = System.Drawing.Color.White;
            this.hardButton.Location = new System.Drawing.Point(408, 224);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(111, 77);
            this.hardButton.TabIndex = 5;
            this.hardButton.Text = "Hard";
            this.hardButton.UseVisualStyleBackColor = false;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            // 
            // beginButton
            // 
            this.beginButton.BackColor = System.Drawing.Color.Black;
            this.beginButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.beginButton.FlatAppearance.BorderSize = 3;
            this.beginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.beginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.beginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beginButton.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginButton.ForeColor = System.Drawing.Color.White;
            this.beginButton.Location = new System.Drawing.Point(190, 331);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(195, 76);
            this.beginButton.TabIndex = 6;
            this.beginButton.Text = "Begin";
            this.beginButton.UseVisualStyleBackColor = false;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Maiandra GD", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(31, 423);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(508, 93);
            this.outputLabel.TabIndex = 7;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(570, 538);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.normalButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hero Quest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button normalButton;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

