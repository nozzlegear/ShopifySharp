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
    public sealed class CheckoutBrandingHeaderCartLinkQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingHeaderCartLink, CheckoutBrandingHeaderCartLinkQueryBuilder>
    {
        protected override CheckoutBrandingHeaderCartLinkQueryBuilder Self => this;

        public CheckoutBrandingHeaderCartLinkQueryBuilder() : this("checkoutBrandingHeaderCartLink")
        {
        }

        public CheckoutBrandingHeaderCartLinkQueryBuilder(string name) : base(new Query<CheckoutBrandingHeaderCartLink>(name))
        {
        }

        public CheckoutBrandingHeaderCartLinkQueryBuilder(IQuery<CheckoutBrandingHeaderCartLink> query) : base(query)
        {
        }

        public CheckoutBrandingHeaderCartLinkQueryBuilder ContentType()
        {
            base.InnerQuery.AddField("contentType");
            return this;
        }

        public CheckoutBrandingHeaderCartLinkQueryBuilder Image(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("image");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }
    }
}