using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToProgramming
{
    class ExternalClass
    {

        #region Fields

        private int _thisIsAField = 0;

        #endregion

        #region Properties

        public int ThisIsAProperty
        {
            get
            {
                return _thisIsAField;
            }
            set
            {
                if (value < 0) return;
                if (value > 120) return;

                // value is a keyword used in setters representing the new value
                _thisIsAField = value;
            }
        }

        #endregion
    }
}
