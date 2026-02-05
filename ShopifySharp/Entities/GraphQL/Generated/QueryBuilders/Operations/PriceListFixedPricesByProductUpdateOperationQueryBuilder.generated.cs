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
    public sealed class PriceListFixedPricesByProductUpdateOperationQueryBuilder : FieldsQueryBuilderBase<PriceListFixedPricesByProductUpdatePayload, PriceListFixedPricesByProductUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<PriceListFixedPricesByProductUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PriceListFixedPricesByProductUpdateArgumentsBuilder Arguments { get; }
        protected override PriceListFixedPricesByProductUpdateOperationQueryBuilder Self => this;

        public PriceListFixedPricesByProductUpdateOperationQueryBuilder() : this("priceListFixedPricesByProductUpdate")
        {
        }

        public PriceListFixedPricesByProductUpdateOperationQueryBuilder(string name) : base(new Query<PriceListFixedPricesByProductUpdatePayload>(name))
        {
            Arguments = new PriceListFixedPricesByProductUpdateArgumentsBuilder(base.InnerQuery);
        }

        public PriceListFixedPricesByProductUpdateOperationQueryBuilder(IQuery<PriceListFixedPricesByProductUpdatePayload> query) : base(query)
        {
            Arguments = new PriceListFixedPricesByProductUpdateArgumentsBuilder(base.InnerQuery);
        }

        public PriceListFixedPricesByProductUpdateOperationQueryBuilder PriceList(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListQueryBuilder> build)
        {
            var query = new Query<PriceList>("priceList");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceList>(query);
            return this;
        }

        public PriceListFixedPricesByProductUpdateOperationQueryBuilder PricesToAddProducts(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("pricesToAddProducts");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public PriceListFixedPricesByProductUpdateOperationQueryBuilder PricesToDeleteProducts(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("pricesToDeleteProducts");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public PriceListFixedPricesByProductUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListFixedPricesByProductBulkUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<PriceListFixedPricesByProductBulkUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListFixedPricesByProductBulkUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListFixedPricesByProductBulkUpdateUserError>(query);
            return this;
        }
    }
}