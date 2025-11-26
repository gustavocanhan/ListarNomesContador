namespace ListarNomesContador
{
    public partial class Frm_TelaInicial : Form
    {
        int contador = 0;

        public Frm_TelaInicial()
        {
            InitializeComponent();
        }

        private void Btn_Adicionar_Click(object sender, EventArgs e)
        {
            string nome = Txt_Nome.Text.Trim();

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Por favor, insira um nome válido.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_Nome.Focus();
                return;
            }

            Lst_Nomes.Items.Add(nome);

            contador++;
            Lbl_Quantidade.Text = contador.ToString();

            Txt_Nome.Clear();
            Txt_Nome.Focus();

        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            contador = 0;
            Lbl_Quantidade.Text = "0";
            Txt_Nome.Clear();
            Lst_Nomes.Items.Clear();
            Txt_Nome.Focus();
        }
    }
}
