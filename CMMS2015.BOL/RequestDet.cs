using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMMS2015.BOL
{
    [Serializable]
    public class RequestDet
    {
        //Property, Building, Shop, Comments
           
        #region "Private properties"
        private string _requestedBy = string.Empty;
        private string _property = string.Empty;
      
        private string _requesterBuilding = string.Empty;
        private string _description = string.Empty;
        //private string _phone1 = string.Empty;
        //private string _phone2 = string.Empty;
        //private string _phone3 = string.Empty;
        private string _phone = string.Empty;
       // private string _cAN = string.Empty;
        private DateTime _requestedOn = DateTime.MinValue;
        private string _requesterRoom = string.Empty;
        //private string _personnel = string.Empty;
        //private string _contractOfficer = string.Empty;

        private string _status = string.Empty;
        private int _wonumber = -1;

        public string Building { get; set; }
        public string Shop { get; set; }
        public string Comments { get; set; }
   
        #endregion

        #region " Business Properties
        
        public string Property
        {
            get { return _property; }
            set
            {
                _property = value;
            }
        }
       
        public string RequesterBuilding
        {
            get { return _requesterBuilding; }
            set
            {
                _requesterBuilding = value;
            }
        }
       
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
            }
        }
      
        public string Status
        {
            get { return _status; }
            set
            {
                _status = value;
            }
        }
        
        

        public string RequesterPhone
        {
            get { return _phone; }
            set
            {
                _phone = value;
            }
        }
        
        public DateTime RequestedOn
        {
            get { return _requestedOn; }
            set
            {
                _requestedOn = value;
            }
        }


        public string RequesterRoom
        {
            get { return _requesterRoom; }
            set
            {
                _requesterRoom = value;
            }
        }

      
        public int WONumber
        {
            get { return _wonumber; }
            set
            {
                _wonumber = value;
            }
        }
        public string RequestedBy
        {
            get { return _requestedBy; }
            set
            {
                _requestedBy = value;
            }
        }
       
        #endregion
    }
}
