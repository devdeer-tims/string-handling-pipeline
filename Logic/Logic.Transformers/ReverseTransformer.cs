namespace devdeer.StringHandlingPipeline.Logic.Transformers
{
    using System.Collections.Generic;
    using System.Linq;

    using Core.BaseTypes;
    /// <summary>
    /// Implements the ReverseTransformer.
    /// </summary>
    public class ReverseTransformer : BaseTransformer
    {
        /// <summary>
        /// Reverses the givin message.
        /// </summary>
        /// <param name="message">The message you want to transform.</param>
        /// <param name="transformationIDs">List of remaining Transformers for the <paramref name="message" />.</param>

        protected override void InternalTransform(string message, List<int> transformationIDs)
        {
            CurrentMessage = (string)message.Reverse();
            transformationIDs.Remove(0);
        }
    }
}