using System;

using MyCompany.Business;

namespace MyCompany.Business
{
   public class sp_whoisactive_data : ObservableObject
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

        private String _dd hh:mm:ss.mss;
        public String dd hh:mm:ss.mss 
        { 
           get { return _dd hh:mm:ss.mss; } 
           set 
           { 
               _dd hh:mm:ss.mss = value;
               base.RaisePropertyChanged();
           } 
        }

        private Int16? _session_id;
        public Int16? session_id 
        { 
           get { return _session_id; } 
           set 
           { 
               _session_id = value;
               base.RaisePropertyChanged();
           } 
        }

        private String _sql_text;
        public String sql_text 
        { 
           get { return _sql_text; } 
           set 
           { 
               _sql_text = value;
               base.RaisePropertyChanged();
           } 
        }

        private String _login_name;
        public String login_name 
        { 
           get { return _login_name; } 
           set 
           { 
               _login_name = value;
               base.RaisePropertyChanged();
           } 
        }

        private String _wait_info;
        public String wait_info 
        { 
           get { return _wait_info; } 
           set 
           { 
               _wait_info = value;
               base.RaisePropertyChanged();
           } 
        }

        private String _CPU;
        public String CPU 
        { 
           get { return _CPU; } 
           set 
           { 
               _CPU = value;
               base.RaisePropertyChanged();
           } 
        }

        private String _tempdb_allocations;
        public String tempdb_allocations 
        { 
           get { return _tempdb_allocations; } 
           set 
           { 
               _tempdb_allocations = value;
               base.RaisePropertyChanged();
           } 
        }

        private String _tempdb_current;
        public String tempdb_current 
        { 
           get { return _tempdb_current; } 
           set 
           { 
               _tempdb_current = value;
               base.RaisePropertyChanged();
           } 
        }

        private String _blocking_session_id;
        public String blocking_session_id 
        { 
           get { return _blocking_session_id; } 
           set 
           { 
               _blocking_session_id = value;
               base.RaisePropertyChanged();
           } 
        }

        private String _reads;
        public String reads 
        { 
           get { return _reads; } 
           set 
           { 
               _reads = value;
               base.RaisePropertyChanged();
           } 
        }

        private String _writes;
        public String writes 
        { 
           get { return _writes; } 
           set 
           { 
               _writes = value;
               base.RaisePropertyChanged();
           } 
        }

        private String _physical_reads;
        public String physical_reads 
        { 
           get { return _physical_reads; } 
           set 
           { 
               _physical_reads = value;
               base.RaisePropertyChanged();
           } 
        }

        private String _used_memory;
        public String used_memory 
        { 
           get { return _used_memory; } 
           set 
           { 
               _used_memory = value;
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

        private String _open_tran_count;
        public String open_tran_count 
        { 
           get { return _open_tran_count; } 
           set 
           { 
               _open_tran_count = value;
               base.RaisePropertyChanged();
           } 
        }

        private String _percent_complete;
        public String percent_complete 
        { 
           get { return _percent_complete; } 
           set 
           { 
               _percent_complete = value;
               base.RaisePropertyChanged();
           } 
        }

        private String _host_name;
        public String host_name 
        { 
           get { return _host_name; } 
           set 
           { 
               _host_name = value;
               base.RaisePropertyChanged();
           } 
        }

        private String _database_name;
        public String database_name 
        { 
           get { return _database_name; } 
           set 
           { 
               _database_name = value;
               base.RaisePropertyChanged();
           } 
        }

        private String _program_name;
        public String program_name 
        { 
           get { return _program_name; } 
           set 
           { 
               _program_name = value;
               base.RaisePropertyChanged();
           } 
        }

        private DateTime? _start_time;
        public DateTime? start_time 
        { 
           get { return _start_time; } 
           set 
           { 
               _start_time = value;
               base.RaisePropertyChanged();
           } 
        }

        private DateTime? _login_time;
        public DateTime? login_time 
        { 
           get { return _login_time; } 
           set 
           { 
               _login_time = value;
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

        private DateTime? _collection_time;
        public DateTime? collection_time 
        { 
           get { return _collection_time; } 
           set 
           { 
               _collection_time = value;
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
           System.Diagnostics.Debug.WriteLine("sp_whoisactive_data property 
changed: " + propertyName); 
        }
    }

}
