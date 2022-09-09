namespace devdeer.StringHandlingPipeline.Tests.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Logic.Core.BaseTypes;

    /// <summary>
    /// A transformer which can be used by unit tests.
    /// </summary>
    public class TestTransformer : BaseTransformer
    {
        #region constructors and destructors

        public TestTransformer(string testCallback) : base(currentMessage:testCallback)
        {
            TestCallback = testCallback;
        }

        #endregion

        #region methods

        protected void InternalTransform(string message)
        {
            TestCallback = message;
        }

        #endregion

        #region properties

        public string TestCallback { get; set; }

        #endregion
    }
}