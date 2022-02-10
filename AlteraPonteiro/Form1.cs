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
        public string caminhoTable;
        public string nomeCompleto = "";
        public string offsetCarta = "";
        public string[] testeCaractere = new string[] { null };
        string[,] traduzCaracteres = new string[2, 80] {
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

        public string ObterOffsetCarta(int index)
        {
            int indexCartaSelecionada = index;
            int offSetAtual = 0x1C6801;

            for (int i = 0; i < indexCartaSelecionada; i++)
            {
                offSetAtual += testeCaractere[i].Length + 1;
            }

            return offSetAtual.ToString("X");
        }

        public string ObterPonteiroCarta()
        {
            string quatroUlimosDigitosOffset = ObterOffsetCarta(listaDeCartas.SelectedIndex).Substring(2, 4);
            int quatroUlimosDigitosOffsetInt = Convert.ToInt32(quatroUlimosDigitosOffset, 16);
            int ponteiroCartaSelecionada = quatroUlimosDigitosOffsetInt - 0x800;
            return ponteiroCartaSelecionada.ToString("X");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaDeCartas.SelectedItem != null)
            {
                tPonteiro.Text = ObterPonteiroCarta();
                tOffset.Text = ObterOffsetCarta(listaDeCartas.SelectedIndex);
            }
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialog = new OpenFileDialog();
            if (DialogResult.OK == dialog.ShowDialog())
            {
                caminhoArquivo = dialog.FileName;
                caminhoTable = "C:/Users/Matheus Ferreira/Desktop/Isos/table.tbl";
                CapturarNomeCarta();
            }
        }
        private void CapturarNomeCarta()
        {
            FileStream caminho = new(caminhoArquivo, FileMode.OpenOrCreate);
            int tamanhoByte = 10956;
            byte[] espacosVazios = new byte[tamanhoByte];

            caminho.Seek(0x1C6801, SeekOrigin.Begin);
            while (caminho.Read(espacosVazios, 0, espacosVazios.Length) == tamanhoByte)
            {
                string espacoAtual = BitConverter.ToString(espacosVazios);
                string[] teste2 = espacoAtual.Split("-");

                string nomeCompletoHex = "";
                string[] caralho = new string[] { };
                for (int meuPau = 0; meuPau < teste2.Length; meuPau++)
                {
                    for (int i = 0; i < 80; i++)
                    {
                        if (traduzCaracteres[0, i] == teste2[meuPau])
                        {
                            nomeCompleto += traduzCaracteres[1, i];
                            nomeCompletoHex += teste2[meuPau];
                        }
                    }
                    if (teste2[meuPau] == "FF")
                    {
                        caralho = nomeCompleto.Split("[ENTER]");
                        testeCaractere = caralho;
                    }
                }

                foreach (string meuCu in caralho)
                {
                    listaDeCartas.Items.Add(meuCu);
                }

                listaDeCartas.Items.RemoveAt(722);
                break;
            }
            caminho.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}