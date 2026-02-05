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
    public sealed class CheckoutBrandingCornerRadiusVariablesQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingCornerRadiusVariables, CheckoutBrandingCornerRadiusVariablesQueryBuilder>
    {
        protected override CheckoutBrandingCornerRadiusVariablesQueryBuilder Self => this;

        public CheckoutBrandingCornerRadiusVariablesQueryBuilder() : this("checkoutBrandingCornerRadiusVariables")
        {
        }

        public CheckoutBrandingCornerRadiusVariablesQueryBuilder(string name) : base(new Query<CheckoutBrandingCornerRadiusVariables>(name))
        {
        }

        public CheckoutBrandingCornerRadiusVariablesQueryBuilder(IQuery<CheckoutBrandingCornerRadiusVariables> query) : base(query)
        {
        }

        public CheckoutBrandingCornerRadiusVariablesQueryBuilder Base()
        {
            base.InnerQuery.AddField("base");
            return this;
        }

        public CheckoutBrandingCornerRadiusVariablesQueryBuilder Large()
        {
            base.InnerQuery.AddField("large");
            return this;
        }

        public CheckoutBrandingCornerRadiusVariablesQueryBuilder Small()
        {
            base.InnerQuery.AddField("small");
            return this;
        }
    }
}