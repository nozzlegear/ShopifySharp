#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class FulfillmentOrdersSetFulfillmentDeadlineUserErrorQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrdersSetFulfillmentDeadlineUserError, FulfillmentOrdersSetFulfillmentDeadlineUserErrorQueryBuilder>
    {
        protected override FulfillmentOrdersSetFulfillmentDeadlineUserErrorQueryBuilder Self => this;

        public FulfillmentOrdersSetFulfillmentDeadlineUserErrorQueryBuilder() : this("fulfillmentOrdersSetFulfillmentDeadlineUserError")
        {
        }

        public FulfillmentOrdersSetFulfillmentDeadlineUserErrorQueryBuilder(string name) : base(new Query<FulfillmentOrdersSetFulfillmentDeadlineUserError>(name))
        {
        }

        public FulfillmentOrdersSetFulfillmentDeadlineUserErrorQueryBuilder(IQuery<FulfillmentOrdersSetFulfillmentDeadlineUserError> query) : base(query)
        {
        }

        public FulfillmentOrdersSetFulfillmentDeadlineUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public FulfillmentOrdersSetFulfillmentDeadlineUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public FulfillmentOrdersSetFulfillmentDeadlineUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}