using System;

namespace _20180327_Task1_SheBear
{
    class BearsLair
    {
        static Random random = new Random();

        // Формируем берлогу из медведей (от 1 до 5)
        Bear[] bearType = new Bear[random.Next(1, 6)]; 

        // Типы медведей в берлоге генерируем с помощью метода GenerateBearType();
        public BearsLair(SheBear sheBear)
        {
            for (int i = 0; i < bearType.Length; i++)
            {
                bearType[i] = GenerateBearType();
                sheBear.SpeakToBearMan += bearType[i].Bear_Handler;   // Присоединение медведям обработчика событий.
            }
        }

        // Метод, генерирующий случайным образом тип медведя
        private Bear GenerateBearType()
        {
            switch (random.Next(1, 4))
            {
                case 1: return new CowardBear();   // Создаем Трусливого медведя
                case 2: return new BraveBear();    // Создаем Храброго медведя
                default: return new SweetBear();   // Создаем Сладкого медведя
            }
        }

        // Метод, показывающий какие медведи находятся в берлоге
        public void BearBehavior()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Состав берлоги:");
            Console.ForegroundColor = ConsoleColor.Gray;

            foreach (Bear unit in bearType)
            {
                unit.BearBehavior();
            }
        }
    }
}