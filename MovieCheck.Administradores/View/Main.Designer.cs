namespace MovieCheck.Administradores.View
{
    partial class Main
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
            contexto.Dispose();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dependenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dependenteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioAtualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liberarNovoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloquearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desbloquearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dependenteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.filmeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exemplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.filmeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exemplarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.filmeToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.exemplarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarFilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alugarFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disponíveisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolverFilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarLocaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem,
            this.filmeToolStripMenuItem,
            this.pendênciasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(478, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.liberarNovoUsuárioToolStripMenuItem,
            this.bloquearToolStripMenuItem,
            this.desbloquearToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.trocarDeUsuarioToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.dependenteToolStripMenuItem,
            this.administradorToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // dependenteToolStripMenuItem
            // 
            this.dependenteToolStripMenuItem.Name = "dependenteToolStripMenuItem";
            this.dependenteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dependenteToolStripMenuItem.Text = "Dependente";
            this.dependenteToolStripMenuItem.Click += new System.EventHandler(this.dependenteToolStripMenuItem_Click);
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.administradorToolStripMenuItem.Text = "Administrador";
            this.administradorToolStripMenuItem.Click += new System.EventHandler(this.administradorToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.dependenteToolStripMenuItem1,
            this.administradorToolStripMenuItem1,
            this.usuárioAtualToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // dependenteToolStripMenuItem1
            // 
            this.dependenteToolStripMenuItem1.Name = "dependenteToolStripMenuItem1";
            this.dependenteToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.dependenteToolStripMenuItem1.Text = "Dependente";
            this.dependenteToolStripMenuItem1.Click += new System.EventHandler(this.dependenteToolStripMenuItem1_Click);
            // 
            // administradorToolStripMenuItem1
            // 
            this.administradorToolStripMenuItem1.Name = "administradorToolStripMenuItem1";
            this.administradorToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.administradorToolStripMenuItem1.Text = "Administrador";
            this.administradorToolStripMenuItem1.Click += new System.EventHandler(this.administradorToolStripMenuItem1_Click);
            // 
            // usuárioAtualToolStripMenuItem
            // 
            this.usuárioAtualToolStripMenuItem.Name = "usuárioAtualToolStripMenuItem";
            this.usuárioAtualToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuárioAtualToolStripMenuItem.Text = "Usuário atual";
            this.usuárioAtualToolStripMenuItem.Click += new System.EventHandler(this.usuárioAtualToolStripMenuItem_Click);
            // 
            // liberarNovoUsuárioToolStripMenuItem
            // 
            this.liberarNovoUsuárioToolStripMenuItem.Enabled = false;
            this.liberarNovoUsuárioToolStripMenuItem.Name = "liberarNovoUsuárioToolStripMenuItem";
            this.liberarNovoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.liberarNovoUsuárioToolStripMenuItem.Text = "Liberar novo usuário";
            this.liberarNovoUsuárioToolStripMenuItem.Click += new System.EventHandler(this.liberarNovoUsuárioToolStripMenuItem_Click);
            // 
            // bloquearToolStripMenuItem
            // 
            this.bloquearToolStripMenuItem.Name = "bloquearToolStripMenuItem";
            this.bloquearToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.bloquearToolStripMenuItem.Text = "Bloquear";
            this.bloquearToolStripMenuItem.Click += new System.EventHandler(this.bloquearToolStripMenuItem_Click);
            // 
            // desbloquearToolStripMenuItem
            // 
            this.desbloquearToolStripMenuItem.Name = "desbloquearToolStripMenuItem";
            this.desbloquearToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.desbloquearToolStripMenuItem.Text = "Desbloquear";
            this.desbloquearToolStripMenuItem.Click += new System.EventHandler(this.desbloquearToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem2,
            this.dependenteToolStripMenuItem2,
            this.administradorToolStripMenuItem2});
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // clienteToolStripMenuItem2
            // 
            this.clienteToolStripMenuItem2.Name = "clienteToolStripMenuItem2";
            this.clienteToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.clienteToolStripMenuItem2.Text = "Cliente";
            this.clienteToolStripMenuItem2.Click += new System.EventHandler(this.clienteToolStripMenuItem2_Click);
            // 
            // dependenteToolStripMenuItem2
            // 
            this.dependenteToolStripMenuItem2.Name = "dependenteToolStripMenuItem2";
            this.dependenteToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.dependenteToolStripMenuItem2.Text = "Dependente";
            this.dependenteToolStripMenuItem2.Click += new System.EventHandler(this.dependenteToolStripMenuItem2_Click);
            // 
            // administradorToolStripMenuItem2
            // 
            this.administradorToolStripMenuItem2.Name = "administradorToolStripMenuItem2";
            this.administradorToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.administradorToolStripMenuItem2.Text = "Administrador";
            this.administradorToolStripMenuItem2.Click += new System.EventHandler(this.administradorToolStripMenuItem2_Click);
            // 
            // trocarDeUsuarioToolStripMenuItem
            // 
            this.trocarDeUsuarioToolStripMenuItem.Name = "trocarDeUsuarioToolStripMenuItem";
            this.trocarDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.trocarDeUsuarioToolStripMenuItem.Text = "Trocar de usuário";
            this.trocarDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.trocarDeUsuarioToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // filmeToolStripMenuItem
            // 
            this.filmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem1,
            this.editarToolStripMenuItem1,
            this.excluirToolStripMenuItem1,
            this.listarFilmeToolStripMenuItem});
            this.filmeToolStripMenuItem.Name = "filmeToolStripMenuItem";
            this.filmeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.filmeToolStripMenuItem.Text = "Filme";
            // 
            // novoToolStripMenuItem1
            // 
            this.novoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmeToolStripMenuItem1,
            this.exemplarToolStripMenuItem});
            this.novoToolStripMenuItem1.Name = "novoToolStripMenuItem1";
            this.novoToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.novoToolStripMenuItem1.Text = "Novo";
            // 
            // filmeToolStripMenuItem1
            // 
            this.filmeToolStripMenuItem1.Name = "filmeToolStripMenuItem1";
            this.filmeToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.filmeToolStripMenuItem1.Text = "Filme";
            // 
            // exemplarToolStripMenuItem
            // 
            this.exemplarToolStripMenuItem.Name = "exemplarToolStripMenuItem";
            this.exemplarToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.exemplarToolStripMenuItem.Text = "Exemplar";
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmeToolStripMenuItem2,
            this.exemplarToolStripMenuItem1});
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.editarToolStripMenuItem1.Text = "Editar";
            // 
            // filmeToolStripMenuItem2
            // 
            this.filmeToolStripMenuItem2.Name = "filmeToolStripMenuItem2";
            this.filmeToolStripMenuItem2.Size = new System.Drawing.Size(122, 22);
            this.filmeToolStripMenuItem2.Text = "Filme";
            // 
            // exemplarToolStripMenuItem1
            // 
            this.exemplarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.editarToolStripMenuItem2});
            this.exemplarToolStripMenuItem1.Name = "exemplarToolStripMenuItem1";
            this.exemplarToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.exemplarToolStripMenuItem1.Text = "Exemplar";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            // 
            // editarToolStripMenuItem2
            // 
            this.editarToolStripMenuItem2.Name = "editarToolStripMenuItem2";
            this.editarToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.editarToolStripMenuItem2.Text = "Editar";
            // 
            // excluirToolStripMenuItem1
            // 
            this.excluirToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmeToolStripMenuItem3,
            this.exemplarToolStripMenuItem2});
            this.excluirToolStripMenuItem1.Name = "excluirToolStripMenuItem1";
            this.excluirToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.excluirToolStripMenuItem1.Text = "Excluir";
            // 
            // filmeToolStripMenuItem3
            // 
            this.filmeToolStripMenuItem3.Name = "filmeToolStripMenuItem3";
            this.filmeToolStripMenuItem3.Size = new System.Drawing.Size(122, 22);
            this.filmeToolStripMenuItem3.Text = "Filme";
            // 
            // exemplarToolStripMenuItem2
            // 
            this.exemplarToolStripMenuItem2.Name = "exemplarToolStripMenuItem2";
            this.exemplarToolStripMenuItem2.Size = new System.Drawing.Size(122, 22);
            this.exemplarToolStripMenuItem2.Text = "Exemplar";
            // 
            // listarFilmeToolStripMenuItem
            // 
            this.listarFilmeToolStripMenuItem.Name = "listarFilmeToolStripMenuItem";
            this.listarFilmeToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.listarFilmeToolStripMenuItem.Text = "Listar filmes";
            // 
            // pendênciasToolStripMenuItem
            // 
            this.pendênciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservasToolStripMenuItem,
            this.locaçãoToolStripMenuItem});
            this.pendênciasToolStripMenuItem.Name = "pendênciasToolStripMenuItem";
            this.pendênciasToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.pendênciasToolStripMenuItem.Text = "Pendências";
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem1,
            this.cancelarToolStripMenuItem,
            this.listarReservasToolStripMenuItem});
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.reservasToolStripMenuItem.Text = "Reserva";
            // 
            // adicionarToolStripMenuItem1
            // 
            this.adicionarToolStripMenuItem1.Name = "adicionarToolStripMenuItem1";
            this.adicionarToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.adicionarToolStripMenuItem1.Text = "Adicionar";
            // 
            // cancelarToolStripMenuItem
            // 
            this.cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem";
            this.cancelarToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.cancelarToolStripMenuItem.Text = "Cancelar";
            // 
            // listarReservasToolStripMenuItem
            // 
            this.listarReservasToolStripMenuItem.Name = "listarReservasToolStripMenuItem";
            this.listarReservasToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.listarReservasToolStripMenuItem.Text = "Listar reservas";
            // 
            // locaçãoToolStripMenuItem
            // 
            this.locaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alugarFilmToolStripMenuItem,
            this.devolverFilmeToolStripMenuItem,
            this.cancelarLocaçãoToolStripMenuItem});
            this.locaçãoToolStripMenuItem.Name = "locaçãoToolStripMenuItem";
            this.locaçãoToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.locaçãoToolStripMenuItem.Text = "Locação";
            // 
            // alugarFilmToolStripMenuItem
            // 
            this.alugarFilmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservadosToolStripMenuItem,
            this.disponíveisToolStripMenuItem});
            this.alugarFilmToolStripMenuItem.Name = "alugarFilmToolStripMenuItem";
            this.alugarFilmToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.alugarFilmToolStripMenuItem.Text = "Alugar filme";
            // 
            // reservadosToolStripMenuItem
            // 
            this.reservadosToolStripMenuItem.Name = "reservadosToolStripMenuItem";
            this.reservadosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.reservadosToolStripMenuItem.Text = "Reservados";
            // 
            // disponíveisToolStripMenuItem
            // 
            this.disponíveisToolStripMenuItem.Name = "disponíveisToolStripMenuItem";
            this.disponíveisToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.disponíveisToolStripMenuItem.Text = "Disponíveis";
            // 
            // devolverFilmeToolStripMenuItem
            // 
            this.devolverFilmeToolStripMenuItem.Name = "devolverFilmeToolStripMenuItem";
            this.devolverFilmeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.devolverFilmeToolStripMenuItem.Text = "Devolver filme";
            // 
            // cancelarLocaçãoToolStripMenuItem
            // 
            this.cancelarLocaçãoToolStripMenuItem.Name = "cancelarLocaçãoToolStripMenuItem";
            this.cancelarLocaçãoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cancelarLocaçãoToolStripMenuItem.Text = "Cancelar locação";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.contatoToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // contatoToolStripMenuItem
            // 
            this.contatoToolStripMenuItem.Name = "contatoToolStripMenuItem";
            this.contatoToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.contatoToolStripMenuItem.Text = "Contato";
            this.contatoToolStripMenuItem.Click += new System.EventHandler(this.contatoToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Seja bem vindo!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(23, 128);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(70, 26);
            this.Nome.TabIndex = 10;
            this.Nome.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(25, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Utilize o menu acima para navegação. ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(337, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 221);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dependenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dependenteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem liberarNovoUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloquearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desbloquearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dependenteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem filmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem filmeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exemplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem filmeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exemplarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem filmeToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exemplarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listarFilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alugarFilmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disponíveisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolverFilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarLocaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contatoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem trocarDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioAtualToolStripMenuItem;
    }
}