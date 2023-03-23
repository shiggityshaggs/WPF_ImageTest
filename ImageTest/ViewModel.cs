using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.IO;

namespace ImageTest
{
    internal partial class ViewModel : ObservableObject
    {
        [ObservableProperty]
        private Stream? _myStream;

        bool swapper = true;

        [RelayCommand]
        public void RC()
        {
            byte[] barr = File.ReadAllBytes($"c:\\test{(swapper ? 1 : 2)}.bmp");
            MyStream = new MemoryStream(barr);
            swapper = !swapper;
        }
    }
}