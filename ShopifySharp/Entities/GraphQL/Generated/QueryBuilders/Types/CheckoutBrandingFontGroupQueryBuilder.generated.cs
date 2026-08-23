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

        public CheckoutBrandingFontGroupQueryBuilder Base(Action<CheckoutBrandingFontInterfaceCasesBuilder> build)
        {
            var query = new Query<ICheckoutBrandingFont>("base");
            var unionBuilder = new CheckoutBrandingFontInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CheckoutBrandingFontGroupQueryBuilder Bold(Action<CheckoutBrandingFontInterfaceCasesBuilder> build)
        {
            var query = new Query<ICheckoutBrandingFont>("bold");
            var unionBuilder = new CheckoutBrandingFontInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}