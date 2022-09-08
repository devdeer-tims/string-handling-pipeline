namespace devdeer.StringHandlingPipeline.Logic.Common.Interfaces
{
    using System.Collections.Generic;

    public interface ICurrentStatus
    {
        List<int> TransformIDs { get; }
    }
}