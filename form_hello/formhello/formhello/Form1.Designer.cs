namespace formhello
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.btnmessa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello World";
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(75, 141);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(195, 53);
            this.btnClick.TabIndex = 1;
            this.btnClick.Text = "Dont click me";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(56, 238);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(237, 42);
            this.txt.TabIndex = 2;
            // 
            // btnmessa
            // 
            this.btnmessa.Location = new System.Drawing.Point(56, 286);
            this.btnmessa.Name = "btnmessa";
            this.btnmessa.Size = new System.Drawing.Size(193, 49);
            this.btnmessa.TabIndex = 3;
            this.btnmessa.Text = "Go";
            this.btnmessa.UseVisualStyleBackColor = true;
            this.btnmessa.Click += new System.EventHandler(this.btnmessa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 385);
            this.Controls.Add(this.btnmessa);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnClick;
        private TextBox txt;
        private Button btnmessa;
    }
}