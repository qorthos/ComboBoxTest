using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxTest
{
    public abstract class ViewModel : ObservableObject
    {
        protected VMManager VMManager;


        public ViewModel(bool addToVMManager)
        {
            VMManager = VMManager.Instance;

            if (addToVMManager)
                VMManager.AddVM(this);
        }

        protected virtual void OnNewGame()
        {

        }


        protected virtual void OnTickFinished()
        {

        }


        public virtual void Focused()
        {

        }

    }
}
