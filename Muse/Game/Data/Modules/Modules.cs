//USING
using UnityEngine;
//USING
using System;
//USING
using System.Collections;
//USING
using System.Collections.Generic;
//USING
public enum ModuleIds { epilogue, menu, p1, p2, p3, prologue };
//CLASS Modules
public partial class Modules {
    ///METHOD Init
    public static void Init (  ) {
        ///METHOD_BODY_START Init
        ModuleData module = null;
        ///MODULE epilogue false _ _ _false
        module = new ModuleData("epilogue", false, false);
        _modules.Add(module.Id, module);
        ///MODULE menu false _ _ _false
        module = new ModuleData("menu", false, false);
        _modules.Add(module.Id, module);
        ///MODULE p1 false _ _ _false
        module = new ModuleData("p1", false, false);
        _modules.Add(module.Id, module);
        ///MODULE p2 false _ _ _false
        module = new ModuleData("p2", false, false);
        _modules.Add(module.Id, module);
        ///MODULE p3 false _ _ _false
        module = new ModuleData("p3", false, false);
        _modules.Add(module.Id, module);
        ///MODULE prologue false _ _ _false
        module = new ModuleData("prologue", false, false);
        _modules.Add(module.Id, module);
        ///METHOD_BODY_END Init
    }
}
//CLASS_END Modules
