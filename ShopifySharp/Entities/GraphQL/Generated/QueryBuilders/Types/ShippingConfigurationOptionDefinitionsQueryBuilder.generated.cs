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
    public sealed class ShippingConfigurationOptionDefinitionsQueryBuilder : FieldsQueryBuilderBase<DeliveryOptionDefinitionConnection, ShippingConfigurationOptionDefinitionsQueryBuilder>, IHasArguments<ShippingConfigurationOptionDefinitionsArgumentsBuilder>
    {
        public ShippingConfigurationOptionDefinitionsArgumentsBuilder Arguments { get; }
        protected override ShippingConfigurationOptionDefinitionsQueryBuilder Self => this;

        public ShippingConfigurationOptionDefinitionsQueryBuilder(string name) : base(new Query<DeliveryOptionDefinitionConnection>(name))
        {
            Arguments = new ShippingConfigurationOptionDefinitionsArgumentsBuilder(base.InnerQuery);
        }

        public ShippingConfigurationOptionDefinitionsQueryBuilder(IQuery<DeliveryOptionDefinitionConnection> query) : base(query)
        {
            Arguments = new ShippingConfigurationOptionDefinitionsArgumentsBuilder(base.InnerQuery);
        }

        public ShippingConfigurationOptionDefinitionsQueryBuilder SetArguments(Action<ShippingConfigurationOptionDefinitionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ShippingConfigurationOptionDefinitionsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryOptionDefinitionEdgeQueryBuilder> build)
        {
            var query = new Query<DeliveryOptionDefinitionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryOptionDefinitionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryOptionDefinitionEdge>(query);
            return this;
        }

        public ShippingConfigurationOptionDefinitionsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }

        public ShippingConfigurationOptionDefinitionsQueryBuilder Nodes(Action<DeliveryOptionDefinitionInterfaceCasesBuilder> build)
        {
            var query = new Query<IDeliveryOptionDefinition>("nodes");
            var unionBuilder = new DeliveryOptionDefinitionInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}