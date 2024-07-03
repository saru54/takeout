using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commen
{
    public class CopyHelper
    {
        public static TTarget PropertyCopy<TSource,TTarget>(TSource source , TTarget target) where TTarget : new ()
        {
            TTarget result = new TTarget();
            var SourceProperties = source.GetType().GetProperties();
            var targetProperties = target.GetType().GetProperties();
            foreach ( var sourceProperty in SourceProperties )
            {
                foreach(var targetProperty in targetProperties )
                {
                    if (sourceProperty.Name == targetProperty.Name && sourceProperty.PropertyType == targetProperty.PropertyType)
                    {
                        sourceProperty.SetValue(result,sourceProperty.GetValue(source));
                    }
                }
            }
            return result;
        }

    }
}
