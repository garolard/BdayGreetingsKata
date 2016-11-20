using System.Collections.Generic;
using System.IO;

namespace BdayGreetingsKata.Data.Helpers
{
    internal interface IOHelper
    {
        IEnumerable<string> ReadFileLines(string path);
    }

    internal class FileHelper : IOHelper
    {
        public IEnumerable<string> ReadFileLines(string path)
        {
            return File.ReadLines(path);
        }
    }

    internal class StubFileHelper : IOHelper
    {
        public IEnumerable<string> ReadFileLines(string path)
        {
            return new List<string>
            {
                "Parker, Peter, 1962/10/08, peter.parker@foobar.com",
                "Wayne, Bruce, 1939/01/05, the_batman@foobar.com",
                "Ferreiro, Gabriel, 1991/17/11, gbril9119@outlook.com"
            };
        }
    }
}