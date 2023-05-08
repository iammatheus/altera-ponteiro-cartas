using AlteraPonteiro.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlteraPonteiro.Shared
{
    public class CardShared
    {
        public CardModel cardModel = new();

        //Obtém o nome da carta.
        //Percorre o arquivo, obtém os bytes em hexadecimal, converte, junta e retorna o nome exato.
        public string[] GetCardName(byte[] emptySpaces, string cardFullName, string[] cardListName)
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

        //todo - remover função e substituir para a nova listview
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

        //Calcula o ponteiro da carta selecionada.
        //Obtém os 2 últimos bytes do offset da carta, calcula e retorna o ponteiro exato.
        public string GetCalculateSelectedCardPointer(int currentOffset)
        {
            var offsetAtual4UltimosDigitos = currentOffset.ToString("X").Substring(2, 4);
            var ponteiroCartaSelecionada = Convert.ToInt32(offsetAtual4UltimosDigitos, 16) - 2048;
            var resultadoCalculado = ponteiroCartaSelecionada.ToString("X");
            var ponteiroCalculado = resultadoCalculado.Substring(2, 2) + resultadoCalculado.Substring(0, 2);
            return ponteiroCalculado;
        }

        //Preenche a lista com o nome das cartas obtidas.
        public void FillInCardNameListView(ListView iListCardsName, IList cards)
        {
            int cardNumber = 1;
            
            for (int count = 0; count < cards.Count; count++)
            {
                ListViewItem listItem = new(cardNumber.ToString().PadLeft(3, '0'));
                listItem.SubItems.Add(cards[count].ToString());
                iListCardsName.Items.Add(listItem);
                cardNumber++;
            }

            int finalIndexList = cardNumber - 2;
            iListCardsName.Items.RemoveAt(finalIndexList);
        }
    }
}