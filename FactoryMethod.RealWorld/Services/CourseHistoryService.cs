using FactoryMethod.RealWorld.Products;

namespace FactoryMethod.RealWorld.Services
{
    class CourseHistoryService : HistoryService
    {
        public override IHistoryEvent CreateEvent()
        {
            return new CourseHistoryEvent();
        }
    }
}