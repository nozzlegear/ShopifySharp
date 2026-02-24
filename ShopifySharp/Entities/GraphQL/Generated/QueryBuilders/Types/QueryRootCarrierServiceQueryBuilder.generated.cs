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
    public sealed class QueryRootCarrierServiceQueryBuilder : FieldsQueryBuilderBase<DeliveryCarrierService, QueryRootCarrierServiceQueryBuilder>, IHasArguments<QueryRootCarrierServiceArgumentsBuilder>
    {
        public QueryRootCarrierServiceArgumentsBuilder Arguments { get; }
        protected override QueryRootCarrierServiceQueryBuilder Self => this;

        public QueryRootCarrierServiceQueryBuilder(string name) : base(new Query<DeliveryCarrierService>(name))
        {
            Arguments = new QueryRootCarrierServiceArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCarrierServiceQueryBuilder(IQuery<DeliveryCarrierService> query) : base(query)
        {
            Arguments = new QueryRootCarrierServiceArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCarrierServiceQueryBuilder SetArguments(Action<QueryRootCarrierServiceArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCarrierServiceQueryBuilder Active()
        {
            base.InnerQuery.AddField("active");
            return this;
        }

        public QueryRootCarrierServiceQueryBuilder AvailableServicesForCountries(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryAvailableServiceQueryBuilder> build)
        {
            var query = new Query<DeliveryAvailableService>("availableServicesForCountries");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryAvailableServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryAvailableService>(query);
            return this;
        }

        public QueryRootCarrierServiceQueryBuilder CallbackUrl()
        {
            base.InnerQuery.AddField("callbackUrl");
            return this;
        }

        public QueryRootCarrierServiceQueryBuilder FormattedName()
        {
            base.InnerQuery.AddField("formattedName");
            return this;
        }

        public QueryRootCarrierServiceQueryBuilder Icon(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("icon");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public QueryRootCarrierServiceQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootCarrierServiceQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public QueryRootCarrierServiceQueryBuilder SupportsServiceDiscovery()
        {
            base.InnerQuery.AddField("supportsServiceDiscovery");
            return this;
        }
    }
}