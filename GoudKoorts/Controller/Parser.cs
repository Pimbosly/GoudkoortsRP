using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoudKoorts.Controller
{
    class Parser
    {
        string path;
        private FileStream _inputStream;
        private StreamReader _streamReader;

        public Parser()
        {
            path = String.Concat("..\\..\\Level\\lvl", ".txt");

        }

        public void LoadLevel()
        {
            string line

            _inputStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            _streamReader = new StreamReader(_inputStream);
            string lineString = _streamReader.ReadLine();

            List<Track> prevLine = null;
            while ((line = _streamReader.ReadLine()) != null)
            {
                Track current = null;
                List<Track> currentLine = new List<Track>();
                for (int i = 0; i < line.Length; i++)
                {
                    Track newObject = null;
                    switch (line[i])
                    {
                    }
                }
            }
        }
      
    }
}
