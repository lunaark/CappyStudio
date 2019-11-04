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
            this.picDisplay.Location = new System.Drawing.Point(192, 48);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(240, 240);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(192, 312);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(12, 13);
            this.lblAction.TabIndex = 2;
            this.lblAction.Text = "\\";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(192, 329);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(12, 13);
            this.lblIndex.TabIndex = 3;
            this.lblIndex.Text = "\\";
            // 
            // lblKeyPress
            // 
            this.lblKeyPress.AutoSize = true;
            this.lblKeyPress.Location = new System.Drawing.Point(192, 295);
            this.lblKeyPress.Name = "lblKeyPress";
            this.lblKeyPress.Size = new System.Drawing.Size(12, 13);
            this.lblKeyPress.TabIndex = 1;
            this.lblKeyPress.Text = "\\";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(192, 345);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(240, 40);
            this.btnModify.TabIndex = 4;
            this.btnModify.Text = "Modify Elements";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(12, 48);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 240);
            this.btnLeft.TabIndex = 5;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(537, 48);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 240);
            this.btnRight.TabIndex = 6;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
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

