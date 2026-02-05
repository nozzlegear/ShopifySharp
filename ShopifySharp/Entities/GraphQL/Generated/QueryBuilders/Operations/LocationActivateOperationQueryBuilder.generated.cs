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
    public sealed class LocationActivateOperationQueryBuilder : FieldsQueryBuilderBase<LocationActivatePayload, LocationActivateOperationQueryBuilder>, IGraphOperationQueryBuilder<LocationActivatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public LocationActivateArgumentsBuilder Arguments { get; }
        protected override LocationActivateOperationQueryBuilder Self => this;

        public LocationActivateOperationQueryBuilder() : this("locationActivate")
        {
        }

        public LocationActivateOperationQueryBuilder(string name) : base(new Query<LocationActivatePayload>(name))
        {
            Arguments = new LocationActivateArgumentsBuilder(base.InnerQuery);
        }

        public LocationActivateOperationQueryBuilder(IQuery<LocationActivatePayload> query) : base(query)
        {
            Arguments = new LocationActivateArgumentsBuilder(base.InnerQuery);
        }

        public LocationActivateOperationQueryBuilder Location(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public LocationActivateOperationQueryBuilder LocationActivateUserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationActivateUserErrorQueryBuilder> build)
        {
            var query = new Query<LocationActivateUserError>("locationActivateUserErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationActivateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationActivateUserError>(query);
            return this;
        }
    }
}