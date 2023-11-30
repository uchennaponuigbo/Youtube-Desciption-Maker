using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Youtube_Desciption_Maker
{
    internal class TimestampTemplateDB
    {
        //https://github.com/uchennaponuigbo/LoopingAudio_net/blob/master/LoopingAudio_net/AudioDB.cs
        private readonly string connectionString;
        public TimestampTemplateDB()
        {
            connectionString = ConfigurationManager.ConnectionStrings["templates"].ConnectionString;
        }
    }
}
