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
    public sealed class CheckoutBrandingImageQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingImage, CheckoutBrandingImageQueryBuilder>
    {
        protected override CheckoutBrandingImageQueryBuilder Self => this;

        public CheckoutBrandingImageQueryBuilder() : this("checkoutBrandingImage")
        {
        }

        public CheckoutBrandingImageQueryBuilder(string name) : base(new Query<CheckoutBrandingImage>(name))
        {
        }

        public CheckoutBrandingImageQueryBuilder(IQuery<CheckoutBrandingImage> query) : base(query)
        {
        }

        public CheckoutBrandingImageQueryBuilder Image(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("image");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }
    }
}