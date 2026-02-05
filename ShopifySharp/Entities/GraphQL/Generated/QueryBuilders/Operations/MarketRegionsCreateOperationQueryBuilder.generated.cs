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
    [Obsolete("This mutation is deprecated and will be removed in the future. Use `marketCreate` or `marketUpdate` instead.")]
    public sealed class MarketRegionsCreateOperationQueryBuilder : FieldsQueryBuilderBase<MarketRegionsCreatePayload, MarketRegionsCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketRegionsCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MarketRegionsCreateArgumentsBuilder Arguments { get; }
        protected override MarketRegionsCreateOperationQueryBuilder Self => this;

        public MarketRegionsCreateOperationQueryBuilder() : this("marketRegionsCreate")
        {
        }

        public MarketRegionsCreateOperationQueryBuilder(string name) : base(new Query<MarketRegionsCreatePayload>(name))
        {
            Arguments = new MarketRegionsCreateArgumentsBuilder(base.InnerQuery);
        }

        public MarketRegionsCreateOperationQueryBuilder(IQuery<MarketRegionsCreatePayload> query) : base(query)
        {
            Arguments = new MarketRegionsCreateArgumentsBuilder(base.InnerQuery);
        }

        public MarketRegionsCreateOperationQueryBuilder Market(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public MarketRegionsCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketUserError>(query);
            return this;
        }
    }
}