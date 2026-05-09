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
    public sealed class CheckoutAndAccountsConfigurationBrandingImageQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingImage, CheckoutAndAccountsConfigurationBrandingImageQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingImageQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingImageQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingImage")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingImageQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingImage>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingImageQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingImage> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingImageQueryBuilder Image(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("image");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }
    }
}