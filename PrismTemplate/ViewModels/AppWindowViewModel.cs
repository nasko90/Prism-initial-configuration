using Prism.Regions;
using PrismTemplate.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismTemplate.ViewModels
{
    public class AppWindowViewModel
    {
        private readonly IRegionManager _regionManager;

        public AppWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            _regionManager.RegisterViewWithRegion("MainRegion", typeof(Tisho));
        }
    }
}
