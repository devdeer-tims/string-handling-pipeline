namespace devdeer.StringHandlingPipeline.Logic.Core.BaseTypes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Common.Interfaces;

    /// <summary>
    /// Contains the List of <see cref="TransformIDs" /> to be transformed.
    /// </summary>
    public class BaseCurrentStatus : BaseTransformer, ICurrentStatus
    {
        #region constructors and destructors

        public BaseCurrentStatus(List<int> transformIDs, string message) : base(message)
        {
            TransformIDs = transformIDs;
        }

        #endregion

        #region explicit interfaces

        public List<int> TransformIDs { get; }

        #endregion

        #region methods

        public void DecideTransformation(TransfromIDs)
        {
            //   var x = new Transformer
            while (TransformIDs != null)
            {
                if (TransformIDs[0] == 1)
                {
                    // somehow we need to reference the transformer here
                    TransformIDs.Remove(0);
                }
                if (TransformIDs[1] == 2)
                {
                    // here
                    TransformIDs.Remove(0);
                }
                if (TransformIDs[2] == 3)
                {
                    // here
                    TransformIDs.Remove(0);
                }
                if (TransformIDs[3] == 4)
                {
                    // here
                    TransformIDs.Remove(0);
                }
                if (TransformIDs[4] == 5)
                {
                    // and here   
                    TransformIDs.Remove(0);
                }
            }
        }

        #endregion
    }
}