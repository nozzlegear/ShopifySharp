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
    public sealed class CheckoutBrandingContentQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingContent, CheckoutBrandingContentQueryBuilder>
    {
        protected override CheckoutBrandingContentQueryBuilder Self => this;

        public CheckoutBrandingContentQueryBuilder() : this("checkoutBrandingContent")
        {
        }

        public CheckoutBrandingContentQueryBuilder(string name) : base(new Query<CheckoutBrandingContent>(name))
        {
        }

        public CheckoutBrandingContentQueryBuilder(IQuery<CheckoutBrandingContent> query) : base(query)
        {
        }

        public CheckoutBrandingContentQueryBuilder Divider(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingContainerDividerQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingContainerDivider>("divider");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingContainerDividerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingContainerDivider>(query);
            return this;
        }
    }
}