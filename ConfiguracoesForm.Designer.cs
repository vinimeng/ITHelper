
namespace ITHelper
{
    partial class ConfiguracoesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfiguracoesForm));
            this.tituloProgramaTextBox = new System.Windows.Forms.TextBox();
            this.tituloProgramaLabel = new System.Windows.Forms.Label();
            this.tituloAbaTextBox = new System.Windows.Forms.TextBox();
            this.tituloAbaLabel = new System.Windows.Forms.Label();
            this.URLLabel = new System.Windows.Forms.Label();
            this.URLTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new FontAwesome.Sharp.IconButton();
            this.abasListBox = new System.Windows.Forms.ListBox();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.salvarButton = new System.Windows.Forms.Button();
            this.configTextBox = new System.Windows.Forms.TextBox();
            this.carregarConfigButton = new System.Windows.Forms.Button();
            this.editButton = new FontAwesome.Sharp.IconButton();
            this.deleteButton = new FontAwesome.Sharp.IconButton();
            this.arrowUpButton = new FontAwesome.Sharp.IconButton();
            this.arrowDownButton = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // tituloProgramaTextBox
            // 
            this.tituloProgramaTextBox.Location = new System.Drawing.Point(165, 12);
            this.tituloProgramaTextBox.Name = "tituloProgramaTextBox";
            this.tituloProgramaTextBox.Size = new System.Drawing.Size(459, 29);
            this.tituloProgramaTextBox.TabIndex = 1;
            this.tituloProgramaTextBox.Text = "ITHelper";
            // 
            // tituloProgramaLabel
            // 
            this.tituloProgramaLabel.AutoSize = true;
            this.tituloProgramaLabel.Location = new System.Drawing.Point(12, 15);
            this.tituloProgramaLabel.Name = "tituloProgramaLabel";
            this.tituloProgramaLabel.Size = new System.Drawing.Size(147, 21);
            this.tituloProgramaLabel.TabIndex = 0;
            this.tituloProgramaLabel.Text = "Título do programa:";
            // 
            // tituloAbaTextBox
            // 
            this.tituloAbaTextBox.Location = new System.Drawing.Point(120, 57);
            this.tituloAbaTextBox.Name = "tituloAbaTextBox";
            this.tituloAbaTextBox.Size = new System.Drawing.Size(135, 29);
            this.tituloAbaTextBox.TabIndex = 2;
            // 
            // tituloAbaLabel
            // 
            this.tituloAbaLabel.AutoSize = true;
            this.tituloAbaLabel.Location = new System.Drawing.Point(12, 60);
            this.tituloAbaLabel.Name = "tituloAbaLabel";
            this.tituloAbaLabel.Size = new System.Drawing.Size(102, 21);
            this.tituloAbaLabel.TabIndex = 0;
            this.tituloAbaLabel.Text = "Título da aba:";
            // 
            // URLLabel
            // 
            this.URLLabel.AutoSize = true;
            this.URLLabel.Location = new System.Drawing.Point(261, 60);
            this.URLLabel.Name = "URLLabel";
            this.URLLabel.Size = new System.Drawing.Size(42, 21);
            this.URLLabel.TabIndex = 0;
            this.URLLabel.Text = "URL:";
            // 
            // URLTextBox
            // 
            this.URLTextBox.Location = new System.Drawing.Point(309, 57);
            this.URLTextBox.Name = "URLTextBox";
            this.URLTextBox.Size = new System.Drawing.Size(267, 29);
            this.URLTextBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addButton.IconColor = System.Drawing.Color.Green;
            this.addButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addButton.IconSize = 28;
            this.addButton.Location = new System.Drawing.Point(582, 57);
            this.addButton.Name = "addButton";
            this.addButton.Padding = new System.Windows.Forms.Padding(1, 7, 0, 0);
            this.addButton.Size = new System.Drawing.Size(42, 29);
            this.addButton.TabIndex = 4;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // abasListBox
            // 
            this.abasListBox.FormattingEnabled = true;
            this.abasListBox.ItemHeight = 21;
            this.abasListBox.Location = new System.Drawing.Point(16, 92);
            this.abasListBox.Name = "abasListBox";
            this.abasListBox.Size = new System.Drawing.Size(560, 151);
            this.abasListBox.TabIndex = 5;
            this.abasListBox.SelectedIndexChanged += new System.EventHandler(this.abasListBox_SelectedIndexChanged);
            // 
            // cancelarButton
            // 
            this.cancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarButton.Location = new System.Drawing.Point(546, 285);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(78, 29);
            this.cancelarButton.TabIndex = 11;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // salvarButton
            // 
            this.salvarButton.Location = new System.Drawing.Point(462, 285);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(78, 29);
            this.salvarButton.TabIndex = 12;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // configTextBox
            // 
            this.configTextBox.Enabled = false;
            this.configTextBox.Location = new System.Drawing.Point(16, 249);
            this.configTextBox.Name = "configTextBox";
            this.configTextBox.Size = new System.Drawing.Size(428, 29);
            this.configTextBox.TabIndex = 0;
            this.configTextBox.TabStop = false;
            // 
            // carregarConfigButton
            // 
            this.carregarConfigButton.Location = new System.Drawing.Point(450, 249);
            this.carregarConfigButton.Name = "carregarConfigButton";
            this.carregarConfigButton.Size = new System.Drawing.Size(174, 29);
            this.carregarConfigButton.TabIndex = 10;
            this.carregarConfigButton.Text = "Carregar configuração";
            this.carregarConfigButton.UseVisualStyleBackColor = true;
            this.carregarConfigButton.Click += new System.EventHandler(this.carregarConfigButton_Click);
            // 
            // editButton
            // 
            this.editButton.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.editButton.IconColor = System.Drawing.Color.Goldenrod;
            this.editButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editButton.IconSize = 28;
            this.editButton.Location = new System.Drawing.Point(582, 92);
            this.editButton.Name = "editButton";
            this.editButton.Padding = new System.Windows.Forms.Padding(1, 7, 0, 0);
            this.editButton.Size = new System.Drawing.Size(42, 29);
            this.editButton.TabIndex = 6;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.deleteButton.IconColor = System.Drawing.Color.DarkRed;
            this.deleteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteButton.IconSize = 25;
            this.deleteButton.Location = new System.Drawing.Point(582, 127);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Padding = new System.Windows.Forms.Padding(1, 5, 0, 0);
            this.deleteButton.Size = new System.Drawing.Size(42, 29);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // arrowUpButton
            // 
            this.arrowUpButton.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            this.arrowUpButton.IconColor = System.Drawing.Color.Black;
            this.arrowUpButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.arrowUpButton.IconSize = 25;
            this.arrowUpButton.Location = new System.Drawing.Point(582, 179);
            this.arrowUpButton.Name = "arrowUpButton";
            this.arrowUpButton.Padding = new System.Windows.Forms.Padding(1, 5, 0, 0);
            this.arrowUpButton.Size = new System.Drawing.Size(42, 29);
            this.arrowUpButton.TabIndex = 8;
            this.arrowUpButton.UseVisualStyleBackColor = true;
            this.arrowUpButton.Click += new System.EventHandler(this.arrowUpButton_Click);
            // 
            // arrowDownButton
            // 
            this.arrowDownButton.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.arrowDownButton.IconColor = System.Drawing.Color.Black;
            this.arrowDownButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.arrowDownButton.IconSize = 25;
            this.arrowDownButton.Location = new System.Drawing.Point(582, 214);
            this.arrowDownButton.Name = "arrowDownButton";
            this.arrowDownButton.Padding = new System.Windows.Forms.Padding(1, 5, 0, 0);
            this.arrowDownButton.Size = new System.Drawing.Size(42, 29);
            this.arrowDownButton.TabIndex = 9;
            this.arrowDownButton.UseVisualStyleBackColor = true;
            this.arrowDownButton.Click += new System.EventHandler(this.arrowDownButton_Click);
            // 
            // ConfiguracoesForm
            // 
            this.AcceptButton = this.salvarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelarButton;
            this.ClientSize = new System.Drawing.Size(636, 326);
            this.Controls.Add(this.arrowDownButton);
            this.Controls.Add(this.arrowUpButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.carregarConfigButton);
            this.Controls.Add(this.configTextBox);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.abasListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.URLTextBox);
            this.Controls.Add(this.URLLabel);
            this.Controls.Add(this.tituloAbaLabel);
            this.Controls.Add(this.tituloAbaTextBox);
            this.Controls.Add(this.tituloProgramaLabel);
            this.Controls.Add(this.tituloProgramaTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(652, 365);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(652, 365);
            this.Name = "ConfiguracoesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfiguracoesForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tituloProgramaTextBox;
        private System.Windows.Forms.Label tituloProgramaLabel;
        private System.Windows.Forms.TextBox tituloAbaTextBox;
        private System.Windows.Forms.Label tituloAbaLabel;
        private System.Windows.Forms.Label URLLabel;
        private System.Windows.Forms.TextBox URLTextBox;
        private FontAwesome.Sharp.IconButton addButton;
        private System.Windows.Forms.ListBox abasListBox;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.TextBox configTextBox;
        private System.Windows.Forms.Button carregarConfigButton;
        private FontAwesome.Sharp.IconButton editButton;
        private FontAwesome.Sharp.IconButton deleteButton;
        private FontAwesome.Sharp.IconButton arrowUpButton;
        private FontAwesome.Sharp.IconButton arrowDownButton;
    }
}