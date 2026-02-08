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
    public sealed class CheckoutBrandingFontGroupQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingFontGroup, CheckoutBrandingFontGroupQueryBuilder>
    {
        protected override CheckoutBrandingFontGroupQueryBuilder Self => this;

        public CheckoutBrandingFontGroupQueryBuilder() : this("checkoutBrandingFontGroup")
        {
        }

        public CheckoutBrandingFontGroupQueryBuilder(string name) : base(new Query<CheckoutBrandingFontGroup>(name))
        {
        }

        public CheckoutBrandingFontGroupQueryBuilder(IQuery<CheckoutBrandingFontGroup> query) : base(query)
        {
        }

        public CheckoutBrandingFontGroupQueryBuilder Base(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingFontQueryBuilder> build)
        {
            var query = new Query<ICheckoutBrandingFont>("base");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingFontQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICheckoutBrandingFont>(query);
            return this;
        }

        public CheckoutBrandingFontGroupQueryBuilder Bold(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingFontQueryBuilder> build)
        {
            var query = new Query<ICheckoutBrandingFont>("bold");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingFontQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICheckoutBrandingFont>(query);
            return this;
        }

        public CheckoutBrandingFontGroupQueryBuilder LoadingStrategy()
        {
            base.InnerQuery.AddField("loadingStrategy");
            return this;
        }

        public CheckoutBrandingFontGroupQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }
    }
}