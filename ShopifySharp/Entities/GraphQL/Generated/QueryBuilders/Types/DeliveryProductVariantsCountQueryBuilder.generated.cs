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
    public sealed class DeliveryProductVariantsCountQueryBuilder : FieldsQueryBuilderBase<DeliveryProductVariantsCount, DeliveryProductVariantsCountQueryBuilder>
    {
        protected override DeliveryProductVariantsCountQueryBuilder Self => this;

        public DeliveryProductVariantsCountQueryBuilder() : this("deliveryProductVariantsCount")
        {
        }

        public DeliveryProductVariantsCountQueryBuilder(string name) : base(new Query<DeliveryProductVariantsCount>(name))
        {
        }

        public DeliveryProductVariantsCountQueryBuilder(IQuery<DeliveryProductVariantsCount> query) : base(query)
        {
        }

        public DeliveryProductVariantsCountQueryBuilder Capped()
        {
            base.InnerQuery.AddField("capped");
            return this;
        }

        public DeliveryProductVariantsCountQueryBuilder Count()
        {
            base.InnerQuery.AddField("count");
            return this;
        }
    }
}