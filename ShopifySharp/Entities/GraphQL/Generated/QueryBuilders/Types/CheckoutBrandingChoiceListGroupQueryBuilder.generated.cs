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
    public sealed class CheckoutBrandingChoiceListGroupQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingChoiceListGroup, CheckoutBrandingChoiceListGroupQueryBuilder>
    {
        protected override CheckoutBrandingChoiceListGroupQueryBuilder Self => this;

        public CheckoutBrandingChoiceListGroupQueryBuilder() : this("checkoutBrandingChoiceListGroup")
        {
        }

        public CheckoutBrandingChoiceListGroupQueryBuilder(string name) : base(new Query<CheckoutBrandingChoiceListGroup>(name))
        {
        }

        public CheckoutBrandingChoiceListGroupQueryBuilder(IQuery<CheckoutBrandingChoiceListGroup> query) : base(query)
        {
        }

        public CheckoutBrandingChoiceListGroupQueryBuilder Spacing()
        {
            base.InnerQuery.AddField("spacing");
            return this;
        }
    }
}