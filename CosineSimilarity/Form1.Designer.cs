namespace CosineSimilarity
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
            label1 = new Label();
            txtVectorA = new TextBox();
            txtVectorB = new TextBox();
            label2 = new Label();
            button1 = new Button();
            progressBar1 = new ProgressBar();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 29);
            label1.Name = "label1";
            label1.Size = new Size(98, 28);
            label1.TabIndex = 0;
            label1.Text = "Vector 1 : ";
            // 
            // txtVectorA
            // 
            txtVectorA.BorderStyle = BorderStyle.FixedSingle;
            txtVectorA.Location = new Point(125, 33);
            txtVectorA.Name = "txtVectorA";
            txtVectorA.Size = new Size(449, 27);
            txtVectorA.TabIndex = 1;
            // 
            // txtVectorB
            // 
            txtVectorB.BorderStyle = BorderStyle.FixedSingle;
            txtVectorB.Location = new Point(125, 83);
            txtVectorB.Name = "txtVectorB";
            txtVectorB.Size = new Size(449, 27);
            txtVectorB.TabIndex = 3;
            txtVectorB.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 78);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 2;
            label2.Text = "Vector 2 : ";
            // 
            // button1
            // 
            button1.Location = new Point(209, 134);
            button1.Name = "button1";
            button1.Size = new Size(159, 29);
            button1.TabIndex = 4;
            button1.Text = "Check Similarity";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(21, 229);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(553, 29);
            progressBar1.TabIndex = 5;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(21, 197);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 288);
            Controls.Add(lblResult);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Controls.Add(txtVectorB);
            Controls.Add(label2);
            Controls.Add(txtVectorA);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Vector Similarity";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtVectorA;
        private TextBox txtVectorB;
        private Label label2;
        private Button button1;
        private ProgressBar progressBar1;
        private Label lblResult;
    }
}
