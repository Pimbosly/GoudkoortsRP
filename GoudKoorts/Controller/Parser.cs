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

        }

        public void LoadLevel(Game game)
        {
            string line;
            _streamReader = new StreamReader("\\Level\\lvl.txt");
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
                        case '.':
                            newObject = new NormalTrack();
                            break;
                        case '-':
                            Console.WriteLine(" ");
                            break;
                        case '8':
                            game.ship = new Ship();
                            newObject = new NormalTrack();
                            game.ship.Position = (Track)newObject;
                            newObject.Moveable.Add(game.ship);
                            break;
                        case 'W':
                            newObject = new Warehouse();
                            break;
                        case 'S':
                            newObject = new Split();
                            break;
                        case 'M':
                            newObject = new Merge();
                            break;
                    }
                    if (current != null && newObject != null)
                    {
                    }
                    if (newObject != null)
                    {
                        if (prevLine != null && prevLine[i] != null)
                        {
                        }
                    }
                }
            }
        }
      
    }
}
