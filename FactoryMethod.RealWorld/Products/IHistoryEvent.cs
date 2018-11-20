using FactoryMethod.RealWorld.DTOs;

namespace FactoryMethod.RealWorld.Products
{
    interface IHistoryEvent
    {
        EventHeader EventHeader { get; set; }
        string InsertRecord<THistoryData>(THistoryData historyData);
    }
}
