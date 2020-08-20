using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxTest
{
    public abstract class ViewModel : ObservableObject
    {

        public ViewModel()
        {
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
