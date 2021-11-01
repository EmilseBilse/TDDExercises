namespace WeatherExercise2
{
    public class Cloudburst : ICloudburst
    {
        public int ContainsCloudburst(double[] rain)
        {
            return RainAnalyze(rain, 6, 15);
        }

        public int ContainsHeavyRain(double[] rain)
        {
            return RainAnalyze(rain, 12, 7.6);
        }
        
        private int RainAnalyze(double[] rain, int howManyIntervals, double howMuchToBreak)
        {
            
            int i = 0;
            while ( i < rain.Length)
            {
                if (i + howManyIntervals <= rain.Length)
                {
                    double totalRain = 0;
                    for (int j = 0; j < howManyIntervals; j++)
                    {
                        totalRain += rain[i + j];
                    }
                    if (totalRain > howMuchToBreak)
                    {
                        return i;
                    }
                }

                i++;
            }
            return -1;
        }
    }
}