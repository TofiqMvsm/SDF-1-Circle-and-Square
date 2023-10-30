namespace STDF
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
            components = new System.ComponentModel.Container();
            Circle = new Button();
            btnSquare = new Button();
            label1 = new Label();
            textbox = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label8 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // Circle
            // 
            Circle.BackColor = SystemColors.MenuBar;
            Circle.Location = new Point(33, 74);
            Circle.Name = "Circle";
            Circle.Size = new Size(128, 40);
            Circle.TabIndex = 0;
            Circle.Text = "Circle";
            Circle.UseVisualStyleBackColor = false;
            Circle.Click += Circle_Click;
            // 
            // btnSquare
            // 
            btnSquare.BackColor = SystemColors.MenuBar;
            btnSquare.Location = new Point(216, 74);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(112, 40);
            btnSquare.TabIndex = 1;
            btnSquare.Text = "Square";
            btnSquare.UseVisualStyleBackColor = false;
            btnSquare.Click += btnSquare_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 9);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 2;
            label1.Text = "Parameters : ";
            // 
            // textbox
            // 
            textbox.Location = new Point(129, 34);
            textbox.Name = "textbox";
            textbox.PlaceholderText = "Size,Color,True";
            textbox.Size = new Size(143, 23);
            textbox.TabIndex = 3;
            // 
            // label2
            // 
            label2.BackColor = Color.MediumSpringGreen;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(33, 117);
            label2.Name = "label2";
            label2.Size = new Size(295, 10);
            label2.TabIndex = 16;
            // 
            // label8
            // 
            label8.BackColor = Color.MediumSpringGreen;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Location = new Point(319, 117);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(9, 302);
            label8.TabIndex = 17;
            
            // 
            // label3
            // 
            label3.BackColor = Color.MediumSpringGreen;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(33, 409);
            label3.Name = "label3";
            label3.Size = new Size(295, 10);
            label3.TabIndex = 16;
            label3.Text = "13232";
            // 
            // label4
            // 
            label4.BackColor = Color.MediumSpringGreen;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(33, 117);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(10, 302);
            label4.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 454);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textbox);
            Controls.Add(label1);
            Controls.Add(btnSquare);
            Controls.Add(Circle);
            DoubleBuffered = true;
            KeyPreview = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
           
            Paint += Form1_Paint;
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Circle;
        private Button btnSquare;
        private Label label1;
        private TextBox textbox;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label label8;
        private Label label3;
        private Label label4;
    }
}