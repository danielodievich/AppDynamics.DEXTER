﻿using System;

namespace AppDynamics.Dexter.ReportObjects
{
    public class ApplicationHealthCheck
    {
        #region APMConfiguration Items
        public string Controller { get; set; }
        public string ApplicationName { get; set; }
        public long ApplicationID { get; set; }
        public int NumTiers { get; set; }
        public int NumBTs { get; set; }

        public bool IsDeveloperModeEnabled { get; set; }
        public bool IsBTLockdownEnabled { get; set; }
        
        #endregion

        public string IsBTOverflow { get; set; }
        public string IsCustomBTRules { get; set; }
        public string IsBTErrorRateHigh { get; set; }
        public string IsCustomSEPRules { get; set; }
        public string IsBackendOverflow { get; set; }
        public string NumDataCollectorsEnabled { get; set; }
        public string NumInfoPoints { get; set; }

        public string IsHRViolationsHigh { get; set; }
        public string IsPoliciesAndActionsEnabled { get; set; }

        public string AppAgentVersion { get; set; }
        public string MachineAgentVersion { get; set; }
        public string MachineAgentEnabledPercent { get; set; }
        public string TiersActivePercent { get; set; }
        public string NodesActivePercent { get; set; }


        public override String ToString()
        {
            return String.Format(
                "ApplicationHealthCheck: {0}/{1}({2})",
                this.Controller,
                this.ApplicationName,
                this.ApplicationID);
        }
    }
}
