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
    public sealed class FulfillmentConstraintRuleCreateOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentConstraintRuleCreatePayload, FulfillmentConstraintRuleCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentConstraintRuleCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentConstraintRuleCreateArgumentsBuilder Arguments { get; }
        protected override FulfillmentConstraintRuleCreateOperationQueryBuilder Self => this;

        public FulfillmentConstraintRuleCreateOperationQueryBuilder() : this("fulfillmentConstraintRuleCreate")
        {
        }

        public FulfillmentConstraintRuleCreateOperationQueryBuilder(string name) : base(new Query<FulfillmentConstraintRuleCreatePayload>(name))
        {
            Arguments = new FulfillmentConstraintRuleCreateArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentConstraintRuleCreateOperationQueryBuilder(IQuery<FulfillmentConstraintRuleCreatePayload> query) : base(query)
        {
            Arguments = new FulfillmentConstraintRuleCreateArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentConstraintRuleCreateOperationQueryBuilder FulfillmentConstraintRule(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentConstraintRuleQueryBuilder> build)
        {
            var query = new Query<FulfillmentConstraintRule>("fulfillmentConstraintRule");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentConstraintRuleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentConstraintRule>(query);
            return this;
        }

        public FulfillmentConstraintRuleCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentConstraintRuleCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<FulfillmentConstraintRuleCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentConstraintRuleCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentConstraintRuleCreateUserError>(query);
            return this;
        }
    }
}