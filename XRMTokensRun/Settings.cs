using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XRMTokensRun
{
    /// <summary>
    /// This class can help you to store settings for your plugin
    /// </summary>
    /// <remarks>
    /// This class must be XML serializable
    /// </remarks>
    public class Settings
    {
        public string Table { get; set; }
        public List<KeyValuePair> RecordId { get; set; }
        public List<KeyValuePair> Token { get; set; } = new List<KeyValuePair>();
    }

    public class KeyValuePair
    {
        public string key { get; set; }
        public string value { get; set; }
    }
}