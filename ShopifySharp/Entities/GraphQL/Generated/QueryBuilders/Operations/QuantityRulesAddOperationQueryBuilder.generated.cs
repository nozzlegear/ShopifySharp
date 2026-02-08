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
    public sealed class QuantityRulesAddOperationQueryBuilder : FieldsQueryBuilderBase<QuantityRulesAddPayload, QuantityRulesAddOperationQueryBuilder>, IGraphOperationQueryBuilder<QuantityRulesAddPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public QuantityRulesAddArgumentsBuilder Arguments { get; }
        protected override QuantityRulesAddOperationQueryBuilder Self => this;

        public QuantityRulesAddOperationQueryBuilder() : this("quantityRulesAdd")
        {
        }

        public QuantityRulesAddOperationQueryBuilder(string name) : base(new Query<QuantityRulesAddPayload>(name))
        {
            Arguments = new QuantityRulesAddArgumentsBuilder(base.InnerQuery);
        }

        public QuantityRulesAddOperationQueryBuilder(IQuery<QuantityRulesAddPayload> query) : base(query)
        {
            Arguments = new QuantityRulesAddArgumentsBuilder(base.InnerQuery);
        }

        public QuantityRulesAddOperationQueryBuilder QuantityRules(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.QuantityRuleQueryBuilder> build)
        {
            var query = new Query<QuantityRule>("quantityRules");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.QuantityRuleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QuantityRule>(query);
            return this;
        }

        public QuantityRulesAddOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.QuantityRuleUserErrorQueryBuilder> build)
        {
            var query = new Query<QuantityRuleUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.QuantityRuleUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QuantityRuleUserError>(query);
            return this;
        }
    }
}