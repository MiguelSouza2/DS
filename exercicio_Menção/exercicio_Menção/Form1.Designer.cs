namespace exercicio_Menção
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mention_1 = new System.Windows.Forms.TextBox();
            this.txt_mention_2 = new System.Windows.Forms.TextBox();
            this.txt_mention_3 = new System.Windows.Forms.TextBox();
            this.txt_mention_4 = new System.Windows.Forms.TextBox();
            this.btn_result = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite a primeira nota do aluno: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite a segunda nota do aluno: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digite a terceira nota do aluno: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Digite a quarta nota do aluno: ";
            // 
            // txt_mention_1
            // 
            this.txt_mention_1.Location = new System.Drawing.Point(16, 29);
            this.txt_mention_1.Name = "txt_mention_1";
            this.txt_mention_1.Size = new System.Drawing.Size(146, 20);
            this.txt_mention_1.TabIndex = 4;
            // 
            // txt_mention_2
            // 
            this.txt_mention_2.Location = new System.Drawing.Point(16, 76);
            this.txt_mention_2.Name = "txt_mention_2";
            this.txt_mention_2.Size = new System.Drawing.Size(146, 20);
            this.txt_mention_2.TabIndex = 5;
            // 
            // txt_mention_3
            // 
            this.txt_mention_3.Location = new System.Drawing.Point(16, 123);
            this.txt_mention_3.Name = "txt_mention_3";
            this.txt_mention_3.Size = new System.Drawing.Size(146, 20);
            this.txt_mention_3.TabIndex = 6;
            // 
            // txt_mention_4
            // 
            this.txt_mention_4.Location = new System.Drawing.Point(16, 168);
            this.txt_mention_4.Name = "txt_mention_4";
            this.txt_mention_4.Size = new System.Drawing.Size(146, 20);
            this.txt_mention_4.TabIndex = 7;
            // 
            // btn_result
            // 
            this.btn_result.Location = new System.Drawing.Point(16, 208);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(75, 23);
            this.btn_result.TabIndex = 8;
            this.btn_result.Text = "submit";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(180, 17);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(92, 171);
            this.txt_result.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.txt_mention_4);
            this.Controls.Add(this.txt_mention_3);
            this.Controls.Add(this.txt_mention_2);
            this.Controls.Add(this.txt_mention_1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mention_1;
        private System.Windows.Forms.TextBox txt_mention_2;
        private System.Windows.Forms.TextBox txt_mention_3;
        private System.Windows.Forms.TextBox txt_mention_4;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.TextBox txt_result;
    }
}

