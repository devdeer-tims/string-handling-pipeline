namespace devdeer.StringHandlingPipeline.Logic.Core.BaseTypes
{
    using System;
    using System.Linq;

    using Common.Interfaces;

    /// <summary>
    /// Abstract base class for all Transformers.
    /// </summary>
    public abstract class BaseTransformer : ITransformer
    {
        #region constructors and destructors

        public BaseTransformer(string currentMessage)
        {
            CurrentMessage = currentMessage;
        }

        #endregion

        #region explicit interfaces

        public string CurrentMessage { get; set; }

        public void Transform(string message)
        {
            
        }

        #endregion
    }
}