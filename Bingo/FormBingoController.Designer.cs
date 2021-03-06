﻿namespace Bingo
{
    partial class FormBingoController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBingoController));
            this.gbGame = new System.Windows.Forms.GroupBox();
            this.cbGameSelector = new System.Windows.Forms.ComboBox();
            this.bPickNumber = new System.Windows.Forms.Button();
            this.bNewGame = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsDdbHelp = new System.Windows.Forms.ToolStripDropDownButton();
            this.tutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLNumSelected = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbMinimap = new System.Windows.Forms.PictureBox();
            this.lNumber = new Bingo.SmoothLabel();
            this.gbGame.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimap)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGame
            // 
            this.gbGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGame.Controls.Add(this.cbGameSelector);
            this.gbGame.Controls.Add(this.lNumber);
            this.gbGame.Controls.Add(this.bPickNumber);
            this.gbGame.Location = new System.Drawing.Point(12, 12);
            this.gbGame.Name = "gbGame";
            this.gbGame.Size = new System.Drawing.Size(480, 134);
            this.gbGame.TabIndex = 0;
            this.gbGame.TabStop = false;
            this.gbGame.Text = "Game";
            // 
            // cbGameSelector
            // 
            this.cbGameSelector.FormattingEnabled = true;
            this.cbGameSelector.Location = new System.Drawing.Point(6, 106);
            this.cbGameSelector.Name = "cbGameSelector";
            this.cbGameSelector.Size = new System.Drawing.Size(150, 21);
            this.cbGameSelector.TabIndex = 2;
            this.cbGameSelector.SelectedIndexChanged += new System.EventHandler(this.cbGameSelector_SelectedIndexChanged);
            // 
            // bPickNumber
            // 
            this.bPickNumber.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPickNumber.Location = new System.Drawing.Point(6, 19);
            this.bPickNumber.Name = "bPickNumber";
            this.bPickNumber.Size = new System.Drawing.Size(150, 81);
            this.bPickNumber.TabIndex = 0;
            this.bPickNumber.Text = "Pick Number";
            this.bPickNumber.UseVisualStyleBackColor = true;
            this.bPickNumber.Click += new System.EventHandler(this.bPickNumber_Click);
            // 
            // bNewGame
            // 
            this.bNewGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bNewGame.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNewGame.Location = new System.Drawing.Point(12, 152);
            this.bNewGame.Name = "bNewGame";
            this.bNewGame.Size = new System.Drawing.Size(480, 44);
            this.bNewGame.TabIndex = 0;
            this.bNewGame.Text = "Reset Board";
            this.bNewGame.UseVisualStyleBackColor = true;
            this.bNewGame.Click += new System.EventHandler(this.bNewGame_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDdbHelp,
            this.tsLNumSelected});
            this.statusStrip1.Location = new System.Drawing.Point(0, 394);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(504, 23);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsDdbHelp
            // 
            this.tsDdbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsDdbHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tutorialToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.tsDdbHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsDdbHelp.Image")));
            this.tsDdbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDdbHelp.Name = "tsDdbHelp";
            this.tsDdbHelp.Size = new System.Drawing.Size(50, 21);
            this.tsDdbHelp.Text = "Help";
            // 
            // tutorialToolStripMenuItem
            // 
            this.tutorialToolStripMenuItem.Name = "tutorialToolStripMenuItem";
            this.tutorialToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.tutorialToolStripMenuItem.Text = "Tutorial";
            this.tutorialToolStripMenuItem.Click += new System.EventHandler(this.tutorialToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tsLNumSelected
            // 
            this.tsLNumSelected.Name = "tsLNumSelected";
            this.tsLNumSelected.Size = new System.Drawing.Size(165, 18);
            this.tsLNumSelected.Text = "Numbers Selected: 0/75";
            // 
            // pbMinimap
            // 
            this.pbMinimap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimap.Location = new System.Drawing.Point(12, 202);
            this.pbMinimap.Name = "pbMinimap";
            this.pbMinimap.Size = new System.Drawing.Size(480, 183);
            this.pbMinimap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimap.TabIndex = 3;
            this.pbMinimap.TabStop = false;
            // 
            // lNumber
            // 
            this.lNumber.AutoSize = true;
            this.lNumber.Font = new System.Drawing.Font("Consolas", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNumber.Location = new System.Drawing.Point(162, 15);
            this.lNumber.Name = "lNumber";
            this.lNumber.Size = new System.Drawing.Size(100, 112);
            this.lNumber.TabIndex = 1;
            this.lNumber.Text = "0";
            this.lNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lNumber.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // FormBingoController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 417);
            this.Controls.Add(this.pbMinimap);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bNewGame);
            this.Controls.Add(this.gbGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBingoController";
            this.Text = "Bingo Controller";
            this.gbGame.ResumeLayout(false);
            this.gbGame.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGame;
        private System.Windows.Forms.Button bNewGame;
        private Bingo.SmoothLabel lNumber;
        private System.Windows.Forms.Button bPickNumber;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsDdbHelp;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorialToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbMinimap;
        private System.Windows.Forms.ToolStripStatusLabel tsLNumSelected;
        private System.Windows.Forms.ComboBox cbGameSelector;
    }
}