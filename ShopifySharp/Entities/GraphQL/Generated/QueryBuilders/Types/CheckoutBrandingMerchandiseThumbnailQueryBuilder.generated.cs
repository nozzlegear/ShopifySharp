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
    public sealed class CheckoutBrandingMerchandiseThumbnailQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingMerchandiseThumbnail, CheckoutBrandingMerchandiseThumbnailQueryBuilder>
    {
        protected override CheckoutBrandingMerchandiseThumbnailQueryBuilder Self => this;

        public CheckoutBrandingMerchandiseThumbnailQueryBuilder() : this("checkoutBrandingMerchandiseThumbnail")
        {
        }

        public CheckoutBrandingMerchandiseThumbnailQueryBuilder(string name) : base(new Query<CheckoutBrandingMerchandiseThumbnail>(name))
        {
        }

        public CheckoutBrandingMerchandiseThumbnailQueryBuilder(IQuery<CheckoutBrandingMerchandiseThumbnail> query) : base(query)
        {
        }

        public CheckoutBrandingMerchandiseThumbnailQueryBuilder Badge(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingMerchandiseThumbnailBadgeQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingMerchandiseThumbnailBadge>("badge");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingMerchandiseThumbnailBadgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingMerchandiseThumbnailBadge>(query);
            return this;
        }

        public CheckoutBrandingMerchandiseThumbnailQueryBuilder Border()
        {
            base.InnerQuery.AddField("border");
            return this;
        }

        public CheckoutBrandingMerchandiseThumbnailQueryBuilder CornerRadius()
        {
            base.InnerQuery.AddField("cornerRadius");
            return this;
        }

        public CheckoutBrandingMerchandiseThumbnailQueryBuilder Fit()
        {
            base.InnerQuery.AddField("fit");
            return this;
        }
    }
}