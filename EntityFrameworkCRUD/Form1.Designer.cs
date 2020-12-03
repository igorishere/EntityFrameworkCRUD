
namespace EntityFrameworkCRUD
{
    partial class EFCRUD
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxPrimeiroNome = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgViewPessoa = new System.Windows.Forms.DataGridView();
            this.PessoaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimeiroNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltimoNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBxUltimoNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(53, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primeiro nome";
            // 
            // txtBxPrimeiroNome
            // 
            this.txtBxPrimeiroNome.Location = new System.Drawing.Point(132, 123);
            this.txtBxPrimeiroNome.Name = "txtBxPrimeiroNome";
            this.txtBxPrimeiroNome.Size = new System.Drawing.Size(178, 20);
            this.txtBxPrimeiroNome.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.ForeColor = System.Drawing.Color.Maroon;
            this.btnSalvar.Location = new System.Drawing.Point(32, 326);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dgViewPessoa
            // 
            this.dgViewPessoa.AllowUserToDeleteRows = false;
            this.dgViewPessoa.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgViewPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewPessoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PessoaID,
            this.PrimeiroNome,
            this.UltimoNome,
            this.Cidade,
            this.Endereco});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgViewPessoa.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgViewPessoa.GridColor = System.Drawing.Color.Gray;
            this.dgViewPessoa.Location = new System.Drawing.Point(357, 12);
            this.dgViewPessoa.Name = "dgViewPessoa";
            this.dgViewPessoa.ReadOnly = true;
            this.dgViewPessoa.Size = new System.Drawing.Size(545, 337);
            this.dgViewPessoa.TabIndex = 3;
            this.dgViewPessoa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewPessoa_CellDoubleClick);
            // 
            // PessoaID
            // 
            this.PessoaID.DataPropertyName = "PessoasID";
            this.PessoaID.HeaderText = "ID";
            this.PessoaID.Name = "PessoaID";
            this.PessoaID.ReadOnly = true;
            // 
            // PrimeiroNome
            // 
            this.PrimeiroNome.DataPropertyName = "PrimeiroNome";
            this.PrimeiroNome.HeaderText = "Primeiro Nome";
            this.PrimeiroNome.Name = "PrimeiroNome";
            this.PrimeiroNome.ReadOnly = true;
            // 
            // UltimoNome
            // 
            this.UltimoNome.DataPropertyName = "UltimoNome";
            this.UltimoNome.HeaderText = "Ultimo Nome";
            this.UltimoNome.Name = "UltimoNome";
            this.UltimoNome.ReadOnly = true;
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "Cidade";
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // Endereco
            // 
            this.Endereco.DataPropertyName = "Endereco";
            this.Endereco.HeaderText = "Endereço";
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            // 
            // txtBxUltimoNome
            // 
            this.txtBxUltimoNome.Location = new System.Drawing.Point(132, 149);
            this.txtBxUltimoNome.Name = "txtBxUltimoNome";
            this.txtBxUltimoNome.Size = new System.Drawing.Size(178, 20);
            this.txtBxUltimoNome.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Último nome";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(132, 175);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(178, 20);
            this.txtCidade.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cidade";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(132, 201);
            this.txtEndereco.Multiline = true;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(178, 62);
            this.txtEndereco.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Endereço";
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.Maroon;
            this.btnCancelar.Location = new System.Drawing.Point(235, 326);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Enabled = false;
            this.btnDeletar.ForeColor = System.Drawing.Color.Maroon;
            this.btnDeletar.Location = new System.Drawing.Point(132, 326);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 11;
            this.btnDeletar.Text = "Excluir";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(187, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "Formulário";
            // 
            // EFCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(914, 361);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxUltimoNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgViewPessoa);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtBxPrimeiroNome);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "EFCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EFCRUD";
            this.Load += new System.EventHandler(this.EFCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewPessoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxPrimeiroNome;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgViewPessoa;
        private System.Windows.Forms.TextBox txtBxUltimoNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn PessoaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimeiroNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn UltimoNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
    }
}

