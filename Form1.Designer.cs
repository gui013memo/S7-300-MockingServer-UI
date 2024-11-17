namespace S7_300_MockingServer_UI
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
            setReadRequestButton = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            SuspendLayout();
            // 
            // setReadRequestButton
            // 
            setReadRequestButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            setReadRequestButton.Location = new Point(12, 166);
            setReadRequestButton.Name = "setReadRequestButton";
            setReadRequestButton.Size = new Size(264, 69);
            setReadRequestButton.TabIndex = 0;
            setReadRequestButton.Text = "Set ReadRequest = 1";
            setReadRequestButton.UseVisualStyleBackColor = true;
            setReadRequestButton.Click += setReadRequestButton_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 44);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 39);
            textBox1.TabIndex = 1;
            textBox1.Text = "BB42F3LAQL123456";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(58, 9);
            label1.Name = "label1";
            label1.Size = new Size(182, 32);
            label1.TabIndex = 2;
            label1.Text = "Engine Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(58, 91);
            label2.Name = "label2";
            label2.Size = new Size(173, 32);
            label2.TabIndex = 4;
            label2.Text = "Assembly Type";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(42, 126);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(84, 34);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Block";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(172, 126);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(84, 34);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Head";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 245);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(setReadRequestButton);
            Name = "Form1";
            Text = "S7-300 TMS Mocking Server";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button setReadRequestButton;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}
