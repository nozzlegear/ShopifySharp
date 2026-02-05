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
    public sealed class AdditionalFeeQueryBuilder : FieldsQueryBuilderBase<AdditionalFee, AdditionalFeeQueryBuilder>
    {
        protected override AdditionalFeeQueryBuilder Self => this;

        public AdditionalFeeQueryBuilder() : this("additionalFee")
        {
        }

        public AdditionalFeeQueryBuilder(string name) : base(new Query<AdditionalFee>(name))
        {
        }

        public AdditionalFeeQueryBuilder(IQuery<AdditionalFee> query) : base(query)
        {
        }

        public AdditionalFeeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public AdditionalFeeQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public AdditionalFeeQueryBuilder Price(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("price");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public AdditionalFeeQueryBuilder TaxLines(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxLineQueryBuilder> build)
        {
            var query = new Query<TaxLine>("taxLines");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxLine>(query);
            return this;
        }
    }
}