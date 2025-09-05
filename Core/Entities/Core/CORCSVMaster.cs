//Business File.
using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;
using System.Text;

namespace Core.Entities.Core
{
/// <summary>
/// Class that holds information about a 	CORCSVMaster.
///
/// Enterprise Design Pattern: Domain Model, Identity Field.
/// </summary>
/// <remarks>
/// This is where your business logic resides. In this example there are none.
/// Another place for business logic and business rules is in the Service.
/// For an example see 	CORCSVMasterService in the Service layer.
///
/// The Domain Model Design Pattern states that domain objects incorporate
/// both behavior and data. Behavior may include simple or complex business logic.
///
/// The Identity Field Design Pattern saves the ID field in an object to maintain
/// identity between an in-memory business object and that database rows.
/// </remarks>
	
	public class 	CORCSVMaster
	{
	/// Class level Local Variables Declaration.
	#region "Variables Declaration"
		private int _CSVMST_ID;
		private string _CSVMST_Date;
		private string _CSVMST_RelatedTo;
		private int _CSVMST_TotalRecords;
		private int _CSVMST_NoofInserted;
		private string _CSVMST_CSVLog;
		private int _CSVMST_UploadedByUserID;
	#endregion

	/// <summary>
	/// Default constructor for CORCSVMaster class.
	/// </summary>
	public CORCSVMaster() { }

