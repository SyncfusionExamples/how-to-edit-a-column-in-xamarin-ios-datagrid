using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditText
{
   public class Model
   {
       #region PrivateVariables
       private int _id;
        private string _name;
        private int _percentage;
        private string _remarks;
       #endregion
        #region PublicProperties

        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                this._id = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                this._name = value;
            }
        }

        public int Percentage
        {
            get
            {
                return _percentage;
            }
            set
            {
                this._percentage = value;
            }
        }

        public string Remarks
        {
            get
            {
                return _remarks;
            }
            set
            {
                this._remarks = value;
            }
        }
        #endregion 
   }
}

