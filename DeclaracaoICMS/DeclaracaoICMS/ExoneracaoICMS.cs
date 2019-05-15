using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;
using Selenium.Utils.Html;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeclaracaoICMS
{
    public partial class ExoneracaoICMS : Form
    {
        private string uUrlInicio = @"https://www1c.siscomex.receita.fazenda.gov.br/siscomexImpweb-7/inicio.html";
        public string uUrlbASE = @"https://www1c.siscomex.receita.fazenda.gov.br/";
        public string urlInicioPrivado = @"https://www1c.siscomex.receita.fazenda.gov.br/siscomexImpweb-7/private_siscomeximpweb_inicio.do";
        public string urlDeclararICMS = @"https://www1c.siscomex.receita.fazenda.gov.br/importacaoweb-7/DeclararICMSMenu.do?i=0";

        public ExoneracaoICMS()
        {
            InitializeComponent();
        }

        private void btnTomarCiencia_Click(object sender, EventArgs e)
        {
            txtDI.Enabled = false;
            txtUF.Enabled = false;
            btnTomarCiencia.Enabled = false;

            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                progressBar1.Invoke((MethodInvoker)delegate ()
                {
                    progressBar1.Style = ProgressBarStyle.Marquee;
                });
                
                using (var service = PhantomJSDriverService.CreateDefaultService())
                {
                    service.IgnoreSslErrors = true;
                    string cert = $"--ssl-client-certificate-file={Directory.GetCurrentDirectory()}\\Certificado\\client-certificate.crt";
                    service.AddArgument(cert);
                    service.AddArgument($"--ssl-client-key-file={Directory.GetCurrentDirectory()}\\Certificado\\client-certificate.key");
                    service.AddArgument($"--ssl-client-key-passphrase=2e123456$");

                    service.AddArgument("test-type");
                    service.AddArgument("no-sandbox");
                    service.HideCommandPromptWindow = true;

                    var options = new PhantomJSOptions();
                    options.AddAdditionalCapability("handlesAlerts", true);

                    using (var _driver = new PhantomJSDriver(service, options))
                    {
                        _driver.Navigate().GoToUrl(urlInicioPrivado);

                        _driver.Navigate().GoToUrl(urlDeclararICMS);

                        Select selectObject = new Select(_driver, By.Id("tp"));

                        selectObject.SelectByText("Exoneração do ICMS");

                        IWebElement element = _driver.FindElement(By.Id("numDI"));

                        txtDI.Invoke((MethodInvoker)delegate ()
                        {
                            element.SendKeys(txtDI.Text);
                        });
                        

                        Select selectObject2 = new Select(_driver, By.Id("uf"));

                        txtUF.Invoke((MethodInvoker)delegate ()
                        {
                            selectObject2.SelectByText(txtUF.Text);
                        });
                        

                        element = _driver.FindElement(By.Id("registrar"));


                        element.Click();

                        string txtInicioBlocoErro = "<!-- MENSAGENS DE ERRO =================================================================================================================================== -->";

                        int posicaoInicioErro = _driver.PageSource.ToString().IndexOf(txtInicioBlocoErro);

                        if (posicaoInicioErro > 0 && _driver.PageSource.Contains("alert"))
                        {
                            posicaoInicioErro = posicaoInicioErro + txtInicioBlocoErro.Length;

                            var posicaoFimErro = _driver.PageSource.ToString().LastIndexOf(");");

                            string textoAreaErro = _driver.PageSource.Substring(posicaoInicioErro, posicaoFimErro - posicaoInicioErro);
                            textoAreaErro = textoAreaErro.Replace("\"", "'");
                            textoAreaErro = textoAreaErro.Replace("<script charset='utf-8' type='text/javascript'>alert('", "");
                            textoAreaErro = textoAreaErro.Replace("'+ '\\n' +''", "");
                            textoAreaErro = Regex.Replace(textoAreaErro, @"[^ 0-9a-zA-Z]+", "");
                            textoAreaErro = Regex.Replace(textoAreaErro, "(\r\n|\r|\n|\t|\r\n\t)", "");

                            e.Result = textoAreaErro;
                        }
                        else
                        {
                            e.Result = "Operação finalizada sem erros.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Blocks;
            txtDI.Enabled = true;
            txtUF.Enabled = true;
            btnTomarCiencia.Enabled = true;
            MessageBox.Show(e.Result.ToString());
        }
    }
}
