using System.Timers;
using Timer = System.Timers.Timer;

public class Car
{
    int speed = 0;

    public event TooFast TooFastDriving;

    public delegate void TooFast(int speed);

    //private TooFast tooFast;
    public void Start()
    {
        speed = 10;
    }
    public void Accelerate()
    {
        speed += 10;

        if(speed > 80)
        {
            if (TooFastDriving != null)
            {
                //tooFast(speed);
                TooFastDriving(speed);
            }
        }
    }

    public void Stop()
    {
        speed = 0;
    }

    //public void RegistOnFast(TooFast tooFast)
    //{
    //    this.tooFast += tooFast; 
    //}
    //public void UnregisterFast(TooFast tooFast)
    //{
    //   this.tooFast -= tooFast;
    //}
}

class Program
{
    static Car car;
    static void Main(string[] args)
    {
        Timer timer = new Timer();
        timer.Elapsed += Timer_Elapsed;

        timer.Interval = 5000;
        timer.Start();

        Console.ReadLine();
        
        car = new Car();

        car.TooFastDriving += CareOnFast;
        car.TooFastDriving += CareOnFast;
        //car.RegistOnFast(CareOnFast);
        //car.RegistOnFast(CareOnFast);

        car.TooFastDriving -= CareOnFast;
        //car.UnregisterFast(CareOnFast);
        car.Start();
        for(int i = 0; i<10; i++)
        {
            car.Accelerate();
        }
        
    }

    private static void Timer_Elapsed(object? sender, ElapsedEventArgs e)
    {
        Console.WriteLine("Work Elapsed.");
        Console.WriteLine("Use enter to enable");
    }

    private static void CareOnFast(int speed)
    {
        Console.WriteLine($"Your car is too fast I stop it....{speed}");
        car.Stop();
    }
}