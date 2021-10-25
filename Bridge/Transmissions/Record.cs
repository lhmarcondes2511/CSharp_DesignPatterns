using Bridge.Platforms;
using System;

namespace Bridge.Transmissions
{
    class Record : AdvancedLive
    {
        public Record(IPlatform platform) : base(platform)
        {

        }

        public void RecordLive()
        {
            Console.WriteLine("Gravando a live");
        }
    }
}
