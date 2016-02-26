using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamProject_Elina_Julie.Interfaces;

namespace TeamProject_Elina_Julie.ViewModel
{
    public class BoardSampleViewModel : ObservableObject , IPageViewModel 
    {
        public string Name
        {
            get
            {
                return "Board";
            }
        }
    }
}
