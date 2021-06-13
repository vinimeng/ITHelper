using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
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
        public List<Aba> AbasArray { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            systemMenu = new SystemMenu(this);
            systemMenu.AddCommand("Configurações", OnSystemMenuConfiguracoes, true);
            List<Aba> data = new List<Aba>();
            try
            {
                string path = System.Reflection.Assembly.GetEntryAssembly().Location;
                path = System.IO.Path.GetDirectoryName(path) + "\\config.ithelper";

                using (var file = File.OpenRead(path))
                {
                    var reader = new BinaryFormatter();
                    data = (List<Aba>)reader.Deserialize(file);
                }

                if(data != null)
                {
                    AbasArray = new List<Aba>();
                    foreach (Aba a in data)
                    {
                        AbasArray.Add(a);
                    }
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                // do nothing
            }

            if (AbasArray != null)
            {
                foreach (Aba a in AbasArray)
                {
                    if (a.tipo == TipoAba.PRINCIPAL)
                    {
                        this.Text = a.titulo;
                    }
                    else if (a.tipo == TipoAba.WEB)
                    {
                        abas.TabPages.Add(a.titulo);
                        TabPage tp = abas.TabPages[abas.TabPages.Count - 1];
                        WebView2 webView = new WebView2();
                        ((System.ComponentModel.ISupportInitialize)(webView)).BeginInit();
                        tp.SuspendLayout();
                        tp.Controls.Add(webView);
                        tp.Location = new System.Drawing.Point(4, 30);
                        tp.Padding = new System.Windows.Forms.Padding(3);
                        tp.Size = new System.Drawing.Size(1196, 587);
                        tp.UseVisualStyleBackColor = true;
                        webView.Anchor = ((System.Windows.Forms.AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
                        webView.CreationProperties = null;
                        webView.DefaultBackgroundColor = System.Drawing.Color.White;
                        webView.Location = new System.Drawing.Point(6, 6);
                        webView.Size = new System.Drawing.Size(1184, 575);
                        webView.Name = a.titulo;
                        webView.Source = new Uri(a.URL, System.UriKind.Absolute);
                        webView.ZoomFactor = 1D;
                        ((System.ComponentModel.ISupportInitialize)(webView)).EndInit();
                        tp.ResumeLayout();
                    }
                }
            }
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

        public void reconfigure(List<Aba> abasReconfig)
        {
            if (abasReconfig != null)
            {
                AbasArray = abasReconfig;
                foreach(TabPage tabP in abas.TabPages)
                {
                    foreach (Control c in tabP.Controls)
                    {
                        if (c.GetType() == typeof(WebView2)) 
                        {
                            WebView2 wb2 = (WebView2)c;
                            wb2.Dispose();
                        }
                    }
                }
                abas.TabPages.Clear();
                foreach (Aba a in AbasArray)
                {
                    Console.WriteLine(a);
                    if (a.tipo == TipoAba.PRINCIPAL)
                    {
                        this.Text = a.titulo;
                    }
                    else if (a.tipo == TipoAba.WEB)
                    {
                        abas.TabPages.Add(a.titulo);
                        TabPage tp = abas.TabPages[abas.TabPages.Count - 1];
                        WebView2 webView = new WebView2();
                        ((System.ComponentModel.ISupportInitialize)(webView)).BeginInit();
                        tp.SuspendLayout();
                        tp.Controls.Add(webView);
                        tp.Location = new System.Drawing.Point(4, 30);
                        tp.Padding = new System.Windows.Forms.Padding(3);
                        tp.Size = new System.Drawing.Size(1196, 587);
                        tp.UseVisualStyleBackColor = true;
                        webView.Anchor = ((System.Windows.Forms.AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
                        webView.CreationProperties = null;
                        webView.DefaultBackgroundColor = System.Drawing.Color.White;
                        webView.Location = new System.Drawing.Point(6, 6);
                        webView.Size = new System.Drawing.Size(1184, 575);
                        webView.Name = a.titulo;
                        webView.Source = new Uri(a.URL, System.UriKind.Absolute);
                        webView.ZoomFactor = 1D;
                        ((System.ComponentModel.ISupportInitialize)(webView)).EndInit();
                        tp.ResumeLayout();
                    }
                }
            }
        }
    }
}
