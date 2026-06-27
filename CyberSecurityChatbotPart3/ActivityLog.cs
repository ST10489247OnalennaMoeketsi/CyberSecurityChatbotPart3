using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatbot
{
    public class ActivityLog
    {
        private List<string> logs = new List<string>();

        public void AddLog(string action)
        {
            logs.Add($"{DateTime.Now:dd/MM/yyyy HH:mm:ss} - {action}");
        }

        public List<string> GetRecentLogs(int count = 5)
        {
            int start = Math.Max(0, logs.Count - count);
            return logs.GetRange(start, logs.Count - start);
        }

        public List<string> GetAllLogs()
        {
            return logs;
        }

        public void ClearLogs()
        {
            logs.Clear();
        }
    }
}
