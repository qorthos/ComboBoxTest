using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxTest
{
    public class VMManager : ObservableObject
    {
        static VMManager instance;
        public static VMManager Instance
        {
            get 
            {
                if (instance == null)
                    instance = new VMManager();
                return instance;
            }
        }

        private ViewModel _selectedViewModel;

        #region PROPERTIES

        public ViewModel SelectedViewModel
        {
            get { return _selectedViewModel; }
            set { _selectedViewModel = value; Notify(); }
        }

        #endregion

        public VMManager()
        {
            
        }

        public void TransitionToVM(ViewModel nextVM)
        {
            SelectedViewModel = nextVM;
            SelectedViewModel.Focused();
        }


        public void TransitionToVM<T>() where T : ViewModel, new()
        {
            SelectedViewModel = new T();
            SelectedViewModel.Focused();
        }
    }
}
