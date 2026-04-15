using System;

public class ApplesAndOranges
{
    // `s` and `t` = house
    // `a` = apple tree
    // `b` = orange tree
    private int s, t, a, b;
    public string collection { get; set; }
    public ApplesAndOranges(int s = 1, int t = 1, int a = 2, int b = 2, string collection = "Hackerrank/ApplesAndOranges/apples-and-oranges-collection.txt")
    {
        this.s  = s;
        this.t = t;
        this.a = a;
        this.b = b;
        this.collection = collection;
    }

    public void Result()
    {
        var s = ExtractFromList(this.s)[0];
        var t = ExtractFromList(this.t)[1];
        var a = ExtractFromList(this.a)[0];
        var b = ExtractFromList(this.b)[1];      
        var apples = ExtractFromList(4);
        var oranges = ExtractFromList(5);

        countApplesAndOranges(s, t, a, b, apples, oranges);
    }
    /// <summary>
    /// this is the function that you can use in the hackerrank Apples and  Oranges problem
    /// </summary>
    /// <param name="s">house starting point</param>
    /// <param name="t">house ending point</param>
    /// <param name="a">apple tree position</param>
    /// <param name="b">orange tree position</param>
    /// <param name="apples">list of apples that fell on the ground</param>
    /// <param name="oranges">list of oranges that fell on the ground</param>
    public void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        var orangeCount = apples.Where(x => (x + a >= s && x + a <= t)).Count();
        var applesCount = oranges.Where(x => (x + b >= s && x + b <= t)).Count();
        Console.WriteLine(orangeCount);
        Console.WriteLine(applesCount);
    }

    private List<int> ExtractFromList(int targetLine)
    {
        var result = File.ReadLines(collection).Where(line => !string.IsNullOrEmpty(line)).Skip(targetLine-1).First();
        return ConvertToInteger(result);
    }

    private List<int> ConvertToInteger(string str)
    {
        var collection = str.Split(" ");

        var result = new List<int>();
        foreach(var n in collection)
        {
            if(int.TryParse(n, out int converted))
                result.Add(converted);
            else
                throw new Exception("Invalid input");
        }
        return result;
    }
}