namespace devdeer.StringHandlingPipeline.Logic.Common.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Must be implemented by all Transformers.
    /// </summary>
    public interface ITransformer
    {
        #region methods

        /// <summary>
        /// Transform the given <paramref name="message" /> with all provided <paramref name="transformationIDs" />.
        /// </summary>
        /// <param name="message">The message you want to transform.</param>
        /// <param name="transformationIDs">The list of operations you provide.</param>
        void Transform(string message, List<int> transformationIDs);

        #endregion
    }
}