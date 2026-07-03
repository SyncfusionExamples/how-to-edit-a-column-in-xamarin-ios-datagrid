using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditText
{
   public class ViewModel
    {
        public DataRepository GridData { get; set; }
        public ViewModel()
        {
            GridData = new DataRepository();
            Info = GridData.GetData(100);
           
        }

        #region Itemsource
        private ObservableCollection<Model> _info;

        public ObservableCollection<Model> Info
        {
            get { return _info; }
            set { this._info = value; }
        }
        #endregion


    }
}
