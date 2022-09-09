namespace devdeer.StringHandlingPipeline.Logic.Transformers
{
    using System;
    using System.Linq;

    using Core.BaseTypes;

    /// <summary>
    /// Replaces the specified character with a another given character in the given message.
    /// </summary>
    public class ReplaceItemTransformer : BaseTransformer
    {
        #region constructors and destructors

        public ReplaceItemTransformer(string currentMessage) : base(currentMessage)
        {
        }

        #endregion

        #region methods

        protected void InternalTransform(string message)
        {
            var replaceOld = 'a';
            var replaceNew = 'b';
            InternalTransform(CurrentMessage, replaceOld, replaceNew);
        }

        /// <summary>
        /// Transforms the actual given <see cref="message" /> and replaces the <see cref="replaceOld" /> character with the
        /// <see cref="replaceNew" /> character.
        /// </summary>
        /// <param name="message">The message you want to transform.</param>
        /// <param name="replaceOld">Character to replace.</param>
        /// <param name="replaceNew">New Character.</param>
        private void InternalTransform(string message, char replaceOld, char replaceNew)
        {
            CurrentMessage = message.Replace(replaceOld, replaceNew);
        }

        #endregion
    }
}