using System;

// https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/events/

/* Write “She Bear” class. It has an event “Speak to Bear Man”.
 * In order to represent bear-man behavior it is necessary to implement the next hierarchy of classes. 
 * Base class “Bear” has several inheritors, namely “Coward Bear”, “Brave Bear”, and “Sweet Bear”. 
 * The main difference for different types of bears is reaction on event “Speak to Bear Man”.
 * - “Coward Bear” hugs Bear woman.
 * - “Brave Bear” present to Bear Woman flowers.
 * - “Sweet Bear” presents barrel of honey to her.
 * Write the next program: Instantiate the object of class “She Bear”.
 * Instantiate a collection of different bears. Choose the length of collection and the type of every Bear in it randomly.
 * When occurs an event “Speak to Bear Man” every Bear react to this event according to behavior, described before.
 * Show this behavior by means of corresponding message. 
 * 
 * Напишите класс “Медведица”. У которого есть событие, “Поговори с медведем”.
 * Чтобы представить поведение медведя, необходимо реализовать следующую иерархию классов. 
 * Базовый класс «Медведь» имеет несколько наследников, а именно, “Трусливый Медведь”, “Храбрый Медведь” и “ Сладкий Медведь”. 
 * Основное различие для различных типов медведей - реакция на событие “Поговори с медведем”.
 * - “Трусливый Медведь” обнимает Медведицу.
 * - “Храбрый Медведь” дарит цветы Медведице.
 * - “Сладкий медведь” дарит ей бочку меда.
 * Напишите следующую программу: Создайте объект класса «Медведица».
 * Создайте коллекцию разных медведей. Выберите длину коллекции и тип каждого медведя в ней случайным образом.
 * Когда происходит, событие “Поговори с медведем” каждый Медведь, реагируют на это событие согласно поведению, описанному ранее. 
 * Покажите это поведение посредством соответствующего сообщения. */

namespace _20180327_Task1_SheBear
{
    class Program
    {
        static void Main()
        {
            SheBear sheBear = new SheBear();                // Создаем Медведицу

            BearsLair bearsLair = new BearsLair(sheBear);   // Создаем Берлогу
            bearsLair.BearBehavior();                       // Получаем информацию о типах медведей в берлоге

            sheBear.StartSpeakEvent();                      // Запуск метода обработчика события.

            Console.ReadKey();
        }
    }
}