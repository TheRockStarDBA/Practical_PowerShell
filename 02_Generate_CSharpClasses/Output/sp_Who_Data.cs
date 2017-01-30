using System;

using MyCompany.Business;

namespace MyCompany.Business
{
   public class sp_Who_Data : ObservableObject
   {
   #region Instance Properties

        private String _ServerName;
        public String ServerName 
        { 
           get { return _ServerName; } 
           set 
           { 
               _ServerName = value;
               base.RaisePropertyChanged();
           } 
        }

        private DateTime? _DateTimeStamp;
        public DateTime? DateTimeStamp 
        { 
           get { return _DateTimeStamp; } 
           set 
           { 
               _DateTimeStamp = value;
               base.RaisePropertyChanged();
           } 
        }

        private Int16? _spid;
        public Int16? spid 
        { 
           get { return _spid; } 
           set 
           { 
               _spid = value;
               base.RaisePropertyChanged();
           } 
        }

        private Int16? _ecid;
        public Int16? ecid 
        { 
           get { return _ecid; } 
           set 
           { 
               _ecid = value;
               base.RaisePropertyChanged();
           } 
        }

        private String _status;
        public String status 
        { 
           get { return _status; } 
           set 
           { 
               _status = value;
               base.RaisePropertyChanged();
           } 
        }

        private String _loginame;
        public String loginame 
        { 
           get { return _loginame; } 
           set 
           { 
               _loginame = value;
               base.RaisePropertyChanged();
           } 
        }

        private String _hostname;
        public String hostname 
        { 
           get { return _hostname; } 
           set 
           { 
               _hostname = value;
               base.RaisePropertyChanged();
           } 
        }

        private String _blk;
        public String blk 
        { 
           get { return _blk; } 
           set 
           { 
               _blk = value;
               base.RaisePropertyChanged();
           } 
        }

        private String _dbname;
        public String dbname 
        { 
           get { return _dbname; } 
           set 
           { 
               _dbname = value;
               base.RaisePropertyChanged();
           } 
        }

        private String _cmd;
        public String cmd 
        { 
           get { return _cmd; } 
           set 
           { 
               _cmd = value;
               base.RaisePropertyChanged();
           } 
        }

        private Int32? _request_id;
        public Int32? request_id 
        { 
           get { return _request_id; } 
           set 
           { 
               _request_id = value;
               base.RaisePropertyChanged();
           } 
        }

        private String _RowError;
        public String RowError 
        { 
           get { return _RowError; } 
           set 
           { 
               _RowError = value;
               base.RaisePropertyChanged();
           } 
        }

        private String _RowState;
        public String RowState 
        { 
           get { return _RowState; } 
           set 
           { 
               _RowState = value;
               base.RaisePropertyChanged();
           } 
        }

        private String _Table;
        public String Table 
        { 
           get { return _Table; } 
           set 
           { 
               _Table = value;
               base.RaisePropertyChanged();
           } 
        }

        private String _ItemArray;
        public String ItemArray 
        { 
           get { return _ItemArray; } 
           set 
           { 
               _ItemArray = value;
               base.RaisePropertyChanged();
           } 
        }

        private Boolean? _HasErrors;
        public Boolean? HasErrors 
        { 
           get { return _HasErrors; } 
           set 
           { 
               _HasErrors = value;
               base.RaisePropertyChanged();
           } 
        }

    #endregion Instance Properties
    
        protected override void AfterPropertyChanged(string propertyName) 
        { 
           System.Diagnostics.Debug.WriteLine("sp_Who_Data property changed: " 
+ propertyName); 
        }
    }

}
