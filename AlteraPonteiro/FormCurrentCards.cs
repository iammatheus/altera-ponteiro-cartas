using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using AlteraPonteiro.Controllers;

namespace AlteraPonteiro
{
    public partial class FormCurrentCards : Form
    {
        public readonly CardController offsetCardController = new();
        public readonly PointerController pointerController = new();

        public OpenFileDialog dialog;
        public FileStream pathObtained;
        public string filePath;
        public string calculatedPointer;
        public string[] ponteirosSeparados = new string[722];
        public string[] cardListName = new string[] { null };

        public FormCurrentCards()
        {
            InitializeComponent();
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

            TextBox[] inputOffset = new TextBox[2] {
                txtOffsetInicial, txtOffsetFinal
            };

            if ((inputOffset[0].Text.Length > 5) &&
                (inputOffset[1].Text.Length > 5))
            {
                BtnBuscar.Enabled = true;
            }
        }
        private void ValidaCamposHexadecimal(object sender, KeyPressEventArgs e)
        {
            if (!Settings.HexLetters.Contains(e.KeyChar)) e.Handled = true;
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


            //NEW CARDS
            lblNewCards.Visible = true;
            lListNewCards.Visible = true;
        }
        private void MostrarBuscarCarta()
        {
            lblTitleBuscar.Visible = true;
            lblOffsetInicial.Visible = true;
            lblOffsetFinal.Visible = true;
            txtOffsetInicial.Visible = true;
            txtOffsetFinal.Visible = true;

            lblOffsetInicial.Visible = true;
            lblOffsetFinal.Visible = true;
            txtOffsetInicial.Visible = true;
            txtOffsetFinal.Visible = true;

            // NEW CARDS
            lblTitleNewCard.Visible = true;
            lblInitialOffsetNewCard.Visible = true;
            lblLastOffsetNewCard.Visible = true;
            txtInitialOffsetNewCard.Visible = true;
            txtLastOffsetNewCard.Visible = true;
            btnSearchNewCard.Visible = true;

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


            //NEW CARDS
            lblResultNewCard.Visible = true;
            lblOffsetNewCard.Visible = true;
            lblPointerCard.Visible = true;
            txtOffsetNewCard.Visible = true;
            txtPointerNewCard.Visible = true;
        }
        // ----- Fim -----

        //
        // Funções para obter Ponteiros e Cartas / Offsets / Lista
        //


        //REFATORADO
        private string ObterOffsetCarta(int indexCartaSelecionada, int offsetInicial)
        {
            for (int i = 0; i < indexCartaSelecionada; i++)
            {
                offsetInicial += cardListName[i].Length + 1;
                for (int c = 0; c < Settings.ColorCode.Length; c++)
                {
                    if (cardListName[i].Substring(0, 2) == Settings.ColorCode[c])
                    {
                        offsetInicial++;
                    }
                }
            }

            calculatedPointer = offsetCardController.GetCalculateSelectedCardPointer(offsetInicial);
            txtPonteiroCalculado.Text = calculatedPointer;

            return offsetInicial.ToString("X");
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
                    txtPonteiro.Text = "";
                    for (int i = 0; i < ponteirosSeparados.Length; i++) 
                    {
                        if (calculatedPointer == ponteirosSeparados[i])
                        {
                            txtPonteiro.Text = ponteirosSeparados[i];
                            return;
                        }
                    }
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

        // REFATORADO!
        private void CapturarNomeCarta(int offsetInicial, int offsetFinal)
        {
            FileStream caminho = new(filePath, FileMode.OpenOrCreate);
            pathObtained = caminho;
            int sizeBytes = offsetFinal;
            byte[] emptySpaces = new byte[sizeBytes];

            caminho.Seek(offsetInicial, SeekOrigin.Begin);

            while (caminho.Read(emptySpaces, 0, emptySpaces.Length) == sizeBytes)
            {
                IList cards = offsetCardController.GetNameCard(emptySpaces);

                cardListName = offsetCardController.FillInCardNameList(lListaDeCartas, cards);
                break;
            }
            caminho.Close();
        }

        // REFATORADO
        private void CapturarPonteiroCarta()
        {
            ponteirosSeparados = pointerController.GetPointerCard(filePath);

            MostrarLista();
            MostrarResultados();
        }
        // ----- Fim -----

        //
        // Funções dos botões - Alterar ponteiro / Buscar cartas e ponteiros
        //
        //private static void AlterarPonteiroCarta(FileStream path, int offset, string firstValue, string secondValue)
        //{
        //    path.Seek(offset, SeekOrigin.Begin);
        //    path.WriteByte(Convert.ToByte(firstValue, 16));
            
        //    path.Seek(offset + 1, SeekOrigin.Begin);
        //    path.WriteByte(Convert.ToByte(secondValue, 16));

        //    path.Flush();
        //}


        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //Cartas
            var offsetInicial = txtOffsetInicial.Text;
            var offsetFinal = txtOffsetFinal.Text;
            var inicio = Convert.ToInt32(offsetInicial, 16);
            var tamanho = Convert.ToInt32(offsetFinal, 16) - inicio;

            CapturarNomeCarta(inicio, Math.Abs(tamanho));
            CapturarPonteiroCarta();
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialog = new OpenFileDialog();

            if (DialogResult.OK == dialog.ShowDialog())
            {
                filePath = dialog.FileName;
                MostrarBuscarCarta();
            }
        }
        // ----- Fim -----
    }
}