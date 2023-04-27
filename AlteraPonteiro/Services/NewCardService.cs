using AlteraPonteiro.Models;
using AlteraPonteiro.Shared;
using System.Collections;
using System.Windows.Forms;

namespace AlteraPonteiro.Services
{
    public class NewCardService
    {
        public NewCardModel newCardModel = new();
        public CardShared cardShared = new();

        public string[] GetNewCardName(byte[] emptySpaces)
        {
            newCardModel.ListNewCardName = cardShared.GetName(emptySpaces, newCardModel.NewCardFullName, newCardModel.ListNewCardName);
            return newCardModel.ListNewCardName;
        }
        public string[] FillInNewCardNameList(ListBox iListCardsName, IList cards)
        {
            cardShared.FillInCardNameList(iListCardsName, cards);

            return newCardModel.ListNewCardName;
        }
    }
}
