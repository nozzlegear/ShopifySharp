using Machine.Specifications;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShopifySharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyThemeService_Tests
{
    [Subject(typeof(ShopifyTransactionService)), Tags("Transaction")]
    class When_deserializing_a_transaction
    {
        Establish context = () =>
        {

        };

        Because of = () =>
        {
            Transaction1 = JsonConvert.DeserializeObject<ShopifyTransaction>(TransactionJson);
            
            Transaction2 = JsonConvert.DeserializeObject<ShopifyTransaction>(Transaction2Json);

            Transaction3 = JsonConvert.DeserializeObject<ShopifyTransaction>(Transaction3Json);

            Transaction4 = JsonConvert.DeserializeObject<ShopifyTransaction>(Transaction4Json);
        };

        It should_deserialize_a_transaction = () =>
        {
            Transaction1.Kind.ShouldEqual("capture");
            Transaction1.ErrorCode.ShouldEqual("card_declined");
            
            Transaction2.Kind.ShouldEqual("void");
            Transaction2.ErrorCode.ShouldEqual("incorrect_address");
            
            Transaction3.Test.HasValue.ShouldBeFalse();

            Transaction4.Test.HasValue.ShouldBeTrue();
            Transaction4.Test.Value.ShouldBeTrue();
        };

        Cleanup after = () =>
        {

        };

        static string TransactionJson { get; } = "{\"id\": 1068278477,\"order_id\": 450789469,\"amount\": \"409.94\",\"kind\": \"capture\",\"gateway\": \"bogus\",\"status\": \"success\",\"message\": \"Bogus Gateway: Forced success\",\"created_at\": \"2015-12-08T11:40:41-05:00\",\"test\": true,\"authorization\": null,\"currency\": \"USD\",\"location_id\": null,\"user_id\": null,\"parent_id\": 389404469,\"device_id\": null,\"receipt\": {},\"error_code\":\"card_declined\",\"source_name\": \"755357713\"}";

        static string Transaction2Json { get; } = "{\"id\": 1068278477,\"order_id\": 450789469,\"amount\": \"409.94\",\"kind\": \"void\",\"gateway\": \"bogus\",\"status\": \"success\",\"message\": \"Bogus Gateway: Forced success\",\"created_at\": \"2015-12-08T11:40:41-05:00\",\"test\": true,\"authorization\": null,\"currency\": \"USD\",\"location_id\": null,\"user_id\": null,\"parent_id\": 389404469,\"device_id\": null,\"receipt\": {},\"error_code\": \"incorrect_address\",\"source_name\": \"755357713\"}";

        static string Transaction3Json { get; } = "{\"id\": 1068278477,\"order_id\": 450789469,\"amount\": \"409.94\",\"kind\": \"void\",\"gateway\": \"bogus\",\"status\": \"success\",\"message\": \"Bogus Gateway: Forced success\",\"created_at\": \"2015-12-08T11:40:41-05:00\",\"test\": null,\"authorization\": null,\"currency\": \"USD\",\"location_id\": null,\"user_id\": null,\"parent_id\": 389404469,\"device_id\": null,\"receipt\": {},\"error_code\": \"incorrect_address\",\"source_name\": \"755357713\"}";

        static string Transaction4Json { get; } = "{\"id\": 1068278477,\"order_id\": 450789469,\"amount\": \"409.94\",\"kind\": \"void\",\"gateway\": \"bogus\",\"status\": \"success\",\"message\": \"Bogus Gateway: Forced success\",\"created_at\": \"2015-12-08T11:40:41-05:00\",\"test\": true,\"authorization\": null,\"currency\": \"USD\",\"location_id\": null,\"user_id\": null,\"parent_id\": 389404469,\"device_id\": null,\"receipt\": {},\"error_code\": \"incorrect_address\",\"source_name\": \"755357713\"}";

        static ShopifyTransaction Transaction1 { get; set; }

        static ShopifyTransaction Transaction2 { get; set; }

        static ShopifyTransaction Transaction3 { get; set; }

        static ShopifyTransaction Transaction4 { get; set; }
    }
}
