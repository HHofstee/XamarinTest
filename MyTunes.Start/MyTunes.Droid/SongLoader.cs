using System.IO;
using System.Threading.Tasks;

namespace MyTunes
{
    public partial class SongLoader
    {
        private async static Task<Stream> OpenData()
        {
            return Android.App.Application.Context.Assets.Open(Filename);
        }
    }
}