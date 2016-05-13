﻿namespace launcherUpdate
{
    partial class updateMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateMain));
            this.quitButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.downloadProgress = new FlatUI.FlatProgressBar();
            this.downloadLabel = new MonoFlat.MonoFlat_Label();
            this.SuspendLayout();
            // 
            // quitButton
            // 
            this.quitButton.Depth = 0;
            this.quitButton.Location = new System.Drawing.Point(422, 60);
            this.quitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.quitButton.Name = "quitButton";
            this.quitButton.Primary = true;
            this.quitButton.Size = new System.Drawing.Size(149, 49);
            this.quitButton.TabIndex = 0;
            this.quitButton.Text = "QUIT";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // downloadProgress
            // 
            this.downloadProgress.BackColor = System.Drawing.Color.White;
            this.downloadProgress.DarkerProgress = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.downloadProgress.Location = new System.Drawing.Point(23, 12);
            this.downloadProgress.Maximum = 100;
            this.downloadProgress.Name = "downloadProgress";
            this.downloadProgress.Pattern = true;
            this.downloadProgress.PercentSign = false;
            this.downloadProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.downloadProgress.ShowBalloon = true;
            this.downloadProgress.Size = new System.Drawing.Size(548, 42);
            this.downloadProgress.TabIndex = 1;
            this.downloadProgress.Text = "downloadProgress";
            this.downloadProgress.Value = 0;
            // 
            // downloadLabel
            // 
            this.downloadLabel.AutoSize = true;
            this.downloadLabel.BackColor = System.Drawing.Color.Transparent;
            this.downloadLabel.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadLabel.ForeColor = System.Drawing.Color.DimGray;
            this.downloadLabel.Location = new System.Drawing.Point(23, 60);
            this.downloadLabel.Name = "downloadLabel";
            this.downloadLabel.Size = new System.Drawing.Size(163, 18);
            this.downloadLabel.TabIndex = 2;
            this.downloadLabel.Text = "Download in progress ... ";
            // 
            // updateMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.ClientSize = new System.Drawing.Size(594, 119);
            this.ControlBox = false;
            this.Controls.Add(this.downloadLabel);
            this.Controls.Add(this.downloadProgress);
            this.Controls.Add(this.quitButton);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "updateMain";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Launcher update";
            this.Load += new System.EventHandler(this.updateMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton quitButton;
        private FlatUI.FlatProgressBar downloadProgress;
        private MonoFlat.MonoFlat_Label downloadLabel;
    }
}