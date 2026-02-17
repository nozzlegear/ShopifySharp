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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class DeliveryPromiseProviderOperationQueryBuilder : FieldsQueryBuilderBase<DeliveryPromiseProvider, DeliveryPromiseProviderOperationQueryBuilder>, IGraphOperationQueryBuilder<DeliveryPromiseProvider>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public DeliveryPromiseProviderArgumentsBuilder Arguments { get; }
        protected override DeliveryPromiseProviderOperationQueryBuilder Self => this;

        public DeliveryPromiseProviderOperationQueryBuilder() : this("deliveryPromiseProvider")
        {
        }

        public DeliveryPromiseProviderOperationQueryBuilder(string name) : base(new Query<DeliveryPromiseProvider>(name))
        {
            Arguments = new DeliveryPromiseProviderArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryPromiseProviderOperationQueryBuilder(IQuery<DeliveryPromiseProvider> query) : base(query)
        {
            Arguments = new DeliveryPromiseProviderArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryPromiseProviderOperationQueryBuilder Active()
        {
            base.InnerQuery.AddField("active");
            return this;
        }

        public DeliveryPromiseProviderOperationQueryBuilder FulfillmentDelay()
        {
            base.InnerQuery.AddField("fulfillmentDelay");
            return this;
        }

        public DeliveryPromiseProviderOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DeliveryPromiseProviderOperationQueryBuilder Location(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public DeliveryPromiseProviderOperationQueryBuilder TimeZone()
        {
            base.InnerQuery.AddField("timeZone");
            return this;
        }
    }
}