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

        public QuantityRulesDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.QuantityRuleUserErrorQueryBuilder> build)
        {
            var query = new Query<QuantityRuleUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.QuantityRuleUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QuantityRuleUserError>(query);
            return this;
        }
    }
}