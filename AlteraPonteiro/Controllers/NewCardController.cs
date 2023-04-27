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
                if (cards == null) return "Nenhuma carta encontrada.";

                return cards;
            }
            catch
            {
                return "Erro ao obter nome das cartas.";
            }
        }

        public dynamic FillInCardNameList(ListBox iListCardsName, IList cards)
        {
            try
            {
                var cardsList = cardService.FillInNewCardNameList(iListCardsName, cards);
                if (cards == null) return "Lista de cartas vazia.";

                return cardsList;
            }
            catch
            {
                return "Erro ao retornar lista de cartas";
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
                return "Erro ao retornar lista de cartas";
            }
        }
    }
}
