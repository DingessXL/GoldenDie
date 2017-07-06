using System;
using System.Linq;
using System.Text;

public struct DiceGroup
{
    int size, number;
    int[] results;
    //constructor
    public DiceGroup(int size, int number)
    {
        this.size = size;
        this.number = number;
        results = new int[number];
    }

    //save dice rolls to results
    public void Roll()
    {
        Random r = new Random();
        for (int x=0; x<number-1; x++)
        {
            results[x] = r.Next(1, size + 1);
        }
    }

    //print information about dice roll
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("[");
        if ((results != null) && (!this.results.Any()))
        {
            sb.Append("{");
            foreach (var c in this.results)
            {
                sb.Append("," + c);
            }
            sb.Append("}");
        }
        sb.Append("]");

        return sb.ToString();
    }
    //add rolls together
    public int AddRolls()
    {
        int sum = 0;
        foreach(var c in results)
        {
            sum += c;
        }
        return sum;
    }
}