using System.Text.RegularExpressions;

namespace Youtube_Desciption_Maker
{
    public class TimeStamp
    {
        private string Timestamp {  get; set; }
        private string Title { get; set; }
        private string Summary { get; set; }
        public bool isValidTimestamp { get; private set; }

        public TimeStamp(string time, string title, string summary)
        {
            Timestamp = CheckTimestamp(time);
            ValidateTimestamp();
            Title = title;
            Summary = summary;
        }

        private string CheckTimestamp(string time)
        {
            if (time[0] == ' ' || time[0] == '0')
                return time.Substring(1);
            else
                return time;
        }

        private void ValidateTimestamp()
        {
            string pattern = "^[0-5]?[0-9]:[0-5][0-9]$";
            if (Regex.IsMatch(Timestamp, pattern))
                isValidTimestamp = true;
            else
                isValidTimestamp = false;
        }

        public override string ToString()
        {
            return $"{Timestamp} {Title}\n{Summary}\n\n";
        }
    }
}
