using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
//Selenium:
using OpenQA.Selenium;
//Google Chrome:
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Keys = OpenQA.Selenium.Keys;
//Microsoft Edge:
using OpenQA.Selenium.Edge;
//Html Agility Pack:
using HtmlAgilityPack;
using static System.Net.Mime.MediaTypeNames;


namespace Stolen_Content
{
    //private static int minhaVariavel = 0;
    //private static readonly object locker = new object();

    public partial class formPrincipal : Form
    {
        // Variável booleana que define o loop do bot
        bool executarBot = false;
        // Variável para armazenar a instância do driver
        private IWebDriver driver = null;
        // Váriavel que armazena texto e numeros de linha da txtBox2 e cbLinhas
        private string textoOriginal;
        private int numLinhasAnterior;
        public formPrincipal()
        {
            InitializeComponent();
            
            //Inicia o WebDriver do Selenium
            //InitializeWebDriver();
        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {
            /*Properties.Settings.Default.NomeDoTextBox = nomeDoTextBox.Text;
            Properties.Settings.Default.Save();*/
        }

        // Configura o WebDriver do Selenium
        private void InitializeWebDriver()
        {
            //Google Chrome:
            // Obtém o objeto de identidade do Windows
            WindowsIdentity identity = WindowsIdentity.GetCurrent();

            // Obtém o nome do usuário logado sem o domínio
            string userName = identity.Name.Split('\\')[1];

            // Caminho para o diretório onde estão os perfis
            string profileDir = $"C:\\Users\\{userName}\\AppData\\Local\\Google\\Chrome\\User Data\\Profile 1";

            // Criar uma instância de ChromeOptions
            ChromeOptions options = new ChromeOptions();

            // Configurar as opções do navegador para utilizar o perfil desejado e salvar os dados e cookies
            options.AddArgument($"--user-data-dir={profileDir}");
            options.AddArgument("--disable-blink-features=AutomationControlled");
            options.AddArgument("--user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.150 Safari/537.36");
            options.AddArgument("--excludeSwitches");
            options.AddArgument("--profile-directory=Pessoa 1");
            options.AddArgument("--disable-popup-blocking");
            options.AddArgument("--disable-notifications");
            options.AddArgument("--disable-infobars");
            //options.AddArgument("--start-maximized");
            //options.AddArgument("--headless"); //Desativa a interface gráfica do Google Chrome
            //options.AddArgument("--kiosk"); // Não funciona
            options.AddArgument("--start-minimized");
            options.AddArgument("--disable-extensions");
            options.AddArgument("--disable-web-security");
            options.AddArgument("--allow-running-insecure-content");
            options.AddArgument("--allow-insecure-localhost");
            options.AddArgument("--disable-save-password-bubble");
            options.AddArgument("--disable-translate");
            options.AddArgument("--disable-logging");
            options.AddArgument("--disable-dev-shm-usage");
            options.AddArgument("--disable-browser-side-navigation");
            options.AddArgument("--disable-gpu");
            options.AddArgument("--enable-automation");
            options.AddArgument("--no-sandbox");
            options.AddArgument("--test-type");
            options.AddArgument("--ignore-certificate-errors");
            options.AddArgument("--ignore-ssl-errors");
            options.AddArgument("--disable-blink-features=AutomationControlled");
            options.AddUserProfilePreference("profile.default_content_settings.cookies", 2);
            options.AddUserProfilePreference("profile.content_settings.cookies", 2);
            options.AddUserProfilePreference("profile.default_content_setting_values.notifications", 2);
            options.AddUserProfilePreference("credentials_enable_service", false);
            options.AddUserProfilePreference("profile.password_manager_enabled", false);            
            // Definir as preferências do perfil do navegador
            options.AddUserProfilePreference("profile.default_content_settings.popups", 0);
            options.AddUserProfilePreference("download.prompt_for_download", false);
            options.AddUserProfilePreference("download.default_directory", @"C:\Downloads");
            // Configurar o perfil do navegador para iniciar com as opções e preferências definidas
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            service.SuppressInitialDiagnosticInformation = true;
            service.Start();

            try 
            {
                // Criar uma instância do navegador Chrome usando as opções configuradas
                driver = new ChromeDriver(service, options);                                

                // Maximizar a janela do navegador para que fique minimizado
                driver.Manage().Window.Maximize();
            }
            catch
            {
                //driver.Quit();
                //MessageBox.Show("Parece que já existe uma instância do Google Chrome em execução. Por favor, feche-a e reinicie o programa.");                
            }
        }

        void AtualizarConsole(string mensagem)
        {
            txtConsole.Invoke(new Action(() =>
            {
                txtConsole.AppendText(mensagem);
                txtConsole.AppendText("\r\n\r\n");
            }));
        }

        void PesquisarGrupo(string nomeGrupo, WebDriverWait wait)
        {
            IWebElement searchBox = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//body/div[@id='app']/div[1]/div[1]/div[4]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/p[1]")));
            searchBox.Click();
            searchBox.SendKeys(nomeGrupo);
            searchBox.SendKeys(Keys.Enter);
        }

        void EntrarNoGrupo(string nomeGrupo, IWebDriver driver, WebDriverWait wait)
        {
            IWebElement grupo = driver.FindElement(By.XPath($"//span[@title='{nomeGrupo}']"));
            wait.Until(ExpectedConditions.ElementToBeClickable(grupo));
            grupo.Click();
        }

        void CancelarPesquisa(WebDriverWait wait)
        {
            IWebElement cancelarPesquisa = wait.Until(ExpectedConditions.ElementExists(By.ClassName("-Jnba")));
            cancelarPesquisa.Click();
        }

        IWebElement EncontrarUltimaMensagem(IWebDriver driver)
        {
            return driver.FindElements(By.ClassName("_21Ahp")).Last();
        }

        string ObterConteudoMensagem(IWebElement ultimaMensagem)
        {
            string html = ultimaMensagem.GetAttribute("innerHTML");
            var documentoHtml = new HtmlAgilityPack.HtmlDocument();
            documentoHtml.LoadHtml(html);

            return string.Join("", documentoHtml.DocumentNode.Descendants()
                .Where(n => n.NodeType == HtmlNodeType.Text ||
                            (n.NodeType == HtmlNodeType.Element && n.Name == "img" && n.Attributes["alt"] != null))
                .Select(n => n.NodeType == HtmlNodeType.Text ? n.InnerHtml : n.Attributes["alt"].Value));
        }

        string ProcessarTexto(string conteudoMensagem)
        {
            var textoConcatenado = new StringBuilder(conteudoMensagem);
            return textoConcatenado.ToString().Substring(0, textoConcatenado.Length - 5).Trim();
        }

        string EncontrarLinkAliExpress(string texto, string regexPattern)
        {
            Regex regex = new Regex(regexPattern);
            Match match = regex.Match(texto);

            if (match.Success)
            {
                return match.Value;
            }
            else
            {
                AtualizarConsole("# Stolen Content Bot -> O link não foi encontrado.");
                //MessageBox.Show("O link não foi encontrado.");
                return string.Empty;
            }
        }

        void AbrirNovaGuia(IWebDriver driver)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }

