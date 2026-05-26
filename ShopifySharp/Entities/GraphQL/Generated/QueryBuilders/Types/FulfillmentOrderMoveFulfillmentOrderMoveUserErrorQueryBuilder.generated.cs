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
    public sealed class FulfillmentOrderMoveFulfillmentOrderMoveUserErrorQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderMoveFulfillmentOrderMoveUserError, FulfillmentOrderMoveFulfillmentOrderMoveUserErrorQueryBuilder>
    {
        protected override FulfillmentOrderMoveFulfillmentOrderMoveUserErrorQueryBuilder Self => this;

        public FulfillmentOrderMoveFulfillmentOrderMoveUserErrorQueryBuilder() : this("fulfillmentOrderMoveFulfillmentOrderMoveUserError")
        {
        }

        public FulfillmentOrderMoveFulfillmentOrderMoveUserErrorQueryBuilder(string name) : base(new Query<FulfillmentOrderMoveFulfillmentOrderMoveUserError>(name))
        {
        }

        public FulfillmentOrderMoveFulfillmentOrderMoveUserErrorQueryBuilder(IQuery<FulfillmentOrderMoveFulfillmentOrderMoveUserError> query) : base(query)
        {
        }

        public FulfillmentOrderMoveFulfillmentOrderMoveUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public FulfillmentOrderMoveFulfillmentOrderMoveUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public FulfillmentOrderMoveFulfillmentOrderMoveUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}