namespace Farm_System.View
{
    partial class CadastroDePessoasOficial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroDePessoasOficial));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbEndereco = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listaDetalhes = new System.Windows.Forms.ListView();
            this.colNome = new System.Windows.Forms.ColumnHeader();
            this.colTelefone = new System.Windows.Forms.ColumnHeader();
            this.colEmail = new System.Windows.Forms.ColumnHeader();
            this.tbInfoBancarias = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbFornecedor = new System.Windows.Forms.CheckBox();
            this.cbCliente = new System.Windows.Forms.CheckBox();
            this.tbCpfCnpj = new System.Windows.Forms.TextBox();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tbEndereco.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotoesPrincipais
            // 
            this.pnlBotoesPrincipais.Size = new System.Drawing.Size(1298, 27);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 617);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbEndereco);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 186);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1298, 431);
            this.panel3.TabIndex = 5;
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
            this.tbEndereco.Size = new System.Drawing.Size(1298, 431);
            this.tbEndereco.TabIndex = 1;
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
            this.tabPage1.Size = new System.Drawing.Size(1290, 400);
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
            this.tbInfoBancarias.Size = new System.Drawing.Size(1290, 400);
            this.tbInfoBancarias.TabIndex = 1;
            this.tbInfoBancarias.Text = "Informações Bancárias";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.cbFornecedor);
            this.panel2.Controls.Add(this.cbCliente);
            this.panel2.Controls.Add(this.tbCpfCnpj);
            this.panel2.Controls.Add(this.lblCpfCnpj);
            this.panel2.Controls.Add(this.lblNome);
            this.panel2.Controls.Add(this.tbNome);
            this.panel2.Controls.Add(this.lblCodigo);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1298, 186);
            this.panel2.TabIndex = 4;
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.AutoSize = true;
            this.cbFornecedor.Location = new System.Drawing.Point(22, 153);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(86, 19);
            this.cbFornecedor.TabIndex = 26;
            this.cbFornecedor.Text = "Fornecedor";
            this.cbFornecedor.UseVisualStyleBackColor = true;
            // 
            // cbCliente
            // 
            this.cbCliente.AutoSize = true;
            this.cbCliente.Location = new System.Drawing.Point(22, 128);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(63, 19);
            this.cbCliente.TabIndex = 25;
            this.cbCliente.Text = "Cliente";
            this.cbCliente.UseVisualStyleBackColor = true;
            // 
            // tbCpfCnpj
            // 
            this.tbCpfCnpj.Location = new System.Drawing.Point(78, 94);
            this.tbCpfCnpj.Name = "tbCpfCnpj";
            this.tbCpfCnpj.Size = new System.Drawing.Size(424, 23);
            this.tbCpfCnpj.TabIndex = 24;
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Location = new System.Drawing.Point(18, 102);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(60, 15);
            this.lblCpfCnpj.TabIndex = 23;
            this.lblCpfCnpj.Text = "CPF/CNPJ";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblNome.Location = new System.Drawing.Point(18, 71);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 22;
            this.lblNome.Text = "Nome";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(78, 63);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(424, 23);
            this.tbNome.TabIndex = 21;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCodigo.Location = new System.Drawing.Point(18, 39);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 15);
            this.lblCodigo.TabIndex = 20;
            this.lblCodigo.Text = "Código";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 23);
            this.textBox1.TabIndex = 19;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "salvar.png");
            this.imageList1.Images.SetKeyName(1, "edit.png");
            this.imageList1.Images.SetKeyName(2, "document_add_256_icon-icons.com_75994.png");
            this.imageList1.Images.SetKeyName(3, "documentediting_editdocuments_text_documentedi_2820.png");
            this.imageList1.Images.SetKeyName(4, "vcsconflicting_93497.ico");
            // 
            // CadastroDePessoasOficial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 617);
            this.Controls.Add(this.panel1);
            this.Name = "CadastroDePessoasOficial";
            this.Text = "CadastroDePessoasOficial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pnlBotoesPrincipais, 0);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tbEndereco.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private ImageList imageList1;
        private Panel panel2;
        private CheckBox cbFornecedor;
        private CheckBox cbCliente;
        private TextBox tbCpfCnpj;
        private Label lblCpfCnpj;
        private Label lblNome;
        private TextBox tbNome;
        private Label lblCodigo;
        private TextBox textBox1;
        private Panel panel3;
        private TabControl tbEndereco;
        private TabPage tabPage1;
        private ListView listaDetalhes;
        private ColumnHeader colNome;
        private ColumnHeader colTelefone;
        private ColumnHeader colEmail;
        private TabPage tbInfoBancarias;
    }
}