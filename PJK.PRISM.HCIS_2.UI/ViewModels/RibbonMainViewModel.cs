using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PJK.PRISM.HCIS_2.UI.ViewModels
{
    public class RibbonMainViewModel : BindableBase
    {

        private IEventAggregator _eventAggregator;

        public DelegateCommand AddProjectCommand { get; private set; }
        public DelegateCommand EditProjectCommand { get; private set; }
        public DelegateCommand DeleteProjectCommand { get; private set; }
        public DelegateCommand RefreshListCommand { get; private set; }


        public RibbonMainViewModel(IEventAggregator eventAggregator)
        {

        }
    }
}
