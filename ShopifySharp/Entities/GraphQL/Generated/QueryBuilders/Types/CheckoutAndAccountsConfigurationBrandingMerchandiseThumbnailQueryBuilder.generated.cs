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
    public sealed class CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnail, CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingMerchandiseThumbnail")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnail>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnail> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailQueryBuilder Badge(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailBadgeQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailBadge>("badge");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailBadgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailBadge>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailQueryBuilder Border()
        {
            base.InnerQuery.AddField("border");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailQueryBuilder CornerRadius()
        {
            base.InnerQuery.AddField("cornerRadius");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailQueryBuilder Fit()
        {
            base.InnerQuery.AddField("fit");
            return this;
        }
    }
}