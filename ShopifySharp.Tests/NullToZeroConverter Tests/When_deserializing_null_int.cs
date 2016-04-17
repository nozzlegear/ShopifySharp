using Machine.Specifications;
using Newtonsoft.Json;
using ShopifySharp.Converters;
using System;

namespace ShopifySharp.Tests.NullToZeroConverter_Tests
{
    [Subject(typeof(NullToZeroConverter))]
    class When_deserializing_null_int
    {
        Establish context = () =>
        {

        };

        Because of = () =>
        {
            //Normal deserialization should fail to convert null or string to int
            Ex = Catch.Exception(() => JsonConvert.DeserializeObject<TestObject>(EmptyValueString));

            //Deserializing with NullToZeroConverter should not throw exception
            EmptyValueResult = JsonConvert.DeserializeObject<TestObject>(EmptyValueString, new NullToZeroConverter());

            //Normal deserialization
            ValueResult = JsonConvert.DeserializeObject<TestObject>(ValueString, new NullToZeroConverter());
        };

        It should_deserialize_null_to_zero = () =>
        {
            EmptyValueResult.Value.ShouldEqual(0);
            ValueResult.Value.ShouldEqual(5);
            Ex.ShouldNotBeNull();
        };

        Cleanup after = () =>
        {

        };

        static TestObject EmptyValueResult;

        static TestObject ValueResult;

        static Exception Ex;
        
        static string EmptyValueString = "{ \"Value\" : \"\" }";

        static string ValueString = " { \"Value\" : 5 } ";
    }
}
