using Machine.Specifications;
using Newtonsoft.Json;
using ShopifySharp.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.FalseToNullConverter_Tests
{
    [Subject(typeof(RecurringChargeService))]
    class When_serializing_false
    {
        Establish context = () =>
        {
            ObjectToSerialize = new TestObject()
            {
                Value = false
            };
        };

        Because of = () =>
        {
            SerializedJson = JsonConvert.SerializeObject(ObjectToSerialize, new FalseToNullConverter());
            ObjectToDeserializeInto = JsonConvert.DeserializeObject<TestObject>(StringToDeserialize, new FalseToNullConverter());
        };

        It should_serialize_false_to_null = () =>
        {
            SerializedJson.ShouldEqual(ExpectedSerializedJson);
        };

        It should_deserialize_null_to_false = () =>
        {
            ObjectToDeserializeInto.Value.ShouldEqual(false);
        };

        Cleanup after = () =>
        {

        };

        static TestObject ObjectToSerialize;

        static TestObject ObjectToDeserializeInto;

        static string SerializedJson;

        static string ExpectedSerializedJson = "{\"Value\":null}";

        static string StringToDeserialize = "{ \"Value\" : \"\" }";
    }
}
