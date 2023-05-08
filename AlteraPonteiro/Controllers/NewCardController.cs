using AlteraPonteiro.Services;
using AlteraPonteiro.Shared;
using System.Collections;
using System.Windows.Forms;

namespace AlteraPonteiro.Controllers
{
    public class NewCardController
    {
        public NewCardService cardService = new();
        public CardShared cardShared = new();
        public dynamic GetCardName(byte[] emptySpaces)
        {
            try
            {
                var cards = cardService.GetNewCardName(emptySpaces);
                if (cards == null) return "No card found.";

                return cards;
            }
            catch
            {
                return "Error getting card name.";
            }
        }

        public dynamic FillInCardNameList(ListBox iListCardsName, IList cards)
        {
            try
            {
                var cardsList = cardService.FillInNewCardNameList(iListCardsName, cards);
                if (cards == null) return "List of empty card.";

                return cardsList;
            }
            catch
            {
                return "Error returning card list.";
            }
        }
        public dynamic GetCalculateSelectedCardPointer(int currentOffset)
        {
            try
            {
                string pointerResult = cardShared.GetCalculateSelectedCardPointer(currentOffset);
                return pointerResult;
            }
            catch
            {
                return "Error returning calculated pointer.";
            }
        }
    }
}
