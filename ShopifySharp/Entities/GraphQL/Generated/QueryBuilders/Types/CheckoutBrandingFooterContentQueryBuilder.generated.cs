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
    public sealed class CheckoutBrandingFooterContentQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingFooterContent, CheckoutBrandingFooterContentQueryBuilder>
    {
        protected override CheckoutBrandingFooterContentQueryBuilder Self => this;

        public CheckoutBrandingFooterContentQueryBuilder() : this("checkoutBrandingFooterContent")
        {
        }

        public CheckoutBrandingFooterContentQueryBuilder(string name) : base(new Query<CheckoutBrandingFooterContent>(name))
        {
        }

        public CheckoutBrandingFooterContentQueryBuilder(IQuery<CheckoutBrandingFooterContent> query) : base(query)
        {
        }

        public CheckoutBrandingFooterContentQueryBuilder Visibility()
        {
            base.InnerQuery.AddField("visibility");
            return this;
        }
    }
}