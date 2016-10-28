using System;
using System.Collections.Generic;
using System.IO;

namespace CodeSample
{
    public class WordCounterBase
    {
        public StreamReader InputStream { get; private set; }
        public StreamWriter OutputStream { get; private set; }

        public WordCounterBase(StreamReader inputStream, StreamWriter outputStream)
        {
            InputStream = inputStream;
            OutputStream = outputStream;
        }

        public void Write()
        {
            foreach (WordEntry entry in GetWordCount())
            {
                OutputStream.WriteLine(String.Format("\"{0}\",\"{1}\"", entry.Word, entry.WordCount));
            }
        }

        public virtual IEnumerable<WordEntry> GetWordCount()
        {
            throw new NotImplementedException();
        }
    }

    //WordEntry class contains a single entry for a single word found in the file along with the count.
    public class WordEntry
    {
        public string Word { get; set; }
        public long WordCount { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Word, WordCount);
        }
    }
}
