﻿using System;

namespace InvokeIR.PowerForensics.Artifacts
{
    public class ScheduledTask
    {
        #region Properties

        public string Path;
        public string Name;
        public string Author;
        public string Description;

        #endregion Properties

        #region Constructors

        internal ScheduledTask(byte[] bytes)
        {
            

        }

        #endregion Constructors
    }
}
