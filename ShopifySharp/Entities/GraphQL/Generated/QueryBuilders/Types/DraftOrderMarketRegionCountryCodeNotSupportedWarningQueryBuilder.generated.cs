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
    public sealed class DraftOrderMarketRegionCountryCodeNotSupportedWarningQueryBuilder : FieldsQueryBuilderBase<DraftOrderMarketRegionCountryCodeNotSupportedWarning, DraftOrderMarketRegionCountryCodeNotSupportedWarningQueryBuilder>
    {
        protected override DraftOrderMarketRegionCountryCodeNotSupportedWarningQueryBuilder Self => this;

        public DraftOrderMarketRegionCountryCodeNotSupportedWarningQueryBuilder() : this("draftOrderMarketRegionCountryCodeNotSupportedWarning")
        {
        }

        public DraftOrderMarketRegionCountryCodeNotSupportedWarningQueryBuilder(string name) : base(new Query<DraftOrderMarketRegionCountryCodeNotSupportedWarning>(name))
        {
        }

        public DraftOrderMarketRegionCountryCodeNotSupportedWarningQueryBuilder(IQuery<DraftOrderMarketRegionCountryCodeNotSupportedWarning> query) : base(query)
        {
        }

        public DraftOrderMarketRegionCountryCodeNotSupportedWarningQueryBuilder ErrorCode()
        {
            base.InnerQuery.AddField("errorCode");
            return this;
        }

        public DraftOrderMarketRegionCountryCodeNotSupportedWarningQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public DraftOrderMarketRegionCountryCodeNotSupportedWarningQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}