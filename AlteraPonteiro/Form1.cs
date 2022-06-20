using System;
using System.IO;
using System.Windows.Forms;

namespace AlteraPonteiro
{
    public partial class Form1 : Form
    {
        public OpenFileDialog dialog;
        public FileStream caminhoObtido;
        public FileStream caminhoObtidoPonteiro;
        public FileStream caminhoPonteiro;
        public string caminhoArquivo;
        public string nomeCompleto = "";
        public string ponteiroCompleto = "";
        public string offsetCarta = "";
        public const string HexLetters = "0123456789abcdefABCDEF\u0003\u0016\b";
        public string[] ponteirosSeparados = new string[722];
        public string[] listaNomeCartas = new string[] { null };
        public string[] listaPonteiros = new string[] { null };
        public string[] bytesPonteiros = new string[] { null };
        public string[] codigoCores = new string[5] { "le", "ln", "li", "lt", "la" };
        public string[,] tabelaDeCaracteres = new string[2, 80] {
            { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "0A", "0B", "0C", "0D", "0E", "0F", "10",
              "11", "12", "13", "14", "15", "16", "17", "18", "19", "1A", "1B", "1C", "1D", "1E", "1F", "20", "21",
              "22", "23", "24", "25", "26", "29", "2A", "2B", "2C", "2D", "2E", "2F", "30", "31", "32", "33", "34",
              "35", "36", "37", "38", "39", "3A", "3B", "3C", "3D", "3E", "3F", "40", "41", "42", "43", "44", "45",
              "46", "48", "4A", "4E", "4F", "50", "56", "57", "59", "5B", "FF", "55"
            },

            { " ","e","t","a","o","i","n","s","r","h","l",".","d","u","m","c","g","y","w","f","p","b","k","!","A","v",
              "I","'","T","S","M",",","D","O","W","H","Y","E","R","G","L","C","N","B","?","P","-","F","z","K","j","U",
              "x","q","0","V","2","J","#","1","Q","Z","\u0022","3","5","&","/","7","X",":","4","6","$","*","+","8","9",
              "%","[ENTER]", "."
            }
        };
        public Form1()
        {
            InitializeComponent();
        }
        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialog = new OpenFileDialog();