        string GerarLinkAffiliate(IWebDriver driver, string regexPattern, string linkCopiado, TextBox txtConsole, TextBox txtBox, TextBox txtBox2)
        {
            driver.Navigate().GoToUrl(linkCopiado);
            AtualizarConsole("# Stolen Content Bot -> Abrindo a página do link e convertendo usando a ToolStrip do Aliexpress");

            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            try
            {
                IWebElement geradorDeLink = wait2.Until(ExpectedConditions.ElementExists(By.ClassName("share_button")));
                geradorDeLink.Click();

                IWebElement link = wait2.Until(ExpectedConditions.ElementExists(By.XPath("//textarea[contains(text(),'<a href=\"https://s.click.aliexpress.com/e/')]")));
                Regex regex = new Regex(regexPattern);
                Match match2 = regex.Match(link.Text);
                //AtualizarConsole($"# Stolen Content Bot -> Conteúdo do link_img_share: {link.Text}");

                string LinkGerado;

                if (match2.Success)
                {
                    LinkGerado = match2.Value.Substring(0, match2.Value.Length - 1).Trim();
                    AtualizarConsole($"# Stolen Content Bot -> O seguinte link foi gerado: {LinkGerado}");

                    txtBox2.Invoke(new Action(() =>
                    {
                        txtBox2.Text = txtBox.Text.Replace(linkCopiado, LinkGerado);
                    }));

                    VoltarGuiaWhatsApp(driver);
                    return LinkGerado;
                }
                else
                {
                    AtualizarConsole("# Stolen Content Bot -> A expressão regular não encontrou um link no botão da ToolStrip.");
                }
            }
            catch
            {
                AtualizarConsole("# Stolen Content Bot -> Infelizmente não consegui localizar a ToolStrip do Aliexpress");
            }

            VoltarGuiaWhatsApp(driver);
            return null;
        }

