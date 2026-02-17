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
    public sealed class CheckoutBrandingLogoQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingLogo, CheckoutBrandingLogoQueryBuilder>
    {
        protected override CheckoutBrandingLogoQueryBuilder Self => this;

        public CheckoutBrandingLogoQueryBuilder() : this("checkoutBrandingLogo")
        {
        }

        public CheckoutBrandingLogoQueryBuilder(string name) : base(new Query<CheckoutBrandingLogo>(name))
        {
        }

        public CheckoutBrandingLogoQueryBuilder(IQuery<CheckoutBrandingLogo> query) : base(query)
        {
        }

        public CheckoutBrandingLogoQueryBuilder Image(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("image");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public CheckoutBrandingLogoQueryBuilder MaxWidth()
        {
            base.InnerQuery.AddField("maxWidth");
            return this;
        }

        public CheckoutBrandingLogoQueryBuilder Visibility()
        {
            base.InnerQuery.AddField("visibility");
            return this;
        }
    }
}