//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Core
{
    /// <summary>
    /// Class that holds information about a 	CONJobsheetMaterialHDRMST.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	CONJobsheetMaterialHDRMSTService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class CONJobsheetMaterialHDRMST
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private decimal _CJMHDR_MaterialID;
        private string _CJMHDR_MaterialDesc;
        private string _CJMHDR_MaterialUnit;
        #endregion

        /// <summary>
        /// Default constructor for CONJobsheetMaterialHDRMST class.
        /// </summary>
        public CONJobsheetMaterialHDRMST() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CONJobsheetMaterialHDRMST(decimal CJMHDR_MaterialID, string CJMHDR_MaterialDesc, string CJMHDR_MaterialUnit)
        {
            this._CJMHDR_MaterialID = CJMHDR_MaterialID;
            this._CJMHDR_MaterialDesc = CJMHDR_MaterialDesc;
            this._CJMHDR_MaterialUnit = CJMHDR_MaterialUnit;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal CJMHDR_MaterialID
        {
            get { return _CJMHDR_MaterialID; }
            set { _CJMHDR_MaterialID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CJMHDR_MaterialDesc
        {
            get { return _CJMHDR_MaterialDesc; }
            set { _CJMHDR_MaterialDesc = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CJMHDR_MaterialUnit
        {
            get { return _CJMHDR_MaterialUnit; }
            set { _CJMHDR_MaterialUnit = value; }
        }

    }

    public class CONJobsheetMaterialHDRMSTList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS

        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private decimal _CJMHDR_MaterialID;
        private string _CJMHDR_MaterialDesc;
        private string _CJMHDR_MaterialUnit;
        private decimal _Rate;
        private int _Count;
        #endregion

        /// <summary>
        /// Default constructor for CONJobsheetMaterialHDRMST class.
        /// </summary>
        public CONJobsheetMaterialHDRMSTList() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CONJobsheetMaterialHDRMSTList(decimal CJMHDR_MaterialID, string CJMHDR_MaterialDesc, string CJMHDR_MaterialUnit,decimal Rate,int Count)
        {
            this._CJMHDR_MaterialID = CJMHDR_MaterialID;
            this._CJMHDR_MaterialDesc = CJMHDR_MaterialDesc;
            this._CJMHDR_MaterialUnit = CJMHDR_MaterialUnit;
            this._Rate = Rate;
            this._Count = Count;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal CJMHDR_MaterialID
        {
            get { return _CJMHDR_MaterialID; }
            set { _CJMHDR_MaterialID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CJMHDR_MaterialDesc
        {
            get { return _CJMHDR_MaterialDesc; }
            set { _CJMHDR_MaterialDesc = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CJMHDR_MaterialUnit
        {
            get { return _CJMHDR_MaterialUnit; }
            set { _CJMHDR_MaterialUnit = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal Rate
        {
            get { return _Rate; }
            set { _Rate = value; }
        }


        public int Count
        {
            get { return _Count;}
            set { _Count = value;}
        }
    }


    public class CONJobsheetMaterialHDRMSTMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public CONJobsheetMaterialHDRMSTMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public CONJobsheetMaterialHDRMSTMsg(int RetVal, string RetStr)
        {
            this._RetVal = RetVal;
            this._RetStr = RetStr;
        }
        /// <summary>
        //Gets or sets unique Salutation identifier. 
        //The Identity Field Design Pattern. 
        /// </summary>
        public int RetVal
        {
            get { return _RetVal; }
            set { _RetVal = value; }
        }
        /// <summary>
        //Gets or sets Country Name.
        /// </summary>
        public string RetStr
        {
            get { return _RetStr; }
            set { _RetStr = value; }
        }
    }
}
