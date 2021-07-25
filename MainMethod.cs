using System;
using System.Collections.Generic;

namespace WordFrequencyUsingHashTables
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            FrequencyOfWords paragraph = new FrequencyOfWords();
            paragraph.WordCounter("Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations");
        }
    }
}
