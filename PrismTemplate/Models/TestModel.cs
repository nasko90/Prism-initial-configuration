using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismTemplate.Models
{
    public class TestModel : BindableBase
    {
        private string _vafla;

        public string Vafla
        {
            get { return _vafla; }
            set { SetProperty(ref _vafla, value); }
        }
    }
}
