sc STOP  AsusAppService
sc STOP  ASUSLinkNear
sc STOP  ASUSLinkRemote
sc STOP  ASUSSoftwareManager
sc STOP  ASUSSwitch
sc STOP  ASUSSystemAnalysis
sc STOP  ASUSSystemDiagnosis
sc STOP ArmouryCrateControlInterface

sc config  AsusAppService start= disabled
sc config  ASUSLinkNear start= disabled
sc config  ASUSLinkRemote start= disabled
sc config  ASUSSoftwareManager start= disabled
sc config  ASUSSwitch start= disabled
sc config  ASUSSystemAnalysis start= disabled
sc config  ASUSSystemDiagnosis start= disabled
sc config  ArmouryCrateControlInterface start= disabled

set /p asd="Hit enter to finish"
