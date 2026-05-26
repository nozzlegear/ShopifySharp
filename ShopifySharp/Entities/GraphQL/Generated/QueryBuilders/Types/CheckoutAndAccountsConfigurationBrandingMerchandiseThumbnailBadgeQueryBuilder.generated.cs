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
    public sealed class CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailBadgeQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailBadge, CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailBadgeQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailBadgeQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailBadgeQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingMerchandiseThumbnailBadge")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailBadgeQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailBadge>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailBadgeQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailBadge> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailBadgeQueryBuilder Background()
        {
            base.InnerQuery.AddField("background");
            return this;
        }
    }
}