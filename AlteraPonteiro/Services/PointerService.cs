using AlteraPonteiro.Models;
using System;
using System.IO;
using System.Windows.Forms;

namespace AlteraPonteiro.Services
{
    public class PointerService
    {
        public FileStream pointerPath;
        public FileStream pointerPathObtained;
        public PointerModel pointerModel = new();
        public int startOffsetPointer = 1859586; // hex: 1C6002
        public int lastOffsetPointer = 1444; // hex: 1C65A6

        //Obtém os ponteiros de todas as 722 cartas do jogo.
        public dynamic GetPointer(string archivePath)
        {
            pointerPath = new(archivePath, FileMode.OpenOrCreate);
            pointerPathObtained = pointerPath;
            int byteSize = lastOffsetPointer;
            byte[] emptySpaces = new byte[byteSize];

            pointerPath.Seek(startOffsetPointer, SeekOrigin.Begin);
            while (pointerPath.Read(emptySpaces, 0, emptySpaces.Length) == byteSize)
            {
                string currentSpace = BitConverter.ToString(emptySpaces);
                string[] byteHexPonteiros = currentSpace.Split("-");
                int controlByte = 0;
                int controlOf722 = byteSize / 2;

                for (int i = 0; i < controlOf722; i++) // Will loop through 722 to get all pointers.
                {
                    for (int j = 0; j < 2; j++) // It will go through every 2 bytes to get the pointer. -> 0160, 2244
                    {
                        if (j > 0)
                            controlByte += 1;
                        else if (controlByte > 0)
                            controlByte += 1;

                        pointerModel.GroupPointers[i] += byteHexPonteiros[controlByte];
                    }
                }
                break;
            }
            return pointerModel.GroupPointers;
        }

        //Obtém o offset do ponteiro da carta selecionada.
        public int GetOffsetPointerCard(ListView listaDeCartas)
        {
            int currentOffset = Convert.ToInt32("1C6002", 16);
            for (int i = 0; i < listaDeCartas.SelectedIndices[0]; i++)
            {
                currentOffset += 2;
            }
            return currentOffset;
        }

        //Altera o ponteiro da carta, padão 2bytes = 0160.
        public void ChangePointerCard(int offset, string firstValue, string secondValue)
        {
            pointerPathObtained.Seek(offset, SeekOrigin.Begin);
            pointerPathObtained.WriteByte(Convert.ToByte(firstValue, 16));

            pointerPathObtained.Seek(offset + 1, SeekOrigin.Begin);
            pointerPathObtained.WriteByte(Convert.ToByte(secondValue, 16));

            pointerPathObtained.Flush();
        }
    }
}
