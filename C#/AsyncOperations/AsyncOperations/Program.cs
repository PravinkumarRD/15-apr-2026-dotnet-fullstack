namespace AsyncOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Task Programming Main Thread Id is {Thread.CurrentThread.ManagedThreadId}!");
            //Task t1 = new Task(() => {
            //    Console.WriteLine($"Task - 1 started on Thread - {Thread.CurrentThread.ManagedThreadId}");
            //});
            //t1.Start();
            //Task.WaitAll(t1);
            //Task.Run(() =>
            //{
            //    Console.WriteLine($"Task - 1 started on Thread - {Thread.CurrentThread.ManagedThreadId}");
            //}).Wait();
            Task<int> t1 = new Task<int>(() =>
            {
                Console.WriteLine($"Task - 1 started on Thread - {Thread.CurrentThread.ManagedThreadId}");
                return 1000;
            });
            t1.Start();
            Console.WriteLine($"Task - 1 output value is {t1.Result}");
            t1.ContinueWith(value =>
            {
                Console.WriteLine($"Task - 1 Continuation started on Thread - {Thread.CurrentThread.ManagedThreadId}");
                Console.WriteLine($"Task continuation with 1000 points addition is {value.Result + 1000}");
            }).Wait();
            Task.WaitAll(t1);
            Console.WriteLine("End Of Program!");
        }
    }
}
