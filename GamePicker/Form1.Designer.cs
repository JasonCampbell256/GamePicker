
namespace GamePicker
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
            this.label1 = new System.Windows.Forms.Label();
            this._textBoxGame = new System.Windows.Forms.TextBox();
            this._textBoxConsole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._textBoxYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._buttonPick = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._comboBoxYearFilter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this._comboBoxConsoleFilter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this._textBoxDescription = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this._textBoxRegion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game";
            // 
            // _textBoxGame
            // 
            this._textBoxGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxGame.Location = new System.Drawing.Point(79, 11);
            this._textBoxGame.Name = "_textBoxGame";
            this._textBoxGame.Size = new System.Drawing.Size(245, 23);
            this._textBoxGame.TabIndex = 1;
            // 
            // _textBoxConsole
            // 
            this._textBoxConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxConsole.Location = new System.Drawing.Point(79, 40);
            this._textBoxConsole.Name = "_textBoxConsole";
            this._textBoxConsole.Size = new System.Drawing.Size(245, 23);
            this._textBoxConsole.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Console";
            // 
            // _textBoxYear
            // 
            this._textBoxYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxYear.Location = new System.Drawing.Point(79, 98);
            this._textBoxYear.Name = "_textBoxYear";
            this._textBoxYear.Size = new System.Drawing.Size(245, 23);
            this._textBoxYear.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Year";
            // 
            // _buttonPick
            // 
            this._buttonPick.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonPick.Location = new System.Drawing.Point(3, 344);
            this._buttonPick.Name = "_buttonPick";
            this._buttonPick.Size = new System.Drawing.Size(314, 23);
            this._buttonPick.TabIndex = 6;
            this._buttonPick.Text = "Pick Random Game";
            this._buttonPick.UseVisualStyleBackColor = true;
            this._buttonPick.Click += new System.EventHandler(this.onButtonClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._comboBoxRegion);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this._buttonPick);
            this.splitContainer1.Panel1.Controls.Add(this._comboBoxYearFilter);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this._comboBoxConsoleFilter);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._textBoxDescription);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this._textBoxRegion);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this._textBoxGame);
            this.splitContainer1.Panel2.Controls.Add(this._textBoxYear);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this._textBoxConsole);
            this.splitContainer1.Panel2.Enabled = false;
            this.splitContainer1.Size = new System.Drawing.Size(660, 379);
            this.splitContainer1.SplitterDistance = 320;
            this.splitContainer1.TabIndex = 7;
            // 
            // _comboBoxRegion
            // 
            this._comboBoxRegion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._comboBoxRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxRegion.FormattingEnabled = true;
            this._comboBoxRegion.Items.AddRange(new object[] {
            "",
            "Nintendo 64",
            "Sony Playstation"});
            this._comboBoxRegion.Location = new System.Drawing.Point(69, 69);
            this._comboBoxRegion.Name = "_comboBoxRegion";
            this._comboBoxRegion.Size = new System.Drawing.Size(248, 23);
            this._comboBoxRegion.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Region";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Filters";
            // 
            // _comboBoxYearFilter
            // 
            this._comboBoxYearFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._comboBoxYearFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxYearFilter.Enabled = false;
            this._comboBoxYearFilter.FormattingEnabled = true;
            this._comboBoxYearFilter.Items.AddRange(new object[] {
            "",
            "2000",
            "1996"});
            this._comboBoxYearFilter.Location = new System.Drawing.Point(69, 98);
            this._comboBoxYearFilter.Name = "_comboBoxYearFilter";
            this._comboBoxYearFilter.Size = new System.Drawing.Size(248, 23);
            this._comboBoxYearFilter.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Year";
            // 
            // _comboBoxConsoleFilter
            // 
            this._comboBoxConsoleFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._comboBoxConsoleFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxConsoleFilter.FormattingEnabled = true;
            this._comboBoxConsoleFilter.Items.AddRange(new object[] {
            "",
            "Nintendo 64",
            "Sony Playstation"});
            this._comboBoxConsoleFilter.Location = new System.Drawing.Point(69, 40);
            this._comboBoxConsoleFilter.Name = "_comboBoxConsoleFilter";
            this._comboBoxConsoleFilter.Size = new System.Drawing.Size(248, 23);
            this._comboBoxConsoleFilter.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Console";
            // 
            // _textBoxDescription
            // 
            this._textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxDescription.Location = new System.Drawing.Point(79, 127);
            this._textBoxDescription.Multiline = true;
            this._textBoxDescription.Name = "_textBoxDescription";
            this._textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._textBoxDescription.Size = new System.Drawing.Size(245, 240);
            this._textBoxDescription.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Description";
            // 
            // _textBoxRegion
            // 
            this._textBoxRegion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxRegion.Location = new System.Drawing.Point(79, 69);
            this._textBoxRegion.Name = "_textBoxRegion";
            this._textBoxRegion.Size = new System.Drawing.Size(245, 23);
            this._textBoxRegion.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Region";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 379);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Futureman\'s Game Randomizer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _textBoxGame;
        private System.Windows.Forms.TextBox _textBoxConsole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _textBoxYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _buttonPick;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox _comboBoxYearFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox _comboBoxConsoleFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox _comboBoxRegion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _textBoxDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox _textBoxRegion;
        private System.Windows.Forms.Label label8;
    }
}

