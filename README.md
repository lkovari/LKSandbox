# LKSandbox
C# practicing, (generics, interfaces etc.)
Currently modeling a vehicle chassis and engine assembly, (I would like to emphasize just for practicing purposes, this implementation is not an exhaustive solution). I tried to "process" different vehicle part types which descendant of interface IVehiclePartType. Each type has three functions HasApprovalToBuild, BuildDuration, TotalCost, which serving us the result data (like as inherited interfaces from IResultData). Each function can get parameters to determine the result, the parameters inherited from IParameters. 
