using AlteraPonteiro.Services;
using AlteraPonteiro.Shared;
using System;
using System.Collections;
using System.Windows.Forms;

namespace AlteraPonteiro.Controllers
{
    public class CardController
    {
        public CardService cardService = new();
        public CardShared cardShared = new();

        //Obtém o nome da carta.
        //Percorre o arquivo, obtém os bytes em hexadecimal, converte, junta e retorna o nome exato.
        public dynamic GetCardName(byte[] emptySpaces)
        {
            try
            {
                var cards = cardService.GetCardName(emptySpaces);
                if (cards == null) return "No found card.";

                return cards;
            }
            catch
            {
                return "Error getting card name.";
            }
        }

        //todo - remover...
        public dynamic FillInCardNameList(ListBox iListCardsName, IList cards)
        {
            try
            {
                var cardsList = cardService.FillInCardNameList(iListCardsName, cards);
                if (cards == null) return "List of empty card.";

                return cardsList;
            }
            catch
            {
                return "Error returning card list.";
            }
        }

        //Preenche a lista com o nome das cartas obtidas.
        public dynamic FillInCardNameListView(ListView iListCardsName, IList cards)
        {
            try
            {
                var cardsList = cardService.FillInCardNameListView(iListCardsName, cards);
                if (cards == null) return "List of empty card.";

                return cardsList;
            }
            catch
            {
                return $"Error returning card list.";
            }
        }

        //Calcula o ponteiro da carta selecionada.
        //Obtém os 2 últimos bytes do offset da carta, calcula e retorna o ponteiro exato.
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

        //Formata nome das cartas que contém código de cores. Ex: ln, li... antes do nome da carta.
        public dynamic FormatCardName(IList cards)
        {
            try
            {
                var cardsFormat = cardService.FormatCardName(cards);
                return cardsFormat;
            }
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
                return "Error when trying to format card name.";
            }
        }
    } 
}
