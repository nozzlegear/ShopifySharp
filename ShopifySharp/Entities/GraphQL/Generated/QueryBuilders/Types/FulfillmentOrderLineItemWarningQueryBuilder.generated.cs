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
    public sealed class FulfillmentOrderLineItemWarningQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderLineItemWarning, FulfillmentOrderLineItemWarningQueryBuilder>
    {
        protected override FulfillmentOrderLineItemWarningQueryBuilder Self => this;

        public FulfillmentOrderLineItemWarningQueryBuilder() : this("fulfillmentOrderLineItemWarning")
        {
        }

        public FulfillmentOrderLineItemWarningQueryBuilder(string name) : base(new Query<FulfillmentOrderLineItemWarning>(name))
        {
        }

        public FulfillmentOrderLineItemWarningQueryBuilder(IQuery<FulfillmentOrderLineItemWarning> query) : base(query)
        {
        }

        public FulfillmentOrderLineItemWarningQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public FulfillmentOrderLineItemWarningQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}