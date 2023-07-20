using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Stolen_Content
{
    public class Stolen
    {
        // Se o conteudo for repetido, ele permanece no loop até achar outro
        /*while (condicao == true)
        {
            // Roda o loop em segundo plano
            await Task.Run(() =>
            {
                if (textoFinal == txtBox.Text)
                {
                    // Encontrar a classe "_21Ahp"(Mensagens de usuários)
                    IWebElement ultimaMensagem2 = driver.FindElements(By.ClassName("_21Ahp")).Last();

                    // Obtém o código HTML da mensagem
                    string html2 = ultimaMensagem2.GetAttribute("innerHTML");

                    // Carrega o código HTML em um documento HtmlAgilityPack
                    var documentoHtml2 = new HtmlAgilityPack.HtmlDocument();
                    documentoHtml2.LoadHtml(html2);

                    // Filtra as tags HTML desnecessárias e mantém apenas o texto e os emojis
                    var textos3 = documentoHtml2.DocumentNode.Descendants()
                        .Where(n2 => n2.NodeType == HtmlNodeType.Text ||
                                    (n2.NodeType == HtmlNodeType.Element && n2.Name == "img" && n2.Attributes["alt"] != null))
                        .Select(n2 => n2.NodeType == HtmlNodeType.Text ? n2.InnerHtml : n2.Attributes["alt"].Value);

                    // Concatena os textos em um único texto usando StringBuilder
                    var textoConcatenado3 = new StringBuilder();
                    foreach (var texto3 in textos3)
                    {
                        textoConcatenado3.Append(texto3);
                    }

                    // Remove os últimos 5 caracteres do texto concatenado e, em seguida, remove espaços em branco
                    textoFinal = textoConcatenado3.ToString().Substring(0, textoConcatenado3.Length - 5).Trim();

                    //Aguarda 10 minutos
                    //Thread.Sleep(5000);

                    txtConsole.Invoke(new Action(() =>
                    {
                        txtConsole.AppendText($"# Stolen Content Bot -> Parece que já encontrei esse conteúdo, tentarei novamente em 5 segundos! - inicio Do While");
                        txtConsole.AppendText("\r\n");
                        txtConsole.AppendText("\r\n");
                    }));
                    condicao = true;
                }
                // Se o resultado do texto capturado da ultima mensagem do whatsapp web for igual ao texto da TextBox2, SE NÃO: executa o código abaixo.
                else
                {
                    if (textoFinal.Contains("https://s.click.aliexpress.com/"))
                    {
                        txtBox.Invoke(new Action(() =>
                        {
                            // Exibe o texto na caixa de texto
                            txtBox.Text = textoFinal;
                        }));

                        //Texto do Console
                        txtConsole.Invoke(new Action(() =>
                        {
                            txtConsole.AppendText("# Stolen Content Bot -> Achei um link de afiliado do Aliexpress");
                            txtConsole.AppendText("\r\n");
                            txtConsole.AppendText("\r\n");
                        }));

                        // Armazena somente o link copiado
                        string linkCopiado;

                        Thread.Sleep(1500);

                        // #SEGUNDA PARTE DO CÓDIGO(2.0): Gerar Link

                        string texto2 = txtBox.Text;

                        // Cria uma expressão regular para encontrar o link do AliExpress no texto.
                        // A expressão regular encontra qualquer coisa que comece com "https://s.click.aliexpress.com/"
                        // seguido por um ou mais caracteres que não sejam espaços em branco.
                        Regex regex = new Regex(@"https://s\.click\.aliexpress\.com/[^\s]+");

                        // Procura por um único match da expressão regular no texto.
                        Match match = regex.Match(texto2);

                        // Se o match for bem-sucedido, imprime o valor do match (ou seja, o link do AliExpress) no console.
                        // Caso contrário, imprime "Link não encontrado."
                        if (match.Success)
                        {
                            linkCopiado = match.Value;
                        }
                        else
                        {
                            MessageBox.Show("O link não foi encontrado.");
                        }

                        // Usar o método "ExecuteScript" do driver para abrir uma nova guia
                        ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");

                        // Selecionar a nova guia aberta
                        driver.SwitchTo().Window(driver.WindowHandles.Last());

                        // Navega para o link copiado do texto da mensagem mais recente do grupo do whatsapp
                        driver.Navigate().GoToUrl($"{match.Value}");

                        // Mensagem de Console:
                        txtConsole.Invoke(new Action(() =>
                        {
                            txtConsole.AppendText("# Stolen Content Bot -> Abrindo a página do link e convertendo usando a ToolStrip do Aliexpress");
                            txtConsole.AppendText("\r\n");
                            txtConsole.AppendText("\r\n");
                        }));

                        // Esperar até que o elemento esteja disponível na página
                        WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                        IWebElement geradorDeLink = wait2.Until(ExpectedConditions.ElementExists(By.ClassName("share_button")));
                        //link_input     

                        geradorDeLink.Click();

                        Thread.Sleep(1500);
                        // Clica no link Gerado pelo Toolstrip e copia 
                        IWebElement link = wait2.Until(ExpectedConditions.ElementExists(By.ClassName("link_img_share")));

                        // Procura por um único match da expressão regular no texto.
                        Match match2 = regex.Match(link.Text);

                        string LinkGerado;

                        // Se o match for bem-sucedido, imprime o valor do match (ou seja, o link do AliExpress) no console.
                        // Caso contrário, imprime "Link não encontrado."
                        if (match2.Success)
                        {
                            LinkGerado = match2.Value.Substring(0, match2.Value.Length - 1).Trim();
                            txtConsole.Invoke(new Action(() =>
                            {
                                txtConsole.AppendText($"# Stolen Content Bot -> O seguinte link foi gerado: {LinkGerado}");
                                txtConsole.AppendText("\r\n");
                                txtConsole.AppendText("\r\n");
                            }));

                            txtBox2.Invoke(new Action(() =>
                            {
                                txtBox2.Text = txtBox.Text.Replace(match.Value, LinkGerado);
                            }));
                            // Mensagem de Console:
                            txtConsole.Invoke(new Action(() =>
                            {
                                txtConsole.AppendText($"# Stolen Content Bot -> O link do texto foi substituido com seu o link de afiliado");
                                txtConsole.AppendText("\r\n");
                                txtConsole.AppendText("\r\n");
                            }));

                            // Voltar para a guia do WhatsApp
                            driver.SwitchTo().Window(driver.WindowHandles.First());

                            // # TERCEIRA PARTE DO CÓDIGO(2.0): Enviar o texto para os Grupos Selecionados

                            string nomeGrupoEnviar = "";

                            cbGrupoEnviar.Invoke(new Action(() =>
                            {
                                // Define o nome do grupo
                                nomeGrupoEnviar = cbGrupoEnviar.Text;
                            }));

                            // Localiza e espera até a barra de pesquisa do Whatsapp ficar visivel 
                            IWebElement searchBox = wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath("//body/div[@id='app']/div[1]/div[1]/div[4]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/p[1]")));

                            // Clica na barra de Pesquisa
                            searchBox.Click();
                            // Pesquisa pelo nome do grupo
                            searchBox.SendKeys($"{nomeGrupoEnviar}");

                            //Mensagem de console
                            txtConsole.Invoke(new Action(() =>
                            {
                                txtConsole.AppendText($"# Stolen Content Bot > Procurando o grupo {nomeGrupoEnviar}");
                                txtConsole.AppendText("\r\n");
                                txtConsole.AppendText("\r\n");
                            }));

                            // Envia para a barra de pesquisa a tecla: Enter
                            searchBox.SendKeys(Keys.Enter);

                            // Localizar o grupo desejado
                            IWebElement grupo = driver.FindElement(By.XPath($"//span[@title='{nomeGrupoEnviar}']"));

                            // Espera até clicar no nome do grupo
                            wait2.Until(ExpectedConditions.ElementToBeClickable(grupo));

                            // Clicar no grupo
                            grupo.Click();

                            // Mensagem de console
                            txtConsole.Invoke(new Action(() =>
                            {
                                txtConsole.AppendText($"# Stolen Content Bot > O grupo {nomeGrupoEnviar} foi encontrado!");
                                txtConsole.AppendText("\r\n");
                                txtConsole.AppendText("\r\n");
                            }));

                            // Espera até o botão de cancelar pesquisa existir
                            IWebElement cancelarPesquisa = wait2.Until(ExpectedConditions.ElementExists(By.ClassName("-Jnba")));
                            // Clica no Botão de cancelar pesquisa
                            cancelarPesquisa.Click();

                            // Espera até a barra de mensagem está visivel
                            IWebElement barraDeMensagem = wait2.Until(ExpectedConditions.ElementExists(By.ClassName("_1VZX7")));

                            // Clica na barra de mensagem
                            barraDeMensagem.Click();

                            string conteudoRoubado = "";
                            txtBox2.Invoke(new Action(() =>
                            {
                                conteudoRoubado = txtBox2.Text;
                            }));

                            // Executar o script JavaScript para enviar o texto e pressionar Enter
                            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
                            executor.ExecuteScript("arguments[0].value += arguments[1]; arguments[0].dispatchEvent(new InputEvent('input', { bubbles: true, cancelable: true, data: arguments[1] })); arguments[0].dispatchEvent(new KeyboardEvent('keydown', { keyCode: 13, bubbles: true, cancelable: true }));", barraDeMensagem, txtBox2.Text);

                            //Torna a condição falsa, para parar o Loop.
                            condicao = false;
                        }
                    }
                    else
                    {
                        txtBox.Invoke(new Action(() =>
                        {
                            // Exibe o texto na caixa de texto
                            txtBox.Text = "";
                        }));

                        txtConsole.Invoke(new Action(() =>
                        {
                            txtConsole.AppendText("# Stolen Content Bot -> Sinto muito, mas fui programado para lidar apenas conteúdo do site Aliexpress - Final Do While");
                            txtConsole.AppendText("\r\n");
                            txtConsole.AppendText("\r\n");
                        }));
                        MessageBox.Show("Sinto muito, mas fui programado para lidar apenas conteúdo do site Aliexpress - Final Do While");
                        driver.Quit();
                    }                                                                
                    condicao = false;
                }
            })                                                                     
        }
    }                
}*/
    }
}
