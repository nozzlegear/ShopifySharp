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
    public sealed class CheckoutBrandingFontInterfaceCasesBuilder : InterfaceCasesBuilderBase<ICheckoutBrandingFont, CheckoutBrandingFontInterfaceCasesBuilder>
    {
        protected override CheckoutBrandingFontInterfaceCasesBuilder Self => this;

        public CheckoutBrandingFontInterfaceCasesBuilder(string fieldName = "bold") : this(new Query<ICheckoutBrandingFont>(fieldName))
        {
        }

        public CheckoutBrandingFontInterfaceCasesBuilder(IQuery<ICheckoutBrandingFont> query) : base(query)
        {
        }

        public CheckoutBrandingFontInterfaceCasesBuilder OnCheckoutBrandingCustomFont(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingCustomFontQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingCustomFont>("... on CheckoutBrandingCustomFont");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingCustomFontQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CheckoutBrandingFontInterfaceCasesBuilder OnCheckoutBrandingShopifyFont(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingShopifyFontQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingShopifyFont>("... on CheckoutBrandingShopifyFont");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingShopifyFontQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}