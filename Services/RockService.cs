using System;
using System.Collections.Generic;
using Entities;
namespace Services{
    public class RockService : RockEntity
    {
        List<CientistService> Observers = new List<CientistService>();
        private float Temperature = 20;
        public void setTemperature(float Temp){
            this.Temperature = Temp;
            Console.WriteLine($"Mudando temperatura da pedra para ${Temp}");
            this.notifyObservers();
        }
        public void registerObserver(CientistService Obs){
            this.Observers.Add(Obs);
            
        }
        public void removeObserver(CientistService Obs){
            this.Observers.Remove(Obs);
        }
        public void notifyObservers(){
            foreach (var Observer in Observers)
            {
                Observer.update(this.Temperature);
            }
        }
    }
}