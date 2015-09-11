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
    [Subject(typeof(ShopifyBillingService))]
    class When_serializing_true
    {
        Establish context = () =>
        {
            ObjectToSerialize = new TestObject()
            {
                Value = true
            };
        };

        Because of = () =>
        {
            SerializedJson = JsonConvert.SerializeObject(ObjectToSerialize, new FalseToNullConverter());
            ObjectToDeserializeInto = JsonConvert.DeserializeObject<TestObject>(StringToDeserialize, new FalseToNullConverter());
        };

        It should_serialize_true_to_true = () =>
        {
            SerializedJson.ShouldEqual(ExpectedSerializedJson);
        };

        It should_deserialize_true_to_true = () =>
        {
            ObjectToDeserializeInto.Value.ShouldEqual(true);
        };

        Cleanup after = () =>
        {

        };

        static TestObject ObjectToSerialize;

        static TestObject ObjectToDeserializeInto;

        static string SerializedJson;

        static string ExpectedSerializedJson = "{\"Value\":true}";

        static string StringToDeserialize = "{ \"Value\" : \"true\" }";
    }
}
