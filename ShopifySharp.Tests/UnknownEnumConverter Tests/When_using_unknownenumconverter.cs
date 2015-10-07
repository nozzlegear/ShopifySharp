using Machine.Specifications;
using Newtonsoft.Json;
using ShopifySharp.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.UnknownEnumConverter_Tests
{
    [Subject("UnknownEnumConverter")]
    class When_serializing_true
    {
        Establish context = () =>
        {
            ObjectToSerializeToUnknown = new TestObject()
            {
                Value = Enums.ShopifyProcessingMethod.Unknown
            };

            ObjectToSerializeToKnown = new TestObject()
            {
                Value = Enums.ShopifyProcessingMethod.Free
            };
        };

        Because of = () =>
        {
            SerializedToNullJson = JsonConvert.SerializeObject(ObjectToSerializeToUnknown, new FalseToNullConverter());
            SerializedToKnownJson = JsonConvert.SerializeObject(ObjectToSerializeToKnown, new FalseToNullConverter());
            ObjectToDeserializeToUnknown = JsonConvert.DeserializeObject<TestObject>(StringToDeserializeToUnknown, new FalseToNullConverter());
            ObjectToDeserializeToKnown = JsonConvert.DeserializeObject<TestObject>(StringToDeserializeToKnown, new FalseToNullConverter());
        };

        It should_serialize_to_null = () =>
        {
            SerializedToNullJson.ShouldEqual(ExpectedSerializedToNullJson);
        };

        It should_serialize_to_known = () =>
        {
            SerializedToKnownJson.ShouldEqual(ExpectedSerializedToKnownJson);
        };

        It should_deserialize_to_unknown = () =>
        {
            ObjectToDeserializeToUnknown.Value.ShouldEqual( Enums.ShopifyProcessingMethod.Unknown);
        };

        It should_deserialize_to_known = () =>
        {
            ObjectToDeserializeToKnown.Value.ShouldEqual(Enums.ShopifyProcessingMethod.Free);
        };


        Cleanup after = () =>
        {

        };

        static TestObject ObjectToSerializeToUnknown;

        static TestObject ObjectToSerializeToKnown;

        static TestObject ObjectToDeserializeToUnknown;

        static TestObject ObjectToDeserializeToKnown;

        static string SerializedToNullJson;

        static string ExpectedSerializedToNullJson = "{\"Value\":null}";

        static string SerializedToKnownJson;

        static string ExpectedSerializedToKnownJson = "{\"Value\":\"free\"}";

        static string StringToDeserializeToUnknown = "{ \"Value\" : \"someRandomString\" }";

        static string StringToDeserializeToKnown = "{ \"Value\" : \"free\" }";
    }
}
