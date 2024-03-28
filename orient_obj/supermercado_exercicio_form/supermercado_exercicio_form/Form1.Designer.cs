namespace supermercado_exercicio_form
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
            this.txt_maxima = new System.Windows.Forms.TextBox();
            this.txt_estoque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_maxima
            // 
            this.txt_maxima.Location = new System.Drawing.Point(15, 102);
            this.txt_maxima.Name = "txt_maxima";
            this.txt_maxima.Size = new System.Drawing.Size(100, 20);
            this.txt_maxima.TabIndex = 0;
            this.txt_maxima.TextChanged += new System.EventHandler(this.txt_maxima_TextChanged);
            // 
            // txt_estoque
            // 
            this.txt_estoque.Location = new System.Drawing.Point(15, 155);
            this.txt_estoque.Name = "txt_estoque";
            this.txt_estoque.Size = new System.Drawing.Size(100, 20);
            this.txt_estoque.TabIndex = 1;
            this.txt_estoque.TextChanged += new System.EventHandler(this.txt_estoque_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite a quantidade máxima do produto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite a quantidade em estoque do produto: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Digite o nome do produto:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(15, 44);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 4;
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(15, 248);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.ReadOnly = true;
            this.txt_result.Size = new System.Drawing.Size(242, 77);
            this.txt_result.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 408);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_estoque);
            this.Controls.Add(this.txt_maxima);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_maxima;
        private System.Windows.Forms.TextBox txt_estoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button button1;
    }
}

