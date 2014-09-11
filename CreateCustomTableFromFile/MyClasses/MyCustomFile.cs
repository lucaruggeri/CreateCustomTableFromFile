using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCustomTableFromFile.MyClasses
{

    public class MyCustomFile
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public char Separator { get; set; }
        public string[] TextLines = new string[9999];

        public string CompleteName()
        {
            string completeName = string.Empty;

            completeName = Path + "\\" + Name;

            return completeName;
        }

        public void CopyInMemory()
        {
            string textLine = string.Empty;
            string[] subStrings = new string[20];
            int i = 0;

            // reading the stream
            System.IO.StreamReader stream = new System.IO.StreamReader(this.CompleteName());
            while ((textLine = stream.ReadLine()) != null)
            {

                if (this.Separator != ' ')
                {

                    // only read if line is not empty
                    if (textLine.Trim().Length > 0)
                    {

                        subStrings = textLine.Split(this.Separator);

                        int ii = 0;
                        foreach (string s in subStrings)
                        {
                            this.TextLines[i] = s.Trim();
                            i = i + 1;
                            ii = ii + 1;
                        }

                    }

                }
                else
                {

                    // only read if line is not empty
                    if (textLine.Trim().Length > 0)
                    {
                        this.TextLines[i] = textLine;
                        i = i + 1;
                    }

                }

            }

            // resizing array
            Array.Resize(ref this.TextLines, i);
        }

    }

}
