namespace prj16_assistencia_tecnica
{
    partial class tlCadEquipamento
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.txtAparelho = new System.Windows.Forms.TextBox();
            this.btnCadEquipamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Aparelho:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Modelo:";
            // 
            // cbModelo
            // 
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(133, 87);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(233, 21);
            this.cbModelo.TabIndex = 9;
            // 
            // txtAparelho
            // 
            this.txtAparelho.Location = new System.Drawing.Point(133, 38);
            this.txtAparelho.Name = "txtAparelho";
            this.txtAparelho.Size = new System.Drawing.Size(233, 20);
            this.txtAparelho.TabIndex = 10;
            // 
            // btnCadEquipamento
            // 
            this.btnCadEquipamento.Location = new System.Drawing.Point(133, 125);
            this.btnCadEquipamento.Name = "btnCadEquipamento";
            this.btnCadEquipamento.Size = new System.Drawing.Size(168, 42);
            this.btnCadEquipamento.TabIndex = 11;
            this.btnCadEquipamento.Text = "Cadastrar Equipamento";
            this.btnCadEquipamento.UseVisualStyleBackColor = true;
            this.btnCadEquipamento.Click += new System.EventHandler(this.btnCadEquipamento_Click);
            // 
            // tlCadEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 188);
            this.Controls.Add(this.btnCadEquipamento);
            this.Controls.Add(this.txtAparelho);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "tlCadEquipamento";
            this.Text = "Cadastro Equipamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.TextBox txtAparelho;
        private System.Windows.Forms.Button btnCadEquipamento;
    }
}