	/// <summary>
	/// Overloaded constructor for the Branch class.
	/// </summary>
	public CORCSVMaster(int CSVMST_ID,string CSVMST_Date,string CSVMST_RelatedTo,int CSVMST_TotalRecords,int CSVMST_NoofInserted,string CSVMST_CSVLog,int CSVMST_UploadedByUserID)
	{
	this._CSVMST_ID = CSVMST_ID;
	this._CSVMST_Date = CSVMST_Date;
	this._CSVMST_RelatedTo = CSVMST_RelatedTo;
	this._CSVMST_TotalRecords = CSVMST_TotalRecords;
	this._CSVMST_NoofInserted = CSVMST_NoofInserted;
	this._CSVMST_CSVLog = CSVMST_CSVLog;
	this._CSVMST_UploadedByUserID = CSVMST_UploadedByUserID;
	}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int CSVMST_ID
		{
			 get { return _CSVMST_ID; }
			 set { _CSVMST_ID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string CSVMST_Date
		{
			 get { return _CSVMST_Date; }
			 set { _CSVMST_Date = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string CSVMST_RelatedTo
		{
			 get { return _CSVMST_RelatedTo; }
			 set { _CSVMST_RelatedTo = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int CSVMST_TotalRecords
		{
			 get { return _CSVMST_TotalRecords; }
			 set { _CSVMST_TotalRecords = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int CSVMST_NoofInserted
		{
			 get { return _CSVMST_NoofInserted; }
			 set { _CSVMST_NoofInserted = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string CSVMST_CSVLog
		{
			 get { return _CSVMST_CSVLog; }
			 set { _CSVMST_CSVLog = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int CSVMST_UploadedByUserID
		{
			 get { return _CSVMST_UploadedByUserID; }
			 set { _CSVMST_UploadedByUserID = value; }
		}

	}

    
    public class SMS
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _SMS_ID;
        private string _MobileNo;
        private string _Message;
        private int _Flag;
        private string _EnterDate;
        private string _SentDate;
        private int _UserId;
        private string _language;
        #endregion

        /// <summary>
        /// Default constructor for CORCSVMaster class.
        /// </summary>
        public SMS() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public SMS(int SMS_ID, string MobileNo, string Message, int Flag, string EnterDate, string SentDate, int UserId, string language)
        {
            this._SMS_ID = SMS_ID;
            this._MobileNo = MobileNo;
            this._Message = Message;
            this._Flag = Flag;
            this._EnterDate = EnterDate;
            this._SentDate = SentDate;
            this._UserId = UserId;
            this._language = language;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int SMS_ID
        {
            get { return _SMS_ID; }
            set { _SMS_ID = value; }
        }

        public string MobileNo
        {
            get { return _MobileNo; }
            set { _MobileNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string Message
        {
            get { return _Message; }
            set { _Message = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int Flag
        {
            get { return _Flag; }
            set { _Flag = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string EnterDate
        {
            get { return _EnterDate; }
            set { _EnterDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string SentDate
        {
            get { return _SentDate; }
            set { _SentDate = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        public string language
        {
            get { return _language; }
            set { _language = value; }
        }
    }

    
    public class SendEmail
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private long _Id;
        private string _CustomerId;
        private string _ToEmailAddress;
        private string _CCEmailAddress;
        private string _EmailSubject;
        private string _EmailBody;
        private int _NoOfAttachment;
        private bool _SendStatus;
        private int _UserId;
    
        #endregion

        /// <summary>
        /// Default constructor for CORCSVMaster class.
        /// </summary>
        public SendEmail() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public SendEmail(long Id, string CustomerId, string ToEmailAddress, string CCEmailAddress, string EmailSubject, string EmailBody, int NoOfAttachment, bool SendStatus, int UserId)
        {
            this._Id = Id;
            this._CustomerId = CustomerId;
            this._ToEmailAddress = ToEmailAddress;
            this._CCEmailAddress = CCEmailAddress;
            this._EmailSubject = EmailSubject;
            this._EmailBody = EmailBody;
            this._NoOfAttachment = NoOfAttachment;
            this._SendStatus = SendStatus;
            this._UserId = UserId;           
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string CustomerId
        {
            get { return _CustomerId; }
            set { _CustomerId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string ToEmailAddress
        {
            get { return _ToEmailAddress; }
            set { _ToEmailAddress = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CCEmailAddress
        {
            get { return _CCEmailAddress; }
            set { _CCEmailAddress = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string EmailSubject
        {
            get { return _EmailSubject; }
            set { _EmailSubject = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string EmailBody
        {
            get { return _EmailBody; }
            set { _EmailBody = value; }
        }
        public int NoOfAttachment
        {
            get { return _NoOfAttachment; }
            set { _NoOfAttachment = value; }
        }

        public bool SendStatus
        {
            get { return _SendStatus; }
            set { _SendStatus = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
    }

    public class 	CORCSVMasterList
{
//Write this List class yourself.
//This List Class can not be generate using this utility.
//--VBS
}


public class CSVUpload_Insert
{
    /// Class level Local Variables Declaration.
    #region "Variables Declaration"
    private string _CSVFor;
    private string _DirPath;
    private string _FileName;
    private int _CenCode;
    private int _CreatedByUserID;
    #endregion

    /// <summary>
    /// Default constructor for CORCSVMaster class.
    /// </summary>
    public CSVUpload_Insert() { }

    /// <summary>
    /// Overloaded constructor for the Branch class.
    /// </summary>
    public CSVUpload_Insert(string CSVFor, string DirPath, string FileName, int CenCode, int CreatedByUserID)
    {
        this._CSVFor = CSVFor;
        this._DirPath = DirPath;
        this._FileName = FileName;
        this._CenCode = CenCode;
        this._CreatedByUserID = CreatedByUserID;
    }

    /// <summary>
    //Write Column Description here. 
    /// </summary>
    public string CSVFor
    {
        get { return _CSVFor; }
        set { _CSVFor = value; }
    }

    /// <summary>
    //Write Column Description here. 
    /// </summary>
    public string DirPath
    {
        get { return _DirPath; }
        set { _DirPath = value; }
    }

    /// <summary>
    //Write Column Description here. 
    /// </summary>
    public string FileName
    {
        get { return _FileName; }
        set { _FileName = value; }
    }

    /// <summary>
    //Write Column Description here. 
    /// </summary>
    public int CenCode
    {
        get { return _CenCode; }
        set { _CenCode = value; }
    }

    /// <summary>
    //Write Column Description here. 
    /// </summary>
    public int CreatedByUserID
    {
        get { return _CreatedByUserID; }
        set { _CreatedByUserID = value; }
    }
}

public class CORCSVMasterMsg
{
	// Class level Local Variables Declaration.
	#region "Variables Declaration"
private int _RetVal;
private string _RetStr;
	#endregion

	/// <summary>
	//Overloaded default constructor for the Salutation class. 
	/// </summary>
public CORCSVMasterMsg(){ }
	/// <summary>
	//Overloaded constructor for the Salutation class. 
	/// </summary>
	/// <param name="saltnmId">Unique Identifier for the Salutation.</param>
	/// <param name="saltnmName">Name of the Salutation.</param>
public CORCSVMasterMsg(int RetVal, string RetStr)
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


    public class CSVUpload_Insert_Msg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        private string _Log;
        private int _TotalRecords;
        private int _RecordsNotInserted;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public CSVUpload_Insert_Msg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public CSVUpload_Insert_Msg(int RetVal, string RetStr, string Log, int TotalRecords, int RecordsNotInserted)
        {
            this._RetVal = RetVal;
            this._RetStr = RetStr;
            this._Log = Log;
            this._TotalRecords = TotalRecords;
            this._RecordsNotInserted = RecordsNotInserted;
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

        /// <summary>
        //Gets or sets Country Name.
        /// </summary>
        public string Log
        {
            get { return _Log; }
            set { _Log = value; }
        }

        /// <summary>
        //Gets or sets Country Name.
        /// </summary>
        public int TotalRecords
        {
            get { return _TotalRecords; }
            set { _TotalRecords = value; }
        }

        /// <summary>
        //Gets or sets Country Name.
        /// </summary>
        public int RecordsNotInserted
        {
            get { return _RecordsNotInserted; }
            set { _RecordsNotInserted = value; }
        }
    }

    public class SMSMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public SMSMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public SMSMsg(int RetVal, string RetStr)
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

    public class SMSSendEmail
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public SMSSendEmail() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public SMSSendEmail(int RetVal, string RetStr)
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
