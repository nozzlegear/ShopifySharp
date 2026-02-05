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
    public sealed class CheckoutBrandingMerchandiseThumbnailBadgeQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingMerchandiseThumbnailBadge, CheckoutBrandingMerchandiseThumbnailBadgeQueryBuilder>
    {
        protected override CheckoutBrandingMerchandiseThumbnailBadgeQueryBuilder Self => this;

        public CheckoutBrandingMerchandiseThumbnailBadgeQueryBuilder() : this("checkoutBrandingMerchandiseThumbnailBadge")
        {
        }

        public CheckoutBrandingMerchandiseThumbnailBadgeQueryBuilder(string name) : base(new Query<CheckoutBrandingMerchandiseThumbnailBadge>(name))
        {
        }

        public CheckoutBrandingMerchandiseThumbnailBadgeQueryBuilder(IQuery<CheckoutBrandingMerchandiseThumbnailBadge> query) : base(query)
        {
        }

        public CheckoutBrandingMerchandiseThumbnailBadgeQueryBuilder Background()
        {
            base.InnerQuery.AddField("background");
            return this;
        }
    }
}