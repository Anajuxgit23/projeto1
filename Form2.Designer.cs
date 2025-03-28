namespace Projeto1
{
    partial class Form2
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lblnotas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl1.Location = new System.Drawing.Point(66, 79);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(251, 25);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Digite a nota do aluno:";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(114, 255);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 66);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl2.Location = new System.Drawing.Point(66, 154);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(208, 25);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "A média da sala é:";
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.txt2.Location = new System.Drawing.Point(334, 151);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(354, 31);
            this.txt2.TabIndex = 3;
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.txt1.Location = new System.Drawing.Point(334, 79);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(354, 31);
            this.txt1.TabIndex = 5;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged_1);
            // 
            // lblnotas
            // 
            this.lblnotas.AutoSize = true;
            this.lblnotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblnotas.Location = new System.Drawing.Point(460, 51);
            this.lblnotas.Name = "lblnotas";
            this.lblnotas.Size = new System.Drawing.Size(58, 25);
            this.lblnotas.TabIndex = 6;
            this.lblnotas.Text = "0/30";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblnotas);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lbl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lblnotas;
    }
}