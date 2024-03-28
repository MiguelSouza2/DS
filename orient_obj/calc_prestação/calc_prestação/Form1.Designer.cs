namespace calc_prestação
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
            this.txt_valor_prest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_taxa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tempo = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_valor_prest
            // 
            this.txt_valor_prest.Location = new System.Drawing.Point(12, 39);
            this.txt_valor_prest.Name = "txt_valor_prest";
            this.txt_valor_prest.Size = new System.Drawing.Size(140, 20);
            this.txt_valor_prest.TabIndex = 0;
            this.txt_valor_prest.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o valor da prestação: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // txt_taxa
            // 
            this.txt_taxa.Location = new System.Drawing.Point(12, 95);
            this.txt_taxa.Name = "txt_taxa";
            this.txt_taxa.Size = new System.Drawing.Size(140, 20);
            this.txt_taxa.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Digite o valor da taxa bancária:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Digite o valor do tempo (em dias) do atraso:";
            // 
            // txt_tempo
            // 
            this.txt_tempo.Location = new System.Drawing.Point(16, 147);
            this.txt_tempo.Name = "txt_tempo";
            this.txt_tempo.Size = new System.Drawing.Size(100, 20);
            this.txt_tempo.TabIndex = 6;
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(16, 208);
            this.txt_result.Name = "txt_result";
            this.txt_result.ReadOnly = true;
            this.txt_result.Size = new System.Drawing.Size(100, 20);
            this.txt_result.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.txt_tempo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_taxa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_valor_prest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_valor_prest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_taxa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tempo;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button button1;
    }
}

