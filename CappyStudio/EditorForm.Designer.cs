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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFull = new System.Windows.Forms.Button();
            this.btnFocus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAction
            // 
            this.txtAction.Location = new System.Drawing.Point(12, 25);
            this.txtAction.MaxLength = 80;
            this.txtAction.Name = "txtAction";
            this.txtAction.Size = new System.Drawing.Size(309, 20);
            this.txtAction.TabIndex = 0;
            // 
            // txtInteraction
            // 
            this.txtInteraction.Location = new System.Drawing.Point(13, 71);
            this.txtInteraction.MaxLength = 80;
            this.txtInteraction.Name = "txtInteraction";
            this.txtInteraction.Size = new System.Drawing.Size(308, 20);
            this.txtInteraction.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Button Action";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Interaction";
            // 
            // btnFull
            // 
            this.btnFull.Location = new System.Drawing.Point(15, 98);
            this.btnFull.Name = "btnFull";
            this.btnFull.Size = new System.Drawing.Size(150, 75);
            this.btnFull.TabIndex = 5;
            this.btnFull.Text = "Choose Full \r\nScreenshot";
            this.btnFull.UseVisualStyleBackColor = true;
            // 
            // btnFocus
            // 
            this.btnFocus.Location = new System.Drawing.Point(171, 98);
            this.btnFocus.Name = "btnFocus";
            this.btnFocus.Size = new System.Drawing.Size(150, 75);
            this.btnFocus.TabIndex = 6;
            this.btnFocus.Text = "Choose Focused Screenshot";
            this.btnFocus.UseVisualStyleBackColor = true;
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 186);
            this.Controls.Add(this.btnFocus);
            this.Controls.Add(this.btnFull);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFull;
        private System.Windows.Forms.Button btnFocus;
    }
}