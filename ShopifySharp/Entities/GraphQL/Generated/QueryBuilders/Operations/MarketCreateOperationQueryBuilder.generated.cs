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
    public sealed class MarketCreateOperationQueryBuilder : FieldsQueryBuilderBase<MarketCreatePayload, MarketCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MarketCreateArgumentsBuilder Arguments { get; }
        protected override MarketCreateOperationQueryBuilder Self => this;

        public MarketCreateOperationQueryBuilder() : this("marketCreate")
        {
        }

        public MarketCreateOperationQueryBuilder(string name) : base(new Query<MarketCreatePayload>(name))
        {
            Arguments = new MarketCreateArgumentsBuilder(base.InnerQuery);
        }

        public MarketCreateOperationQueryBuilder(IQuery<MarketCreatePayload> query) : base(query)
        {
            Arguments = new MarketCreateArgumentsBuilder(base.InnerQuery);
        }

        public MarketCreateOperationQueryBuilder Market(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public MarketCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketUserError>(query);
            return this;
        }
    }
}