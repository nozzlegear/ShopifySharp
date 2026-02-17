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
    public sealed class QuantityRulesDeleteOperationQueryBuilder : FieldsQueryBuilderBase<QuantityRulesDeletePayload, QuantityRulesDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<QuantityRulesDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public QuantityRulesDeleteArgumentsBuilder Arguments { get; }
        protected override QuantityRulesDeleteOperationQueryBuilder Self => this;

        public QuantityRulesDeleteOperationQueryBuilder() : this("quantityRulesDelete")
        {
        }

        public QuantityRulesDeleteOperationQueryBuilder(string name) : base(new Query<QuantityRulesDeletePayload>(name))
        {
            Arguments = new QuantityRulesDeleteArgumentsBuilder(base.InnerQuery);
        }

        public QuantityRulesDeleteOperationQueryBuilder(IQuery<QuantityRulesDeletePayload> query) : base(query)
        {
            Arguments = new QuantityRulesDeleteArgumentsBuilder(base.InnerQuery);
        }

        public QuantityRulesDeleteOperationQueryBuilder DeletedQuantityRulesVariantIds()
        {
            base.InnerQuery.AddField("deletedQuantityRulesVariantIds");
            return this;
        }

        public QuantityRulesDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.QuantityRuleUserErrorQueryBuilder> build)
        {
            var query = new Query<QuantityRuleUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.QuantityRuleUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QuantityRuleUserError>(query);
            return this;
        }
    }
}