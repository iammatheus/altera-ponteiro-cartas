using AlteraPonteiro.Services;
using System.Collections;
using System.Windows.Forms;

namespace AlteraPonteiro.Controllers
{
    public class CardController
    {
        public CardService cardService = new();
        public dynamic GetNameCard(byte[] emptySpaces)
        {
            try
            {
                var cards = cardService.GetNameCard(emptySpaces);
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
                var cardsList = cardService.FillInCardNameList(iListCardsName, cards);
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
                string pointerResult = cardService.GetCalculateSelectedCardPointer(currentOffset);
                return pointerResult;
            }
            catch
            {
                return "Erro ao retornar lista de cartas";
            }
        }
    }
}