        void VoltarGuiaWhatsApp(IWebDriver driver)
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
        }

        void EnviarMensagemWhatsApp(IWebDriver driver, WebDriverWait wait, TextBox txtBox, TextBox txtBox2, string linkGerado, string linkCopiado)
        {
            // Espera até a barra de mensagem existir no frame
            IWebElement barraDeMensagem = wait.Until(ExpectedConditions.ElementExists(By.XPath("//body/div[@id='app']/div[1]/div[1]/div[5]/div[1]/footer[1]/div[1]/div[1]/span[2]/div[1]/div[2]/div[1]/div[1]/div[1]/p[1]")));

            // Clica na barra de mensagem
            barraDeMensagem.Click();

            string conteudoRoubado = "";
            txtBox2.Invoke(new Action(() =>
            {
                SubstituirLinks();
                SubstituirEmotes();
                conteudoRoubado = txtBox2.Text;
            }));

            // Executar o script JavaScript para enviar o texto e pressionar Enter
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].value += arguments[1]; arguments[0].dispatchEvent(new InputEvent('input', { bubbles: true, cancelable: true, data: arguments[1] })); arguments[0].dispatchEvent(new KeyboardEvent('keydown', { keyCode: 13, bubles: true, cancelable: true }));", barraDeMensagem, conteudoRoubado);

