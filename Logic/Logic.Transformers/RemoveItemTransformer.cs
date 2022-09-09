namespace devdeer.StringHandlingPipeline.Logic.Transformers
{
    using System;
    using System.Linq;

    using Core.BaseTypes;

    /// <summary>
    /// Removes a specified character from the given message.
    /// </summary>
    public class RemoveItemTransformer : BaseTransformer
    {
        #region constructors and destructors

        public RemoveItemTransformer(string currentMessage) : base(currentMessage)
        {
        }

        #endregion

        #region methods

        protected void InternalTransform(string message)
        {
            var charToRemove = 'a';
            InternalTransform(CurrentMessage, charToRemove);
        }

        /// <summary>
        /// Transforms the actual given <see cref="message" /> and removes the <see cref="charToRemove" /> character.
        /// </summary>
        /// <param name="message">The message you want to transform.</param>
        /// <param name="charToRemove">The character you want to remove.</param>
        private void InternalTransform(string message, char charToRemove)
        {
            CurrentMessage.Remove(charToRemove);
        }

        #endregion
    }
}