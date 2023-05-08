using AlteraPonteiro.Models;
using AlteraPonteiro.Shared;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlteraPonteiro.Services
{
    // Gets the name of the card and calculates pointers automatically.
    public class CardService
    {
        public CardModel cardModel = new();
        public CardShared cardShared = new();

        //Obtém o nome da carta.
        //Percorre o arquivo, obtém os bytes em hexadecimal, converte, junta e retorna o nome exato.
        public string[] GetCardName(byte[] emptySpaces)
        {
            cardModel.CardListName = cardShared.GetCardName(emptySpaces, cardModel.CardFullName, cardModel.CardListName);
            return cardModel.CardListName;
        }

        //remover...
        public string[] FillInCardNameList(ListBox iListCardsName, IList cards)
        {
            cardShared.FillInCardNameList(iListCardsName, cards);

            return cardModel.CardListName;
        }

        //Preenche a lista com o nome das cartas obtidas.
        public string[] FillInCardNameListView(ListView iListCardsName, IList cards)
        {
            cardShared.FillInCardNameListView(iListCardsName, cards);

            return cardModel.CardListName;
        }

        //Formata nome das cartas que contém código de cores. Ex: ln, li... antes do nome da carta.
        public IList FormatCardName(IList cards)
        {
            string listCardNameFormat = "";
            IList cardsNew = new List<string>();

            for (int i = 0; i < cards.Count; i++)
            {
                for (int c = 0; c < Settings.ColorCode.Length; c++)
                {
                    if (cards[i].ToString().Length <= 0) break; //Verifica se na lista vem vazio alguma posição

                    //Remove os códigos que representam as cores dos nomes das cartas
                    //Ex: lnBlue-Eyes White Dragon - ln = red, então remove o ln e deixa apenas o nome da carta.
                    if ((cards[i].ToString().Substring(0, 2)) == Settings.ColorCode[c])
                    {
                        listCardNameFormat = cards[i].ToString()[2..];
                        break;
                    }
                    listCardNameFormat = cards[i].ToString();
                }
                cardsNew.Add(listCardNameFormat);
            }
            return cardsNew;
        }
    }
}
