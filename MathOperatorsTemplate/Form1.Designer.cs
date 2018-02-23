namespace MathOperatorsTemplate
{
    partial class Form1
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Black;
            this.outputLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.Lime;
            this.outputLabel.Location = new System.Drawing.Point(22, 24);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(945, 410);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "Welcome...";
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(24, 456);
            this.runButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(187, 78);
            this.runButton.TabIndex = 1;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 574);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.outputLabel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Operators";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button runButton;
    }
}

