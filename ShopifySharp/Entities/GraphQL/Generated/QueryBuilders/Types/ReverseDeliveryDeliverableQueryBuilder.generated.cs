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
    public sealed class ReverseDeliveryDeliverableQueryBuilder : FieldsQueryBuilderBase<ReverseDeliveryDeliverable, ReverseDeliveryDeliverableQueryBuilder>
    {
        protected override ReverseDeliveryDeliverableQueryBuilder Self => this;

        public ReverseDeliveryDeliverableQueryBuilder() : this("reverseDeliveryDeliverable")
        {
        }

        public ReverseDeliveryDeliverableQueryBuilder(string name) : base(new Query<ReverseDeliveryDeliverable>(name))
        {
        }

        public ReverseDeliveryDeliverableQueryBuilder(IQuery<ReverseDeliveryDeliverable> query) : base(query)
        {
        }

        public ReverseDeliveryDeliverableQueryBuilder ReverseDeliveryDeliverable(Action<ReverseDeliveryDeliverableUnionCasesBuilder> build)
        {
            var query = new Query<ReverseDeliveryDeliverable>("reverseDeliveryDeliverable");
            var unionBuilder = new ReverseDeliveryDeliverableUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}