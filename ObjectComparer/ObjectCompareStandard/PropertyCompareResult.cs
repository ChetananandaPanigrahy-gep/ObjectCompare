using System;
using System.Collections.Generic;
using System.Text;

namespace ObjComparerMinimal
{
    public class PropertyCompareResult
    {
        public string PropertyPath { get; private set; }
        public object OldValue { get; private set; }
        public object NewValue { get; private set; }

        public PropertyCompareResult(string propertyPath, object oldValue, object newValue)
        {
            PropertyPath = propertyPath;
            OldValue = oldValue;
            NewValue = newValue;
        }
    }
}
