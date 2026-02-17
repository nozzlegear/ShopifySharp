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
    public sealed class DeliveryCustomizationsOperationQueryBuilder : FieldsQueryBuilderBase<DeliveryCustomizationConnection, DeliveryCustomizationsOperationQueryBuilder>, IGraphOperationQueryBuilder<DeliveryCustomizationConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public DeliveryCustomizationsArgumentsBuilder Arguments { get; }
        protected override DeliveryCustomizationsOperationQueryBuilder Self => this;

        public DeliveryCustomizationsOperationQueryBuilder() : this("deliveryCustomizations")
        {
        }

        public DeliveryCustomizationsOperationQueryBuilder(string name) : base(new Query<DeliveryCustomizationConnection>(name))
        {
            Arguments = new DeliveryCustomizationsArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryCustomizationsOperationQueryBuilder(IQuery<DeliveryCustomizationConnection> query) : base(query)
        {
            Arguments = new DeliveryCustomizationsArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryCustomizationsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCustomizationEdgeQueryBuilder> build)
        {
            var query = new Query<DeliveryCustomizationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCustomizationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCustomizationEdge>(query);
            return this;
        }

        public DeliveryCustomizationsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCustomizationQueryBuilder> build)
        {
            var query = new Query<DeliveryCustomization>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCustomizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCustomization>(query);
            return this;
        }

        public DeliveryCustomizationsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}