using System;
using FactoryMethod.RealWorld.DTOs;
using FactoryMethod.RealWorld.Services;

namespace FactoryMethod.RealWorld
{

    class Client
    {
        public void Main()
        {
            var eventHeader = new EventHeader();

            var student = new Student()
            {
                Name = "Grace Hopper",
                StartYear = 1952
            };

            var course = new Course()
            {
                Name = "Assembly Programming",
                Length = 40
            };


            var studentHistoryService = new StudentHistoryService();
            var studentHistoryResult = studentHistoryService.AddHistoryEvent(eventHeader, student);

            Console.WriteLine(studentHistoryResult);

            var courseHistoryService = new CourseHistoryService();
            var courseHistoryResult = courseHistoryService.AddHistoryEvent(eventHeader, course);

            Console.WriteLine(courseHistoryResult);
            Console.ReadLine();
        }

    }

    class Program
    {
        static void Main()
        {
            new Client().Main();
        }
    }
}
