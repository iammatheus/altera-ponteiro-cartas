using AlteraPonteiro.Models;
using AlteraPonteiro.Shared;
using System;
using System.Collections;
using System.Windows.Forms;

namespace AlteraPonteiro.Services
{
    // Gets the name of the card and calculates pointers automatically.
    public class CardService
    {
        public CardModel cardModel = new();
        public CardShared cardShared = new();
        public string[] GetCardName(byte[] emptySpaces)
        {
            cardModel.CardListName = cardShared.GetName(emptySpaces, cardModel.CardFullName, cardModel.CardListName);
            return cardModel.CardListName;
        }

        public string[] FillInCardNameList(ListBox iListCardsName, IList cards)
        {
            cardShared.FillInCardNameList(iListCardsName, cards);

            return cardModel.CardListName;
        }
    }
}
