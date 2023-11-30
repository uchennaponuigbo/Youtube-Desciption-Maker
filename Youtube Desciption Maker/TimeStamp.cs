using System.Text.RegularExpressions;

namespace Youtube_Desciption_Maker
{
    public class TimeStamp
    {
        public string Timestamp {  get; }
        public string Title { get; }
        public string Summary { get; }
        /// <summary>
        /// Returns the total size of the 3 string objects.
        /// </summary>
        public int Size { get; }
        //public bool isValidTimestamp { get; private set; }

        public bool AllowSpaces { get; }

        public TimeStamp(string time, string title, string summary, bool allowSpaces)
        {
            //Timestamp = CheckTimestamp(time);
            //ValidateTimestamp();
            Timestamp = time;
            Title = title;
            Summary = summary;
            AllowSpaces = allowSpaces;
            Size = time.Length + title.Length + summary.Length;
        }

        public TimeStamp(TimeStamp timestamp)
        {
            Timestamp = timestamp.Timestamp;
            Title = timestamp.Title;
            Summary = timestamp.Summary;
            Size = timestamp.Size;
            //isValidTimestamp = timestamp.isValidTimestamp;
            AllowSpaces = timestamp.AllowSpaces;
        }

        //private string CheckTimestamp(string time)
        //{
        //    if (time[0] == ' ' || time[0] == '0')
        //        return time.Substring(1);
        //    else
        //        return time;
        //}

        //private void ValidateTimestamp()
        //{
        //    //string pattern = "^[0-5]?[0-9]:[0-5][0-9]$";
        //    //if (Regex.IsMatch(Timestamp, pattern))
        //    //    isValidTimestamp = true;
        //    //else
        //    //    isValidTimestamp = false;
        //}

        public override string ToString()
        {
            if(AllowSpaces)
                return $"{Timestamp} {Title}\n{Summary}\n\n";
            else
                return $"{Timestamp} {Title}\n{Summary}";
        }
    }
}
