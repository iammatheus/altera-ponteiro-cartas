using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlteraPonteiro
{
    public partial class Form1 : Form
    {
        public OpenFileDialog dialog;
        public string caminhoArquivo;
        public FileStream caminhoObtido;
        public FileStream caminhoObtidoPonteiro;
        string[] ponteirosSeparados = new string[722];
        public string nomeCompleto = "";
        public string ponteiroCompleto = "";
        public string offsetCarta = "";
        string hexPonteiros = "";
        public string[] listaNomeCartas = new string[] { null };
        public string[] listaPonteiros = new string[] { null };
        public string[] bytesPonteiros = new string[] { null };
        string[,] tabelaDeCaracteres = new string[2, 80] {
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

        public string ObterOffsetCarta(int indexCartaSelecionada)
        {
            int offSetAtual = 0x1C6801;

            for (int i = 0; i < indexCartaSelecionada; i++)
            {
                offSetAtual += listaNomeCartas[i].Length + 1;
            }

            return offSetAtual.ToString("X");
        }

        public string ObterOffsetPonteiro()
        {
            int offSetAtual = 0x1C6002;
            if (tPonteiro.Text != null)
            {

                if (lListaPonteiros.Items.Contains(tPonteiro.Text))
                {
                    lListaPonteiros.SelectedIndex = lListaDeCartas.SelectedIndex;

                    for(int i = 0; i < lListaPonteiros.SelectedIndex; i++)
                    {
                        offSetAtual += 2;
                    }
                }
            }

            return offSetAtual.ToString("X");
        }

        public string ObterPonteiroCarta()
        {
            string quatroUlimosDigitosOffset = ObterOffsetCarta(lListaDeCartas.SelectedIndex).Substring(2, 4);
            int quatroUlimosDigitosOffsetInt = Convert.ToInt32(quatroUlimosDigitosOffset, 16);
            int resultadoConta = quatroUlimosDigitosOffsetInt - 0x800;

            string primeiroByte = resultadoConta.ToString("X").Substring(0, 2);
            string segundoByte = resultadoConta.ToString("X").Substring(2, 2);
            string ponteiro = segundoByte + primeiroByte;

            return ponteiro;
        }

        private void ListaDeCartas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lListaDeCartas.SelectedItem != null)
            {
                tPonteiro.Text = ObterPonteiroCarta();
                tOffset.Text = ObterOffsetCarta(lListaDeCartas.SelectedIndex);
            }
            ObterOffsetPonteiro();
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialog = new OpenFileDialog();
            if (DialogResult.OK == dialog.ShowDialog())
            {
                caminhoArquivo = dialog.FileName;
                CapturarNomeCarta();
                CapturarPonteiroCarta();
            }
        }
        private void CapturarNomeCarta()
        {
            FileStream caminho = new(caminhoArquivo, FileMode.OpenOrCreate);
            caminhoObtido = caminho;
            int tamanhoByte = 10956;
            byte[] espacosVazios = new byte[tamanhoByte];

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
                    lListaDeCartas.Items.Add(carta);
                }

                lListaDeCartas.Items.RemoveAt(722);
                break;
            }
            caminho.Close();
        }

        private void CapturarPonteiroCarta()
        {
            FileStream caminhoPonteiro = new(caminhoArquivo, FileMode.OpenOrCreate);
            caminhoObtidoPonteiro = caminhoPonteiro;
            int tamanhoByte = 1444;
            byte[] espacosVazios = new byte[tamanhoByte];

            caminhoPonteiro.Seek(0x1C6002, SeekOrigin.Begin);
            while (caminhoPonteiro.Read(espacosVazios, 0, espacosVazios.Length) == tamanhoByte)
            {
                string espacoAtual = BitConverter.ToString(espacosVazios);
                string[] byteHexPonteiros = espacoAtual.Split("-");
                
                for (int b = 0; b < byteHexPonteiros.Length; b++)
                {
                    hexPonteiros += byteHexPonteiros[b];
                }

                int controle = 0;

                for (int i = 0; i < 722; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if(j > 0)
                        {
                            controle += 1;
                        }else if(controle > 0)
                        {
                            controle += 1;
                        }
                        ponteirosSeparados[i] += byteHexPonteiros[controle];
                    }
                }

                foreach(string element in ponteirosSeparados)
                {
                    lListaPonteiros.Items.Add(element);
                }

                break;
            }
            caminhoPonteiro.Close();
        }
    }
}