namespace Attendance_Register_App
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1title = new System.Windows.Forms.Label();
            this.textValue = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1title
            // 
            this.label1title.AutoSize = true;
            this.label1title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1title.Location = new System.Drawing.Point(3, 14);
            this.label1title.Name = "label1title";
            this.label1title.Size = new System.Drawing.Size(70, 26);
            this.label1title.TabIndex = 0;
            this.label1title.Text = "label1";
            // 
            // textValue
            // 
            this.textValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textValue.Location = new System.Drawing.Point(8, 43);
            this.textValue.Name = "textValue";
            this.textValue.Size = new System.Drawing.Size(147, 26);
            this.textValue.TabIndex = 1;
            this.textValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.clearButton.Location = new System.Drawing.Point(161, 43);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(37, 30);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "@";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.textValue);
            this.Controls.Add(this.label1title);
            this.MinimumSize = new System.Drawing.Size(84, 53);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(307, 72);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1title;
        private System.Windows.Forms.TextBox textValue;
        private System.Windows.Forms.Button clearButton;
    }
}
