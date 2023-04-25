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
        public dynamic GetOffsetPointerCard(string initialOffsetPointer, ListBox listaDeCartas)
        {
            try
            {
                int? currentOffsetPointer = pointerService.GetOffsetPointerCard(initialOffsetPointer, listaDeCartas);
                if (currentOffsetPointer == null) return "Offset não encontrado.";

                return currentOffsetPointer;
            }
            catch
            {
                return "Erro ao obter offset do ponteiro.";
            }
        }
    }
}
