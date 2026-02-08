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
    public sealed class CheckoutBrandingFooterQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingFooter, CheckoutBrandingFooterQueryBuilder>
    {
        protected override CheckoutBrandingFooterQueryBuilder Self => this;

        public CheckoutBrandingFooterQueryBuilder() : this("checkoutBrandingFooter")
        {
        }

        public CheckoutBrandingFooterQueryBuilder(string name) : base(new Query<CheckoutBrandingFooter>(name))
        {
        }

        public CheckoutBrandingFooterQueryBuilder(IQuery<CheckoutBrandingFooter> query) : base(query)
        {
        }

        public CheckoutBrandingFooterQueryBuilder Alignment()
        {
            base.InnerQuery.AddField("alignment");
            return this;
        }

        public CheckoutBrandingFooterQueryBuilder ColorScheme()
        {
            base.InnerQuery.AddField("colorScheme");
            return this;
        }

        public CheckoutBrandingFooterQueryBuilder Content(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingFooterContentQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingFooterContent>("content");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingFooterContentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingFooterContent>(query);
            return this;
        }

        public CheckoutBrandingFooterQueryBuilder Divided()
        {
            base.InnerQuery.AddField("divided");
            return this;
        }

        public CheckoutBrandingFooterQueryBuilder Padding()
        {
            base.InnerQuery.AddField("padding");
            return this;
        }

        public CheckoutBrandingFooterQueryBuilder Position()
        {
            base.InnerQuery.AddField("position");
            return this;
        }
    }
}