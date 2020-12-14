public static bool IsCorrectMove(string from, string to)
    {
        if (from == to)
            return false;

        int from1 = Convert.ToInt32(from[0]);
        int from2 = Convert.ToInt32(from[1]);
        int to1 = Convert.ToInt32(to[0]);
        int to2 = Convert.ToInt32(to[1]);

        if (Math.Abs(from1 - to1) == Math.Abs(from2 - to2))
            return true;
        else if (Math.Abs(from1 - to1) == 0)
            return true;
        else if (0 == Math.Abs(from2 - to2)) 
            return true;

        return false;    
    }
