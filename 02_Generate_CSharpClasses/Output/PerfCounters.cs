using System;

using MyCompany.Business;

namespace MyCompany.Business
{
   public class PerfCounters : ObservableObject
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

        private Decimal? _BufferCacheHitRatio;
        public Decimal? BufferCacheHitRatio 
        { 
           get { return _BufferCacheHitRatio; } 
           set 
           { 
               _BufferCacheHitRatio = value;
               base.RaisePropertyChanged();
           } 
        }

        private Int64? _PageReadsPerSec;
        public Int64? PageReadsPerSec 
        { 
           get { return _PageReadsPerSec; } 
           set 
           { 
               _PageReadsPerSec = value;
               base.RaisePropertyChanged();
           } 
        }

        private Int64? _PageWritesPerSecond;
        public Int64? PageWritesPerSecond 
        { 
           get { return _PageWritesPerSecond; } 
           set 
           { 
               _PageWritesPerSecond = value;
               base.RaisePropertyChanged();
           } 
        }

        private Int64? _UserConnections;
        public Int64? UserConnections 
        { 
           get { return _UserConnections; } 
           set 
           { 
               _UserConnections = value;
               base.RaisePropertyChanged();
           } 
        }

        private Int64? _PageLifeExpectency;
        public Int64? PageLifeExpectency 
        { 
           get { return _PageLifeExpectency; } 
           set 
           { 
               _PageLifeExpectency = value;
               base.RaisePropertyChanged();
           } 
        }

        private Int64? _CheckpointPagesPerSecond;
        public Int64? CheckpointPagesPerSecond 
        { 
           get { return _CheckpointPagesPerSecond; } 
           set 
           { 
               _CheckpointPagesPerSecond = value;
               base.RaisePropertyChanged();
           } 
        }

        private Int64? _LazyWritesPerSecond;
        public Int64? LazyWritesPerSecond 
        { 
           get { return _LazyWritesPerSecond; } 
           set 
           { 
               _LazyWritesPerSecond = value;
               base.RaisePropertyChanged();
           } 
        }

        private Int64? _FreeSpaceInTempdbKB;
        public Int64? FreeSpaceInTempdbKB 
        { 
           get { return _FreeSpaceInTempdbKB; } 
           set 
           { 
               _FreeSpaceInTempdbKB = value;
               base.RaisePropertyChanged();
           } 
        }

        private Int64? _BatchRequestsPerSecond;
        public Int64? BatchRequestsPerSecond 
        { 
           get { return _BatchRequestsPerSecond; } 
           set 
           { 
               _BatchRequestsPerSecond = value;
               base.RaisePropertyChanged();
           } 
        }

        private Int64? _SQLCompilationsPerSecond;
        public Int64? SQLCompilationsPerSecond 
        { 
           get { return _SQLCompilationsPerSecond; } 
           set 
           { 
               _SQLCompilationsPerSecond = value;
               base.RaisePropertyChanged();
           } 
        }

        private Int64? _SQLReCompilationsPerSecond;
        public Int64? SQLReCompilationsPerSecond 
        { 
           get { return _SQLReCompilationsPerSecond; } 
           set 
           { 
               _SQLReCompilationsPerSecond = value;
               base.RaisePropertyChanged();
           } 
        }

        private Int64? _Target Server Memory (KB);
        public Int64? Target Server Memory (KB) 
        { 
           get { return _Target Server Memory (KB); } 
           set 
           { 
               _Target Server Memory (KB) = value;
               base.RaisePropertyChanged();
           } 
        }

        private Int64? _Total Server Memory (KB);
        public Int64? Total Server Memory (KB) 
        { 
           get { return _Total Server Memory (KB); } 
           set 
           { 
               _Total Server Memory (KB) = value;
               base.RaisePropertyChanged();
           } 
        }

        private DateTime? _MeasurementTime;
        public DateTime? MeasurementTime 
        { 
           get { return _MeasurementTime; } 
           set 
           { 
               _MeasurementTime = value;
               base.RaisePropertyChanged();
           } 
        }

        private Int32? _avgtaskcount;
        public Int32? avgtaskcount 
        { 
           get { return _avgtaskcount; } 
           set 
           { 
               _avgtaskcount = value;
               base.RaisePropertyChanged();
           } 
        }

        private Int32? _avgrunnabletaskcount;
        public Int32? avgrunnabletaskcount 
        { 
           get { return _avgrunnabletaskcount; } 
           set 
           { 
               _avgrunnabletaskcount = value;
               base.RaisePropertyChanged();
           } 
        }

        private Int32? _avgpendingdiskiocount;
        public Int32? avgpendingdiskiocount 
        { 
           get { return _avgpendingdiskiocount; } 
           set 
           { 
               _avgpendingdiskiocount = value;
               base.RaisePropertyChanged();
           } 
        }

        private Int64? _PercentSignalWait;
        public Int64? PercentSignalWait 
        { 
           get { return _PercentSignalWait; } 
           set 
           { 
               _PercentSignalWait = value;
               base.RaisePropertyChanged();
           } 
        }

        private Int64? _PageLookupsPerSecond;
        public Int64? PageLookupsPerSecond 
        { 
           get { return _PageLookupsPerSecond; } 
           set 
           { 
               _PageLookupsPerSecond = value;
               base.RaisePropertyChanged();
           } 
        }

        private Int64? _TransactionsPerSecond;
        public Int64? TransactionsPerSecond 
        { 
           get { return _TransactionsPerSecond; } 
           set 
           { 
               _TransactionsPerSecond = value;
               base.RaisePropertyChanged();
           } 
        }

        private Int64? _MemoryGrantsPending;
        public Int64? MemoryGrantsPending 
        { 
           get { return _MemoryGrantsPending; } 
           set 
           { 
               _MemoryGrantsPending = value;
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
           System.Diagnostics.Debug.WriteLine("PerfCounters property changed: 
" + propertyName); 
        }
    }

}
