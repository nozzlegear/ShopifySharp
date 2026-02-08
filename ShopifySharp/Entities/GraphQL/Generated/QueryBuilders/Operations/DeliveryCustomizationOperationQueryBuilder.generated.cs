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
    public sealed class DeliveryCustomizationOperationQueryBuilder : FieldsQueryBuilderBase<DeliveryCustomization, DeliveryCustomizationOperationQueryBuilder>, IGraphOperationQueryBuilder<DeliveryCustomization>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public DeliveryCustomizationArgumentsBuilder Arguments { get; }
        protected override DeliveryCustomizationOperationQueryBuilder Self => this;

        public DeliveryCustomizationOperationQueryBuilder() : this("deliveryCustomization")
        {
        }

        public DeliveryCustomizationOperationQueryBuilder(string name) : base(new Query<DeliveryCustomization>(name))
        {
            Arguments = new DeliveryCustomizationArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryCustomizationOperationQueryBuilder(IQuery<DeliveryCustomization> query) : base(query)
        {
            Arguments = new DeliveryCustomizationArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryCustomizationOperationQueryBuilder Enabled()
        {
            base.InnerQuery.AddField("enabled");
            return this;
        }

        public DeliveryCustomizationOperationQueryBuilder ErrorHistory(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FunctionsErrorHistoryQueryBuilder> build)
        {
            var query = new Query<FunctionsErrorHistory>("errorHistory");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FunctionsErrorHistoryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FunctionsErrorHistory>(query);
            return this;
        }

        public DeliveryCustomizationOperationQueryBuilder FunctionId()
        {
            base.InnerQuery.AddField("functionId");
            return this;
        }

        public DeliveryCustomizationOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DeliveryCustomizationOperationQueryBuilder Metafield(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public DeliveryCustomizationOperationQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public DeliveryCustomizationOperationQueryBuilder Metafields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public DeliveryCustomizationOperationQueryBuilder ShopifyFunction(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyFunctionQueryBuilder> build)
        {
            var query = new Query<ShopifyFunction>("shopifyFunction");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyFunctionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyFunction>(query);
            return this;
        }

        public DeliveryCustomizationOperationQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}