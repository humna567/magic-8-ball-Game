namespace magic_8_ball
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 381);
            button2.Name = "button2";
            button2.Size = new Size(209, 46);
            button2.TabIndex = 1;
            button2.Text = "Tell Me!";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 340);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 35);
            textBox1.TabIndex = 2;
            textBox1.Text = "Ask your question ..";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(319, 149);
            label1.Name = "label1";
            label1.Size = new Size(133, 32);
            label1.TabIndex = 3;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(301, 343);
            label3.Name = "label3";
            label3.Size = new Size(213, 28);
            label3.TabIndex = 5;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(769, 430);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            DoubleBuffered = true;
            Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "magi 8 ball";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private Label label3;
    }
}