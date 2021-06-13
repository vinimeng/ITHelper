using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ITHelper
{
    public partial class ConfiguracoesForm : Form
    {
        private readonly MainWindow mf;
        private string tituloOriginal;
        private bool hasBeenEdited;
        public ConfiguracoesForm(MainWindow mainForm)
        {
            InitializeComponent();
            hasBeenEdited = false;
            tituloOriginal = "ITHelper";
            mf = mainForm;
            if(mf.AbasArray != null)
            {
                foreach (Aba aba in mf.AbasArray)
                {
                    if (aba.tipo == TipoAba.PRINCIPAL)
                    {
                        tituloProgramaTextBox.Text = aba.titulo;
                        tituloOriginal = aba.titulo;
                    }
                    else
                    {
                        abasListBox.Items.Add(aba);
                    }
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (tituloAbaTextBox.Text != "" && URLTextBox.Text != "")
            {
                if (Uri.IsWellFormedUriString(URLTextBox.Text, UriKind.Absolute))
                {
                    Aba a;
                    a.titulo = tituloAbaTextBox.Text;
                    a.URL = URLTextBox.Text;
                    a.tipo = TipoAba.WEB;
                    abasListBox.Items.Add(a);
                    hasBeenEdited = true;
                }
                else
                {
                    MessageBox.Show("URL informada não é válida.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (tituloAbaTextBox.Text == "" && URLTextBox.Text == "")
                {
                    MessageBox.Show("Título da aba e URL devem estar preenchidos para uma aba ser inserida.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (tituloAbaTextBox.Text == "")
                    {
                        MessageBox.Show("Título da aba deve estar preenchida para uma aba ser inserida.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("URL deve estar preenchida para uma aba ser inserida.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if(abasListBox.SelectedItem != null)
            {
                Aba a = (Aba)abasListBox.SelectedItem;
                a.titulo = tituloAbaTextBox.Text;
                a.URL = URLTextBox.Text;
                abasListBox.Items[abasListBox.SelectedIndex] = a;
                hasBeenEdited = true;
            }
            else
            {
                MessageBox.Show("Selecione alguma aba para editar.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (abasListBox.SelectedItem != null)
            {
                DialogResult dr = MessageBox.Show("Tem certeza que desejar remover essa aba?", "Remover aba", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    abasListBox.Items.RemoveAt(abasListBox.SelectedIndex);
                    hasBeenEdited = true;
                }
            }
            else
            {
                MessageBox.Show("Selecione alguma aba para remover.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            if (this.closingCheck())
            {
                Dispose();
            }
        }

        private void ConfiguracoesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.closingCheck())
            {
                Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private bool closingCheck()
        {
            if (hasBeenEdited || tituloOriginal != tituloProgramaTextBox.Text)
            {
                DialogResult dr = MessageBox.Show("Tem certeza que desejar cancelar? Existem edições que não foram salvas.", "Cancelar edição das configurações", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return dr == DialogResult.Yes;
            }
            else
            {
                return true;
            }
        }

        private void arrowUpButton_Click(object sender, EventArgs e)
        {
            if (abasListBox.SelectedItem != null)
            {
                Aba selected = (Aba)abasListBox.SelectedItem;

                for (int i = 0; i < abasListBox.Items.Count; i++)
                {
                    Aba g = (Aba)abasListBox.Items[i];
                    if (g.titulo == selected.titulo)
                    {
                        if (i == 0)
                        {
                            MessageBox.Show("Aba já é a primeira da lista.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Aba anterior = (Aba)abasListBox.Items[i - 1];
                            abasListBox.Items[i - 1] = abasListBox.Items[i];
                            abasListBox.Items[i] = anterior;
                            abasListBox.SelectedIndex -= 1;
                            hasBeenEdited = true;
                        }
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione alguma aba para editar sua ordem.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void arrowDownButton_Click(object sender, EventArgs e)
        {
            if (abasListBox.SelectedItem != null)
            {
                Aba selected = (Aba)abasListBox.SelectedItem;

                for (int i = 0; i < abasListBox.Items.Count; i++)
                {
                    Aba g = (Aba)abasListBox.Items[i];
                    if (g.titulo == selected.titulo)
                    {
                        if (i == (abasListBox.Items.Count - 1))
                        {
                            MessageBox.Show("Aba já é a última da lista.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Aba proximo = (Aba)abasListBox.Items[i + 1];
                            abasListBox.Items[i + 1] = abasListBox.Items[i];
                            abasListBox.Items[i] = proximo;
                            abasListBox.SelectedIndex += 1;
                            hasBeenEdited = true;
                        }
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione alguma aba para editar sua ordem.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            if (hasBeenEdited || tituloOriginal != tituloProgramaTextBox.Text)
            {
                DialogResult dr = MessageBox.Show("Deseja salvar as edições feitas?", "Salvar alterações", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    List<Aba> data = new List<Aba>();

                    if (tituloProgramaTextBox.Text != "")
                    {
                        Aba titulo;
                        titulo.titulo = tituloProgramaTextBox.Text;
                        titulo.URL = "";
                        titulo.tipo = TipoAba.PRINCIPAL;

                        data.Add(titulo);
                    }

                    foreach (Aba p in abasListBox.Items)
                        data.Add(p);

                    string path = System.Reflection.Assembly.GetEntryAssembly().Location;
                    path = Path.GetDirectoryName(path) + "\\config.ithelper";

                    using (var file = File.OpenWrite(path))
                    {
                        var writer = new BinaryFormatter();
                        writer.Serialize(file, data);
                    }

                    mf.reconfigure(data);
                    Dispose();
                }
            } 
            else
            {
                Dispose();
            }
        }

        private void carregarConfigButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog procuraConfigFileDialog = new OpenFileDialog();
            procuraConfigFileDialog.Title = "Carregar configuração";
            procuraConfigFileDialog.Filter = "ITHelper|*.ithelper";
            procuraConfigFileDialog.DefaultExt = ".ithelper";
            if (procuraConfigFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream openFile;
                    if ((openFile = procuraConfigFileDialog.OpenFile()) != null)
                    {
                        configTextBox.Text = procuraConfigFileDialog.FileName;
                        List<Aba> abaList = new List<Aba>();
                        using (openFile)
                        {
                            var reader = new BinaryFormatter();
                            abaList = (List<Aba>)reader.Deserialize(openFile);
                        }

                        if (abaList != null)
                        {
                            abasListBox.Items.Clear();
                            foreach (Aba aba in abaList)
                            {
                                if (aba.tipo == TipoAba.PRINCIPAL)
                                {
                                    tituloProgramaTextBox.Text = aba.titulo;
                                }
                                else
                                {
                                    abasListBox.Items.Add(aba);
                                }
                            }
                            hasBeenEdited = true;
                        }
                        else
                        {
                            MessageBox.Show("Arquivo de configuração selecionado estava vazio.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro ao tentar carregar configuração. Erro original:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void abasListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (abasListBox.SelectedItem != null)
            {
                Aba a = (Aba)abasListBox.SelectedItem;
                tituloAbaTextBox.Text = a.titulo;
                URLTextBox.Text = a.URL;
            }
        }
    }
}
