using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTunes
{
    partial class SongLoader
    {
        private async static Task<Stream> OpenData()
        {
            var sf = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync(Filename);
            return await sf.OpenStreamForReadAsync();
        }
    }
}
