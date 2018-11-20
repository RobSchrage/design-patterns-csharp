using FactoryMethod.RealWorld.DTOs;

namespace FactoryMethod.RealWorld.Products
{
    class CourseHistoryEvent : IHistoryEvent
    {
        public EventHeader EventHeader { get; set; }

        public string InsertRecord<TDataObject>(TDataObject dataObject)
        {
            var course = (Course)(object) dataObject;

            return "CourseHistoryEvent InsertRecord called with the following data: " + course.ToString();
        }

        public string DeleteRecord(int id)
        {
            return "CourseHistoryEvent: Deleted id " + id;
        }
    }
}