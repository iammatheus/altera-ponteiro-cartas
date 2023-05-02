using AlteraPonteiro.Services;
using System.Windows.Forms;

namespace AlteraPonteiro.Controllers
{
    public class PointerController
    {
        public PointerService pointerService = new();
        public dynamic GetPointerCard(string archivePath)
        {
            try
            {
                string[] pointers = pointerService.GetPointer(archivePath);
                if (pointers == null) return "Nenhum ponteiro obtido.";

                return pointers;
            }
            catch
            {
                return "Erro ao obter ponteiros.";
            }
        }
        public dynamic GetOffsetPointerCard(ListBox listaDeCartas)
        {
            try
            {
                int? currentOffsetPointer = pointerService.GetOffsetPointerCard(listaDeCartas);
                if (currentOffsetPointer == null) return "Offset não encontrado.";

                return currentOffsetPointer;
            }
            catch
            {
                return "Erro ao obter offset do ponteiro.";
            }
        }

        public void ChangePointerCard(int offset, string firstValue, string secondValue)
        {
            pointerService.ChangePointerCard(offset, firstValue, secondValue);
        }
    }
}
