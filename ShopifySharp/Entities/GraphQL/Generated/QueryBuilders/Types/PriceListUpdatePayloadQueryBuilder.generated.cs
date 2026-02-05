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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class PriceListUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<PriceListUpdatePayload, PriceListUpdatePayloadQueryBuilder>
    {
        protected override PriceListUpdatePayloadQueryBuilder Self => this;

        public PriceListUpdatePayloadQueryBuilder() : this("priceListUpdatePayload")
        {
        }

        public PriceListUpdatePayloadQueryBuilder(string name) : base(new Query<PriceListUpdatePayload>(name))
        {
        }

        public PriceListUpdatePayloadQueryBuilder(IQuery<PriceListUpdatePayload> query) : base(query)
        {
        }

        public PriceListUpdatePayloadQueryBuilder PriceList(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListQueryBuilder> build)
        {
            var query = new Query<PriceList>("priceList");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceList>(query);
            return this;
        }

        public PriceListUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListUserErrorQueryBuilder> build)
        {
            var query = new Query<PriceListUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListUserError>(query);
            return this;
        }
    }
}