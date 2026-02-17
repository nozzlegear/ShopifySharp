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
    public sealed class MarketDeleteOperationQueryBuilder : FieldsQueryBuilderBase<MarketDeletePayload, MarketDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MarketDeleteArgumentsBuilder Arguments { get; }
        protected override MarketDeleteOperationQueryBuilder Self => this;

        public MarketDeleteOperationQueryBuilder() : this("marketDelete")
        {
        }

        public MarketDeleteOperationQueryBuilder(string name) : base(new Query<MarketDeletePayload>(name))
        {
            Arguments = new MarketDeleteArgumentsBuilder(base.InnerQuery);
        }

        public MarketDeleteOperationQueryBuilder(IQuery<MarketDeletePayload> query) : base(query)
        {
            Arguments = new MarketDeleteArgumentsBuilder(base.InnerQuery);
        }

        public MarketDeleteOperationQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public MarketDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketUserError>(query);
            return this;
        }
    }
}