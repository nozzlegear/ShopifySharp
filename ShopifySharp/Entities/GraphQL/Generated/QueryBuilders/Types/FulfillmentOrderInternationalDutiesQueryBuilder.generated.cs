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