using FactoryMethod.RealWorld.Products;

namespace FactoryMethod.RealWorld.Services
{
    class StudentHistoryService : HistoryService
    {
        public override IHistoryEvent CreateEvent()
        {
            return new StudentHistoryEvent();
        }
    }
}
