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
    public sealed class DeliveryBrandedPromiseQueryBuilder : FieldsQueryBuilderBase<DeliveryBrandedPromise, DeliveryBrandedPromiseQueryBuilder>
    {
        protected override DeliveryBrandedPromiseQueryBuilder Self => this;

        public DeliveryBrandedPromiseQueryBuilder() : this("deliveryBrandedPromise")
        {
        }

        public DeliveryBrandedPromiseQueryBuilder(string name) : base(new Query<DeliveryBrandedPromise>(name))
        {
        }

        public DeliveryBrandedPromiseQueryBuilder(IQuery<DeliveryBrandedPromise> query) : base(query)
        {
        }

        public DeliveryBrandedPromiseQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public DeliveryBrandedPromiseQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }
    }
}