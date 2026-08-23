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
    public sealed class CheckoutBrandingFontQueryBuilder : FieldsQueryBuilderBase<ICheckoutBrandingFont, CheckoutBrandingFontQueryBuilder>
    {
        protected override CheckoutBrandingFontQueryBuilder Self => this;

        public CheckoutBrandingFontQueryBuilder() : this("checkoutBrandingFont")
        {
        }

        public CheckoutBrandingFontQueryBuilder(string name) : base(new Query<ICheckoutBrandingFont>(name))
        {
        }

        public CheckoutBrandingFontQueryBuilder(IQuery<ICheckoutBrandingFont> query) : base(query)
        {
        }

        public CheckoutBrandingFontQueryBuilder Sources()
        {
            base.InnerQuery.AddField("sources");
            return this;
        }

        public CheckoutBrandingFontQueryBuilder Weight()
        {
            base.InnerQuery.AddField("weight");
            return this;
        }

        public CheckoutBrandingFontQueryBuilder OnCheckoutBrandingCustomFont(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingCustomFontQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingCustomFont>("... on CheckoutBrandingCustomFont");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingCustomFontQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CheckoutBrandingFontQueryBuilder OnCheckoutBrandingShopifyFont(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingShopifyFontQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingShopifyFont>("... on CheckoutBrandingShopifyFont");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingShopifyFontQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CheckoutBrandingFontQueryBuilder CheckoutBrandingFont(Action<CheckoutBrandingFontInterfaceCasesBuilder> build)
        {
            var query = new Query<ICheckoutBrandingFont>("checkoutBrandingFont");
            var unionBuilder = new CheckoutBrandingFontInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}