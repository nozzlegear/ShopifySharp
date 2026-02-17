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
    public sealed class CheckoutBrandingColorGlobalQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingColorGlobal, CheckoutBrandingColorGlobalQueryBuilder>
    {
        protected override CheckoutBrandingColorGlobalQueryBuilder Self => this;

        public CheckoutBrandingColorGlobalQueryBuilder() : this("checkoutBrandingColorGlobal")
        {
        }

        public CheckoutBrandingColorGlobalQueryBuilder(string name) : base(new Query<CheckoutBrandingColorGlobal>(name))
        {
        }

        public CheckoutBrandingColorGlobalQueryBuilder(IQuery<CheckoutBrandingColorGlobal> query) : base(query)
        {
        }

        public CheckoutBrandingColorGlobalQueryBuilder Accent()
        {
            base.InnerQuery.AddField("accent");
            return this;
        }

        public CheckoutBrandingColorGlobalQueryBuilder Brand()
        {
            base.InnerQuery.AddField("brand");
            return this;
        }

        public CheckoutBrandingColorGlobalQueryBuilder Critical()
        {
            base.InnerQuery.AddField("critical");
            return this;
        }

        public CheckoutBrandingColorGlobalQueryBuilder Decorative()
        {
            base.InnerQuery.AddField("decorative");
            return this;
        }

        public CheckoutBrandingColorGlobalQueryBuilder Info()
        {
            base.InnerQuery.AddField("info");
            return this;
        }

        public CheckoutBrandingColorGlobalQueryBuilder Success()
        {
            base.InnerQuery.AddField("success");
            return this;
        }

        public CheckoutBrandingColorGlobalQueryBuilder Warning()
        {
            base.InnerQuery.AddField("warning");
            return this;
        }
    }
}