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

        public MarketCreateOperationQueryBuilder Market(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public MarketCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketUserError>(query);
            return this;
        }
    }
}