            // Envia a tecla enter para a barra de mensagem do WhatsappWeb
            barraDeMensagem.SendKeys(Keys.Enter);
        }

        // Método para aguardar a chegada de uma nova mensagem
        void AguardarNovaMensagem(IWebDriver driver, IWebElement ultimaMensagem, string mensagemAnterior)
        {
            // Obter o conteúdo da mensagem mais recente
            string conteudoMensagem = ObterConteudoMensagem(ultimaMensagem);

            // Continuar procurando enquanto a mensagem for a mesma que a mensagem anterior
            while (conteudoMensagem == mensagemAnterior)
            {
                // Aguardar um curto período de tempo antes de verificar novamente
                Thread.Sleep(1000);

                // Encontrar a mensagem mais recente
                ultimaMensagem = EncontrarUltimaMensagem(driver);

                // Obter o conteúdo da nova mensagem
                conteudoMensagem = ObterConteudoMensagem(ultimaMensagem);
                AtualizarConsole("# Stolen Content Bot > Parece que já encontrei essa mensagem, vamos tentar de novo!");
            }
        }

        private void ContarLinhas()
        {
            txtBox2.Invoke(new Action(() =>
            {
                int totalLinhas = txtBox2.GetLineFromCharIndex(txtBox2.TextLength) + 1;
                cbLinhas.Items.Clear();

                for (int i = 1; i <= totalLinhas; i++)
                {
                    cbLinhas.Items.Add(i.ToString());
                }

                textoOriginal = txtBox2.Text;
                numLinhasAnterior = totalLinhas;
            }));
        }

        private void AtualizarLinhas()
        {
            txtBox2.Invoke(new Action(() =>
            {
                int numLinhas = cbLinhas.SelectedIndex + 1;
                int totalLinhas = txtBox2.GetLineFromCharIndex(txtBox2.TextLength) + 1;

                if (numLinhas == totalLinhas || numLinhas == numLinhasAnterior)
                {
                    return;
                }

                if (numLinhas > totalLinhas)
                {
                    int numLinhasAdicionais = numLinhas - totalLinhas;

                    for (int i = 0; i < numLinhasAdicionais; i++)
                    {
                        txtBox2.AppendText(Environment.NewLine);
                    }
                }
                else
                {
                    int numLinhasRemovidas = totalLinhas - numLinhas;
                    int indexRemover = txtBox2.GetFirstCharIndexFromLine(numLinhas);

                    if (indexRemover < 0)
                    {
                        indexRemover = txtBox2.TextLength;
                    }

                    txtBox2.Select(indexRemover, txtBox2.TextLength - indexRemover);
                    txtBox2.SelectedText = "";
                }

                numLinhasAnterior = numLinhas;
            }));
        }

        private void SubstituirEmotes()
        {
            string textoOriginal = txtBox2.Text;
            foreach (DataGridViewRow row in dgEmote.Rows)
            {
                if (!row.IsNewRow)
                {
                    textoOriginal = textoOriginal.Replace(row.Cells[1].Value.ToString(), row.Cells[0].Value.ToString());
                }
            }
            txtBox2.Text = textoOriginal;
        }

        private void ApagarLinhaSelecionada()
        {
            if (dgEmote.SelectedRows.Count > 0)
            {
                dgEmote.Rows.RemoveAt(dgEmote.SelectedRows[0].Index);
            }
            else if (dgEmote.SelectedCells.Count > 0)
            {
                int rowIndex = dgEmote.SelectedCells[0].RowIndex;
                dgEmote.Rows.RemoveAt(rowIndex);
            }
        }

        private void SubstituirLinks()
        {
            // Expressão regular para encontrar o link do WhatsApp
            Regex whatsappRegex = new Regex(@"(?<=WhatsApp:).*?(?=\r?\n|$)");

            txtBox2.Invoke(new Action(() =>
            {
                // Substitui a URL do WhatsApp em txtBox2.Text
                txtBox2.Text = whatsappRegex.Replace(txtBox2.Text, match =>
                {
                    return txtBoxWhatsapp.Text;
                });

                // Verifica a URL do Telegram em txtBox2.Text
                Regex regexTelegram = new Regex(@"^https?:\/\/t\.me\/[A-Za-z0-9_]+");
                Match matchTelegram = regexTelegram.Match(txtBox2.Text);

                if (matchTelegram.Success)
                {
                    // Substitui a URL do Telegram pelo texto em txtBoxTelegram
                    txtBox2.Text = txtBox2.Text.Replace(matchTelegram.Value, txtBoxTelegram.Text);
                }
            }));
        }

        private async void bntStolen_Click(object sender, EventArgs e)
        {
            // Inicia o bot
            executarBot = true;
            // Inicia o WebDriver (1)
            InitializeWebDriver();
            bntStop.Enabled = true;

            try
            {
                // Navegar até a página do WhatsApp
                driver.Navigate().GoToUrl("https://web.whatsapp.com/");


                AtualizarConsole("# Stolen Content Bot > Abrindo o Whatsapp Web...");

                // Código de console
                AtualizarConsole("# Stolen Content Bot > Aguardando o usuário ler o QR code. O programa será encerrado em 120 segundos, caso o usuário não tenha sucesso ao fazer login.");

                while (executarBot == true)
                {                   
                    // #PRIMEIRA PARTE DO CÓDIGO: Capturar conteudo                    
                    await Task.Run( async () =>
                    {
                        string nomeGrupo = "";

                        // Instância o Wait
                        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
                                               
                        // tratamento de excessão: Esperar usuário fazer login
                        try
                        {
                            // Esperar até que o usuário faça o login
                            IWebElement esperarLogin = wait.Until(ExpectedConditions.ElementExists(By.ClassName("_3sHED")));
                            // Reduzir a janela do navegador para o tamanho mínimo
                            //driver.Manage().Window.Size = new System.Drawing.Size(1, 1);
                        }
                        catch
                        {
                            driver.Quit();
                        }

                        cbNomeGrupo.Invoke(new Action(() =>
                        {
                            // Define o nome do grupo
                            nomeGrupo = cbNomeGrupo.Text;
                        }));

                        PesquisarGrupo(nomeGrupo, wait);
                        EntrarNoGrupo(nomeGrupo, driver, wait);
                        AtualizarConsole($"# Stolen Content Bot > O grupo {nomeGrupo} foi encontrado!");
                        CancelarPesquisa(wait);
                        AtualizarConsole($"# Stolen Content Bot > Procurando a mensagem mais recente do grupo {nomeGrupo}...");

                        IWebElement ultimaMensagem = EncontrarUltimaMensagem(driver);
                        string conteudoMensagem = ObterConteudoMensagem(ultimaMensagem);
                        string textoFinal = ProcessarTexto(conteudoMensagem);

                        AtualizarConsole($"# Stolen Content Bot > Pronto!! O conteúdo foi capturado");                                              
                        // AtualizarConsole($"# Stolen Content Bot > Vou imprimir na caixa de texto, abaixo segue o conteúdo:");                        
                        //AtualizarConsole($"# Stolen Content Bot > \r\n\r\n {textoFinal}");

                        // Verifica se o Link do conteúdo copiado, contém o Link abaixo:
                        if (textoFinal.Contains("https://s.click.aliexpress.com/"))
                        {
                            txtBox.Invoke(new Action(() =>
                            {
                                // Exibe o texto na caixa de texto
                                txtBox.Text = textoFinal;
                            }));
                            
                            AtualizarConsole($"# Stolen Content Bot -> Achei um link de afiliado do Aliexpress");                            

                            Thread.Sleep(1500);

                            // #SEGUNDA PARTE DO CÓDIGO: Gerar Link
                            try
                            {
                                const string regexAliExpress = @"https://s\.click\.aliexpress\.com/[^\s]+";
                                string texto2 = txtBox.Text;
                                string linkCopiado = EncontrarLinkAliExpress(texto2, regexAliExpress);
                                string linkGerado = "";

                                if (!string.IsNullOrEmpty(linkCopiado))
                                {
                                    AbrirNovaGuia(driver);
                                    linkGerado = GerarLinkAffiliate(driver, regexAliExpress, linkCopiado, txtConsole, txtBox, txtBox2);
                                    ContarLinhas();
                                }

                                //Thread.Sleep(120000);

                                // #FORMATAR O TEXTO UTILIZANDO O CHATGPT: Teste
                                AbrirNovaGuia(driver);
                                // Navegar até a página do ChatGPT
                                driver.Navigate().GoToUrl("https://chat.openai.com/");
                                string prompt = "";
                                txtChatGPT.Invoke(new Action(() =>
                                {
                                    prompt = txtChatGPT.Text;
                                }));

                                IWebElement textoGPT = driver.FindElement(By.XPath("//body/div[@id='__next']/div[2]/div[2]/div[1]/main[1]/div[3]/form[1]/div[1]/div[2]/textarea[1]"));
                                // Executar o script JavaScript para enviar o texto e pressionar Enter
                                IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
                                executor.ExecuteScript("arguments[0].value += arguments[1]; arguments[0].dispatchEvent(new InputEvent('input', { bubbles: true, cancelable: true, data: arguments[1] })); arguments[0].dispatchEvent(new KeyboardEvent('keydown', { keyCode: 13, bubles: true, cancelable: true }));", textoGPT, prompt);
                                textoGPT.SendKeys(Keys.Enter);

                                // # TERCEIRA PARTE DO CÓDIGO: Enviar o texto para os Grupos Selecionados.
                                cbGrupoEnviar.Invoke(new Action(() =>
                                {
                                    foreach (var item in cbGrupoEnviar.Items)
                                    {
                                        string nomeGrupoEnviar = item.ToString();
                                        PesquisarGrupo(nomeGrupoEnviar, wait);
                                        Thread.Sleep(500);
                                        EntrarNoGrupo(nomeGrupoEnviar, driver, wait);
                                        Thread.Sleep(500);
                                        CancelarPesquisa(wait);
                                        AtualizarConsole($"# Stolen Content Bot > O grupo {nomeGrupoEnviar} foi encontrado!");

                                        if (!string.IsNullOrEmpty(linkGerado))
                                        {
                                            IWebElement barraDeMensagem = wait.Until(ExpectedConditions.ElementExists(By.ClassName("g0rxnol2"))); 
                                            EnviarMensagemWhatsApp(driver, wait, txtBox, txtBox2, linkGerado, linkCopiado);
                                        }
                                    }
                                }));

                                // # QUARTA PARTE DO CÓDIGO: Entra em Loop até encontrar uma nova mensagem.
                                PesquisarGrupo(nomeGrupo, wait);
                                Thread.Sleep(500);
                                EntrarNoGrupo(nomeGrupo, driver, wait);
                                Thread.Sleep(500);
                                AtualizarConsole($"# Stolen Content Bot > O grupo {nomeGrupo} foi encontrado!");
                                CancelarPesquisa(wait);
                                AtualizarConsole($"# Stolen Content Bot > Procurando novas mensagens no grupo: {nomeGrupo}");

                                //Encontrar a última mensagem no chat
                                IWebElement ultimaMensagem2 = EncontrarUltimaMensagem(driver);

                                // Obter o conteúdo da última mensagem
                                string mensagemAnterior = ObterConteudoMensagem(ultimaMensagem2);

                                // Aguardar a chegada de uma nova mensagem
                                AguardarNovaMensagem(driver, ultimaMensagem2, mensagemAnterior);
                            }
                            catch (InvalidOperationException ex)
                            {
                                AtualizarConsole($"# Stolen Content Bot -> {ex.Message}");                                
                            }                            
                        }
                        else
                        {
                            txtBox.Invoke(new Action(() =>
                            {
                                // Exibe o texto na caixa de texto
                                txtBox.Text = "";
                            }));                            
                            AtualizarConsole("# Stolen Content Bot -> Desculpe-me, mas fui programado somente para lidar com conteúdos do site Aliexpress.");
                            //MessageBox.Show("Sinto muito, mas fui programado para lidar apenas conteúdo do site Aliexpress - Final do Código normal");
                            //driver.Quit();
                        }
                    });
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Infelizmente ocorreu um erro ao tenta executar o programa, abaixo mais informações: \r\n\r\n {ex}");
                //driver.Quit();
            }            
        }

        private void bntSend_Click(object sender, EventArgs e)
        {
            AtualizarConsole("# Stolen Content Bot -> Encerrando as atividades do bot. Vida longa e próspera!");
            executarBot = false;
            bntStop.Enabled = false;
            //driver.Quit();
        }

        private void bntNomeGrupoApagar_Click(object sender, EventArgs e)
        {
            if(cbNomeGrupo.Text != "")
            {
                DialogResult result = MessageBox.Show("Você tem certeza que deseja apagar o item selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (cbNomeGrupo.SelectedIndex != -1)
                    {
                        cbNomeGrupo.Items.RemoveAt(cbNomeGrupo.SelectedIndex);
                        cbNomeGrupo.Refresh();
                        cbNomeGrupo.Text = "";
                    }
                    cbNomeGrupo.Text = "";
                    AtualizarConsole("# Stolen Content Bot -> O grupo alvo foi apagado com sucesso!");
                }
                else if (result == DialogResult.No)
                {
                    // Código para o botão "Não"
                    AtualizarConsole("# Stolen Content Bot -> Ótima escolha!");
                }
            }
            else
            {
                
            }                        
        }

        private void bntNomeGrupoSalvar_Click(object sender, EventArgs e)
        {
            if(cbNomeGrupo.Text != "")
            {
                DialogResult result = MessageBox.Show("Você tem certeza que deseja salvar o item selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (cbNomeGrupo.Text != "")
                    {
                        cbNomeGrupo.Items.Add(cbNomeGrupo.Text);
                        cbNomeGrupo.SelectedIndex = cbNomeGrupo.Items.Count - 1;
                    }
                    AtualizarConsole("# Stolen Content Bot -> O grupo alvo foi salvo com sucesso!");
                }
                else if (result == DialogResult.No)
                {
                    // Código para o botão "Não"
                }
            }
            else
            {
                AtualizarConsole("# Stolen Content Bot -> A caixa de texto está vazia, para de ser maluco!");
            }                        
        }

        private void cbLinhas_SelectedIndexChanged(object sender, EventArgs e)
        {            
            txtBox2.Invoke(new Action(() =>
            {
                if (cbLinhas.SelectedIndex == numLinhasAnterior - 1)
                {
                    txtBox2.Text = textoOriginal;
                }
                else
                {
                    int numLinhas = cbLinhas.SelectedIndex + 1;
                    int totalLinhas = txtBox2.GetLineFromCharIndex(txtBox2.TextLength) + 1;

                    string[] linhas = txtBox2.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                    List<string> textoSelecionado = new List<string>();

                    for (int i = 0; i < numLinhas && i < linhas.Length; i++)
                    {
                        textoSelecionado.Add(linhas[i]);
                    }

                    txtBox2.Text = string.Join(Environment.NewLine, textoSelecionado);
                    numLinhasAnterior = cbLinhas.SelectedIndex + 1;
                    AtualizarLinhas();
                }
            }));
        }

        private void bntSalvarSub_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você tem certeza que deseja salvar o item selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string textoSub = txtBoxTextoSub.Text;
                string emote = txtBoxEmote.Text;
                if (!string.IsNullOrEmpty(emote))
                {
                    dgEmote.Rows.Add(textoSub, emote);
                    AtualizarConsole($"# Stolen Content Bot -> O siguinte texto foi salvo: {textoSub} \r\n\r\n # Stolen Content Bot -> Ele substituirá: {emote}");
                }
                else
                {
                    AtualizarConsole($"# Stolen Content Bot -> A caixa de texto do texto a ser substituido está vazia, preencha e tente novamente!");
                }                  
            }
            else if (result == DialogResult.No)
            {
                // Código para o botão "Não"
            }            
        }

        private void bntApagarSub_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você tem certeza que deseja salvar o item selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ApagarLinhaSelecionada();
                AtualizarConsole("# Stolen Content Bot -> O contéudo da linha selecionada foi apagado!");
            }
            else if (result == DialogResult.No)
            {
                // Código para o botão "Não"
            }            
        }

        private void bntSalvarGrupo_Click(object sender, EventArgs e)
        {
            if (cbGrupoEnviar.Text != "")
            {
                DialogResult result = MessageBox.Show("Você tem certeza que deseja salvar o item selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (cbGrupoEnviar.Text != "")
                    {
                        cbGrupoEnviar.Items.Add(cbGrupoEnviar.Text);
                        cbGrupoEnviar.SelectedIndex = cbGrupoEnviar.Items.Count - 1;
                    }
                    AtualizarConsole("# Stolen Content Bot -> O grupo alvo foi salvo com sucesso!");
                }
                else if (result == DialogResult.No)
                {
                    // Código para o botão "Não"
                }
            }
            else
            {
                AtualizarConsole("# Stolen Content Bot -> A caixa de texto está vazia, para de ser maluco!");
            }
        }

        private void formPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void bntGrupoEnviarApagar_Click(object sender, EventArgs e)
        {
            if (cbGrupoEnviar.Text != "")
            {
                DialogResult result = MessageBox.Show("Você tem certeza que deseja apagar o item selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (cbGrupoEnviar.SelectedIndex != -1)
                    {
                        cbGrupoEnviar.Items.RemoveAt(cbGrupoEnviar.SelectedIndex);
                        cbGrupoEnviar.Refresh();
                        cbGrupoEnviar.Text = "";
                    }
                    cbGrupoEnviar.Text = "";
                    AtualizarConsole("# Stolen Content Bot -> O grupo alvo foi apagado com sucesso!");
                }
                else if (result == DialogResult.No)
                {
                    // Código para o botão "Não"
                    AtualizarConsole("# Stolen Content Bot -> Ótima escolha!");
                }
            }
            else
            {

            }
        }
    }
}