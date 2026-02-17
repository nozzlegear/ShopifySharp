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

        public CheckoutBrandingContentQueryBuilder Divider(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingContainerDividerQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingContainerDivider>("divider");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingContainerDividerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingContainerDivider>(query);
            return this;
        }
    }
}