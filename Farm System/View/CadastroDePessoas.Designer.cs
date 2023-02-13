namespace Farm_System.View
{
    partial class CadastroDePessoas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroDePessoas));
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlInformacoesAdicionais = new System.Windows.Forms.Panel();
            this.tbEndereco = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listaDetalhes = new System.Windows.Forms.ListView();
            this.colNome = new System.Windows.Forms.ColumnHeader();
            this.colTelefone = new System.Windows.Forms.ColumnHeader();
            this.colEmail = new System.Windows.Forms.ColumnHeader();
            this.tbInfoBancarias = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cbFornecedor = new System.Windows.Forms.CheckBox();
            this.cbCliente = new System.Windows.Forms.CheckBox();
            this.tbCpfCnpj = new System.Windows.Forms.TextBox();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Salvar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlPrincipal.SuspendLayout();
            this.pnlInformacoesAdicionais.SuspendLayout();
            this.tbEndereco.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.AutoSize = true;
            this.pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPrincipal.Controls.Add(this.pnlInformacoesAdicionais);
            this.pnlPrincipal.Controls.Add(this.panel1);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1342, 690);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // pnlInformacoesAdicionais
            // 
            this.pnlInformacoesAdicionais.Controls.Add(this.tbEndereco);
            this.pnlInformacoesAdicionais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInformacoesAdicionais.Location = new System.Drawing.Point(0, 213);
            this.pnlInformacoesAdicionais.Name = "pnlInformacoesAdicionais";
            this.pnlInformacoesAdicionais.Size = new System.Drawing.Size(1340, 475);
            this.pnlInformacoesAdicionais.TabIndex = 1;
            // 
            // tbEndereco
            // 
            this.tbEndereco.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbEndereco.CausesValidation = false;
            this.tbEndereco.Controls.Add(this.tabPage1);
            this.tbEndereco.Controls.Add(this.tbInfoBancarias);
            this.tbEndereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEndereco.Location = new System.Drawing.Point(0, 0);
            this.tbEndereco.Multiline = true;
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.SelectedIndex = 0;
            this.tbEndereco.Size = new System.Drawing.Size(1340, 475);
            this.tbEndereco.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.listaDetalhes);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1332, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Endereço";
            // 
            // listaDetalhes
            // 
            this.listaDetalhes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNome,
            this.colTelefone,
            this.colEmail});
            this.listaDetalhes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listaDetalhes.FullRowSelect = true;
            this.listaDetalhes.Location = new System.Drawing.Point(51, 16);
            this.listaDetalhes.Name = "listaDetalhes";
            this.listaDetalhes.Size = new System.Drawing.Size(1135, 274);
            this.listaDetalhes.TabIndex = 0;
            this.listaDetalhes.UseCompatibleStateImageBehavior = false;
            this.listaDetalhes.View = System.Windows.Forms.View.Details;
            // 
            // colNome
            // 
            this.colNome.Text = "Nome";
            this.colNome.Width = 200;
            // 
            // colTelefone
            // 
            this.colTelefone.Text = "Telefone";
            this.colTelefone.Width = 200;
            // 
            // colEmail
            // 
            this.colEmail.Text = "Email";
            this.colEmail.Width = 250;
            // 
            // tbInfoBancarias
            // 
            this.tbInfoBancarias.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbInfoBancarias.Location = new System.Drawing.Point(4, 27);
            this.tbInfoBancarias.Name = "tbInfoBancarias";
            this.tbInfoBancarias.Padding = new System.Windows.Forms.Padding(3);
            this.tbInfoBancarias.Size = new System.Drawing.Size(1332, 444);
            this.tbInfoBancarias.TabIndex = 1;
            this.tbInfoBancarias.Text = "Informações Bancárias";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Salvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 213);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnLimpar);
            this.panel2.Controls.Add(this.cbFornecedor);
            this.panel2.Controls.Add(this.cbCliente);
            this.panel2.Controls.Add(this.tbCpfCnpj);
            this.panel2.Controls.Add(this.lblCpfCnpj);
            this.panel2.Controls.Add(this.lblNome);
            this.panel2.Controls.Add(this.tbNome);
            this.panel2.Controls.Add(this.lblCodigo);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1336, 166);
            this.panel2.TabIndex = 12;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(1043, 38);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(145, 49);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.AutoSize = true;
            this.cbFornecedor.Location = new System.Drawing.Point(15, 137);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(86, 19);
            this.cbFornecedor.TabIndex = 18;
            this.cbFornecedor.Text = "Fornecedor";
            this.cbFornecedor.UseVisualStyleBackColor = true;
            // 
            // cbCliente
            // 
            this.cbCliente.AutoSize = true;
            this.cbCliente.Location = new System.Drawing.Point(15, 112);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(63, 19);
            this.cbCliente.TabIndex = 17;
            this.cbCliente.Text = "Cliente";
            this.cbCliente.UseVisualStyleBackColor = true;
            // 
            // tbCpfCnpj
            // 
            this.tbCpfCnpj.Location = new System.Drawing.Point(71, 78);
            this.tbCpfCnpj.Name = "tbCpfCnpj";
            this.tbCpfCnpj.Size = new System.Drawing.Size(424, 23);
            this.tbCpfCnpj.TabIndex = 16;
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Location = new System.Drawing.Point(11, 86);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(60, 15);
            this.lblCpfCnpj.TabIndex = 15;
            this.lblCpfCnpj.Text = "CPF/CNPJ";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblNome.Location = new System.Drawing.Point(11, 55);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 14;
            this.lblNome.Text = "Nome";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(71, 47);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(424, 23);
            this.tbNome.TabIndex = 13;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCodigo.Location = new System.Drawing.Point(11, 23);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 15);
            this.lblCodigo.TabIndex = 12;
            this.lblCodigo.Text = "Código";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 23);
            this.textBox1.TabIndex = 11;
            // 
            // Salvar
            // 
            this.Salvar.ImageIndex = 0;
            this.Salvar.ImageList = this.imageList1;
            this.Salvar.Location = new System.Drawing.Point(71, 11);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(58, 30);
            this.Salvar.TabIndex = 6;
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "salvar.png");
            // 
            // CadastroDePessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 690);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "CadastroDePessoas";
            this.Text = "Pessoa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlInformacoesAdicionais.ResumeLayout(false);
            this.tbEndereco.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlPrincipal;
        private Panel pnlInformacoesAdicionais;
        private TabControl tbEndereco;
        private TabPage tabPage1;
        private TabPage tbInfoBancarias;
        private Panel panel1;
        private Button Salvar;
        private ImageList imageList1;
        private Panel panel2;
        private TextBox tbCpfCnpj;
        private Label lblCpfCnpj;
        private Label lblNome;
        private TextBox tbNome;
        private Label lblCodigo;
        private TextBox textBox1;
        private CheckBox cbFornecedor;
        private CheckBox cbCliente;
        private ListView listaDetalhes;
        private ColumnHeader colNome;
        private ColumnHeader colTelefone;
        private ColumnHeader colEmail;
        private Button btnLimpar;
    }
}