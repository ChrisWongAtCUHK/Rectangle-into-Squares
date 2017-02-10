using System.Collections.Generic;
public class SqInRect
{

    public static List<int> sqInRect(int lng, int wdth)
    {
        if (lng == wdth) return null;

        List<int> squares = new List<int>();

        while (true)
        {
            // calculate the area
            int area = lng * wdth;

            // calculate the largest square
            int sqWdth = lng > wdth ? wdth : lng;
            squares.Add(sqWdth);

            // calculate the remaining area
            int remainingArea = area - sqWdth * sqWdth;

            // calculate the new lng and wdth
            if (lng == sqWdth)
            {
                wdth -= sqWdth;
            }
            else
            {
                lng -= sqWdth;
            }

            // final square
            if(lng == wdth)
            {
                squares.Add(lng);
                break;
            }
        }

        // do until lng and wdth are zero
        return squares;
    }
}

