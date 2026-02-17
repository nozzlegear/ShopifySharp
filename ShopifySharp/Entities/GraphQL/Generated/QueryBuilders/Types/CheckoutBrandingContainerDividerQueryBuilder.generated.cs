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
    public sealed class CheckoutBrandingContainerDividerQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingContainerDivider, CheckoutBrandingContainerDividerQueryBuilder>
    {
        protected override CheckoutBrandingContainerDividerQueryBuilder Self => this;

        public CheckoutBrandingContainerDividerQueryBuilder() : this("checkoutBrandingContainerDivider")
        {
        }

        public CheckoutBrandingContainerDividerQueryBuilder(string name) : base(new Query<CheckoutBrandingContainerDivider>(name))
        {
        }

        public CheckoutBrandingContainerDividerQueryBuilder(IQuery<CheckoutBrandingContainerDivider> query) : base(query)
        {
        }

        public CheckoutBrandingContainerDividerQueryBuilder BorderStyle()
        {
            base.InnerQuery.AddField("borderStyle");
            return this;
        }

        public CheckoutBrandingContainerDividerQueryBuilder BorderWidth()
        {
            base.InnerQuery.AddField("borderWidth");
            return this;
        }

        public CheckoutBrandingContainerDividerQueryBuilder Visibility()
        {
            base.InnerQuery.AddField("visibility");
            return this;
        }
    }
}