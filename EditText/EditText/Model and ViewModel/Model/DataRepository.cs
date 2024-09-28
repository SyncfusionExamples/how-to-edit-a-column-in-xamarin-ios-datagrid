using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditText
{
    public class DataRepository
    {
        #region Fields

        private Random random = new Random();

        #endregion

        #region Constructor

        public DataRepository()
        {

        }

        #endregion

        #region ItemsSource Generator

        public ObservableCollection<Model> GetData(int count)
        {
            ObservableCollection<Model> Details = new ObservableCollection<Model>();
            for (int i = 0; i < count; i++)
            {
                var data = new Model()
                {
                    ID = i+1,
                    Name = Name[random.Next(3)],
                    Percentage = Percentage[random.Next(3)],
                    Remarks = Remarks[random.Next(2)]
                };
                Details.Add(data);
            }
            return Details;
        }

        #endregion

        #region DataSource

        string[] Name = new string[] { "Arun", "Bala", "Cathy", "David", "Ram" };
        int[] Percentage = new int[] { 45, 35, 76, 97, 23, 34, 65 };
        string[] Remarks = new string[] { "Poor", "Good", "Excellent" };

        #endregion
    }
}
