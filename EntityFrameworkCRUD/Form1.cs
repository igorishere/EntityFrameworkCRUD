using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace EntityFrameworkCRUD
{
    public partial class EFCRUD : Form
    {
        Pessoas pessoa = new Pessoas();
        public EFCRUD()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            txtBxPrimeiroNome.Text = txtBxUltimoNome.Text = txtCidade.Text = txtEndereco.Text = "";
            btnSalvar.Text = "Salvar";
            btnDeletar.Enabled = false;
            pessoa.PessoasID = 0;
        }

        private void EFCRUD_Load(object sender, EventArgs e)
        {
            Clear();
            this.ActiveControl = txtBxPrimeiroNome;
            LoadData();
        }

        private Boolean estaPreenchido(TextBox campoParaValidar)
        {
            if (campoParaValidar.Text == "")
            {
                campoParaValidar.Focus(); 
                MessageBox.Show("Existem campos vazios, verifique");

                return false;
            }

            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (estaPreenchido(txtBxPrimeiroNome) && estaPreenchido(txtBxUltimoNome) && estaPreenchido(txtCidade) && estaPreenchido(txtEndereco))
            { 
                pessoa.PrimeiroNome = txtBxPrimeiroNome.Text.Trim();
                pessoa.UltimoNome = txtBxUltimoNome.Text.Trim();
                pessoa.Cidade = txtCidade.Text.Trim();
                pessoa.Endereco = txtEndereco.Text.Trim();

                using (EFCRUDEntities database = new EFCRUDEntities())
                {
                    if (pessoa.PessoasID == 0)
                    {
                        database.Pessoas.Add(pessoa);
                    }
                    else
                    {
                        database.Entry(pessoa).State = EntityState.Modified;
                    }

                    database.SaveChanges();
                }
                LoadData();
                Clear();

                MessageBox.Show("Salvo com sucesso");
            } 

            
        }


        void LoadData()
        {
            using (EFCRUDEntities database = new EFCRUDEntities())
            {
                dgViewPessoa.DataSource = database.Pessoas.ToList<Pessoas>();
            }
        }


        private void dgViewPessoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgViewPessoa.CurrentRow.Index != -1)
            {
                var conteudoPessoasID = dgViewPessoa.CurrentRow.Cells["PessoaID"].Value;
                btnDeletar.Enabled = true;

                pessoa.PessoasID = Convert.ToInt32(conteudoPessoasID);
                using (EFCRUDEntities database = new EFCRUDEntities())
                {
                    pessoa = database.Pessoas.Where(
                        itemEncontrado => itemEncontrado.PessoasID == pessoa.PessoasID
                        ).FirstOrDefault();

                    txtBxPrimeiroNome.Text = pessoa.PrimeiroNome;
                    txtBxUltimoNome.Text = pessoa.UltimoNome;
                    txtCidade.Text = pessoa.Cidade;
                    txtEndereco.Text = pessoa.Endereco;
                }
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir?","Aviso",MessageBoxButtons.YesNo) == DialogResult.Yes );
            {
                using (EFCRUDEntities database = new EFCRUDEntities())
                {
                    var entry = database.Entry(pessoa);

                    if(entry.State == EntityState.Detached)
                    {
                        database.Pessoas.Attach(pessoa);
                        database.Pessoas.Remove(pessoa);
                        database.SaveChanges();
                        LoadData();
                        Clear();

                        MessageBox.Show("Deletado com sucesso");
                    }
                }
            }
        }
 
    }
}
