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
    public sealed class PriceListDeletePayloadQueryBuilder : FieldsQueryBuilderBase<PriceListDeletePayload, PriceListDeletePayloadQueryBuilder>
    {
        protected override PriceListDeletePayloadQueryBuilder Self => this;

        public PriceListDeletePayloadQueryBuilder() : this("priceListDeletePayload")
        {
        }

        public PriceListDeletePayloadQueryBuilder(string name) : base(new Query<PriceListDeletePayload>(name))
        {
        }

        public PriceListDeletePayloadQueryBuilder(IQuery<PriceListDeletePayload> query) : base(query)
        {
        }

        public PriceListDeletePayloadQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public PriceListDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListUserErrorQueryBuilder> build)
        {
            var query = new Query<PriceListUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListUserError>(query);
            return this;
        }
    }
}