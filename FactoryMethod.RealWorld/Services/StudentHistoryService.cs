namespace FactoryMethod.RealWorld
{
    class StudentHistoryService : HistoryService
    {
        public override IHistoryEvent CreateEvent()
        {
            return new StudentHistoryEvent();
        }
    }
}
