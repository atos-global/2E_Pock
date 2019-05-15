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

namespace EnviarPLI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                bw.ReportProgress(5);

                using (var service = PhantomJSDriverService.CreateDefaultService())
                {
                    service.AddArgument("test-type");
                    service.AddArgument("no-sandbox");
                    service.HideCommandPromptWindow = true;

                    using (var _driver = new PhantomJSDriver(service))
                    {
                        _driver.Navigate().GoToUrl(@"https://portal1.suframa.gov.br/pmerecebimento/rotinas.do");

                        OpenQA.Selenium.IWebElement element = _driver.FindElementById("login");

                        txtLogin.Invoke((MethodInvoker)delegate ()
                        {
                            element.SendKeys(txtLogin.Text);
                        });
                        
                        
                        element = _driver.FindElementByName("field(-senha)");
                        
                        txtSenha.Invoke((MethodInvoker)delegate ()
                        {
                            element.SendKeys(txtSenha.Text);
                        });

                        element = _driver.FindElementByName("btLogar");
                        element.Click();
                        
                        // etapa 2
                        element = _driver.FindElementByPartialLinkText("Enviar PLI");
                        element.Click();
                        
                        // etapa 3
                        element = _driver.FindElementByName("field(-manter-arquivo)");
                        element.SendKeys(ObterArquivoTemporario());
                        element = _driver.FindElementById("btnEnviarpli");
                        element.Click();
                        // etapa 4
                        element = _driver.FindElementById("ERROR");
                        
                        e.Result = element.Text;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar executar o processo, verifique e tente novamente.\n" + ex.Message);
            }
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                progressBar1.Style = ProgressBarStyle.Blocks;
                MessageBox.Show(e.Result.ToString());
                btnEnviarPLI.Enabled = true;
                txtLogin.Enabled = true;
                txtSenha.Enabled = true;
            }
            catch (Exception ex)
            {
                progressBar1.Style = ProgressBarStyle.Blocks;
                MessageBox.Show(ex.Message);
                btnEnviarPLI.Enabled = true;
                txtLogin.Enabled = true;
                txtSenha.Enabled = true;
            }
        }

        private void btnEnviarPLI_Click(object sender, EventArgs e)
        {
            btnEnviarPLI.Enabled = false;
            txtLogin.Enabled = false;
            txtSenha.Enabled = false;
            progressBar1.Style = ProgressBarStyle.Marquee;
            bw.RunWorkerAsync();
        }

        private string ObterArquivoTemporario()
        {
            string temp = Path.GetTempPath() + "\\temp.txt";

            if (!File.Exists(temp))
            {
                StreamWriter writer = new StreamWriter(temp);
                writer.WriteLine("Teste Envio PLI." + DateTime.Now.ToString());
                writer.Close();
            }

            return temp;
        }
    }
}
