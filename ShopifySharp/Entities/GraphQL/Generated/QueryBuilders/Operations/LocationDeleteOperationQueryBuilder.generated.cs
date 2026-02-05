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
    public sealed class LocationDeleteOperationQueryBuilder : FieldsQueryBuilderBase<LocationDeletePayload, LocationDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<LocationDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public LocationDeleteArgumentsBuilder Arguments { get; }
        protected override LocationDeleteOperationQueryBuilder Self => this;

        public LocationDeleteOperationQueryBuilder() : this("locationDelete")
        {
        }

        public LocationDeleteOperationQueryBuilder(string name) : base(new Query<LocationDeletePayload>(name))
        {
            Arguments = new LocationDeleteArgumentsBuilder(base.InnerQuery);
        }

        public LocationDeleteOperationQueryBuilder(IQuery<LocationDeletePayload> query) : base(query)
        {
            Arguments = new LocationDeleteArgumentsBuilder(base.InnerQuery);
        }

        public LocationDeleteOperationQueryBuilder DeletedLocationId()
        {
            base.InnerQuery.AddField("deletedLocationId");
            return this;
        }

        public LocationDeleteOperationQueryBuilder LocationDeleteUserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<LocationDeleteUserError>("locationDeleteUserErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationDeleteUserError>(query);
            return this;
        }
    }
}