namespace devdeer.StringHandlingPipeline.Logic.Transformers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Core.BaseTypes;

    /// <summary>
    /// Implements the ToUpperTransformer.
    /// </summary>
    public class ToUpperTransformer : BaseTransformer
    {
        internal ToUpperTransformer(string message) : base(message)
        {
        }
        #region methods

        /// <summary>
        /// Transforms the given message to all uppercase letters.
        /// </summary>
        /// <param name="message">The message you want to transform.</param>
        protected void InternalTransform(string message)
        {
            CurrentMessage = message.ToUpper();
        }

        #endregion
    }
}