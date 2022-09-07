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
        #region methods

        /// <summary>
        /// Transforms the givin message to all uppercase letters.
        /// </summary>
        /// <param name="message">The message you want to transform.</param>
        /// <param name="transformationIDs">List of remaining Transformers for the <paramref name="message" />.</param>
        protected override void InternalTransform(string message, List<int> transformationIDs)
        {
            CurrentMessage = message.ToUpper();
            transformationIDs.Remove(0);
        }

        #endregion
    }
}