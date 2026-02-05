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
    public sealed class CheckoutBrandingChoiceListQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingChoiceList, CheckoutBrandingChoiceListQueryBuilder>
    {
        protected override CheckoutBrandingChoiceListQueryBuilder Self => this;

        public CheckoutBrandingChoiceListQueryBuilder() : this("checkoutBrandingChoiceList")
        {
        }

        public CheckoutBrandingChoiceListQueryBuilder(string name) : base(new Query<CheckoutBrandingChoiceList>(name))
        {
        }

        public CheckoutBrandingChoiceListQueryBuilder(IQuery<CheckoutBrandingChoiceList> query) : base(query)
        {
        }

        public CheckoutBrandingChoiceListQueryBuilder Group(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingChoiceListGroupQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingChoiceListGroup>("group");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingChoiceListGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingChoiceListGroup>(query);
            return this;
        }
    }
}