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
    public sealed class FulfillmentConstraintRuleDeletePayloadQueryBuilder : FieldsQueryBuilderBase<FulfillmentConstraintRuleDeletePayload, FulfillmentConstraintRuleDeletePayloadQueryBuilder>
    {
        protected override FulfillmentConstraintRuleDeletePayloadQueryBuilder Self => this;

        public FulfillmentConstraintRuleDeletePayloadQueryBuilder() : this("fulfillmentConstraintRuleDeletePayload")
        {
        }

        public FulfillmentConstraintRuleDeletePayloadQueryBuilder(string name) : base(new Query<FulfillmentConstraintRuleDeletePayload>(name))
        {
        }

        public FulfillmentConstraintRuleDeletePayloadQueryBuilder(IQuery<FulfillmentConstraintRuleDeletePayload> query) : base(query)
        {
        }

        public FulfillmentConstraintRuleDeletePayloadQueryBuilder Success()
        {
            base.InnerQuery.AddField("success");
            return this;
        }

        public FulfillmentConstraintRuleDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentConstraintRuleDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<FulfillmentConstraintRuleDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentConstraintRuleDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentConstraintRuleDeleteUserError>(query);
            return this;
        }
    }
}