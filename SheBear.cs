using System;

namespace _20180327_Task1_SheBear
{
    public delegate void EventDelegate();

    class SheBear
    {
        public event EventDelegate SpeakToBearMan = null;

        public void StartSpeakEvent()
        {
            if (SpeakToBearMan != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nМедведица начала разговор с медведями.\n");
                Console.ForegroundColor = ConsoleColor.Gray;
                SpeakToBearMan.Invoke();
            }
        }
    }
}