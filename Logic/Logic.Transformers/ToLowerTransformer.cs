namespace devdeer.StringHandlingPipeline.Logic.Transformers
{
    using System;
    using System.Linq;

    using Core.BaseTypes;

    /// <summary>
    /// Implements the ToLowerTransformer.
    /// </summary>
    public class ToLowerTransformer : BaseTransformer
    {
        #region constructors and destructors

        internal ToLowerTransformer(string message) : base(message)
        {
        }

        #endregion

        #region methods

        /// <summary>
        /// Transforms the given message to all lowercase letters.
        /// </summary>
        /// <param name="message">The message you want to transform.</param>
        protected void InternalTransform(string message)
        {
            CurrentMessage = message.ToLower();
        }

        #endregion
    }
}