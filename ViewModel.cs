using System.ComponentModel;

namespace MauiAppDemo
{
    public class ViewModel : BindableObject, INotifyPropertyChanged
    {
        public string Text { get; set; } = null;

        public ViewModel()
        {
            Task.Run(async () =>
            {
                await Task.Delay(2000);
                Text = "Text is black but should not be";
                OnPropertyChanged(nameof(Text));
            });
        }
    }
}
