namespace DailySpecial
{
    partial class Form1
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
            this.dayBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.specialButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dayBox
            // 
            this.dayBox.Location = new System.Drawing.Point(176, 133);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(48, 23);
            this.dayBox.TabIndex = 0;
            this.dayBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a day number to see our special";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "For example, Sunday = 1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // specialButton
            // 
            this.specialButton.Location = new System.Drawing.Point(159, 180);
            this.specialButton.Name = "specialButton";
            this.specialButton.Size = new System.Drawing.Size(75, 23);
            this.specialButton.TabIndex = 3;
            this.specialButton.Text = "Get special";
            this.specialButton.UseVisualStyleBackColor = true;
            this.specialButton.Click += new System.EventHandler(this.SpecialButton_Click);
            // 
            // label3
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(149, 232);
            this.outputLabel.Name = "label3";
            this.outputLabel.Size = new System.Drawing.Size(0, 16);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.specialButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dayBox);
            this.Name = "Form1";
            this.Text = "Chatterbox Diner Daily Specials";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox dayBox;
        private Label label1;
        private Label label2;
        private Button specialButton;
        private Label outputLabel;
    }
}