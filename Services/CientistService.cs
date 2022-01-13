using System;
using Entities;

namespace Services
{
    public class CientistService
    {
        private RockService Sub;
		
        public CientistService(RockService Sub){
            this.Sub = Sub;
            Sub.registerObserver(this);
        }
		
        public void update(float Sub){
            if(Sub >60){
                Console.WriteLine("Krl ta muito quente");
            }else{
                Console.WriteLine("Temperatura ta bao");
            }
        }
		
    }
}