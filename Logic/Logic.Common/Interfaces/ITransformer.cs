namespace devdeer.StringHandlingPipeline.Logic.Common.Interfaces
{
    using System;
    using System.Linq;

    /// <summary>
    /// Must be implemented by all Transformers.
    /// </summary>
    public interface ITransformer
    {
        #region methods

        /// <summary>
        /// Transform the given <paramref name="message" />.
        /// </summary>
        /// <param name="message">The message you want to transform.</param>
        void Transform(string message);

        #endregion

        #region properties

        string CurrentMessage { get; set; }

        #endregion
    }
}