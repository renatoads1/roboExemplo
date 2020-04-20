using System;
using AutoIt;

namespace autoit2
{
    class Program
    {
        static void Main(string[] args)
        {
            //pega a posição do mause
            int x = AutoItX.MouseGetPos().X;
            int y = AutoItX.MouseGetPos().Y;
            Console.WriteLine("x");
            Console.WriteLine(x.ToString());
            Console.WriteLine("y");
            Console.WriteLine(y.ToString());
            //move o mause
            AutoItX.MouseMove(540, 752, 3);
            AutoItX.MouseClick("LEFT",540,752, 1);
            AutoItX.ProcessWait(null, 10);
            //AutoItX.Sleep(30000);

            //clica no brauser
            AutoItX.MouseMove(843,56, 3);
            AutoItX.MouseClick("LEFT", 843, 56, 1);
            

            Console.WriteLine("esperando");

            //da uma pausa
            AutoItX.ProcessWait(null,3);
            Console.WriteLine("feito");
            
            AutoItX.MouseMove(689, 61,3);
            AutoItX.MouseClick("LEFT",689,61,1);
            AutoItX.Send("http://www.realsis.com.br/teste");
            AutoItX.ProcessWait(null,3);
            AutoItX.Send("{BACKSPACE}");
            AutoItX.Send("{BACKSPACE}");
            AutoItX.Send("{BACKSPACE}");
            AutoItX.Send("{BACKSPACE}");
            AutoItX.Send("{BACKSPACE}");
            AutoItX.Send("{BACKSPACE}");
            AutoItX.ProcessWait(null, 3);
            AutoItX.Send("{ENTER}");
            AutoItX.ProcessWait(null, 7);
            //click do mouse
            AutoItX.MouseClick("LEFT", 689, 61, 1);
            //copiar
            AutoItX.Send("^c");
            AutoItX.ProcessWait(null,3);
            //botão do windows
            AutoItX.Send("{LWIN}");
            AutoItX.ProcessWait(null, 2);
            AutoItX.Send("bloco");
            AutoItX.ProcessWait(null, 2);
            AutoItX.Send("{ENTER}");
            AutoItX.ProcessWait(null, 3);
            //colar
            AutoItX.Send("^v");

        }

    }
}
