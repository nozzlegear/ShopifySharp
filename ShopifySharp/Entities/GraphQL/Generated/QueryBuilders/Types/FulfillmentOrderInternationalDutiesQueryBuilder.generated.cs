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
    public sealed class FulfillmentOrderInternationalDutiesQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderInternationalDuties, FulfillmentOrderInternationalDutiesQueryBuilder>
    {
        protected override FulfillmentOrderInternationalDutiesQueryBuilder Self => this;

        public FulfillmentOrderInternationalDutiesQueryBuilder() : this("fulfillmentOrderInternationalDuties")
        {
        }

        public FulfillmentOrderInternationalDutiesQueryBuilder(string name) : base(new Query<FulfillmentOrderInternationalDuties>(name))
        {
        }

        public FulfillmentOrderInternationalDutiesQueryBuilder(IQuery<FulfillmentOrderInternationalDuties> query) : base(query)
        {
        }

        public FulfillmentOrderInternationalDutiesQueryBuilder Incoterm()
        {
            base.InnerQuery.AddField("incoterm");
            return this;
        }
    }
}