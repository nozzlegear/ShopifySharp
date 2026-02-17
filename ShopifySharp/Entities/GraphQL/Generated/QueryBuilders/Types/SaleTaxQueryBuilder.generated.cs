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
    public sealed class SaleTaxQueryBuilder : FieldsQueryBuilderBase<SaleTax, SaleTaxQueryBuilder>
    {
        protected override SaleTaxQueryBuilder Self => this;

        public SaleTaxQueryBuilder() : this("saleTax")
        {
        }

        public SaleTaxQueryBuilder(string name) : base(new Query<SaleTax>(name))
        {
        }

        public SaleTaxQueryBuilder(IQuery<SaleTax> query) : base(query)
        {
        }

        public SaleTaxQueryBuilder Amount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("amount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public SaleTaxQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public SaleTaxQueryBuilder TaxLine(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxLineQueryBuilder> build)
        {
            var query = new Query<TaxLine>("taxLine");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxLine>(query);
            return this;
        }
    }
}