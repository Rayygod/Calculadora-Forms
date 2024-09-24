namespace Calculadora
{
    partial class FrmWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWindow));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 97);
            button1.Name = "button1";
            button1.Size = new Size(72, 71);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(109, 97);
            button2.Name = "button2";
            button2.Size = new Size(72, 71);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(199, 97);
            button3.Name = "button3";
            button3.Size = new Size(72, 71);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(291, 97);
            button4.Name = "button4";
            button4.Size = new Size(72, 71);
            button4.TabIndex = 3;
            button4.Text = "+";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(291, 190);
            button5.Name = "button5";
            button5.Size = new Size(72, 71);
            button5.TabIndex = 7;
            button5.Text = "-";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(199, 190);
            button6.Name = "button6";
            button6.Size = new Size(72, 71);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(109, 190);
            button7.Name = "button7";
            button7.Size = new Size(72, 71);
            button7.TabIndex = 5;
            button7.Text = "5";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(12, 190);
            button8.Name = "button8";
            button8.Size = new Size(72, 71);
            button8.TabIndex = 4;
            button8.Text = "4";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(291, 279);
            button9.Name = "button9";
            button9.Size = new Size(72, 71);
            button9.TabIndex = 11;
            button9.Text = "/";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(199, 279);
            button10.Name = "button10";
            button10.Size = new Size(72, 71);
            button10.TabIndex = 10;
            button10.Text = "9";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(109, 279);
            button11.Name = "button11";
            button11.Size = new Size(72, 71);
            button11.TabIndex = 9;
            button11.Text = "8";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(12, 279);
            button12.Name = "button12";
            button12.Size = new Size(72, 71);
            button12.TabIndex = 8;
            button12.Text = "7";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button14
            // 
            button14.Location = new Point(199, 367);
            button14.Name = "button14";
            button14.Size = new Size(164, 71);
            button14.TabIndex = 14;
            button14.Text = "=";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Location = new Point(109, 367);
            button15.Name = "button15";
            button15.Size = new Size(72, 71);
            button15.TabIndex = 13;
            button15.Text = "0";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.Location = new Point(12, 367);
            button16.Name = "button16";
            button16.Size = new Size(72, 71);
            button16.TabIndex = 12;
            button16.Text = "*";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(12, 24);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(351, 67);
            txtResultado.TabIndex = 15;
            // 
            // FrmWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(375, 450);
            Controls.Add(txtResultado);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FrmWindow";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmWindow";
            Load += FrmWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button14;
        private Button button15;
        private Button button16;
        private TextBox txtResultado;
    }
}