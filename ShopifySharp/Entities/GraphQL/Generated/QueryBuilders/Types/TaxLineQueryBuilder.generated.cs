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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class TaxLineQueryBuilder : FieldsQueryBuilderBase<TaxLine, TaxLineQueryBuilder>
    {
        protected override TaxLineQueryBuilder Self => this;

        public TaxLineQueryBuilder() : this("taxLine")
        {
        }

        public TaxLineQueryBuilder(string name) : base(new Query<TaxLine>(name))
        {
        }

        public TaxLineQueryBuilder(IQuery<TaxLine> query) : base(query)
        {
        }

        public TaxLineQueryBuilder ChannelLiable()
        {
            base.InnerQuery.AddField("channelLiable");
            return this;
        }

        [Obsolete("Use `priceSet` instead.")]
        public TaxLineQueryBuilder Price()
        {
            base.InnerQuery.AddField("price");
            return this;
        }

        public TaxLineQueryBuilder PriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("priceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public TaxLineQueryBuilder Rate()
        {
            base.InnerQuery.AddField("rate");
            return this;
        }

        public TaxLineQueryBuilder RatePercentage()
        {
            base.InnerQuery.AddField("ratePercentage");
            return this;
        }

        public TaxLineQueryBuilder Source()
        {
            base.InnerQuery.AddField("source");
            return this;
        }

        public TaxLineQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}