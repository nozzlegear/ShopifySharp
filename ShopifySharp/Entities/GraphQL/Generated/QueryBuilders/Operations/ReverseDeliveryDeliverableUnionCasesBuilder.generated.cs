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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class ReverseDeliveryDeliverableUnionCasesBuilder : UnionCasesBuilderBase<ReverseDeliveryDeliverable, ReverseDeliveryDeliverableUnionCasesBuilder>
    {
        protected override ReverseDeliveryDeliverableUnionCasesBuilder Self => this;

        public ReverseDeliveryDeliverableUnionCasesBuilder(string fieldName = "deliverable") : this(new Query<ReverseDeliveryDeliverable>(fieldName))
        {
        }

        public ReverseDeliveryDeliverableUnionCasesBuilder(IQuery<ReverseDeliveryDeliverable> query) : base(query)
        {
        }

        public ReverseDeliveryDeliverableUnionCasesBuilder OnReverseDeliveryShippingDeliverable(Action<ReverseDeliveryShippingDeliverableQueryBuilder> build)
        {
            var query = new Query<ReverseDeliveryShippingDeliverable>("... on ReverseDeliveryShippingDeliverable");
            var queryBuilder = new ReverseDeliveryShippingDeliverableQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}