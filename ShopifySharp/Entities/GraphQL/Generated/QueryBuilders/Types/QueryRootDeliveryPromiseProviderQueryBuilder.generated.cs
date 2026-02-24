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
    public sealed class QueryRootDeliveryPromiseProviderQueryBuilder : FieldsQueryBuilderBase<DeliveryPromiseProvider, QueryRootDeliveryPromiseProviderQueryBuilder>, IHasArguments<QueryRootDeliveryPromiseProviderArgumentsBuilder>
    {
        public QueryRootDeliveryPromiseProviderArgumentsBuilder Arguments { get; }
        protected override QueryRootDeliveryPromiseProviderQueryBuilder Self => this;

        public QueryRootDeliveryPromiseProviderQueryBuilder(string name) : base(new Query<DeliveryPromiseProvider>(name))
        {
            Arguments = new QueryRootDeliveryPromiseProviderArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootDeliveryPromiseProviderQueryBuilder(IQuery<DeliveryPromiseProvider> query) : base(query)
        {
            Arguments = new QueryRootDeliveryPromiseProviderArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootDeliveryPromiseProviderQueryBuilder SetArguments(Action<QueryRootDeliveryPromiseProviderArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootDeliveryPromiseProviderQueryBuilder Active()
        {
            base.InnerQuery.AddField("active");
            return this;
        }

        public QueryRootDeliveryPromiseProviderQueryBuilder FulfillmentDelay()
        {
            base.InnerQuery.AddField("fulfillmentDelay");
            return this;
        }

        public QueryRootDeliveryPromiseProviderQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootDeliveryPromiseProviderQueryBuilder Location(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public QueryRootDeliveryPromiseProviderQueryBuilder TimeZone()
        {
            base.InnerQuery.AddField("timeZone");
            return this;
        }
    }
}