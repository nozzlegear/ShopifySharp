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
    public sealed class FulfillmentConstraintRuleUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<FulfillmentConstraintRuleUpdatePayload, FulfillmentConstraintRuleUpdatePayloadQueryBuilder>
    {
        protected override FulfillmentConstraintRuleUpdatePayloadQueryBuilder Self => this;

        public FulfillmentConstraintRuleUpdatePayloadQueryBuilder() : this("fulfillmentConstraintRuleUpdatePayload")
        {
        }

        public FulfillmentConstraintRuleUpdatePayloadQueryBuilder(string name) : base(new Query<FulfillmentConstraintRuleUpdatePayload>(name))
        {
        }

        public FulfillmentConstraintRuleUpdatePayloadQueryBuilder(IQuery<FulfillmentConstraintRuleUpdatePayload> query) : base(query)
        {
        }

        public FulfillmentConstraintRuleUpdatePayloadQueryBuilder FulfillmentConstraintRule(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentConstraintRuleQueryBuilder> build)
        {
            var query = new Query<FulfillmentConstraintRule>("fulfillmentConstraintRule");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentConstraintRuleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentConstraintRule>(query);
            return this;
        }

        public FulfillmentConstraintRuleUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentConstraintRuleUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<FulfillmentConstraintRuleUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentConstraintRuleUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentConstraintRuleUpdateUserError>(query);
            return this;
        }
    }
}