namespace prj16_assistencia_tecnica
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
            this.btnCadCliente = new System.Windows.Forms.Button();
            this.btnCadEquipamento = new System.Windows.Forms.Button();
            this.btnCadServiço = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.Location = new System.Drawing.Point(26, 38);
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Size = new System.Drawing.Size(113, 46);
            this.btnCadCliente.TabIndex = 0;
            this.btnCadCliente.Text = "Cadastro Cliente";
            this.btnCadCliente.UseVisualStyleBackColor = true;
            this.btnCadCliente.Click += new System.EventHandler(this.btnCadCliente_Click);
            // 
            // btnCadEquipamento
            // 
            this.btnCadEquipamento.Location = new System.Drawing.Point(175, 38);
            this.btnCadEquipamento.Name = "btnCadEquipamento";
            this.btnCadEquipamento.Size = new System.Drawing.Size(113, 46);
            this.btnCadEquipamento.TabIndex = 1;
            this.btnCadEquipamento.Text = "Cadastro Equipamento";
            this.btnCadEquipamento.UseVisualStyleBackColor = true;
            this.btnCadEquipamento.Click += new System.EventHandler(this.btnCadEquipamento_Click);
            // 
            // btnCadServiço
            // 
            this.btnCadServiço.Location = new System.Drawing.Point(26, 110);
            this.btnCadServiço.Name = "btnCadServiço";
            this.btnCadServiço.Size = new System.Drawing.Size(262, 48);
            this.btnCadServiço.TabIndex = 2;
            this.btnCadServiço.Text = "Cadastro Serviço";
            this.btnCadServiço.UseVisualStyleBackColor = true;
            this.btnCadServiço.Click += new System.EventHandler(this.btnCadServiço_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 189);
            this.Controls.Add(this.btnCadServiço);
            this.Controls.Add(this.btnCadEquipamento);
            this.Controls.Add(this.btnCadCliente);
            this.Name = "Form1";
            this.Text = "Assitência Técnica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadCliente;
        private System.Windows.Forms.Button btnCadEquipamento;
        private System.Windows.Forms.Button btnCadServiço;
    }
}