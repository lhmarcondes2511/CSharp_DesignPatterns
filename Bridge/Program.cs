using Bridge.Platforms;
using Bridge.Transmissions;
using System;

namespace Bridge
{
    class Program
    {
        static void StartLive(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            Live live = new Live(platform);

            live.Broadcasting();
            live.Result();
        }

        static void StartLiveAdvanced(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            AdvancedLive live = new AdvancedLive(platform);

            live.Broadcasting();
            live.Subtitle();
            live.Comments();
            live.Result();
        }

        static void StartLiveRecord(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            Record live = new Record(platform);

            live.Broadcasting();
            live.Subtitle();
            live.Comments();
            live.RecordLive();
            live.Result();
        }
        static void Main(string[] args)
        {

            StartLiveAdvanced(new Youtube());
            StartLive(new Facebook());
            StartLiveRecord(new TwitchTV());

            Console.ReadLine();
        }
    }
}
