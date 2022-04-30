
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
            this.label1 = new System.Windows.Forms.Label();
            this._textBoxConsole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._buttonPick = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._buttonClearSelection = new System.Windows.Forms.Button();
            this._listBoxConsoleFilter = new System.Windows.Forms.ListBox();
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
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game";
            // 
            // _textBoxConsole
            // 
            this._textBoxConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxConsole.Location = new System.Drawing.Point(79, 78);
            this._textBoxConsole.Name = "_textBoxConsole";
            this._textBoxConsole.ReadOnly = true;
            this._textBoxConsole.Size = new System.Drawing.Size(252, 23);
            this._textBoxConsole.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Console";
            // 
            // _buttonPick
            // 
            this._buttonPick.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonPick.Location = new System.Drawing.Point(12, 392);
            this._buttonPick.Name = "_buttonPick";
            this._buttonPick.Size = new System.Drawing.Size(299, 38);
            this._buttonPick.TabIndex = 6;
            this._buttonPick.Text = "Pick Random Game";
            this._buttonPick.UseVisualStyleBackColor = true;
            this._buttonPick.Click += new System.EventHandler(this.onButtonClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._buttonClearSelection);
            this.splitContainer1.Panel1.Controls.Add(this._buttonPick);
            this.splitContainer1.Panel1.Controls.Add(this._listBoxConsoleFilter);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._textBoxGame);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this._textBoxConsole);
            this.splitContainer1.Size = new System.Drawing.Size(676, 442);
            this.splitContainer1.SplitterDistance = 326;
            this.splitContainer1.TabIndex = 7;
            // 
            // _buttonClearSelection
            // 
            this._buttonClearSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonClearSelection.Location = new System.Drawing.Point(12, 348);
            this._buttonClearSelection.Name = "_buttonClearSelection";
            this._buttonClearSelection.Size = new System.Drawing.Size(299, 38);
            this._buttonClearSelection.TabIndex = 8;
            this._buttonClearSelection.Text = "Clear Console Selections";
            this._buttonClearSelection.UseVisualStyleBackColor = true;
            this._buttonClearSelection.Click += new System.EventHandler(this.onButtonClick);
            // 
            // _listBoxConsoleFilter
            // 
            this._listBoxConsoleFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._listBoxConsoleFilter.FormattingEnabled = true;
            this._listBoxConsoleFilter.ItemHeight = 15;
            this._listBoxConsoleFilter.Location = new System.Drawing.Point(12, 12);
            this._listBoxConsoleFilter.Name = "_listBoxConsoleFilter";
            this._listBoxConsoleFilter.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this._listBoxConsoleFilter.Size = new System.Drawing.Size(299, 319);
            this._listBoxConsoleFilter.TabIndex = 7;
            // 
            // _textBoxGame
            // 
            this._textBoxGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxGame.Location = new System.Drawing.Point(79, 13);
            this._textBoxGame.Multiline = true;
            this._textBoxGame.Name = "_textBoxGame";
            this._textBoxGame.ReadOnly = true;
            this._textBoxGame.Size = new System.Drawing.Size(252, 50);
            this._textBoxGame.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 442);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Random Game Picker";
            this.splitContainer1.Panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button _buttonClearSelection;
    }
}

