namespace Batch_VS_Workers
{
    public class ComplexCalculationSimulator
    {
        // _tasks value holds time in seconds needed for simulated calculations
        private List<int> _tasks;

        private int _minTimeSec;
        private int _maxTimeSec;

        public ComplexCalculationSimulator()
        {
            _tasks = new List<int>();
        }

        public void GenerateTasks(int minTimeSec = 1, int maxTimeSec = 10, int totalTasks = 100)
        {
            _tasks.Clear();
            var rand = new Random();

            for (int i = 0; i < totalTasks; i++)
            {
                _tasks.Add(rand.Next(minTimeSec, maxTimeSec));
            }

            Console.WriteLine("{0} tasks was generated between {1} and {2} seconds diapason", totalTasks, minTimeSec, maxTimeSec);
        }

        /// <summary>
        /// Represents Batch processing using threads
        /// </summary>
        /// <param name="batchSize"></param>
        public void BatchProcessing(int batchSize = 10)
        {
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();

            int i = 0;
            List<Thread> processes = new List<Thread>();

            while (i < _tasks.Count) 
            {
                // initialize threads 
                processes.Clear(); 
                for (int j = 0; j < Math.Min(batchSize, _tasks.Count - i); j++)
                {
                    processes.Add(new Thread(SimulateTimeConsumingCalculations));
                }

                // run threads 
                for (int j = 0; j < processes.Count; j++)
                {
                    processes[j].Start(_tasks[i]);
                    i++;
                }

                // wait to finish
                for (int j = 0; j < processes.Count; j++)
                {
                    processes[j].Join();
                }
            }

            watch.Stop();
            Console.WriteLine("Batch processing execution Time: {0} ms. \nBatch size: {1}", watch.ElapsedMilliseconds, batchSize);
        }

        /// <summary>
        /// Individual worker processing. If one worker finishes work another worker is started.
        /// </summary>
        /// <param name="WorkersCount"></param>
        public void Workers(int workerCount = 10)
        {
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();

            int i = 0;
            List<Thread> processes = new List<Thread>();
            while (i < _tasks.Count)
            {
                // initialize thread 
                for (int j = 0; j < workerCount - processes.Count; j++)
                {
                    processes.Add(new Thread(SimulateTimeConsumingCalculations));
                    processes.Last().Start(_tasks[i]);
                    i++;
                }
                
                for (int j = 0; j < processes.Count; j++)
                {
                    if (processes[j].IsAlive == false)
                    {
                        processes.RemoveAt(j);
                    }
                }

                Thread.Sleep(1);
            }

            watch.Stop();
            Console.WriteLine("Individual worker processing execution Time: {0} ms. \nWorker count: {1}", watch.ElapsedMilliseconds, workerCount);
        }

        public void SimulateTimeConsumingCalculations(object obj)
        {
            int sleepSec = (int)obj;

            Thread.Sleep(sleepSec * 1000);
        }
    }   
}
