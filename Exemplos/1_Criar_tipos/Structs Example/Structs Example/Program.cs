



using System;

namespace Struct_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Poss�vel ter construtor com parametros...
            Mark m = new Mark(6,7);
            m.Dothis();

            //Se n�o colocar new, tem que inicializar variaveis...
            Mark m2;
            m2.x = 3;
            m2.y = 12;
            m2.Dothis();
        }
    }

    public struct Mark
    {
        public int x;
        public int y;

        public Mark(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Dothis()
        {
            Console.WriteLine(x + y);
            Console.ReadLine();
        }
    }


}