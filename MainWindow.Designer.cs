
namespace ITHelper
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.barraFerramentas = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarcomoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarImpressãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.recortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selecionarTudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conteúdoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.índiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abas = new System.Windows.Forms.TabControl();
            this.abaSwitches = new System.Windows.Forms.TabPage();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnDel = new FontAwesome.Sharp.IconButton();
            this.barraFerramentas.SuspendLayout();
            this.abas.SuspendLayout();
            this.abaSwitches.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraFerramentas
            // 
            this.barraFerramentas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barraFerramentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.ferramentasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.barraFerramentas.Location = new System.Drawing.Point(0, 0);
            this.barraFerramentas.Name = "barraFerramentas";
            this.barraFerramentas.Size = new System.Drawing.Size(1224, 28);
            this.barraFerramentas.TabIndex = 0;
            this.barraFerramentas.Text = "Barra de Ferramentas";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.toolStripSeparator,
            this.salvarToolStripMenuItem,
            this.salvarcomoToolStripMenuItem,
            this.toolStripSeparator1,
            this.imprimirToolStripMenuItem,
            this.visualizarImpressãoToolStripMenuItem,
            this.toolStripSeparator2,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripMenuItem.Image")));
            this.novoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.novoToolStripMenuItem.Text = "&Novo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem.Image")));
            this.abrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.abrirToolStripMenuItem.Text = "&Abrir";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(210, 6);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripMenuItem.Image")));
            this.salvarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.salvarToolStripMenuItem.Text = "&Salvar";
            // 
            // salvarcomoToolStripMenuItem
            // 
            this.salvarcomoToolStripMenuItem.Name = "salvarcomoToolStripMenuItem";
            this.salvarcomoToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.salvarcomoToolStripMenuItem.Text = "Salvar &como";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripMenuItem.Image")));
            this.imprimirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.imprimirToolStripMenuItem.Text = "&Imprimir";
            // 
            // visualizarImpressãoToolStripMenuItem
            // 
            this.visualizarImpressãoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("visualizarImpressãoToolStripMenuItem.Image")));
            this.visualizarImpressãoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.visualizarImpressãoToolStripMenuItem.Name = "visualizarImpressãoToolStripMenuItem";
            this.visualizarImpressãoToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.visualizarImpressãoToolStripMenuItem.Text = "Visuali&zar Impressão";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(210, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.sairToolStripMenuItem.Text = "Sai&r";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desfazerToolStripMenuItem,
            this.refazerToolStripMenuItem,
            this.toolStripSeparator3,
            this.recortarToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.toolStripSeparator4,
            this.selecionarTudoToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.editarToolStripMenuItem.Text = "&Editar";
            // 
            // desfazerToolStripMenuItem
            // 
            this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            this.desfazerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.desfazerToolStripMenuItem.Text = "&Desfazer";
            // 
            // refazerToolStripMenuItem
            // 
            this.refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            this.refazerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.refazerToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.refazerToolStripMenuItem.Text = "&Refazer";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(184, 6);
            // 
            // recortarToolStripMenuItem
            // 
            this.recortarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("recortarToolStripMenuItem.Image")));
            this.recortarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            this.recortarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.recortarToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.recortarToolStripMenuItem.Text = "Recor&tar";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripMenuItem.Image")));
            this.copiarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.copiarToolStripMenuItem.Text = "&Copiar";
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("colarToolStripMenuItem.Image")));
            this.colarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.colarToolStripMenuItem.Text = "C&olar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(184, 6);
            // 
            // selecionarTudoToolStripMenuItem
            // 
            this.selecionarTudoToolStripMenuItem.Name = "selecionarTudoToolStripMenuItem";
            this.selecionarTudoToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.selecionarTudoToolStripMenuItem.Text = "Selecionar &Tudo";
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalizarToolStripMenuItem,
            this.opçõesToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.ferramentasToolStripMenuItem.Text = "Ferra&mentas";
            // 
            // personalizarToolStripMenuItem
            // 
            this.personalizarToolStripMenuItem.Name = "personalizarToolStripMenuItem";
            this.personalizarToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.personalizarToolStripMenuItem.Text = "&Personalizar";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.opçõesToolStripMenuItem.Text = "&Opções";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conteúdoToolStripMenuItem,
            this.índiceToolStripMenuItem,
            this.pesquisarToolStripMenuItem,
            this.toolStripSeparator5,
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.ajudaToolStripMenuItem.Text = "Aj&uda";
            // 
            // conteúdoToolStripMenuItem
            // 
            this.conteúdoToolStripMenuItem.Name = "conteúdoToolStripMenuItem";
            this.conteúdoToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.conteúdoToolStripMenuItem.Text = "&Conteúdo";
            // 
            // índiceToolStripMenuItem
            // 
            this.índiceToolStripMenuItem.Name = "índiceToolStripMenuItem";
            this.índiceToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.índiceToolStripMenuItem.Text = "Í&ndice";
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.pesquisarToolStripMenuItem.Text = "&Pesquisar";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(140, 6);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.sobreToolStripMenuItem.Text = "&Sobre...";
            // 
            // abas
            // 
            this.abas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.abas.Controls.Add(this.abaSwitches);
            this.abas.Location = new System.Drawing.Point(12, 31);
            this.abas.Name = "abas";
            this.abas.SelectedIndex = 0;
            this.abas.Size = new System.Drawing.Size(1200, 598);
            this.abas.TabIndex = 1;
            // 
            // abaSwitches
            // 
            this.abaSwitches.Controls.Add(this.btnDel);
            this.abaSwitches.Controls.Add(this.btnAdd);
            this.abaSwitches.Location = new System.Drawing.Point(4, 30);
            this.abaSwitches.Name = "abaSwitches";
            this.abaSwitches.Padding = new System.Windows.Forms.Padding(3);
            this.abaSwitches.Size = new System.Drawing.Size(1192, 564);
            this.abaSwitches.TabIndex = 0;
            this.abaSwitches.Text = "Switches";
            this.abaSwitches.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Green;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 42;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(42, 42);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDel.IconColor = System.Drawing.Color.DarkRed;
            this.btnDel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDel.IconSize = 42;
            this.btnDel.Location = new System.Drawing.Point(54, 3);
            this.btnDel.Margin = new System.Windows.Forms.Padding(0);
            this.btnDel.Name = "btnDel";
            this.btnDel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnDel.Size = new System.Drawing.Size(42, 42);
            this.btnDel.TabIndex = 1;
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1224, 641);
            this.Controls.Add(this.abas);
            this.Controls.Add(this.barraFerramentas);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1240, 680);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ITHelper";
            this.barraFerramentas.ResumeLayout(false);
            this.barraFerramentas.PerformLayout();
            this.abas.ResumeLayout(false);
            this.abaSwitches.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip barraFerramentas;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarcomoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarImpressãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desfazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem recortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selecionarTudoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conteúdoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem índiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.TabControl abas;
        private System.Windows.Forms.TabPage abaSwitches;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnDel;
    }
}

