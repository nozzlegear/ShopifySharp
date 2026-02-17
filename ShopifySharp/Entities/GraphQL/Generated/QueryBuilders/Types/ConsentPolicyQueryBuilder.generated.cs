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
    public sealed class ConsentPolicyQueryBuilder : FieldsQueryBuilderBase<ConsentPolicy, ConsentPolicyQueryBuilder>
    {
        protected override ConsentPolicyQueryBuilder Self => this;

        public ConsentPolicyQueryBuilder() : this("consentPolicy")
        {
        }

        public ConsentPolicyQueryBuilder(string name) : base(new Query<ConsentPolicy>(name))
        {
        }

        public ConsentPolicyQueryBuilder(IQuery<ConsentPolicy> query) : base(query)
        {
        }

        public ConsentPolicyQueryBuilder ConsentRequired()
        {
            base.InnerQuery.AddField("consentRequired");
            return this;
        }

        public ConsentPolicyQueryBuilder CountryCode()
        {
            base.InnerQuery.AddField("countryCode");
            return this;
        }

        public ConsentPolicyQueryBuilder DataSaleOptOutRequired()
        {
            base.InnerQuery.AddField("dataSaleOptOutRequired");
            return this;
        }

        public ConsentPolicyQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ConsentPolicyQueryBuilder RegionCode()
        {
            base.InnerQuery.AddField("regionCode");
            return this;
        }

        public ConsentPolicyQueryBuilder ShopId()
        {
            base.InnerQuery.AddField("shopId");
            return this;
        }
    }
}