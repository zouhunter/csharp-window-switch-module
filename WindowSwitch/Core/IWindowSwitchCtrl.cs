﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Diagnostics;
public interface IWindowSwitchCtrl {
    IntPtr Parent { get; }
    bool OnOpenedByParent(out string[] args);
    void OpenChildWindow(string path,bool hideThis,params string[] args);
    bool CloseChildWindow();
    void OnCloseThisThisWindow();
}
