
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
            label1 = new System.Windows.Forms.Label();
            _textBoxConsole = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            _buttonPick = new System.Windows.Forms.Button();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            _checkBoxRegionEurope = new System.Windows.Forms.CheckBox();
            _checkBoxRegionJapan = new System.Windows.Forms.CheckBox();
            _checkBoxRegionUSA = new System.Windows.Forms.CheckBox();
            _textBoxSearchTerms = new System.Windows.Forms.TextBox();
            _buttonResetFilters = new System.Windows.Forms.Button();
            _listBoxConsoleFilter = new System.Windows.Forms.ListBox();
            label11 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            _textBoxRegion = new System.Windows.Forms.TextBox();
            _textBoxGame = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("SF TransRobotics Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Lime;
            label1.Location = new System.Drawing.Point(14, 185);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(100, 30);
            label1.TabIndex = 2;
            label1.Text = "Game";
            // 
            // _textBoxConsole
            // 
            _textBoxConsole.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _textBoxConsole.BackColor = System.Drawing.Color.Black;
            _textBoxConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            _textBoxConsole.Font = new System.Drawing.Font("SF TransRobotics Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _textBoxConsole.ForeColor = System.Drawing.Color.Lime;
            _textBoxConsole.Location = new System.Drawing.Point(25, 338);
            _textBoxConsole.Name = "_textBoxConsole";
            _textBoxConsole.ReadOnly = true;
            _textBoxConsole.Size = new System.Drawing.Size(328, 30);
            _textBoxConsole.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("SF TransRobotics Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Lime;
            label2.Location = new System.Drawing.Point(14, 305);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(136, 30);
            label2.TabIndex = 4;
            label2.Text = "Console";
            // 
            // _buttonPick
            // 
            _buttonPick.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _buttonPick.Font = new System.Drawing.Font("SF TransRobotics Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _buttonPick.Location = new System.Drawing.Point(14, 810);
            _buttonPick.Name = "_buttonPick";
            _buttonPick.Size = new System.Drawing.Size(340, 38);
            _buttonPick.TabIndex = 11;
            _buttonPick.Text = "Encabulate";
            _buttonPick.UseVisualStyleBackColor = true;
            _buttonPick.Click += onButtonClick;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(_checkBoxRegionEurope);
            splitContainer1.Panel1.Controls.Add(_checkBoxRegionJapan);
            splitContainer1.Panel1.Controls.Add(_checkBoxRegionUSA);
            splitContainer1.Panel1.Controls.Add(_textBoxSearchTerms);
            splitContainer1.Panel1.Controls.Add(_buttonResetFilters);
            splitContainer1.Panel1.Controls.Add(_buttonPick);
            splitContainer1.Panel1.Controls.Add(_listBoxConsoleFilter);
            splitContainer1.Panel1.Controls.Add(label11);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label8);
            splitContainer1.Panel2.Controls.Add(label14);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(_textBoxRegion);
            splitContainer1.Panel2.Controls.Add(_textBoxGame);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(_textBoxConsole);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new System.Drawing.Size(725, 860);
            splitContainer1.SplitterDistance = 367;
            splitContainer1.TabIndex = 0;
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label6.Font = new System.Drawing.Font("SF TransRobotics Extended", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.Lime;
            label6.Location = new System.Drawing.Point(6, 9);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(358, 34);
            label6.TabIndex = 0;
            label6.Text = "Parameters";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label5.Font = new System.Drawing.Font("SF TransRobotics Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.Lime;
            label5.Location = new System.Drawing.Point(3, 677);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(358, 34);
            label5.TabIndex = 7;
            label5.Text = "Keyword";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("SF TransRobotics", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.Lime;
            label7.Location = new System.Drawing.Point(14, 747);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(174, 16);
            label7.TabIndex = 9;
            label7.Text = "Created by JasonRulesUDont";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label4.Font = new System.Drawing.Font("SF TransRobotics Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.Lime;
            label4.Location = new System.Drawing.Point(6, 549);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(358, 34);
            label4.TabIndex = 3;
            label4.Text = "Regions";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _checkBoxRegionEurope
            // 
            _checkBoxRegionEurope.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            _checkBoxRegionEurope.AutoSize = true;
            _checkBoxRegionEurope.Font = new System.Drawing.Font("SF TransRobotics Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _checkBoxRegionEurope.ForeColor = System.Drawing.Color.Lime;
            _checkBoxRegionEurope.Location = new System.Drawing.Point(30, 648);
            _checkBoxRegionEurope.Name = "_checkBoxRegionEurope";
            _checkBoxRegionEurope.Size = new System.Drawing.Size(117, 28);
            _checkBoxRegionEurope.TabIndex = 6;
            _checkBoxRegionEurope.Text = "Europe";
            _checkBoxRegionEurope.UseVisualStyleBackColor = true;
            _checkBoxRegionEurope.CheckedChanged += _checkBoxRegionEurope_CheckedChanged;
            // 
            // _checkBoxRegionJapan
            // 
            _checkBoxRegionJapan.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            _checkBoxRegionJapan.AutoSize = true;
            _checkBoxRegionJapan.Font = new System.Drawing.Font("SF TransRobotics Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _checkBoxRegionJapan.ForeColor = System.Drawing.Color.Lime;
            _checkBoxRegionJapan.Location = new System.Drawing.Point(30, 614);
            _checkBoxRegionJapan.Name = "_checkBoxRegionJapan";
            _checkBoxRegionJapan.Size = new System.Drawing.Size(99, 28);
            _checkBoxRegionJapan.TabIndex = 5;
            _checkBoxRegionJapan.Text = "Japan";
            _checkBoxRegionJapan.UseVisualStyleBackColor = true;
            // 
            // _checkBoxRegionUSA
            // 
            _checkBoxRegionUSA.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            _checkBoxRegionUSA.AutoSize = true;
            _checkBoxRegionUSA.Font = new System.Drawing.Font("SF TransRobotics Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _checkBoxRegionUSA.ForeColor = System.Drawing.Color.Lime;
            _checkBoxRegionUSA.Location = new System.Drawing.Point(30, 580);
            _checkBoxRegionUSA.Name = "_checkBoxRegionUSA";
            _checkBoxRegionUSA.Size = new System.Drawing.Size(79, 28);
            _checkBoxRegionUSA.TabIndex = 4;
            _checkBoxRegionUSA.Text = "USA";
            _checkBoxRegionUSA.UseVisualStyleBackColor = true;
            // 
            // _textBoxSearchTerms
            // 
            _textBoxSearchTerms.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _textBoxSearchTerms.BackColor = System.Drawing.Color.Black;
            _textBoxSearchTerms.ForeColor = System.Drawing.Color.Lime;
            _textBoxSearchTerms.Location = new System.Drawing.Point(12, 724);
            _textBoxSearchTerms.Name = "_textBoxSearchTerms";
            _textBoxSearchTerms.PlaceholderText = "Text Filter";
            _textBoxSearchTerms.Size = new System.Drawing.Size(339, 23);
            _textBoxSearchTerms.TabIndex = 8;
            // 
            // _buttonResetFilters
            // 
            _buttonResetFilters.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _buttonResetFilters.Font = new System.Drawing.Font("SF TransRobotics Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _buttonResetFilters.Location = new System.Drawing.Point(14, 766);
            _buttonResetFilters.Name = "_buttonResetFilters";
            _buttonResetFilters.Size = new System.Drawing.Size(340, 38);
            _buttonResetFilters.TabIndex = 10;
            _buttonResetFilters.Text = "Reset Filters";
            _buttonResetFilters.UseVisualStyleBackColor = true;
            _buttonResetFilters.Click += onButtonClick;
            // 
            // _listBoxConsoleFilter
            // 
            _listBoxConsoleFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _listBoxConsoleFilter.BackColor = System.Drawing.Color.Black;
            _listBoxConsoleFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            _listBoxConsoleFilter.Font = new System.Drawing.Font("SF TransRobotics Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _listBoxConsoleFilter.ForeColor = System.Drawing.Color.Lime;
            _listBoxConsoleFilter.FormattingEnabled = true;
            _listBoxConsoleFilter.ItemHeight = 24;
            _listBoxConsoleFilter.Location = new System.Drawing.Point(16, 67);
            _listBoxConsoleFilter.Name = "_listBoxConsoleFilter";
            _listBoxConsoleFilter.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            _listBoxConsoleFilter.Size = new System.Drawing.Size(335, 480);
            _listBoxConsoleFilter.TabIndex = 2;
            // 
            // label11
            // 
            label11.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label11.Font = new System.Drawing.Font("SF TransRobotics Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.ForeColor = System.Drawing.Color.Lime;
            label11.Location = new System.Drawing.Point(0, 43);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(358, 34);
            label11.TabIndex = 1;
            label11.Text = "Consoles";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label8.BackColor = System.Drawing.Color.Lime;
            label8.Location = new System.Drawing.Point(-3, 9);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(4, 839);
            label8.TabIndex = 0;
            label8.Text = "label8";
            // 
            // label14
            // 
            label14.Font = new System.Drawing.Font("SF TransRobotics Extended", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label14.ForeColor = System.Drawing.Color.Lime;
            label14.Location = new System.Drawing.Point(14, 4);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(312, 97);
            label14.TabIndex = 1;
            label14.Text = "Encabulation Results";
            label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("SF TransRobotics Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Lime;
            label3.Location = new System.Drawing.Point(14, 386);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(118, 30);
            label3.TabIndex = 6;
            label3.Text = "Region";
            // 
            // _textBoxRegion
            // 
            _textBoxRegion.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _textBoxRegion.BackColor = System.Drawing.Color.Black;
            _textBoxRegion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            _textBoxRegion.Font = new System.Drawing.Font("SF TransRobotics Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _textBoxRegion.ForeColor = System.Drawing.Color.Lime;
            _textBoxRegion.Location = new System.Drawing.Point(26, 419);
            _textBoxRegion.Name = "_textBoxRegion";
            _textBoxRegion.ReadOnly = true;
            _textBoxRegion.Size = new System.Drawing.Size(328, 30);
            _textBoxRegion.TabIndex = 7;
            // 
            // _textBoxGame
            // 
            _textBoxGame.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _textBoxGame.BackColor = System.Drawing.Color.Black;
            _textBoxGame.BorderStyle = System.Windows.Forms.BorderStyle.None;
            _textBoxGame.Font = new System.Drawing.Font("SF TransRobotics Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _textBoxGame.ForeColor = System.Drawing.Color.Lime;
            _textBoxGame.Location = new System.Drawing.Point(25, 218);
            _textBoxGame.Multiline = true;
            _textBoxGame.Name = "_textBoxGame";
            _textBoxGame.ReadOnly = true;
            _textBoxGame.Size = new System.Drawing.Size(328, 60);
            _textBoxGame.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(725, 860);
            Controls.Add(splitContainer1);
            ForeColor = System.Drawing.Color.Lime;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Random Game Picker";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}

