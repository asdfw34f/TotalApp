using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotalApp.MVVM.Base;

namespace TotalApp.MVVM.ViewModel
{
    class MainViewModel : NotifyProperty
    {
        private bool _FrameVis;
        private bool _StackVis;

        public bool FrameVis
        {
            get => _FrameVis;
            set => Set(ref _FrameVis, value);
        }
    }
}