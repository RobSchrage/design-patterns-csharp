namespace FactoryMethod.RealWorld
{
    abstract class HistoryService
    {
        public abstract IHistoryEvent CreateEvent();

        public string AddHistoryEvent<THistoryData>(EventHeader eventHeader, THistoryData historyData)
        {
            var historyEvent = CreateEvent();

            historyEvent.EventHeader = eventHeader;

            var result = "HistoryService: " + historyEvent.InsertRecord<THistoryData>(historyData);

            return result;
        }
    }
}
