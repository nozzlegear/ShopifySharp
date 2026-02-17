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
    public sealed class PriceListFixedPricesUpdateOperationQueryBuilder : FieldsQueryBuilderBase<PriceListFixedPricesUpdatePayload, PriceListFixedPricesUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<PriceListFixedPricesUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PriceListFixedPricesUpdateArgumentsBuilder Arguments { get; }
        protected override PriceListFixedPricesUpdateOperationQueryBuilder Self => this;

        public PriceListFixedPricesUpdateOperationQueryBuilder() : this("priceListFixedPricesUpdate")
        {
        }

        public PriceListFixedPricesUpdateOperationQueryBuilder(string name) : base(new Query<PriceListFixedPricesUpdatePayload>(name))
        {
            Arguments = new PriceListFixedPricesUpdateArgumentsBuilder(base.InnerQuery);
        }

        public PriceListFixedPricesUpdateOperationQueryBuilder(IQuery<PriceListFixedPricesUpdatePayload> query) : base(query)
        {
            Arguments = new PriceListFixedPricesUpdateArgumentsBuilder(base.InnerQuery);
        }

        public PriceListFixedPricesUpdateOperationQueryBuilder DeletedFixedPriceVariantIds()
        {
            base.InnerQuery.AddField("deletedFixedPriceVariantIds");
            return this;
        }

        public PriceListFixedPricesUpdateOperationQueryBuilder PriceList(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListQueryBuilder> build)
        {
            var query = new Query<PriceList>("priceList");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceList>(query);
            return this;
        }

        public PriceListFixedPricesUpdateOperationQueryBuilder PricesAdded(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListPriceQueryBuilder> build)
        {
            var query = new Query<PriceListPrice>("pricesAdded");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListPriceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListPrice>(query);
            return this;
        }

        public PriceListFixedPricesUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListPriceUserErrorQueryBuilder> build)
        {
            var query = new Query<PriceListPriceUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListPriceUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListPriceUserError>(query);
            return this;
        }
    }
}