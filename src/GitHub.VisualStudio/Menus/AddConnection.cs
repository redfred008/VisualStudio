﻿using GitHub.Services;
using GitHub.UI;
using NullGuard;
using System;

namespace GitHub.VisualStudio.Menus
{
    public class AddConnection: MenuBase, IMenuHandler
    {
        public AddConnection(IUIProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        public Guid Guid => GuidList.guidGitHubCmdSet;
        public int CmdId => PkgCmdIDList.addConnectionCommand;

        public void Activate([AllowNull]object data = null)
        {
            StartFlow(UIControllerFlow.Authentication);
        }
    }
}
