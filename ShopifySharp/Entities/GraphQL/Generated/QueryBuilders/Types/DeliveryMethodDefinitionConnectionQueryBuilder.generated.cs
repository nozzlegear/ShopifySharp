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
    public sealed class DeliveryMethodDefinitionConnectionQueryBuilder : FieldsQueryBuilderBase<DeliveryMethodDefinitionConnection, DeliveryMethodDefinitionConnectionQueryBuilder>, IHasArguments<DeliveryMethodDefinitionConnectionArgumentsBuilder>
    {
        public DeliveryMethodDefinitionConnectionArgumentsBuilder Arguments { get; }
        protected override DeliveryMethodDefinitionConnectionQueryBuilder Self => this;

        public DeliveryMethodDefinitionConnectionQueryBuilder() : this("deliveryMethodDefinitionConnection")
        {
        }

        public DeliveryMethodDefinitionConnectionQueryBuilder(string name) : base(new Query<DeliveryMethodDefinitionConnection>(name))
        {
            Arguments = new DeliveryMethodDefinitionConnectionArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryMethodDefinitionConnectionQueryBuilder(IQuery<DeliveryMethodDefinitionConnection> query) : base(query)
        {
            Arguments = new DeliveryMethodDefinitionConnectionArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryMethodDefinitionConnectionQueryBuilder SetArguments(Action<DeliveryMethodDefinitionConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DeliveryMethodDefinitionConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryMethodDefinitionEdgeQueryBuilder> build)
        {
            var query = new Query<DeliveryMethodDefinitionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryMethodDefinitionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryMethodDefinitionEdge>(query);
            return this;
        }

        public DeliveryMethodDefinitionConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryMethodDefinitionQueryBuilder> build)
        {
            var query = new Query<DeliveryMethodDefinition>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryMethodDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryMethodDefinition>(query);
            return this;
        }

        public DeliveryMethodDefinitionConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}