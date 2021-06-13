using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITHelper
{
    public enum TipoAba
    {
        PRINCIPAL,
        WEB,
        OUTRO
    }

    [Serializable]
    public struct Aba
    {
        public string titulo;
        public string URL;
        public TipoAba tipo;
        public override string ToString()
        {
            return titulo;
        }
    }
    public partial class MainWindow : Form
    {
        private readonly SystemMenu systemMenu;
        private ConfiguracoesForm configuracoesForm;
        public List<Aba> AbasArray { get; }
        public MainWindow()
        {
            InitializeComponent();
            systemMenu = new SystemMenu(this);
            systemMenu.AddCommand("Configurações", OnSystemMenuConfiguracoes, true);
        }

        private void loadConfigForm()
        {
            configuracoesForm = new ConfiguracoesForm(this);
            configuracoesForm.Show();
        }

        private void OnSystemMenuConfiguracoes()
        {
            this.loadConfigForm();
        }

        protected override void WndProc(ref Message msg)
        {
            base.WndProc(ref msg);
            systemMenu.HandleMessage(ref msg);
        }

        private void configuracoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.loadConfigForm();
        }
    }
}
