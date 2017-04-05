using System;
using System.Reflection;

namespace Ice.Reflection.Performance
{
    public class Program
    {
        private const long LoopTimes = 100000;
        static void Main(string[] args)
        {
            // Compare time to construct 1000 instance 
            var time = DateTime.Now;
            CreateInstanceByConstructor();
            Console.WriteLine($"Time elasped for {nameof(CreateInstanceByConstructor)}: {(DateTime.Now - time).TotalMilliseconds} ms");

            // By Reflection
            time = DateTime.Now;
            CreateInstanceByReflection();
            Console.WriteLine($"Time elasped for {nameof(CreateInstanceByReflection)}: {(DateTime.Now - time).TotalMilliseconds} ms");

        }
        private static void CreateInstanceByConstructor()
        {
            for (var i = 0L; i < LoopTimes; i++)
            {
                var item = new Item();
                item.UpdateModifiedDate();
            }
        }

        private static void CreateInstanceByReflection()
        {
            for (var i = 0L; i < LoopTimes; i++)
            {
                var instance = Activator.CreateInstance(typeof(Item));
                var methodInfo = typeof(Item).GetMethod("UpdateModifiedDate");
                methodInfo.Invoke(instance, null);
            }
        }
    }

    class Item
    {
        public string Id { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? LastModified { get; set; }

        public int SourceId { get; set; }
        public string Group { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string SaleType { get; set; }
        public string ListingType { get; set; }

        public void UpdateModifiedDate()
        {
            LastModified = DateTime.Now;
        }
    }
}
