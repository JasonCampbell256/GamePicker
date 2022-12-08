
namespace GamePicker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this._textBoxConsole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._buttonPick = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this._checkBoxRegionEurope = new System.Windows.Forms.CheckBox();
            this._checkBoxRegionJapan = new System.Windows.Forms.CheckBox();
            this._checkBoxRegionUSA = new System.Windows.Forms.CheckBox();
            this._textBoxSearchTerms = new System.Windows.Forms.TextBox();
            this._buttonResetFilters = new System.Windows.Forms.Button();
            this._listBoxConsoleFilter = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._textBoxRegion = new System.Windows.Forms.TextBox();
            this._textBoxGame = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game";
            // 
            // _textBoxConsole
            // 
            this._textBoxConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxConsole.Location = new System.Drawing.Point(82, 89);
            this._textBoxConsole.Name = "_textBoxConsole";
            this._textBoxConsole.ReadOnly = true;
            this._textBoxConsole.Size = new System.Drawing.Size(257, 23);
            this._textBoxConsole.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Console";
            // 
            // _buttonPick
            // 
            this._buttonPick.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonPick.Location = new System.Drawing.Point(15, 647);
            this._buttonPick.Name = "_buttonPick";
            this._buttonPick.Size = new System.Drawing.Size(294, 38);
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
            this.splitContainer1.Panel1.Controls.Add(this.label13);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this._checkBoxRegionEurope);
            this.splitContainer1.Panel1.Controls.Add(this._checkBoxRegionJapan);
            this.splitContainer1.Panel1.Controls.Add(this._checkBoxRegionUSA);
            this.splitContainer1.Panel1.Controls.Add(this._textBoxSearchTerms);
            this.splitContainer1.Panel1.Controls.Add(this._buttonResetFilters);
            this.splitContainer1.Panel1.Controls.Add(this._buttonPick);
            this.splitContainer1.Panel1.Controls.Add(this._listBoxConsoleFilter);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label14);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this._textBoxRegion);
            this.splitContainer1.Panel2.Controls.Add(this._textBoxGame);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this._textBoxConsole);
            this.splitContainer1.Size = new System.Drawing.Size(676, 694);
            this.splitContainer1.SplitterDistance = 321;
            this.splitContainer1.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(15, 645);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(300, 2);
            this.label13.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(15, 587);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(300, 2);
            this.label12.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 630);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Created by JasonRulesUDont";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(15, 628);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(300, 2);
            this.label9.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(15, 555);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 2);
            this.label6.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(15, 524);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 2);
            this.label5.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Region Filter";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(15, 452);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(300, 2);
            this.label10.TabIndex = 19;
            // 
            // _checkBoxRegionEurope
            // 
            this._checkBoxRegionEurope.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._checkBoxRegionEurope.AutoSize = true;
            this._checkBoxRegionEurope.Location = new System.Drawing.Point(19, 504);
            this._checkBoxRegionEurope.Name = "_checkBoxRegionEurope";
            this._checkBoxRegionEurope.Size = new System.Drawing.Size(63, 19);
            this._checkBoxRegionEurope.TabIndex = 14;
            this._checkBoxRegionEurope.Text = "Europe";
            this._checkBoxRegionEurope.UseVisualStyleBackColor = true;
            this._checkBoxRegionEurope.CheckedChanged += new System.EventHandler(this._checkBoxRegionEurope_CheckedChanged);
            // 
            // _checkBoxRegionJapan
            // 
            this._checkBoxRegionJapan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._checkBoxRegionJapan.AutoSize = true;
            this._checkBoxRegionJapan.Location = new System.Drawing.Point(19, 488);
            this._checkBoxRegionJapan.Name = "_checkBoxRegionJapan";
            this._checkBoxRegionJapan.Size = new System.Drawing.Size(56, 19);
            this._checkBoxRegionJapan.TabIndex = 13;
            this._checkBoxRegionJapan.Text = "Japan";
            this._checkBoxRegionJapan.UseVisualStyleBackColor = true;
            // 
            // _checkBoxRegionUSA
            // 
            this._checkBoxRegionUSA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._checkBoxRegionUSA.AutoSize = true;
            this._checkBoxRegionUSA.Location = new System.Drawing.Point(19, 472);
            this._checkBoxRegionUSA.Name = "_checkBoxRegionUSA";
            this._checkBoxRegionUSA.Size = new System.Drawing.Size(48, 19);
            this._checkBoxRegionUSA.TabIndex = 12;
            this._checkBoxRegionUSA.Text = "USA";
            this._checkBoxRegionUSA.UseVisualStyleBackColor = true;
            // 
            // _textBoxSearchTerms
            // 
            this._textBoxSearchTerms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxSearchTerms.Location = new System.Drawing.Point(16, 529);
            this._textBoxSearchTerms.Name = "_textBoxSearchTerms";
            this._textBoxSearchTerms.PlaceholderText = "Text Filter";
            this._textBoxSearchTerms.Size = new System.Drawing.Size(293, 23);
            this._textBoxSearchTerms.TabIndex = 9;
            // 
            // _buttonResetFilters
            // 
            this._buttonResetFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonResetFilters.Location = new System.Drawing.Point(15, 590);
            this._buttonResetFilters.Name = "_buttonResetFilters";
            this._buttonResetFilters.Size = new System.Drawing.Size(294, 38);
            this._buttonResetFilters.TabIndex = 8;
            this._buttonResetFilters.Text = "Reset Filters";
            this._buttonResetFilters.UseVisualStyleBackColor = true;
            this._buttonResetFilters.Click += new System.EventHandler(this.onButtonClick);
            // 
            // _listBoxConsoleFilter
            // 
            this._listBoxConsoleFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._listBoxConsoleFilter.FormattingEnabled = true;
            this._listBoxConsoleFilter.ItemHeight = 15;
            this._listBoxConsoleFilter.Location = new System.Drawing.Point(14, 22);
            this._listBoxConsoleFilter.Name = "_listBoxConsoleFilter";
            this._listBoxConsoleFilter.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this._listBoxConsoleFilter.Size = new System.Drawing.Size(294, 424);
            this._listBoxConsoleFilter.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label8.Location = new System.Drawing.Point(0, 692);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(321, 2);
            this.label8.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Console Filter";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 561);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(293, 23);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "Playlist Filter (Coming soon)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 15);
            this.label14.TabIndex = 27;
            this.label14.Text = "Chosen Game";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Region";
            // 
            // _textBoxRegion
            // 
            this._textBoxRegion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxRegion.Location = new System.Drawing.Point(82, 118);
            this._textBoxRegion.Name = "_textBoxRegion";
            this._textBoxRegion.ReadOnly = true;
            this._textBoxRegion.Size = new System.Drawing.Size(257, 23);
            this._textBoxRegion.TabIndex = 6;
            // 
            // _textBoxGame
            // 
            this._textBoxGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxGame.Location = new System.Drawing.Point(82, 33);
            this._textBoxGame.Multiline = true;
            this._textBoxGame.Name = "_textBoxGame";
            this._textBoxGame.ReadOnly = true;
            this._textBoxGame.Size = new System.Drawing.Size(257, 50);
            this._textBoxGame.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 694);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Random Game Picker";
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
        private System.Windows.Forms.TextBox _textBoxConsole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _buttonPick;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox _listBoxConsoleFilter;
        private System.Windows.Forms.TextBox _textBoxGame;
        private System.Windows.Forms.Button _buttonResetFilters;
        private System.Windows.Forms.TextBox _textBoxSearchTerms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _textBoxRegion;
        private System.Windows.Forms.CheckBox _checkBoxRegionEurope;
        private System.Windows.Forms.CheckBox _checkBoxRegionJapan;
        private System.Windows.Forms.CheckBox _checkBoxRegionUSA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
    }
}

