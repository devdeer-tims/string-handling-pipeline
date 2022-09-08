namespace devdeer.StringHandlingPipeline.Logic.Transformers
{
    using System;
    using System.Linq;

    public class TransformerContext
    {
        #region constructors and destructors

        public TransformerContext(string message)
        {
            Message = message;
        }

        #endregion

        #region properties

        public ToLowerTransformer ToLowerTransformer => new(Message);

        //       public ToUpperTransformer ToUpperTransformer => new(Message);

        private string Message { get; }

        #endregion
    }
}