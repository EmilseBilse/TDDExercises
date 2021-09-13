namespace WeatherExercise2
{
    public class Cloudburst : ICloudburst
    {
        public int ContainsCloudburst(double[] rain)
        {
            int totalRain = 0;
            int i = 0;
            while ( i < rain.Length)
            {
                if (i + 6 <= rain.Length)
                {
                    totalRain = (int) rain[i] + (int) rain[i + 1] + (int) rain[i + 2] + (int) rain[i + 3] + (int) rain[i + 4] + (int) rain[i + 5];
                    if (totalRain > 15)
                    {
                        return (int) rain[i];
                    }
                }
                i++;
            }
            return -1;
        }
    }
}