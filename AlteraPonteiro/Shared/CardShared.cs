using AlteraPonteiro.Models;
using System;
using System.Collections;
using System.Windows.Forms;

namespace AlteraPonteiro.Shared
{
    public class CardShared
    {
        public CardModel cardModel = new();
        public string[] GetName(byte[] emptySpaces, string cardFullName, string[] cardListName)
        {
            string currentSpace = BitConverter.ToString(emptySpaces);
            string[] byteHexCardName = currentSpace.Split("-");
            string hexCardNames = "";

            for (int b = 0; b < byteHexCardName.Length; b++)
            {
                for (int i = 0; i < 80; i++)
                {
                    if (Settings.CharacterTable[0, i] == byteHexCardName[b])
                    {
                        cardFullName += (Settings.CharacterTable[1, i]);
                        hexCardNames += byteHexCardName[b];
                    }
                }
                if (byteHexCardName[b] == "FF")
                {
                    cardListName = cardFullName.Split("[ENTER]");
                }
            }
            return cardListName;
        }
        public void FillInCardNameList(ListBox iListCardsName, IList cards)
        {
            int cardNumber = 1;

            foreach (string card in cards)
            {
                iListCardsName.Items.Add(cardNumber.ToString().PadLeft(3, '0') + " - " + card);
                cardNumber++;
            }

            int finalIndexList = cardNumber - 2;
            iListCardsName.Items.RemoveAt(finalIndexList);
        }

        public string GetCalculateSelectedCardPointer(int currentOffset)
        {
            var offsetAtual4UltimosDigitos = currentOffset.ToString("X").Substring(2, 4);
            var ponteiroCartaSelecionada = Convert.ToInt32(offsetAtual4UltimosDigitos, 16) - 2048;
            var resultadoCalculado = ponteiroCartaSelecionada.ToString("X");
            var ponteiroCalculado = resultadoCalculado.Substring(2, 2) + resultadoCalculado.Substring(0, 2);
            return ponteiroCalculado;
        }
    }
}
