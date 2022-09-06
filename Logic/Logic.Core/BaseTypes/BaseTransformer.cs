namespace devdeer.StringHandlingPipeline.Logic.Core.BaseTypes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Common.Interfaces;

    /// <summary>
    /// Abstract base class for all Transformers.
    /// </summary>
    public abstract class BaseTransformer : ITransformer
    {
        #region member vars

        public string CurrentMessage = string.Empty;

        #endregion

        #region explicit interfaces

        public void Transform(string message, List<int> transformationIDs)
        {
            var transformedMessage = $"{message} was transformed with following Transformers: {transformationIDs}";
            InternalTransform(transformedMessage, transformationIDs);
        }

        #endregion

        #region methods

        /// <summary>
        /// Must be overridden by children to handle the actual transform.
        /// </summary>
        /// <param name="message">The message you want to transform.</param>
        /// <param name="transformationIDs">The provided transform-operations.</param>
        protected abstract void InternalTransform(string message, List<int> transformationIDs);

        #endregion
    }
}