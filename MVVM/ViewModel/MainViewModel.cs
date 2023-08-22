using TotalApp.MVVM.Base;

namespace TotalApp.MVVM.ViewModel
{
    internal class MainViewModel : NotifyProperty
    {
        private bool _FrameVis;
        private readonly bool _StackVis;

        public bool FrameVis
        {
            get => _FrameVis;
            set => Set(ref _FrameVis, value);
        }
    }
}