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
    public sealed class DutyQueryBuilder : FieldsQueryBuilderBase<Duty, DutyQueryBuilder>
    {
        protected override DutyQueryBuilder Self => this;

        public DutyQueryBuilder() : this("duty")
        {
        }

        public DutyQueryBuilder(string name) : base(new Query<Duty>(name))
        {
        }

        public DutyQueryBuilder(IQuery<Duty> query) : base(query)
        {
        }

        public DutyQueryBuilder CountryCodeOfOrigin()
        {
            base.InnerQuery.AddField("countryCodeOfOrigin");
            return this;
        }

        public DutyQueryBuilder HarmonizedSystemCode()
        {
            base.InnerQuery.AddField("harmonizedSystemCode");
            return this;
        }

        public DutyQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DutyQueryBuilder Price(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("price");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public DutyQueryBuilder TaxLines(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxLineQueryBuilder> build)
        {
            var query = new Query<TaxLine>("taxLines");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxLine>(query);
            return this;
        }
    }
}