using System;

namespace _20180327_Task1_SheBear
{
    class Bear
    {
        public virtual void BearBehavior()
        {
            Console.WriteLine("Неопределенный тип медведя.");
        }

        public virtual void Bear_Handler()
        {
            Console.WriteLine("Handler - Поведение медведя не определено.");
        }
    }

    class CowardBear : Bear
    {
        public override void BearBehavior()
        {
            Console.WriteLine("CowardBear");
        }

        public override void Bear_Handler()
        {
            Console.WriteLine("Трусливый медведь обнимает медведицу.");
        }
    }

    class BraveBear : Bear
    {
        public override void BearBehavior()
        {
            Console.WriteLine("BraveBear");
        }

        public override void Bear_Handler()
        {
            Console.WriteLine("Храбрый медведь дарит цветы медведице.");
        }
    }

    class SweetBear : Bear
    {
        public override void BearBehavior()
        {
            Console.WriteLine("SweetBear");
        }

        public override void Bear_Handler()
        {
            Console.WriteLine("Сладкий медведь дарит медведице бочку меда.");
        }
    }
}