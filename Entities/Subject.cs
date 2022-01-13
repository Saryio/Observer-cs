using System;
using Services;

namespace Entities
{
    public interface ISubject
    {
        public void registerObserver(CientistService Obs);
        public void removeObserver(CientistService Obs);
        public void notifyObservers();
    }
}