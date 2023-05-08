using System;
using System.Collections;
using System.Collections.Generic;
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
        public string[] cardsPointers = new string[722];
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
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialog = new OpenFileDialog();

            if (DialogResult.OK == dialog.ShowDialog())
            {
                filePath = dialog.FileName;
                ShowCardSearch();
            }
        }

        private void ValidateOkButton(object sender, KeyEventArgs e)
        {
            //Função que habilita o botão Ok caso os campos estejam preenchidos.
            BtnSearchCards.Enabled = false;

            TextBox[] inputOffset = new TextBox[2] {
                TxtStartOffset, TxtLastOffset
            };

            if ((inputOffset[0].Text.Length > 5) &&
                (inputOffset[1].Text.Length > 5))
            {
                BtnSearchCards.Enabled = true;
            }
        }
        private void ValidatesHexFields(object sender, KeyPressEventArgs e)
        {
            if (!Settings.HexLetters.Contains(e.KeyChar)) e.Handled = true;
        }
        private void MessageInfo(System.Drawing.Color color, string text)
        {
            lblMessageInfo.Text = text;
            lblMessageInfo.ForeColor = color;
        }

        private void ShowList()
        {
            //NEW CARDS
            lblNewCards.Visible = true;
            lListNewCards.Visible = true;
        }
        private void ShowCardSearch()
        {
            LblTitleSearchCards.Visible = true;
            LblStartOffset.Visible = true;
            LblLastOffset.Visible = true;
            TxtStartOffset.Visible = true;
            TxtLastOffset.Visible = true;

            LblStartOffset.Visible = true;
            LblLastOffset.Visible = true;
            TxtStartOffset.Visible = true;
            TxtLastOffset.Visible = true;

            // NEW CARDS
            LblTitleNewCard.Visible = true;
            LblStartOffsetNewCard.Visible = true;
            LblLastOffsetNewCard.Visible = true;
            TxtStartOffsetNewCard.Visible = true;
            TxtLastOffsetNewCard.Visible = true;
            BtnSearchNewCard.Visible = true;

            BtnSearchCards.Visible = true;
        }
        private void ShowResults()
        {
            lblResultTitle.Visible = true;
            LblOffset.Visible = true;
            LblCurrentPointer.Visible = true;
            LblCalculatedPointer.Visible = true;
            lblMessageInfo.Visible = true;
            TxtCalculatedPointer.Visible = true;
            TxtOffset.Visible = true;
            TxtCurrentPointer.Visible = true;
            BtnChangePointer.Visible = true;


            //NEW CARDS
            LblResultNewCard.Visible = true;
            LblOffsetNewCard.Visible = true;
            LblPointerCard.Visible = true;
            TxtOffsetNewCard.Visible = true;
            TxtPointerNewCard.Visible = true;
        }

        //REFATORADO
        private string GetCardOffset(int indexSelectedCard, int startOffset)
        {
            for (int i = 0; i < indexSelectedCard; i++)
            {
                startOffset += listCardName[i].Length + 1;
                for (int c = 0; c < Settings.ColorCode.Length; c++)
                {
                    if (listCardName[i].Substring(0, 2) == Settings.ColorCode[c])
                    {
                        startOffset++;
                    }
                }
            }

            calculatedPointer = cardController.GetCalculateSelectedCardPointer(startOffset);
            TxtCalculatedPointer.Text = calculatedPointer;

            return startOffset.ToString("X");
        }

        // Obter offset da lista de cartas novas.
        private string GetOffsetNewCard(int indexCardSelected, int startOffset)
        {
            for (int i = 0; i < indexCardSelected; i++)
            {
                startOffset += listNewCardName[i].Length + 1;
                for (int c = 0; c < Settings.ColorCode.Length; c++)
                {
                    if (listNewCardName[i].Substring(0, 2) == Settings.ColorCode[c])
                    {
                        startOffset++;
                    }
                }
            }

            calculatedPointerNewCard = newCardController.GetCalculateSelectedCardPointer(startOffset);
            TxtPointerNewCard.Text = calculatedPointer;

            return startOffset.ToString("X");
        }

        // REFATORADO!
        private void GetCardName(int startOffset, int lastOffset)
        {
            FileStream path = new(filePath, FileMode.OpenOrCreate);
            pathObtained = path;
            int sizeBytes = lastOffset;
            byte[] emptySpaces = new byte[sizeBytes];

            path.Seek(startOffset, SeekOrigin.Begin);

            while (path.Read(emptySpaces, 0, emptySpaces.Length) == sizeBytes)
            {
                IList cards = cardController.GetCardName(emptySpaces);
                
                listCardName = cardController.FillInCardNameListView(lListCardsView, cardController.FormatCardName(cards));

                break;
            }
            path.Close();
        }

        //teste
        private void GetCardNameNew(int offsetInicial, int offsetFinal)
        {
            FileStream path = new(filePath, FileMode.OpenOrCreate);
            pathObtainedNew = path;
            int sizeBytes = offsetFinal;
            byte[] emptySpaces = new byte[sizeBytes];

            path.Seek(offsetInicial, SeekOrigin.Begin);

            while (path.Read(emptySpaces, 0, emptySpaces.Length) == sizeBytes)
            {
                IList cards = newCardController.GetCardName(emptySpaces);

                listNewCardName = newCardController.FillInCardNameList(lListNewCards, cards);
                break;
            }
            path.Close();
        }

        // REFATORADO
        private void GetCardPointer()
        {
            cardsPointers = pointerController.GetPointerCard(filePath);

            ShowList();
            ShowResults();
        }

        public void SearchCurrentCards()
        {
            var startOffset = TxtStartOffset.Text;
            var lastOffset = TxtLastOffset.Text;

            var start = Convert.ToInt32(startOffset, 16);
            var size = Convert.ToInt32(lastOffset, 16) - start;
            GetCardName(start, Math.Abs(size));
        }
        public void SearchNewCards()
        {
            var startOffsetNewCard = TxtStartOffsetNewCard.Text;
            var lastOffsetNewCard = TxtLastOffsetNewCard.Text;

            var start = Convert.ToInt32(startOffsetNewCard, 16);
            var size = Convert.ToInt32(lastOffsetNewCard, 16) - start;
            GetCardNameNew(start, Math.Abs(size));
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchCurrentCards();
            SearchNewCards();
            GetCardPointer();
        }

        private void ListNewCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMessageInfo.Text = "";

            try
            {
                if (lListNewCards.SelectedItem != null)
                {
                    TxtOffsetNewCard.Text = GetOffsetNewCard(lListNewCards.SelectedIndex, Convert.ToInt32(TxtStartOffsetNewCard.Text, 16));
                    TxtPointerNewCard.Text = calculatedPointerNewCard;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void BtnChangePointer_Click(object sender, EventArgs e)
        {
            try
            {
                string firstByte = TxtCurrentPointer.Text.Substring(0, 2);
                string secondByte = TxtCurrentPointer.Text.Substring(2, 2);

                int offset = pointerController.GetOffsetPointerCard(lListCardsView);

                pointerController.ChangePointerCard(offset, firstByte, secondByte);
                cardsPointers[lListCardsView.SelectedIndices[0]] = firstByte + secondByte;

                MessageInfo(System.Drawing.Color.LimeGreen, $"Changed pointer!");
            }
            catch
            {
                MessageInfo(System.Drawing.Color.OrangeRed, $"Could not change pointer, please try again!");
            }
        }

        private void BtnSearchNewCard_Click(object sender, EventArgs e)
        {
            TxtCurrentPointer.Text = TxtPointerNewCard.Text;
            MessageInfo(System.Drawing.Color.LimeGreen, $"Replaced pointer!");
        }

        private void ListCardsView_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMessageInfo.Text = "";

            try
            {
                if (lListCardsView.SelectedItems.Count <= 0) return;

                int selectedIndex = lListCardsView.SelectedIndices[0];

                TxtOffset.Text = GetCardOffset(selectedIndex, Convert.ToInt32(TxtStartOffset.Text, 16));

                if(cardsPointers[selectedIndex] == null)
                {
                    MessageInfo(System.Drawing.Color.OrangeRed, "Unable to get the CURRENT card pointer. Check the given pointers.");
                    TxtCurrentPointer.ResetText();
                }

                TxtCurrentPointer.Text = "";
                for (int i = 0; i < cardsPointers.Length; i++)
                {
                    if (calculatedPointer == cardsPointers[i])
                         TxtCurrentPointer.Text = cardsPointers[i];
                    else
                        TxtCurrentPointer.Text = cardsPointers[selectedIndex];
                    
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception thrown in ListCardsView: {ex}");
                return;
            }
        }
        // ----- Fim -----
    }
}