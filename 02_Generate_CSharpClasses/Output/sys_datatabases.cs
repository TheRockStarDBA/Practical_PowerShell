using System;

using MyCompany.Business;

namespace MyCompany.Business
{
   public class sys_datatabases : ObservableObject
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

        private String _name;
        public String name 
        { 
           get { return _name; } 
           set 
           { 
               _name = value;
               base.RaisePropertyChanged();
           } 
        }

        private Int32? _database_id;
        public Int32? database_id 
        { 
           get { return _database_id; } 
           set 
           { 
               _database_id = value;
               base.RaisePropertyChanged();
           } 
        }

        private DateTime? _create_date;
        public DateTime? create_date 
        { 
           get { return _create_date; } 
           set 
           { 
               _create_date = value;
               base.RaisePropertyChanged();
           } 
        }

        private String _collation_name;
        public String collation_name 
        { 
           get { return _collation_name; } 
           set 
           { 
               _collation_name = value;
               base.RaisePropertyChanged();
           } 
        }

        private String _state_desc;
        public String state_desc 
        { 
           get { return _state_desc; } 
           set 
           { 
               _state_desc = value;
               base.RaisePropertyChanged();
           } 
        }

        private String _recovery_model_desc;
        public String recovery_model_desc 
        { 
           get { return _recovery_model_desc; } 
           set 
           { 
               _recovery_model_desc = value;
               base.RaisePropertyChanged();
           } 
        }

        private String _log_reuse_wait_desc;
        public String log_reuse_wait_desc 
        { 
           get { return _log_reuse_wait_desc; } 
           set 
           { 
               _log_reuse_wait_desc = value;
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
           System.Diagnostics.Debug.WriteLine("sys_datatabases property 
changed: " + propertyName); 
        }
    }

}
