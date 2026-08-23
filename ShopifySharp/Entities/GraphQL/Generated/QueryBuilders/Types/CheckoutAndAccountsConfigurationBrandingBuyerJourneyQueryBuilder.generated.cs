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
    public sealed class CheckoutAndAccountsConfigurationBrandingBuyerJourneyQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingBuyerJourney, CheckoutAndAccountsConfigurationBrandingBuyerJourneyQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingBuyerJourneyQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingBuyerJourneyQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingBuyerJourney")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingBuyerJourneyQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingBuyerJourney>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingBuyerJourneyQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingBuyerJourney> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingBuyerJourneyQueryBuilder Visibility()
        {
            base.InnerQuery.AddField("visibility");
            return this;
        }
    }
}