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
    public sealed class CheckoutAndAccountsConfigurationBrandingImageValueUnionCasesBuilder : UnionCasesBuilderBase<CheckoutAndAccountsConfigurationBrandingImageValue, CheckoutAndAccountsConfigurationBrandingImageValueUnionCasesBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingImageValueUnionCasesBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingImageValueUnionCasesBuilder(string fieldName = "backgroundImage") : this(new Query<CheckoutAndAccountsConfigurationBrandingImageValue>(fieldName))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingImageValueUnionCasesBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingImageValue> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingImageValueUnionCasesBuilder OnCheckoutAndAccountsConfigurationBrandingImage(Action<CheckoutAndAccountsConfigurationBrandingImageQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingImage>("... on CheckoutAndAccountsConfigurationBrandingImage");
            var queryBuilder = new CheckoutAndAccountsConfigurationBrandingImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}