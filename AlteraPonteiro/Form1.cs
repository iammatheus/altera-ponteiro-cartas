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
        public string[] ponteirosSeparados = new string[722];
        public string[] listaNomeCartas = new string[] { null };
        public string[] listaPonteiros = new string[] { null };
        public string[] bytesPonteiros = new string[] { null };
        public string[,] tabelaDeCaracteres = new string[2, 80] {
                { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "0A", "0B", "0C", "0D", "0E", "0F", "10",
                  "11", "12", "13", "14", "15", "16", "17", "18", "19", "1A", "1B", "1C", "1D", "1E", "1F", "20", "21",
                  "22", "23", "24", "25", "26", "29", "2A", "2B", "2C", "2D", "2E", "2F", "30", "31", "32", "33", "34",
                  "35", "36", "37", "38", "39", "3A", "3B", "3C", "3D", "3E", "3F", "40", "41", "42", "43", "44", "45",
                  "46", "48", "4A", "4E", "4F", "50", "56", "57", "59", "5B", "FF", "55"},

                {" ","e","t","a","o","i","n","s","r","h","l",".","d","u","m","c","g","y","w","f","p","b","k","!","A","v",
                 "I","'","T","S","M",",","D","O","W","H","Y","E","R","G","L","C","N","B","?","P","-","F","z","K","j","U",
                 "x","q","0","V","2","J","#","1","Q","Z","\u0022","3","5","&","/","7","X",":","4","6","$","*","+","8","9",
                 "%","[ENTER]", "."}
                };

        public Form1()
        {
            InitializeComponent();
        }

        private void MostraCamposForm()
        {
            lListaDeCartas.Visible = true;
            lblMessageInfo.Visible = true;
            lblOffset.Visible = true;
            lblPonteiro.Visible = true;
            BtnAlterarPonteiro.Visible = true;
            txtOffset.Visible = true;
            txtPonteiro.Visible = true;
        }

        public string ObterOffsetCarta(int indexCartaSelecionada)
        {
            int offSetAtual = 0x1C6801;
            for (int i = 0; i < indexCartaSelecionada; i++)
            {
                offSetAtual += listaNomeCartas[i].Length + 1;
            }
            return offSetAtual.ToString("X");
        }

        public int ObterOffsetPonteiro()
        {
            int offSetAtual = 0x1C6002;
            for (int i = 0; i < lListaDeCartas.SelectedIndex; i++)
            {
                offSetAtual += 2;
            }
            return offSetAtual;
        }

        private void ListaDeCartas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lListaDeCartas.SelectedItem != null)
            {
                txtOffset.Text = ObterOffsetCarta(lListaDeCartas.SelectedIndex);
            }
            txtPonteiro.Text = ponteirosSeparados[lListaDeCartas.SelectedIndex].ToString();
            lblMessageInfo.Text = "";
        }
        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialog = new OpenFileDialog();
            if (DialogResult.OK == dialog.ShowDialog())
            {
                caminhoArquivo = dialog.FileName;
                CapturarNomeCarta();
                CapturarPonteiroCarta();
                MostraCamposForm();
            }
        }
        private void MessageInfo(System.Drawing.Color color, string text)
        {
            lblMessageInfo.Text = text;
            lblMessageInfo.ForeColor = color;
        }

        private void CapturarNomeCarta()
        {
            FileStream caminho = new(caminhoArquivo, FileMode.OpenOrCreate);
            caminhoObtido = caminho;
            int tamanhoByte = 10956;
            byte[] espacosVazios = new byte[tamanhoByte];
            int numeroCarta = 1;

            caminho.Seek(0x1C6801, SeekOrigin.Begin);
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

                lListaDeCartas.Items.RemoveAt(722);
                break;
            }
            caminho.Close();
        }
        private void CapturarPonteiroCarta()
        {
            caminhoPonteiro = new(caminhoArquivo, FileMode.OpenOrCreate);
            caminhoObtidoPonteiro = caminhoPonteiro;
            int tamanhoByte = 1444;
            byte[] espacosVazios = new byte[tamanhoByte];

            caminhoPonteiro.Seek(0x1C6002, SeekOrigin.Begin);
            while (caminhoPonteiro.Read(espacosVazios, 0, espacosVazios.Length) == tamanhoByte)
            {
                string espacoAtual = BitConverter.ToString(espacosVazios);
                string[] byteHexPonteiros = espacoAtual.Split("-");
                int controle = 0;

                for (int i = 0; i < 722; i++)
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
        }

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

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}