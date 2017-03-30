using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.Test_Data
{
    class MetaFieldCreation
    {
        public static MetaField CreateValidMetaField1()
        {
            return new ShopifySharp.MetaField()
            {
                Namespace = "testing",
                Key = "test_key1",
                Value = "5",
                ValueType = "integer",
                Description = "This is a test meta field. It is an integer value.",
            };
        }

        public static MetaField CreateValidMetaField2()
        {
            return new ShopifySharp.MetaField()
            {
                Namespace = "testing",
                Key = "test_key2",
                Value = "22",
                ValueType = "integer",
                Description = "This is a test meta field. It is an integer value.",
            };
        }

        public static MetaField CreateValidMetaField3()
        {
            return new ShopifySharp.MetaField()
            {
                Namespace = "testing",
                Key = "test_key3",
                Value = "This is a string",
                ValueType = "string",
                Description = "This is a test meta field. It is a string value.",
            };
        }
    }
}
