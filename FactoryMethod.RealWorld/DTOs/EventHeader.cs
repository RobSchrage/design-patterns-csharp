using System;

namespace FactoryMethod.RealWorld.DTOs
{
    class EventHeader
    {
        public string EventType { get; set; }
        public string ChangeUser { get; set; }
        public DateTime ChangeDate { get; set; }
    }
}