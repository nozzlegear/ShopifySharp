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
    public sealed class DraftOrderShippingRateQueryBuilder : FieldsQueryBuilderBase<DraftOrderShippingRate, DraftOrderShippingRateQueryBuilder>
    {
        protected override DraftOrderShippingRateQueryBuilder Self => this;

        public DraftOrderShippingRateQueryBuilder() : this("draftOrderShippingRate")
        {
        }

        public DraftOrderShippingRateQueryBuilder(string name) : base(new Query<DraftOrderShippingRate>(name))
        {
        }

        public DraftOrderShippingRateQueryBuilder(IQuery<DraftOrderShippingRate> query) : base(query)
        {
        }

        public DraftOrderShippingRateQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public DraftOrderShippingRateQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public DraftOrderShippingRateQueryBuilder Price(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("price");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public DraftOrderShippingRateQueryBuilder Source()
        {
            base.InnerQuery.AddField("source");
            return this;
        }

        public DraftOrderShippingRateQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}