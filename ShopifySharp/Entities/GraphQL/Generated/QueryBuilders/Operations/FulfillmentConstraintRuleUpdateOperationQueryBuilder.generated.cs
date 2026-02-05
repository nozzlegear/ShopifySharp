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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class FulfillmentConstraintRuleUpdateOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentConstraintRuleUpdatePayload, FulfillmentConstraintRuleUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentConstraintRuleUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentConstraintRuleUpdateArgumentsBuilder Arguments { get; }
        protected override FulfillmentConstraintRuleUpdateOperationQueryBuilder Self => this;

        public FulfillmentConstraintRuleUpdateOperationQueryBuilder() : this("fulfillmentConstraintRuleUpdate")
        {
        }

        public FulfillmentConstraintRuleUpdateOperationQueryBuilder(string name) : base(new Query<FulfillmentConstraintRuleUpdatePayload>(name))
        {
            Arguments = new FulfillmentConstraintRuleUpdateArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentConstraintRuleUpdateOperationQueryBuilder(IQuery<FulfillmentConstraintRuleUpdatePayload> query) : base(query)
        {
            Arguments = new FulfillmentConstraintRuleUpdateArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentConstraintRuleUpdateOperationQueryBuilder FulfillmentConstraintRule(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentConstraintRuleQueryBuilder> build)
        {
            var query = new Query<FulfillmentConstraintRule>("fulfillmentConstraintRule");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentConstraintRuleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentConstraintRule>(query);
            return this;
        }

        public FulfillmentConstraintRuleUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentConstraintRuleUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<FulfillmentConstraintRuleUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentConstraintRuleUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentConstraintRuleUpdateUserError>(query);
            return this;
        }
    }
}