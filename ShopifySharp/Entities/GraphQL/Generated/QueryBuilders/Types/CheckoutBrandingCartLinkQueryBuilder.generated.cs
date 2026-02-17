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
    public sealed class CheckoutBrandingCartLinkQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingCartLink, CheckoutBrandingCartLinkQueryBuilder>
    {
        protected override CheckoutBrandingCartLinkQueryBuilder Self => this;

        public CheckoutBrandingCartLinkQueryBuilder() : this("checkoutBrandingCartLink")
        {
        }

        public CheckoutBrandingCartLinkQueryBuilder(string name) : base(new Query<CheckoutBrandingCartLink>(name))
        {
        }

        public CheckoutBrandingCartLinkQueryBuilder(IQuery<CheckoutBrandingCartLink> query) : base(query)
        {
        }

        public CheckoutBrandingCartLinkQueryBuilder Visibility()
        {
            base.InnerQuery.AddField("visibility");
            return this;
        }
    }
}