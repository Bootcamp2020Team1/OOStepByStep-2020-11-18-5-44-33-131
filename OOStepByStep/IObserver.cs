using System;
using System.Collections.Generic;
using System.Text;

namespace OOStepByStep
{
    public interface IObserver
    {
        void Update(ISubject subject)
    }
}
