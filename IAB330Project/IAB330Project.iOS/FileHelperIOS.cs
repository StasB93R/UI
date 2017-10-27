using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using Foundation;
using UIKit;

namespace IAB330Project.iOS
{
    public class FileHelperIOS : IFileHelper
    {
        public string GetLocalPath(string filename)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
            return Path.Combine(libFolder, filename);
        }
    }
}