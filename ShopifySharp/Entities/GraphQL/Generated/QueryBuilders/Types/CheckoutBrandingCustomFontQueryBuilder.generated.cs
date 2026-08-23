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
    public sealed class CheckoutBrandingCustomFontQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingCustomFont, CheckoutBrandingCustomFontQueryBuilder>
    {
        protected override CheckoutBrandingCustomFontQueryBuilder Self => this;

        public CheckoutBrandingCustomFontQueryBuilder() : this("checkoutBrandingCustomFont")
        {
        }

        public CheckoutBrandingCustomFontQueryBuilder(string name) : base(new Query<CheckoutBrandingCustomFont>(name))
        {
        }

        public CheckoutBrandingCustomFontQueryBuilder(IQuery<CheckoutBrandingCustomFont> query) : base(query)
        {
        }

        public CheckoutBrandingCustomFontQueryBuilder GenericFileId()
        {
            base.InnerQuery.AddField("genericFileId");
            return this;
        }

        public CheckoutBrandingCustomFontQueryBuilder Sources()
        {
            base.InnerQuery.AddField("sources");
            return this;
        }

        public CheckoutBrandingCustomFontQueryBuilder Weight()
        {
            base.InnerQuery.AddField("weight");
            return this;
        }
    }
}