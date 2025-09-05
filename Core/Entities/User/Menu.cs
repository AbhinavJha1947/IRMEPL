using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.User
{
    public class Menu
    {
            /// Class level Local Variables Declaration.
            #region "Variables Declaration"
            private int _MenuId;
            private string _Text;
            private string _ImageURL;
            private string _Description;
            private int _ParentID;
            private string _NavigateURL;
            #endregion

            /// <summary>
            /// Default constructor for Menu class.
            /// </summary>
            public Menu() { }

            /// <summary>
            /// Overloaded constructor for the Branch class.
            /// </summary>
            public Menu(int MenuId, string Text, string ImageURL, string Description, int ParentID, string NavigateURL)
            {
                this._MenuId = MenuId;
                this._Text = Text;
                this._ImageURL = ImageURL;
                this._Description = Description;
                this._ParentID = ParentID;
                this._NavigateURL = NavigateURL;
            }

            /// <summary>
            //Write Column Description here. 
            /// </summary>
            public int MenuId
            {
                get { return _MenuId; }
                set { _MenuId = value; }
            }

            /// <summary>
            //Write Column Description here. 
            /// </summary>
            public string Text
            {
                get { return _Text; }
                set { _Text = value; }
            }

            /// <summary>
            //Write Column Description here. 
            /// </summary>
            public string ImageURL
            {
                get { return _ImageURL; }
                set { _ImageURL = value; }
            }

            /// <summary>
            //Write Column Description here. 
            /// </summary>
            public string Description
            {
                get { return _Description; }
                set { _Description = value; }
            }

            /// <summary>
            //Write Column Description here. 
            /// </summary>
            public int ParentID
            {
                get { return _ParentID; }
                set { _ParentID = value; }
            }

            /// <summary>
            //Write Column Description here. 
            /// </summary>
            public string NavigateURL
            {
                get { return _NavigateURL; }
                set { _NavigateURL = value; }
            }

        }

        public class MenuList
        {
            /// Class level Local Variables Declaration.
            #region "Variables Declaration"
            private int _MenuId;
            private string _Text;
            private string _ImageURL;
            private string _Description;
            private int _ParentID;
            private string _NavigateURL;

            #endregion

            /// <summary>
            /// Default constructor for Storagelist class.
            /// </summary>
            public MenuList() { }
            /// <summary>
            /// Overloaded constructor for the Branch class.
            /// </summary>
            /// <param name="StorageId">Unique Identifier for the Branch.</param>
            /// <param name="Storagename">name of the storage.</param>
            /// <param name="parentid">parentid.</param>
            /// <param name="Status">status.</param>
            public MenuList(int MenuID, string Menutext, string ImageURL, string MenuDiscription, int ParentID, string NavigateURL)
            {
                this._MenuId = MenuID;
                this._Text = Menutext;
                this._ImageURL = ImageURL;
                this._Description = MenuDiscription;
                this._ParentID = ParentID;
                this._NavigateURL = NavigateURL;
            }
            /// <summary>
            //Write Column Description here. 
            /// </summary>
            public int MenuId
            {
                get { return _MenuId; }
                set { _MenuId = value; }
            }

            /// <summary>
            //Write Column Description here. 
            /// </summary>
            public string Text
            {
                get { return _Text; }
                set { _Text = value; }
            }

            /// <summary>
            //Write Column Description here. 
            /// </summary>
            public string ImageURL
            {
                get { return _ImageURL; }
                set { _ImageURL = value; }
            }

            /// <summary>
            //Write Column Description here. 
            /// </summary>
            public string Description
            {
                get { return _Description; }
                set { _Description = value; }
            }

            /// <summary>
            //Write Column Description here. 
            /// </summary>
            public int ParentID
            {
                get { return _ParentID; }
                set { _ParentID = value; }
            }

            /// <summary>
            //Write Column Description here. 
            /// </summary>
            public string NavigateURL
            {
                get { return _NavigateURL; }
                set { _NavigateURL = value; }
            }
        }
    
}
