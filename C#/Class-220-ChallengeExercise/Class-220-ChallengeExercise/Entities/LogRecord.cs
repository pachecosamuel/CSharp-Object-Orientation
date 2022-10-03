using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_220_ChallengeExercise.Entities
{
    internal class LogRecord
    {
        public string Username { get; set; }
        public DateTime Moment { get; set; }


        public LogRecord(string username, DateTime moment)
        {
            Username = username;
            Moment = moment;
        }

        public LogRecord()
        {
        }

        public override bool Equals(object? obj)
        {
            if(obj is not LogRecord) return false;

            LogRecord other = obj as LogRecord;

            return Username.Equals(other.Username);
        }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }
    }
}
