using TotalApp.Infrastructure.Commands.ButtonCommand;
using TotalApp.MVVM.Base;

namespace TotalApp.MVVM.ViewModel
{
    public class MainViewModel : NotifyProperty
    {
        private bool _FrameVis;
        private readonly bool _StackVis;

        public bool FrameVis
        {
            get => _FrameVis;
            set => Set(ref _FrameVis, value);
        }
        public ButtonsCmd cmd { get; set; }

        public MainViewModel()
        {
            cmd = new ButtonsCmd();
        }
    }
}