//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Core
{
    /// <summary>
    /// Class that holds information about a 	CORMaterialDTLMST.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	CORMaterialDTLMSTService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class CORMaterialDTLMST
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _MTDMST_ID;
        private int _MTDMST_MaterialID;
        private int _MTDMST_TaxID;
        #endregion

        /// <summary>
        /// Default constructor for CORMaterialDTLMST class.
        /// </summary>
        public CORMaterialDTLMST() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORMaterialDTLMST(int MTDMST_ID, int MTDMST_MaterialID, int MTDMST_TaxID)
        {
            this._MTDMST_ID = MTDMST_ID;
            this._MTDMST_MaterialID = MTDMST_MaterialID;
            this._MTDMST_TaxID = MTDMST_TaxID;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int MTDMST_ID
        {
            get { return _MTDMST_ID; }
            set { _MTDMST_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int MTDMST_MaterialID
        {
            get { return _MTDMST_MaterialID; }
            set { _MTDMST_MaterialID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int MTDMST_TaxID
        {
            get { return _MTDMST_TaxID; }
            set { _MTDMST_TaxID = value; }
        }

    }

    public class CORMaterialDTLMSTList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS
        #region "Variables Declaration"
        private int _MTDMST_ID;
        private int _MTDMST_MaterialID;
        private int _MTDMST_TaxID;
        private int _Count;
        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public CORMaterialDTLMSTList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public CORMaterialDTLMSTList(int MTDMST_ID, int MTDMST_MaterialID, int MTDMST_TaxID, int Count)
        {
            this._MTDMST_ID = MTDMST_ID;
            this._MTDMST_MaterialID = MTDMST_MaterialID;
            this._MTDMST_TaxID = MTDMST_TaxID;
            this._Count = Count;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int MTDMST_ID
        {
            get { return _MTDMST_ID; }
            set { _MTDMST_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int MTDMST_MaterialID
        {
            get { return _MTDMST_MaterialID; }
            set { _MTDMST_MaterialID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int MTDMST_TaxID
        {
            get { return _MTDMST_TaxID; }
            set { _MTDMST_TaxID = value; }
        }

        public int Count
        {
            get { return _Count; }

        }
    }


    public class CORMaterialDTLMSTMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public CORMaterialDTLMSTMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public CORMaterialDTLMSTMsg(int RetVal, string RetStr)
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
