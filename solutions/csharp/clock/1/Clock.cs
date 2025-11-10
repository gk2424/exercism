public class Clock
{
   private int minutes;
    private int hours;
    private const int MINUTES_PER_HOUR = 60;
    private const int MAX_HOURS = 24;
    public Clock(int hours, int minutes)
    {
        int totalMinutes = minutes + (hours * MINUTES_PER_HOUR);
        int resolvedHours;
        int resolvedMinutes;
        if (totalMinutes < 0)
        {
            resolvedHours = MAX_HOURS + (totalMinutes/MINUTES_PER_HOUR % MAX_HOURS);
            resolvedMinutes = (MINUTES_PER_HOUR + (totalMinutes % MINUTES_PER_HOUR)) % MINUTES_PER_HOUR;
            if (resolvedMinutes > 0) {
                resolvedHours = resolvedHours - 1;
            }
        }
        else
        {
            resolvedHours = (totalMinutes / MINUTES_PER_HOUR) % MAX_HOURS;
            resolvedMinutes = totalMinutes % MINUTES_PER_HOUR;
        }
        this.minutes = resolvedMinutes;
        this.hours = resolvedHours;
    }
    public Clock Add(int minutesToAdd)
    {
        return new Clock(this.hours, this.minutes + minutesToAdd);
    }
    public Clock Subtract(int minutesToSubtract)
    {
        return new Clock(this.hours, this.minutes - minutesToSubtract);
    }
    public override string ToString()
    {
        return this.hours.ToString("00") + ":" + this.minutes.ToString("00");
    }
    public override bool Equals(object obj)
    {
        return String.Equals(this.ToString(), obj.ToString());
    }
}
