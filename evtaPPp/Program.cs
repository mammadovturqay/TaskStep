

////public class Point
////{
////    private int x;
////    private int y;


////    public Point()
////    {
////        x = 0;
////        y = 0;
////    }


////    public Point(int xValue, int yValue)
////    {
////        x = xValue;
////        y = yValue;
////    }


////    public void ShowData()
////    {
////        Console.WriteLine($"x: {x}, y: {y}");
////    }
////}

////class Program
////{
////    static void Main(string[] args)
////    {
////        Point c = new Point(0, 100); 
////        c.ShowData(); 
////    }
////}



//public class Counter
//{
//    private int min;
//    private int max;
//    private int currentData;

//    public Counter(int minValue, int maxValue)
//    {
//        min = minValue;
//        max = maxValue;
//        currentData = min;
//    }

//    public void Increment()
//    {
//        if (currentData < max)
//        {
//            Console.WriteLine("+++");

//            currentData++;
//        }
//    }

//    public int GetCurrent()
//    {
//        return currentData;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Counter c = new Counter(0, 100); 
//        c.Increment();
//        Console.WriteLine(c.GetCurrent()); 
//        c.Increment();
//        Console.WriteLine(c.GetCurrent()); 
//    }
//}


//using System;

//public class WaterCounter
//{
//    private int min;
//    private int max;
//    private int nowCounter;

//    public WaterCounter(int minC, int maxC)
//    {
//        min = minC;
//        max = maxC;
//        nowCounter = min;
//    }

//    public WaterCounter(int min, int max, int nowCounter)
//    {
//        this.min = min;
//        this.max = max;
//        this.nowCounter = nowCounter;
//    }

//    public void AddCount()
//    {
//        if (nowCounter < max)
//        {
//            nowCounter++;
//        }
//        else
//        {
//            nowCounter = min;
//        }
//    }

//    public int nowWaterGet()
//    {
//        return nowCounter;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
         
//            WaterCounter s = new WaterCounter(0, 3); 
//        do
//        {

//            s.AddCount();
//            Thread.Sleep(2000);
//            Console.WriteLine(s.nowWaterGet());
//            s.AddCount();
//            Thread.Sleep(2000);
//            Console.WriteLine(s.nowWaterGet()); 
//            s.AddCount();
//            Thread.Sleep(2000);
//            Console.WriteLine(s.nowWaterGet()); 
//            s.AddCount();
//            Thread.Sleep(2000);
//            Console.WriteLine(s.nowWaterGet()); 
//            s.AddCount();
//            Thread.Sleep(2000);
//            Console.WriteLine(s.nowWaterGet()); 
//        } while (true);
//    }
//}

