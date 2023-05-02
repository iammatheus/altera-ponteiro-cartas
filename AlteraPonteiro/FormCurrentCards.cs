using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using AlteraPonteiro.Controllers;

namespace AlteraPonteiro
{
    public partial class FormCurrentCards : Form
    {
        public readonly CardController cardController = new();
        public readonly NewCardController newCardController = new();
        public readonly PointerController pointerController = new();
        public Settings settings = new();

        public OpenFileDialog dialog;
        public FileStream pathObtained;
        public FileStream pathObtainedNew;
        public string filePath;
        public string calculatedPointer;
        public string calculatedPointerNewCard;
        public string[] ponteirosSeparados = new string[722];
        public string[] listCardName = new string[] { null };
        public string[] listNewCardName = new string[] { null };

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

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialog = new OpenFileDialog();

            if (DialogResult.OK == dialog.ShowDialog())
            {
                filePath = dialog.FileName;
                MostrarBuscarCarta();
            }
        }

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
            lblStartOffsetNewCard.Visible = true;
            lblLastOffsetNewCard.Visible = true;
            txtStartOffsetNewCard.Visible = true;
            txtLastOffsetNewCard.Visible = true;
            BtnSearchNewCard.Visible = true;

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

        //REFATORADO
        private string ObterOffsetCarta(int indexCartaSelecionada, int offsetInicial)
        {
            for (int i = 0; i < indexCartaSelecionada; i++)
            {
                offsetInicial += listCardName[i].Length + 1;
                for (int c = 0; c < Settings.ColorCode.Length; c++)
                {
                    if (listCardName[i].Substring(0, 2) == Settings.ColorCode[c])
                    {
                        offsetInicial++;
                    }
                }
            }

            calculatedPointer = cardController.GetCalculateSelectedCardPointer(offsetInicial);
            txtPonteiroCalculado.Text = calculatedPointer;

            return offsetInicial.ToString("X");
        }

        // Obter offset da lista de cartas novas.
        private string GetOfssetNewCard(int indexCartaSelecionada, int offsetInicial)
        {
            for (int i = 0; i < indexCartaSelecionada; i++)
            {
                offsetInicial += listNewCardName[i].Length + 1;
                for (int c = 0; c < Settings.ColorCode.Length; c++)
                {
                    if (listNewCardName[i].Substring(0, 2) == Settings.ColorCode[c])
                    {
                        offsetInicial++;
                    }
                }
            }

            calculatedPointerNewCard = newCardController.GetCalculateSelectedCardPointer(offsetInicial);
            txtPointerNewCard.Text = calculatedPointer;

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
                        }
                        else
                        {
                            txtPonteiro.Text = ponteirosSeparados[lListaDeCartas.SelectedIndex];
                            
                        }
                        return;
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
                IList cards = cardController.GetCardName(emptySpaces);

                listCardName = cardController.FillInCardNameList(lListaDeCartas, cards);
                break;
            }
            caminho.Close();
        }

        //teste
        private void CapturarNomeCartaNova(int offsetInicial, int offsetFinal)
        {
            FileStream caminho = new(filePath, FileMode.OpenOrCreate);
            pathObtainedNew = caminho;
            int sizeBytes = offsetFinal;
            byte[] emptySpaces = new byte[sizeBytes];

            caminho.Seek(offsetInicial, SeekOrigin.Begin);

            while (caminho.Read(emptySpaces, 0, emptySpaces.Length) == sizeBytes)
            {
                IList cards = newCardController.GetCardName(emptySpaces);

                listNewCardName = newCardController.FillInCardNameList(lListNewCards, cards);
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

        public void SearchCurrentCards()
        {
            var startOffset = txtOffsetInicial.Text;
            var lastOffset = txtOffsetFinal.Text;

            var start = Convert.ToInt32(startOffset, 16);
            var size = Convert.ToInt32(lastOffset, 16) - start;
            CapturarNomeCarta(start, Math.Abs(size));
        }
        public void SearchNewCards()
        {
            var startOffsetNewCard = txtStartOffsetNewCard.Text;
            var lastOffsetNewCard = txtLastOffsetNewCard.Text;

            var start = Convert.ToInt32(startOffsetNewCard, 16);
            var size = Convert.ToInt32(lastOffsetNewCard, 16) - start;
            CapturarNomeCartaNova(start, Math.Abs(size));
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            SearchCurrentCards();
            SearchNewCards();
            CapturarPonteiroCarta();
        }

        private void ListNewCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMessageInfo.Text = "";

            try
            {
                if (lListNewCards.SelectedItem != null)
                {
                    txtOffsetNewCard.Text = GetOfssetNewCard(lListNewCards.SelectedIndex, Convert.ToInt32(txtStartOffsetNewCard.Text, 16));
                    txtPointerNewCard.Text = calculatedPointerNewCard;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void BtnAlterarPonteiro_Click(object sender, EventArgs e)
        {
            try
            {
                string firstByte = txtPonteiro.Text.Substring(0, 2);
                string secondByte = txtPonteiro.Text.Substring(2, 2);

                int offset = pointerController.GetOffsetPointerCard(lListaDeCartas);

                pointerController.ChangePointerCard(offset, firstByte, secondByte);
                ponteirosSeparados[lListaDeCartas.SelectedIndex] = firstByte + secondByte;

                MessageInfo(System.Drawing.Color.LimeGreen, $"Ponteiro alterado!");
            }
            catch
            {
                MessageInfo(System.Drawing.Color.OrangeRed, $"Não foi possível alterar o ponteiro, tente novamente!");
            }
        }

        private void BtnSearchNewCard_Click(object sender, EventArgs e)
        {
            txtPonteiro.Text = txtPointerNewCard.Text;
            MessageInfo(System.Drawing.Color.LimeGreen, $"Ponteiro substituído!");
        }
        // ----- Fim -----
    }
}