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
    public sealed class PriceListUpdateOperationQueryBuilder : FieldsQueryBuilderBase<PriceListUpdatePayload, PriceListUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<PriceListUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PriceListUpdateArgumentsBuilder Arguments { get; }
        protected override PriceListUpdateOperationQueryBuilder Self => this;

        public PriceListUpdateOperationQueryBuilder() : this("priceListUpdate")
        {
        }

        public PriceListUpdateOperationQueryBuilder(string name) : base(new Query<PriceListUpdatePayload>(name))
        {
            Arguments = new PriceListUpdateArgumentsBuilder(base.InnerQuery);
        }

        public PriceListUpdateOperationQueryBuilder(IQuery<PriceListUpdatePayload> query) : base(query)
        {
            Arguments = new PriceListUpdateArgumentsBuilder(base.InnerQuery);
        }

        public PriceListUpdateOperationQueryBuilder PriceList(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListQueryBuilder> build)
        {
            var query = new Query<PriceList>("priceList");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceList>(query);
            return this;
        }

        public PriceListUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListUserErrorQueryBuilder> build)
        {
            var query = new Query<PriceListUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListUserError>(query);
            return this;
        }
    }
}