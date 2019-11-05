namespace CappyStudio
{
    partial class EditorForm
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
            this.txtAction = new System.Windows.Forms.TextBox();
            this.txtInteraction = new System.Windows.Forms.TextBox();
            this.lblAction = new System.Windows.Forms.Label();
            this.lblInteraction = new System.Windows.Forms.Label();
            this.btnFull = new System.Windows.Forms.Button();
            this.btnFocus = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblIndex = new System.Windows.Forms.Label();
            this.lblButtonClicked = new System.Windows.Forms.Label();
            this.txtBtnClicked = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAction
            // 
            this.txtAction.Location = new System.Drawing.Point(11, 25);
            this.txtAction.MaxLength = 80;
            this.txtAction.Name = "txtAction";
            this.txtAction.Size = new System.Drawing.Size(309, 20);
            this.txtAction.TabIndex = 0;
            // 
            // txtInteraction
            // 
            this.txtInteraction.Location = new System.Drawing.Point(12, 103);
            this.txtInteraction.MaxLength = 80;
            this.txtInteraction.Name = "txtInteraction";
            this.txtInteraction.Size = new System.Drawing.Size(308, 20);
            this.txtInteraction.TabIndex = 2;
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(12, 9);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(71, 13);
            this.lblAction.TabIndex = 3;
            this.lblAction.Text = "Button Action";
            // 
            // lblInteraction
            // 
            this.lblInteraction.AutoSize = true;
            this.lblInteraction.Location = new System.Drawing.Point(12, 87);
            this.lblInteraction.Name = "lblInteraction";
            this.lblInteraction.Size = new System.Drawing.Size(57, 13);
            this.lblInteraction.TabIndex = 4;
            this.lblInteraction.Text = "Interaction";
            // 
            // btnFull
            // 
            this.btnFull.Location = new System.Drawing.Point(15, 132);
            this.btnFull.Name = "btnFull";
            this.btnFull.Size = new System.Drawing.Size(150, 75);
            this.btnFull.TabIndex = 5;
            this.btnFull.Text = "Choose Full \r\nScreenshot";
            this.btnFull.UseVisualStyleBackColor = true;
            this.btnFull.Click += new System.EventHandler(this.btnFull_Click);
            // 
            // btnFocus
            // 
            this.btnFocus.Location = new System.Drawing.Point(170, 132);
            this.btnFocus.Name = "btnFocus";
            this.btnFocus.Size = new System.Drawing.Size(150, 75);
            this.btnFocus.TabIndex = 6;
            this.btnFocus.Text = "Choose Focused Screenshot";
            this.btnFocus.UseVisualStyleBackColor = true;
            this.btnFocus.Click += new System.EventHandler(this.btnFocus_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(171, 213);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(150, 23);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next Interaction";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(15, 213);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(150, 23);
            this.btnPrev.TabIndex = 8;
            this.btnPrev.Text = "Previous Interaction";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(15, 243);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(36, 13);
            this.lblIndex.TabIndex = 9;
            this.lblIndex.Text = "Index:";
            // 
            // lblButtonClicked
            // 
            this.lblButtonClicked.AutoSize = true;
            this.lblButtonClicked.Location = new System.Drawing.Point(12, 48);
            this.lblButtonClicked.Name = "lblButtonClicked";
            this.lblButtonClicked.Size = new System.Drawing.Size(76, 13);
            this.lblButtonClicked.TabIndex = 11;
            this.lblButtonClicked.Text = "Button Clicked";
            // 
            // txtBtnClicked
            // 
            this.txtBtnClicked.Location = new System.Drawing.Point(11, 64);
            this.txtBtnClicked.MaxLength = 80;
            this.txtBtnClicked.Name = "txtBtnClicked";
            this.txtBtnClicked.Size = new System.Drawing.Size(309, 20);
            this.txtBtnClicked.TabIndex = 10;
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 264);
            this.Controls.Add(this.lblButtonClicked);
            this.Controls.Add(this.txtBtnClicked);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFocus);
            this.Controls.Add(this.btnFull);
            this.Controls.Add(this.lblInteraction);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.txtInteraction);
            this.Controls.Add(this.txtAction);
            this.Name = "EditorForm";
            this.Text = "Element Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAction;
        private System.Windows.Forms.TextBox txtInteraction;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Label lblInteraction;
        private System.Windows.Forms.Button btnFull;
        private System.Windows.Forms.Button btnFocus;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Label lblButtonClicked;
        private System.Windows.Forms.TextBox txtBtnClicked;
    }
}