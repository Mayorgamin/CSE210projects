using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ExerciseTracking Program\n");
        // Instances of activities
        Running run = new Running("21 Feb 2025", 30, 5.0f);     // Expected output: 21 Feb 2025 Running (30 min) - Distance: 5.00 km, Speed: 10.00 kph, Pace: 6.00 min per km
        Cycling cycle = new Cycling("20 Feb 2025", 45, 20.0f);  // Expected output: 20 Feb 2025 Cycling (45 min) - Distance: 15.00 km, Speed: 20.00 kph, Pace: 3.00 min per km
        Swimming swim = new Swimming("19 Feb 2025", 25, 45);    // Expected output: 19 Feb 2025 Swimming (25 min) - Distance: 2.25 km, Speed: 5.40 kph, Pace: 11.11 min per km

        // Stores activities in a list
        List<Activity> activities = new List<Activity>{run, cycle, swim};
        // Loops through activities and displays the respective summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}