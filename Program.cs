using System;

namespace DigitalClock
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockPublisher clockPublisher = new ClockPublisher();
            ClockSubcriber clockSubscriber = new ClockSubcriber();
            clockSubscriber.Subscribe(clockPublisher);

            clockPublisher.Run();
        }
            
    }
}
