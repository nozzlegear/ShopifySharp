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
    public sealed class MarketUpdateOperationQueryBuilder : FieldsQueryBuilderBase<MarketUpdatePayload, MarketUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MarketUpdateArgumentsBuilder Arguments { get; }
        protected override MarketUpdateOperationQueryBuilder Self => this;

        public MarketUpdateOperationQueryBuilder() : this("marketUpdate")
        {
        }

        public MarketUpdateOperationQueryBuilder(string name) : base(new Query<MarketUpdatePayload>(name))
        {
            Arguments = new MarketUpdateArgumentsBuilder(base.InnerQuery);
        }

        public MarketUpdateOperationQueryBuilder(IQuery<MarketUpdatePayload> query) : base(query)
        {
            Arguments = new MarketUpdateArgumentsBuilder(base.InnerQuery);
        }

        public MarketUpdateOperationQueryBuilder Market(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public MarketUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketUserError>(query);
            return this;
        }
    }
}