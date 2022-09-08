namespace devdeer.StringHandlingPipeline.Logic.Core.BaseTypes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography;

    using Common.Emunerations;
    using Common.Interfaces;

    /// <summary>
    /// Contains the List of <see cref="TransformIDs" /> to be transformed.
    /// </summary>
    public class BaseCurrentStatus : BaseTransformer, ICurrentStatus
    {
        #region constructors and destructors

        public BaseCurrentStatus(List<int> transformIDs) : base()
        {
            TransformIDs = transformIDs;
        }

        #endregion
        
        

        public void DecideTransformation(TransfromId)
        {
            var x = new Transformer
            while (TransformIDs != null)
            {
                if (TransformIDs[0] == 1){
                    
                    TransformIDs.Remove(0);
                }
                if (TransformIDs[1] == 2)
                {

                    TransformIDs.Remove(0);
                }
                if (TransformIDs[2] == 3)
                {

                    TransformIDs.Remove(0);
                }
                if (TransformIDs[3] == 4)
                {

                    TransformIDs.Remove(0);
                }
                if (TransformIDs[4] == 5)
                {

                    TransformIDs.Remove(0);
                }
            }
        }

        #region explicit interfaces

        public List<int> TransformIDs { get; }

        #endregion
    }
}