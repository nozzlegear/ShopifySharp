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
    public sealed class FulfillmentConstraintRuleCreatePayloadQueryBuilder : FieldsQueryBuilderBase<FulfillmentConstraintRuleCreatePayload, FulfillmentConstraintRuleCreatePayloadQueryBuilder>
    {
        protected override FulfillmentConstraintRuleCreatePayloadQueryBuilder Self => this;

        public FulfillmentConstraintRuleCreatePayloadQueryBuilder() : this("fulfillmentConstraintRuleCreatePayload")
        {
        }

        public FulfillmentConstraintRuleCreatePayloadQueryBuilder(string name) : base(new Query<FulfillmentConstraintRuleCreatePayload>(name))
        {
        }

        public FulfillmentConstraintRuleCreatePayloadQueryBuilder(IQuery<FulfillmentConstraintRuleCreatePayload> query) : base(query)
        {
        }

        public FulfillmentConstraintRuleCreatePayloadQueryBuilder FulfillmentConstraintRule(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentConstraintRuleQueryBuilder> build)
        {
            var query = new Query<FulfillmentConstraintRule>("fulfillmentConstraintRule");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentConstraintRuleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentConstraintRule>(query);
            return this;
        }

        public FulfillmentConstraintRuleCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentConstraintRuleCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<FulfillmentConstraintRuleCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentConstraintRuleCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentConstraintRuleCreateUserError>(query);
            return this;
        }
    }
}