namespace CappyStudio
{
    partial class MainForm
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
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.lblAction = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.lblKeyPress = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(66, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(492, 276);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(63, 304);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(0, 13);
            this.lblAction.TabIndex = 2;
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(63, 376);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(0, 13);
            this.lblIndex.TabIndex = 3;
            // 
            // lblKeyPress
            // 
            this.lblKeyPress.AutoSize = true;
            this.lblKeyPress.Location = new System.Drawing.Point(63, 291);
            this.lblKeyPress.Name = "lblKeyPress";
            this.lblKeyPress.Size = new System.Drawing.Size(0, 13);
            this.lblKeyPress.TabIndex = 1;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(408, 339);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(150, 50);
            this.btnModify.TabIndex = 4;
            this.btnModify.Text = "Modify Elements";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Location = new System.Drawing.Point(12, 12);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(48, 276);
            this.btnLeft.TabIndex = 5;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Transparent;
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Location = new System.Drawing.Point(564, 12);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(48, 276);
            this.btnRight.TabIndex = 6;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 401);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.lblKeyPress);
            this.Controls.Add(this.picDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "CappyStudio";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Label lblKeyPress;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
    }
}

