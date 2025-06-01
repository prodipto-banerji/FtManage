public static class list
    {
        public static double M(this List<double> values)
        {
            return values.Count == 0 ? 0 : values.M(0, values.Count);
        }
 
        public static double M(this List<double> values, 
                                  int start, int end)
        {
            double s = 0;
 
            for (int i = start; i < end; i++)
            {
                s += values[i];
            }
 
            return s / (end - start);
        }
 
        public static double V(this List<double> values)
        {
            return values.V(values.M(), 0, values.Count);
        }
 
        public static double V(this List<double> values, double M)
        {
            return values.V(M, 0, values.Count);
        }
 
        public static double V(this List<double> values, double M, 
                                      int start, int end)
        {
            double V = 0;
 
            for (int i = start; i < end; i++)
            {
                V += Math.Pow((values[i] - M), 2);
            }
 
            int n = end - start;
            if (start > 0) n -= 1;
 
            return V / (n);
        }
        public static double SD(this List<double> values)
        {
            return values.Count == 0 ? 0 : values.SD(0, values.Count);
        }
        public static double SD(this List<double> values, 
                                               int start, int end)
        {
            double M = values.M(start, end);
            double V = values.V(M, start, end);
            return Math.Sqrt(V);
        }
    }