namespace ex9dezembro
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
            this.Botao = new System.Windows.Forms.Button();
            this.mensagem1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Botao
            // 
            this.Botao.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Botao.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Botao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Botao.Location = new System.Drawing.Point(265, 94);
            this.Botao.Name = "Botao";
            this.Botao.Size = new System.Drawing.Size(244, 74);
            this.Botao.TabIndex = 0;
            this.Botao.Text = "clique aqui";
            this.Botao.UseVisualStyleBackColor = false;
            this.Botao.Click += new System.EventHandler(this.botao_Click);
            // 
            // mensagem1
            // 
            this.mensagem1.AutoSize = true;
            this.mensagem1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mensagem1.Location = new System.Drawing.Point(218, 204);
            this.mensagem1.Name = "mensagem1";
            this.mensagem1.Size = new System.Drawing.Size(362, 86);
            this.mensagem1.TabIndex = 1;
            this.mensagem1.Text = "ola mundo";
            this.mensagem1.Click += new System.EventHandler(this.mensagem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mensagem1);
            this.Controls.Add(this.Botao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Botao;
        private Label mensagem1;
    }
}