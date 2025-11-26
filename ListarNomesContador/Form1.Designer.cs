namespace ListarNomesContador
{
    partial class Frm_TelaInicial
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
            label1 = new Label();
            Txt_Nome = new TextBox();
            Btn_Adicionar = new Button();
            Lst_Nomes = new ListBox();
            Lbl_Resultado = new Label();
            Lbl_QuantidadeTitulo = new Label();
            Lbl_Quantidade = new Label();
            Btn_Limpar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // Txt_Nome
            // 
            Txt_Nome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Txt_Nome.Location = new Point(12, 27);
            Txt_Nome.Name = "Txt_Nome";
            Txt_Nome.Size = new Size(260, 23);
            Txt_Nome.TabIndex = 2;
            // 
            // Btn_Adicionar
            // 
            Btn_Adicionar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Adicionar.Location = new Point(197, 56);
            Btn_Adicionar.Name = "Btn_Adicionar";
            Btn_Adicionar.Size = new Size(75, 23);
            Btn_Adicionar.TabIndex = 3;
            Btn_Adicionar.Text = "Adicionar";
            Btn_Adicionar.UseVisualStyleBackColor = true;
            Btn_Adicionar.Click += Btn_Adicionar_Click;
            // 
            // Lst_Nomes
            // 
            Lst_Nomes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Lst_Nomes.FormattingEnabled = true;
            Lst_Nomes.Location = new Point(12, 103);
            Lst_Nomes.Name = "Lst_Nomes";
            Lst_Nomes.Size = new Size(260, 184);
            Lst_Nomes.TabIndex = 4;
            // 
            // Lbl_Resultado
            // 
            Lbl_Resultado.AutoSize = true;
            Lbl_Resultado.Location = new Point(12, 85);
            Lbl_Resultado.Name = "Lbl_Resultado";
            Lbl_Resultado.Size = new Size(91, 15);
            Lbl_Resultado.TabIndex = 5;
            Lbl_Resultado.Text = "Lista de Nomes:";
            // 
            // Lbl_QuantidadeTitulo
            // 
            Lbl_QuantidadeTitulo.AutoSize = true;
            Lbl_QuantidadeTitulo.Location = new Point(12, 290);
            Lbl_QuantidadeTitulo.Name = "Lbl_QuantidadeTitulo";
            Lbl_QuantidadeTitulo.Size = new Size(127, 15);
            Lbl_QuantidadeTitulo.TabIndex = 6;
            Lbl_QuantidadeTitulo.Text = "Quantidade de nomes:";
            // 
            // Lbl_Quantidade
            // 
            Lbl_Quantidade.AutoSize = true;
            Lbl_Quantidade.Location = new Point(134, 290);
            Lbl_Quantidade.Name = "Lbl_Quantidade";
            Lbl_Quantidade.Size = new Size(13, 15);
            Lbl_Quantidade.TabIndex = 7;
            Lbl_Quantidade.Text = "0";
            // 
            // Btn_Limpar
            // 
            Btn_Limpar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Limpar.Location = new Point(197, 320);
            Btn_Limpar.Name = "Btn_Limpar";
            Btn_Limpar.Size = new Size(75, 23);
            Btn_Limpar.TabIndex = 8;
            Btn_Limpar.Text = "Limpar";
            Btn_Limpar.UseVisualStyleBackColor = true;
            Btn_Limpar.Click += Btn_Limpar_Click;
            // 
            // Frm_TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 362);
            Controls.Add(Btn_Limpar);
            Controls.Add(Lbl_Quantidade);
            Controls.Add(Lbl_QuantidadeTitulo);
            Controls.Add(Lbl_Resultado);
            Controls.Add(Lst_Nomes);
            Controls.Add(Btn_Adicionar);
            Controls.Add(Txt_Nome);
            Controls.Add(label1);
            Name = "Frm_TelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Nomes com Contador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Txt_Nome;
        private Button Btn_Adicionar;
        private ListBox Lst_Nomes;
        private Label Lbl_Resultado;
        private Label Lbl_QuantidadeTitulo;
        private Label Lbl_Quantidade;
        private Button Btn_Limpar;
    }
}
