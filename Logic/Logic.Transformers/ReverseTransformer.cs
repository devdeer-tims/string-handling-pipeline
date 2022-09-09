namespace devdeer.StringHandlingPipeline.Logic.Transformers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Core.BaseTypes;

    /// <summary>
    /// Implements the ReverseTransformer.
    /// </summary>
    public class ReverseTransformer : BaseTransformer
    {
        internal ReverseTransformer(string message) : base(message)
        {
        }
        #region methods

        /// <summary>
        /// Reverses the given message.
        /// </summary>
        /// <param name="message">The message you want to transform.</param>
        protected void InternalTransform(string message)
        {
            CurrentMessage = (string)message.Reverse();
        }

        #endregion
    }
}