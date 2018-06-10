using Prism.Commands;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismTemplate.ViewModels
{
    public class TishoViewModel
    {
        private readonly IAutomationManager automationManager;
        private readonly IRegionManager regionManager;

        public TishoViewModel(IAutomationManager automationManager, IRegionManager regionManager)
        {
            this.regionManager = regionManager;
            this.automationManager = automationManager;
            CSKACommand = new DelegateCommand(DoMethod);
            NavigateToPesa = new DelegateCommand(Navigate);
        }

        private void Navigate()
        {
            regionManager.RequestNavigate("MainRegion", "Pesa");
        }

        private void DoMethod()
        {
            automationManager.CskENomerEndo();
        }

        public DelegateCommand CSKACommand { get; set; }
        public DelegateCommand NavigateToPesa { get; set; }
    }
}
