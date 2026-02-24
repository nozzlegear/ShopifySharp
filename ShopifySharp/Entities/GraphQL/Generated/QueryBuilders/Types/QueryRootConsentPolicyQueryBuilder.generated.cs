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
    public sealed class QueryRootConsentPolicyQueryBuilder : FieldsQueryBuilderBase<ConsentPolicy, QueryRootConsentPolicyQueryBuilder>, IHasArguments<QueryRootConsentPolicyArgumentsBuilder>
    {
        public QueryRootConsentPolicyArgumentsBuilder Arguments { get; }
        protected override QueryRootConsentPolicyQueryBuilder Self => this;

        public QueryRootConsentPolicyQueryBuilder(string name) : base(new Query<ConsentPolicy>(name))
        {
            Arguments = new QueryRootConsentPolicyArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootConsentPolicyQueryBuilder(IQuery<ConsentPolicy> query) : base(query)
        {
            Arguments = new QueryRootConsentPolicyArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootConsentPolicyQueryBuilder SetArguments(Action<QueryRootConsentPolicyArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootConsentPolicyQueryBuilder ConsentRequired()
        {
            base.InnerQuery.AddField("consentRequired");
            return this;
        }

        public QueryRootConsentPolicyQueryBuilder CountryCode()
        {
            base.InnerQuery.AddField("countryCode");
            return this;
        }

        public QueryRootConsentPolicyQueryBuilder DataSaleOptOutRequired()
        {
            base.InnerQuery.AddField("dataSaleOptOutRequired");
            return this;
        }

        public QueryRootConsentPolicyQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootConsentPolicyQueryBuilder RegionCode()
        {
            base.InnerQuery.AddField("regionCode");
            return this;
        }

        public QueryRootConsentPolicyQueryBuilder ShopId()
        {
            base.InnerQuery.AddField("shopId");
            return this;
        }
    }
}