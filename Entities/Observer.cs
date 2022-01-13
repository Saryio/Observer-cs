using System;

namespace Entities
{
    public interface IObserver
    {
        public void update(RockEntity Sub);
    }
}