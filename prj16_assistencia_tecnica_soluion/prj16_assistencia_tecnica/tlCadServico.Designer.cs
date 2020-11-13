namespace prj16_assistencia_tecnica
{
    partial class tlCadServico
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
            this.cbEquipamento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProblema = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadServico = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbEquipamento
            // 
            this.cbEquipamento.FormattingEnabled = true;
            this.cbEquipamento.Location = new System.Drawing.Point(196, 85);
            this.cbEquipamento.Name = "cbEquipamento";
            this.cbEquipamento.Size = new System.Drawing.Size(233, 21);
            this.cbEquipamento.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Equipamento:";
            // 
            // txtProblema
            // 
            this.txtProblema.Location = new System.Drawing.Point(196, 128);
            this.txtProblema.Multiline = true;
            this.txtProblema.Name = "txtProblema";
            this.txtProblema.Size = new System.Drawing.Size(233, 103);
            this.txtProblema.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Problemas do Equipamento:";
            // 
            // btnCadServico
            // 
            this.btnCadServico.Location = new System.Drawing.Point(141, 302);
            this.btnCadServico.Name = "btnCadServico";
            this.btnCadServico.Size = new System.Drawing.Size(153, 51);
            this.btnCadServico.TabIndex = 12;
            this.btnCadServico.Text = "Cadastrar Serviço";
            this.btnCadServico.UseVisualStyleBackColor = true;
            this.btnCadServico.Click += new System.EventHandler(this.btnCadServico_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cliente:";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(196, 44);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(233, 21);
            this.cbCliente.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Valor do Serviço:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(196, 253);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(109, 20);
            this.txtValor.TabIndex = 16;
            // 
            // tlCadServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 380);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCadServico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProblema);
            this.Controls.Add(this.cbEquipamento);
            this.Controls.Add(this.label4);
            this.Name = "tlCadServico";
            this.Text = "tlCadServico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEquipamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProblema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadServico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor;
    }
}