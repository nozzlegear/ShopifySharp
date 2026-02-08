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
    public sealed class CheckoutBrandingControlQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingControl, CheckoutBrandingControlQueryBuilder>
    {
        protected override CheckoutBrandingControlQueryBuilder Self => this;

        public CheckoutBrandingControlQueryBuilder() : this("checkoutBrandingControl")
        {
        }

        public CheckoutBrandingControlQueryBuilder(string name) : base(new Query<CheckoutBrandingControl>(name))
        {
        }

        public CheckoutBrandingControlQueryBuilder(IQuery<CheckoutBrandingControl> query) : base(query)
        {
        }

        public CheckoutBrandingControlQueryBuilder Border()
        {
            base.InnerQuery.AddField("border");
            return this;
        }

        public CheckoutBrandingControlQueryBuilder Color()
        {
            base.InnerQuery.AddField("color");
            return this;
        }

        public CheckoutBrandingControlQueryBuilder CornerRadius()
        {
            base.InnerQuery.AddField("cornerRadius");
            return this;
        }

        public CheckoutBrandingControlQueryBuilder LabelPosition()
        {
            base.InnerQuery.AddField("labelPosition");
            return this;
        }
    }
}