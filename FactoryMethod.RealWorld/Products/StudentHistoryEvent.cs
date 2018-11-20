using FactoryMethod.RealWorld.DTOs;

namespace FactoryMethod.RealWorld.Products
{
    class StudentHistoryEvent : IHistoryEvent
    {
        public EventHeader EventHeader { get; set; }

        public string InsertRecord<TDataObject>(TDataObject dataObject)
        {
            var student = (Student)(object) dataObject;

            return "StudentHistoryEvent with the following data: " + student.ToString();
        }
    }
}