            if (DialogResult.OK == dialog.ShowDialog())
            {
                caminhoArquivo = dialog.FileName;
                MostrarBuscarCarta();
            }
        }
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Ferramenta desenvolvida por Matheus Ferreira (Master Mage).\n\nCódigo livre no GitHub:\nhttps://github.com/iammatheus/altera-ponteiro-cartas";
            const string caption = "Sobre";
            MessageBox.Show(message, caption, MessageBoxButtons.OK);
        }
        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // 
        // Funções Gerais
        // 
        private void ValidaBotaoOk(object sender, KeyEventArgs e)
        {
            //Função que habilita o botão Ok caso os campos estejam preenchidos.
            BtnBuscar.Enabled = false;

            TextBox[] teste = new TextBox[2] {
                txtOffsetInicial, txtOffsetFinal
            };
            TextBox[] teste2 = new TextBox[2] {
                txtOffsetInicialPonteiro, txtOffsetFinalPonteiro
            };

            if ((teste[0].Text.Length > 5 && teste2[0].Text.Length > 5) &&
                (teste[1].Text.Length > 5 && teste2[1].Text.Length > 5))
            {
                BtnBuscar.Enabled = true;
            }
        }
        private void ValidaCamposHexadecimal(object sender, KeyPressEventArgs e)
        {
            if (!HexLetters.Contains(e.KeyChar)) e.Handled = true;
        }
        private void MessageInfo(System.Drawing.Color color, string text)
        {
            lblMessageInfo.Text = text;
            lblMessageInfo.ForeColor = color;
        }
        private void MostrarLista()
        {
            lblTitleLista.Visible = true;
            lListaDeCartas.Visible = true;
            backTitleLista.Visible = true;
            backLeftLista.Visible = true;
            backBottomLista.Visible = true;
            backTopScroll.Visible = true;
            backBottomScroll.Visible = true;
            borderRightLista.Visible = true;
            borderTopLista.Visible = true;
            borderBottomTitleLista.Visible = true;
        }
        private void MostrarBuscarCarta()
        {
            lblTitleBuscar.Visible = true;
            lblOffsetInicial.Visible = true;
            lblOffsetFinal.Visible = true;
            txtOffsetInicial.Visible = true;
            txtOffsetFinal.Visible = true;

            lblTitleBuscarPonteiro.Visible = true;
            lblOffsetInicialPonteiro.Visible = true;
            lblOffsetFinalPonteiro.Visible = true;
            txtOffsetInicialPonteiro.Visible = true;
            txtOffsetFinalPonteiro.Visible = true;

            BtnBuscar.Visible = true;
        }
        private void MostrarResultados()
        {
            lblTitleResultados.Visible = true;
            lblOffset.Visible = true;
            lblPonteiro.Visible = true;
            lblPonteiroCalculado.Visible = true;
            lblMessageInfo.Visible = true;
            txtPonteiroCalculado.Visible = true;
            txtOffset.Visible = true;
            txtPonteiro.Visible = true;
            BtnAlterarPonteiro.Visible = true;
        }
        // ----- Fim -----

        //
        // Funções para obter Ponteiros e Cartas / Offsets / Lista
        //
        private void CalcularPonteiroCartaSelecionada(int offSetAtual)
        {
            var offsetAtual4UltimosDigitos = offSetAtual.ToString("X").Substring(2, 4);
            var ponteiroCartaSelecionada = Convert.ToInt32(offsetAtual4UltimosDigitos, 16) - 2048;
            var resultadoCalculado = ponteiroCartaSelecionada.ToString("X");
            var ponteiroCalculado = resultadoCalculado.Substring(2, 2) + resultadoCalculado.Substring(0, 2);
            txtPonteiroCalculado.Text = ponteiroCalculado;
        }
        private int ObterOffsetPonteiro()
        {
            int offSetAtual = Convert.ToInt32(txtOffsetInicialPonteiro.Text, 16);
            for (int i = 0; i < lListaDeCartas.SelectedIndex; i++)
            {
                offSetAtual += 2;
            }
            return offSetAtual;
        }
        private string ObterOffsetCarta(int indexCartaSelecionada, int offsetInicial)
        {
            int offSetAtual = offsetInicial;

            for (int i = 0; i < indexCartaSelecionada; i++)
            {
                offSetAtual += listaNomeCartas[i].Length + 1;
                for (int c = 0; c < codigoCores.Length; c++)
                {
                    if (listaNomeCartas[i].Substring(0, 2) == codigoCores[c])
                    {
                        offSetAtual++;
                    }
                }
            }
            CalcularPonteiroCartaSelecionada(offSetAtual);

            return offSetAtual.ToString("X");
        }
        private void ListaDeCartas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMessageInfo.Text = "";

            try
            {
                if (lListaDeCartas.SelectedItem != null)
                {
                    txtOffset.Text = ObterOffsetCarta(lListaDeCartas.SelectedIndex, Convert.ToInt32(txtOffsetInicial.Text, 16));
                }

                if (ponteirosSeparados[lListaDeCartas.SelectedIndex] != null)
                {
                    txtPonteiro.Text = ponteirosSeparados[lListaDeCartas.SelectedIndex];
                }
                else
                {
                    MessageInfo(System.Drawing.Color.OrangeRed, "Não foi possível obter o ponteiro ATUAL da carta. Verifique os ponteiros informados.");
                    txtPonteiro.ResetText();
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        private void CapturarNomeCarta(int offsetInicial, int offsetFinal)
        {
            FileStream caminho = new(caminhoArquivo, FileMode.OpenOrCreate);
            caminhoObtido = caminho;
            int tamanhoByte = offsetFinal;
            byte[] espacosVazios = new byte[tamanhoByte];
            int numeroCarta = 1;

            caminho.Seek(offsetInicial, SeekOrigin.Begin);
            while (caminho.Read(espacosVazios, 0, espacosVazios.Length) == tamanhoByte)
            {
                string espacoAtual = BitConverter.ToString(espacosVazios);
                string[] byteHexNomeCartas = espacoAtual.Split("-");
                string hexNomeCartas = "";

                for (int b = 0; b < byteHexNomeCartas.Length; b++)
                {
                    for (int i = 0; i < 80; i++)
                    {
                        if (tabelaDeCaracteres[0, i] == byteHexNomeCartas[b])
                        {
                            nomeCompleto += tabelaDeCaracteres[1, i];
                            hexNomeCartas += byteHexNomeCartas[b];
                        }
                    }
                    if (byteHexNomeCartas[b] == "FF")
                    {
                        listaNomeCartas = nomeCompleto.Split("[ENTER]");
                    }
                }

                foreach (string carta in listaNomeCartas)
                {
                    lListaDeCartas.Items.Add(numeroCarta.ToString().PadLeft(3, '0') + " - " + carta);
                    numeroCarta++;
                }

                int ultimoIndiceLista = numeroCarta - 2;
                lListaDeCartas.Items.RemoveAt(ultimoIndiceLista);
                break;
            }
            caminho.Close();
        }
        private void CapturarPonteiroCarta(int offsetInicialPonteiro, int offsetFinalPonteiro)
        {
            caminhoPonteiro = new(caminhoArquivo, FileMode.OpenOrCreate);
            caminhoObtidoPonteiro = caminhoPonteiro;
            int tamanhoByte = offsetFinalPonteiro;
            byte[] espacosVazios = new byte[tamanhoByte];

            caminhoPonteiro.Seek(offsetInicialPonteiro, SeekOrigin.Begin);
            while (caminhoPonteiro.Read(espacosVazios, 0, espacosVazios.Length) == tamanhoByte)
            {
                string espacoAtual = BitConverter.ToString(espacosVazios);
                string[] byteHexPonteiros = espacoAtual.Split("-");
                int controle = 0;
                int controle2 = tamanhoByte / 2;

                for (int i = 0; i < controle2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if (j > 0)
                        {
                            controle += 1;
                        }
                        else if (controle > 0)
                        {
                            controle += 1;
                        }
                        ponteirosSeparados[i] += byteHexPonteiros[controle];
                    }
                }
                break;
            }
            MostrarLista();
            MostrarResultados();
        }
        // ----- Fim -----

        //
        // Funções dos botões - Alterar ponteiro / Buscar cartas e ponteiros
        //
        private static void AlterarPonteiroCarta(FileStream path, int offset, string firstValue, string secondValue)
        {
            path.Seek(offset, SeekOrigin.Begin);
            path.WriteByte(Convert.ToByte(firstValue, 16));
            
            path.Seek(offset + 1, SeekOrigin.Begin);
            path.WriteByte(Convert.ToByte(secondValue, 16));

            path.Flush();
        }
        private void BtnAlterarPonteiro_Click(object sender, EventArgs e)
        {
            try
            {
                string firstByte = txtPonteiro.Text.Substring(0, 2);
                string secondByte = txtPonteiro.Text.Substring(2, 2);

                if(firstByte != null && secondByte != null)
                {
                    AlterarPonteiroCarta(caminhoObtidoPonteiro, ObterOffsetPonteiro(), firstByte, secondByte);
                    MessageInfo(System.Drawing.Color.LimeGreen, "Ponteiro alterado!");
                }
            }
            catch(Exception)
            {
                MessageInfo(System.Drawing.Color.OrangeRed, "Não foi possível alterar o ponteiro, tente novamente!");
            }
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //Cartas
            var offsetInicial = txtOffsetInicial.Text;
            var offsetFinal = txtOffsetFinal.Text;
            var inicio = Convert.ToInt32(offsetInicial, 16);
            var tamanho = Convert.ToInt32(offsetFinal, 16) - inicio;

            //Ponteiros
            var offsetInicialPonteiro = txtOffsetInicialPonteiro.Text;
            var offsetFinalPonteiro = txtOffsetFinalPonteiro.Text;
            var inicioPonteiro = Convert.ToInt32(offsetInicialPonteiro, 16);
            var tamanhoPonteiro = Convert.ToInt32(offsetFinalPonteiro, 16) - inicioPonteiro;

            CapturarNomeCarta(inicio, Math.Abs(tamanho));
            CapturarPonteiroCarta(inicioPonteiro, Math.Abs(tamanhoPonteiro));
        }
        // ----- Fim -----
    }
}