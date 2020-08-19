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

        List<ViewModel> viewModels;

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
            viewModels = new List<ViewModel>();
        }

        public void AddVM(ViewModel vm)
        {
            viewModels.Add(vm);
        }

        public T GetVM<T>() where T : ViewModel, new()
        {
            Type type = typeof(T);

            foreach (ViewModel vm in viewModels)
            {
                if (vm is T)
                {
                    return (T)vm;
                }
            }

            var newVM = new T();
            viewModels.Add(newVM);

            return newVM;
        }


        public void TransitionToVM(ViewModel nextVM)
        {
            SelectedViewModel = nextVM;
            SelectedViewModel.Focused();
        }


        public void TransitionToVM<T>() where T : ViewModel, new()
        {
            SelectedViewModel = GetVM<T>();
            SelectedViewModel.Focused();
        }
    }
}
