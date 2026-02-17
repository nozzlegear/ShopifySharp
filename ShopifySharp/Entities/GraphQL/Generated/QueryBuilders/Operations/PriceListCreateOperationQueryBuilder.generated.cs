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
    public sealed class PriceListCreateOperationQueryBuilder : FieldsQueryBuilderBase<PriceListCreatePayload, PriceListCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<PriceListCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PriceListCreateArgumentsBuilder Arguments { get; }
        protected override PriceListCreateOperationQueryBuilder Self => this;

        public PriceListCreateOperationQueryBuilder() : this("priceListCreate")
        {
        }

        public PriceListCreateOperationQueryBuilder(string name) : base(new Query<PriceListCreatePayload>(name))
        {
            Arguments = new PriceListCreateArgumentsBuilder(base.InnerQuery);
        }

        public PriceListCreateOperationQueryBuilder(IQuery<PriceListCreatePayload> query) : base(query)
        {
            Arguments = new PriceListCreateArgumentsBuilder(base.InnerQuery);
        }

        public PriceListCreateOperationQueryBuilder PriceList(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListQueryBuilder> build)
        {
            var query = new Query<PriceList>("priceList");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceList>(query);
            return this;
        }

        public PriceListCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListUserErrorQueryBuilder> build)
        {
            var query = new Query<PriceListUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListUserError>(query);
            return this;
        }
    }
}