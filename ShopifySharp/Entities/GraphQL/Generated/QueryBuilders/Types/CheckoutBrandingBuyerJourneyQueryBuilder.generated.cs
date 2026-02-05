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
    public sealed class CheckoutBrandingBuyerJourneyQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingBuyerJourney, CheckoutBrandingBuyerJourneyQueryBuilder>
    {
        protected override CheckoutBrandingBuyerJourneyQueryBuilder Self => this;

        public CheckoutBrandingBuyerJourneyQueryBuilder() : this("checkoutBrandingBuyerJourney")
        {
        }

        public CheckoutBrandingBuyerJourneyQueryBuilder(string name) : base(new Query<CheckoutBrandingBuyerJourney>(name))
        {
        }

        public CheckoutBrandingBuyerJourneyQueryBuilder(IQuery<CheckoutBrandingBuyerJourney> query) : base(query)
        {
        }

        public CheckoutBrandingBuyerJourneyQueryBuilder Visibility()
        {
            base.InnerQuery.AddField("visibility");
            return this;
        }
    }
}