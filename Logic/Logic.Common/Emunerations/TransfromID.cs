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
        Upper = 2,
        Reverse = 3,
        Remove = 4,
        Replace = 5
    }
}