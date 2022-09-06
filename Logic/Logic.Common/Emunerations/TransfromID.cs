namespace devdeer.StringHandlingPipeline.Logic.Common.Emunerations
{
    using System;
    using System.Linq;

    /// <summary>
    /// Contains unique ID's for all possible operations.
    /// </summary>
    [Flags]
    public enum TransfromId
    {
        Lower = 1,
        Revert = 2,
        Upper = 4,
        Remove = 8,
        Replace = 16
    }
}