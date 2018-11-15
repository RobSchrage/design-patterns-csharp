namespace FactoryMethod.RealWorld
{
    class CourseHistoryService : HistoryService
    {
        public override IHistoryEvent CreateEvent()
        {
            return new CourseHistoryEvent();
        }
    }
}