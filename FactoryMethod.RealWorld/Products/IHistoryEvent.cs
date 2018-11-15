namespace FactoryMethod.RealWorld
{
    interface IHistoryEvent
    {
        EventHeader EventHeader { get; set; }
        string InsertRecord<THistoryData>(THistoryData historyData);
    }
}
