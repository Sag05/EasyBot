namespace EasyBot
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
            tokenSelectorButton = new Button();
            testLabel = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            startButton = new Button();
            textOutput = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // tokenSelectorButton
            // 
            tokenSelectorButton.Location = new Point(12, 12);
            tokenSelectorButton.Name = "tokenSelectorButton";
            tokenSelectorButton.Size = new Size(75, 23);
            tokenSelectorButton.TabIndex = 0;
            tokenSelectorButton.Text = "Get Token";
            tokenSelectorButton.UseVisualStyleBackColor = true;
            tokenSelectorButton.Click += button1_Click;
            // 
            // testLabel
            // 
            testLabel.AutoSize = true;
            testLabel.Location = new Point(12, 426);
            testLabel.Name = "testLabel";
            testLabel.Size = new Size(38, 15);
            testLabel.TabIndex = 1;
            testLabel.Text = "label1";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 137);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(12, 162);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(83, 19);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(12, 187);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(83, 19);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(12, 212);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(83, 19);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            startButton.Location = new Point(486, 12);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 23);
            startButton.TabIndex = 6;
            startButton.Text = "Start Bot";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // textOutput
            // 
            textOutput.Location = new Point(486, 67);
            textOutput.Name = "textOutput";
            textOutput.Size = new Size(446, 374);
            textOutput.TabIndex = 8;
            textOutput.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(486, 38);
            label1.Name = "label1";
            label1.Size = new Size(70, 26);
            label1.TabIndex = 9;
            label1.Text = " Output";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 453);
            Controls.Add(label1);
            Controls.Add(textOutput);
            Controls.Add(startButton);
            Controls.Add(checkBox3);
            Controls.Add(checkBox4);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(testLabel);
            Controls.Add(tokenSelectorButton);
            Name = "Form1";
            Text = "EasyBot";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tokenSelectorButton;
        private Label testLabel;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Button startButton;
        private RichTextBox textOutput;
        private Label label1;
    }
}