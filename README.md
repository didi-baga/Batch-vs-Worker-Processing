# Batch vs Worker Processing

## Overview

Simple project to play with batch and worker processing. Explore the difference in code and execution time using C#.

## Case of Study

The goal is to explore the following:

- Difference between two approaches 
- Application execution time difference 
- Code optimization 


## Sample Classes

Sample class ComplexCalculationSimulator contains operations to simulate batch and worker processing. 
**Note:** Sleep timer will simulate time-consuming operations.

ComplexCalculationSimulator class short description:

* **Properties**
    * List<int> _tasks - the complexity of a task is defined by seconds.
    * int _minTimeSec - the minimal complexity. 
    * int _maxTimeSec - the maximal complexity.
* **Methods**
    * GenerateTasks - Generates random numbers  between minTimeSec and maxTimeSec 
    * BatchProcessing - Represents Batch processing using threads
    * Workers - Individual worker processing. If one worker finishes work another worker is started.
    * SimulateTimeConsumingCalculations 

## Implementation 

Simulate time-consuming processes. For all test cases batch size and worker count equals 10, number of tasks equals 100. 
Complexity (time) distribution increases case by case.
    
* minTimeSec = 1 and maxTimeSec = 1 - the difference between approaches is minimal
* minTimeSec = 1 and maxTimeSec = 2 - the difference between approaches is minimal
* minTimeSec = 1 and maxTimeSec = 3 - the difference between approaches is around 20% 
* minTimeSec = 1 and maxTimeSec = 4 - the difference between approaches is around 20-30% 
* minTimeSec = 1 and maxTimeSec = 5 - the difference between approaches is around 30-40% 
* minTimeSec = 1 and maxTimeSec = 6 - the difference between approaches is around 40% 
* minTimeSec = 1 and maxTimeSec = 7 - the difference between approaches is around 40-45% 
* minTimeSec = 1 and maxTimeSec = 8 - the difference between approaches is around 40-50% 
* minTimeSec = 1 and maxTimeSec = 9 - the difference between approaches is around 40-50% 
* minTimeSec = 1 and maxTimeSec = 10 - the difference between approaches is around 45-55% 


### Output

Console output: 

>   ==================================================
>  100 tasks was generated between 1 and 1 seconds diapason
>  Batch processing execution Time: 10142 ms.
>  Batch size: 10
>  Individual worker processing execution Time: 9449 ms.
>  Worker count: 10
>  
>  
>   ==================================================
>  100 tasks was generated between 1 and 2 seconds diapason
>  Batch processing execution Time: 10128 ms.
>  Batch size: 10
>  Individual worker processing execution Time: 9484 ms.
>  Worker count: 10
>  
>  
>   ==================================================
>  100 tasks was generated between 1 and 3 seconds diapason
>  Batch processing execution Time: 20132 ms.
>  Batch size: 10
>  Individual worker processing execution Time: 15403 ms.
>  Worker count: 10
>  
>  
>   ==================================================
>  100 tasks was generated between 1 and 4 seconds diapason
>  Batch processing execution Time: 30166 ms.
>  Batch size: 10
>  Individual worker processing execution Time: 18288 ms.
>  Worker count: 10
>  
>  
>   ==================================================
>  100 tasks was generated between 1 and 5 seconds diapason
>  Batch processing execution Time: 40182 ms.
>  Batch size: 10
>  Individual worker processing execution Time: 24338 ms.
>  Worker count: 10
>  
>  
>   ==================================================
>  100 tasks was generated between 1 and 6 seconds diapason
>  Batch processing execution Time: 49118 ms.
>  Batch size: 10
>  Individual worker processing execution Time: 29318 ms.
>  Worker count: 10
>  
>  
>   ==================================================
>  100 tasks was generated between 1 and 7 seconds diapason
>  Batch processing execution Time: 58119 ms.
>  Batch size: 10
>  Individual worker processing execution Time: 33454 ms.
>  Worker count: 10
>  
>  
>   ==================================================
>  100 tasks was generated between 1 and 8 seconds diapason
>  Batch processing execution Time: 70078 ms.
>  Batch size: 10
>  Individual worker processing execution Time: 41332 ms.
>  Worker count: 10
>  
>  
>   ==================================================
>  100 tasks was generated between 1 and 9 seconds diapason
>  Batch processing execution Time: 77117 ms.
>  Batch size: 10
>  Individual worker processing execution Time: 38402 ms.
>  Worker count: 10
>  
>  
>   ==================================================
>  100 tasks was generated between 1 and 10 seconds diapason
>  Batch processing execution Time: 1098599 ms.
>  Batch size: 10
>  Individual worker processing execution Time: 49301 ms.
>  Worker count: 10
>  


## Conclusion

When complexity dispersions between different tasks increase or there are a large number of tasks use individual workers for more efficiency.
**Note:** In some cases using individual workers may increase code complexity.