#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class FulfillmentOrdersSetFulfillmentDeadlinePayloadQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrdersSetFulfillmentDeadlinePayload, FulfillmentOrdersSetFulfillmentDeadlinePayloadQueryBuilder>
    {
        protected override FulfillmentOrdersSetFulfillmentDeadlinePayloadQueryBuilder Self => this;

        public FulfillmentOrdersSetFulfillmentDeadlinePayloadQueryBuilder() : this("fulfillmentOrdersSetFulfillmentDeadlinePayload")
        {
        }

        public FulfillmentOrdersSetFulfillmentDeadlinePayloadQueryBuilder(string name) : base(new Query<FulfillmentOrdersSetFulfillmentDeadlinePayload>(name))
        {
        }

        public FulfillmentOrdersSetFulfillmentDeadlinePayloadQueryBuilder(IQuery<FulfillmentOrdersSetFulfillmentDeadlinePayload> query) : base(query)
        {
        }

        public FulfillmentOrdersSetFulfillmentDeadlinePayloadQueryBuilder Success()
        {
            base.InnerQuery.AddField("success");
            return this;
        }

        public FulfillmentOrdersSetFulfillmentDeadlinePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrdersSetFulfillmentDeadlineUserErrorQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrdersSetFulfillmentDeadlineUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrdersSetFulfillmentDeadlineUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrdersSetFulfillmentDeadlineUserError>(query);
            return this;
        }
    }
}