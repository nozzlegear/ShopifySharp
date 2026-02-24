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
    public sealed class LineItemTaxLinesQueryBuilder : FieldsQueryBuilderBase<TaxLine, LineItemTaxLinesQueryBuilder>, IHasArguments<LineItemTaxLinesArgumentsBuilder>
    {
        public LineItemTaxLinesArgumentsBuilder Arguments { get; }
        protected override LineItemTaxLinesQueryBuilder Self => this;

        public LineItemTaxLinesQueryBuilder(string name) : base(new Query<TaxLine>(name))
        {
            Arguments = new LineItemTaxLinesArgumentsBuilder(base.InnerQuery);
        }

        public LineItemTaxLinesQueryBuilder(IQuery<TaxLine> query) : base(query)
        {
            Arguments = new LineItemTaxLinesArgumentsBuilder(base.InnerQuery);
        }

        public LineItemTaxLinesQueryBuilder SetArguments(Action<LineItemTaxLinesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public LineItemTaxLinesQueryBuilder ChannelLiable()
        {
            base.InnerQuery.AddField("channelLiable");
            return this;
        }

        [Obsolete("Use `priceSet` instead.")]
        public LineItemTaxLinesQueryBuilder Price()
        {
            base.InnerQuery.AddField("price");
            return this;
        }

        public LineItemTaxLinesQueryBuilder PriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("priceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public LineItemTaxLinesQueryBuilder Rate()
        {
            base.InnerQuery.AddField("rate");
            return this;
        }

        public LineItemTaxLinesQueryBuilder RatePercentage()
        {
            base.InnerQuery.AddField("ratePercentage");
            return this;
        }

        public LineItemTaxLinesQueryBuilder Source()
        {
            base.InnerQuery.AddField("source");
            return this;
        }

        public LineItemTaxLinesQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}