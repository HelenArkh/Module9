using System;
using System.Collections.Generic;
using System.Text;

namespace Module9
{
    public delegate void Notify();  // делегат
    class ProcessBusinessLogic
    {
        public event Notify ProcessCompleted; // событие

        public void StartProcess()
        {
            Console.WriteLine("Процесс начат!");
            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted() //protected virtual method
        {
            ProcessCompleted?.Invoke();
        }
    }
}
