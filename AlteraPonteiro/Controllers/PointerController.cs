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
                if (pointers == null) return "No found pointer.";

                return pointers;
            }
            catch
            {
                return "Error getting pointers.";
            }
        }
        public dynamic GetOffsetPointerCard(ListView listaDeCartas)
        {
            try
            {
                int? currentOffsetPointer = pointerService.GetOffsetPointerCard(listaDeCartas);
                if (currentOffsetPointer == null) return "No found offset.";

                return currentOffsetPointer;
            }
            catch
            {
                return "Error getting pointer offset.";
            }
        }

        public void ChangePointerCard(int offset, string firstValue, string secondValue)
        {
            pointerService.ChangePointerCard(offset, firstValue, secondValue);
        }
    }
}
