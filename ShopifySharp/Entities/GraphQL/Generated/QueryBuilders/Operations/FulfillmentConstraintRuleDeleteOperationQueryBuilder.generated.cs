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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class FulfillmentConstraintRuleDeleteOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentConstraintRuleDeletePayload, FulfillmentConstraintRuleDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentConstraintRuleDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentConstraintRuleDeleteArgumentsBuilder Arguments { get; }
        protected override FulfillmentConstraintRuleDeleteOperationQueryBuilder Self => this;

        public FulfillmentConstraintRuleDeleteOperationQueryBuilder() : this("fulfillmentConstraintRuleDelete")
        {
        }

        public FulfillmentConstraintRuleDeleteOperationQueryBuilder(string name) : base(new Query<FulfillmentConstraintRuleDeletePayload>(name))
        {
            Arguments = new FulfillmentConstraintRuleDeleteArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentConstraintRuleDeleteOperationQueryBuilder(IQuery<FulfillmentConstraintRuleDeletePayload> query) : base(query)
        {
            Arguments = new FulfillmentConstraintRuleDeleteArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentConstraintRuleDeleteOperationQueryBuilder Success()
        {
            base.InnerQuery.AddField("success");
            return this;
        }

        public FulfillmentConstraintRuleDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentConstraintRuleDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<FulfillmentConstraintRuleDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentConstraintRuleDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentConstraintRuleDeleteUserError>(query);
            return this;
        }
    }
}