using Batch_VS_Workers;

ComplexCalculationSimulator calculationSimulator = new ComplexCalculationSimulator();

Console.WriteLine(" ================================================== ");

calculationSimulator.GenerateTasks(1, 1, 100);

calculationSimulator.BatchProcessing(10);
calculationSimulator.Workers(10);

Console.WriteLine("\n");
Console.WriteLine(" ================================================== ");

calculationSimulator.GenerateTasks(1, 2, 100);

calculationSimulator.BatchProcessing(10);
calculationSimulator.Workers(10);

Console.WriteLine("\n");
Console.WriteLine(" ================================================== ");

calculationSimulator.GenerateTasks(1, 3, 100);

calculationSimulator.BatchProcessing(10);
calculationSimulator.Workers(10);

Console.WriteLine("\n");
Console.WriteLine(" ================================================== ");

calculationSimulator.GenerateTasks(1, 4, 100);

calculationSimulator.BatchProcessing(10);
calculationSimulator.Workers(10);

Console.WriteLine("\n");
Console.WriteLine(" ================================================== ");

calculationSimulator.GenerateTasks(1, 5, 100);

calculationSimulator.BatchProcessing(10);
calculationSimulator.Workers(10);

Console.WriteLine("\n");
Console.WriteLine(" ================================================== ");

calculationSimulator.GenerateTasks(1, 6, 100);

calculationSimulator.BatchProcessing(10);
calculationSimulator.Workers(10);

Console.WriteLine("\n");
Console.WriteLine(" ================================================== ");

calculationSimulator.GenerateTasks(1, 7, 100);

calculationSimulator.BatchProcessing(10);
calculationSimulator.Workers(10);

Console.WriteLine("\n");
Console.WriteLine(" ================================================== ");

calculationSimulator.GenerateTasks(1, 8, 100);

calculationSimulator.BatchProcessing(10);
calculationSimulator.Workers(10);

Console.WriteLine("\n");
Console.WriteLine(" ================================================== ");

calculationSimulator.GenerateTasks(1, 9, 100);

calculationSimulator.BatchProcessing(10);
calculationSimulator.Workers(10);

Console.WriteLine("\n");
Console.WriteLine(" ================================================== ");

calculationSimulator.GenerateTasks(1, 10, 100);

calculationSimulator.BatchProcessing(10);
calculationSimulator.Workers(10);

Console.ReadLine();