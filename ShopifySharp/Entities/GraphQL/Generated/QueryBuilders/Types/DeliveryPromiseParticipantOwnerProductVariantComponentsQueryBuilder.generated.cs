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
    public sealed class DeliveryPromiseParticipantOwnerProductVariantComponentsQueryBuilder : FieldsQueryBuilderBase<ProductVariantComponentConnection, DeliveryPromiseParticipantOwnerProductVariantComponentsQueryBuilder>, IHasArguments<DeliveryPromiseParticipantOwnerProductVariantComponentsArgumentsBuilder>
    {
        public DeliveryPromiseParticipantOwnerProductVariantComponentsArgumentsBuilder Arguments { get; }
        protected override DeliveryPromiseParticipantOwnerProductVariantComponentsQueryBuilder Self => this;

        public DeliveryPromiseParticipantOwnerProductVariantComponentsQueryBuilder(string name) : base(new Query<ProductVariantComponentConnection>(name))
        {
            Arguments = new DeliveryPromiseParticipantOwnerProductVariantComponentsArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryPromiseParticipantOwnerProductVariantComponentsQueryBuilder(IQuery<ProductVariantComponentConnection> query) : base(query)
        {
            Arguments = new DeliveryPromiseParticipantOwnerProductVariantComponentsArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryPromiseParticipantOwnerProductVariantComponentsQueryBuilder SetArguments(Action<DeliveryPromiseParticipantOwnerProductVariantComponentsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DeliveryPromiseParticipantOwnerProductVariantComponentsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantComponentEdgeQueryBuilder> build)
        {
            var query = new Query<ProductVariantComponentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantComponentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantComponentEdge>(query);
            return this;
        }

        public DeliveryPromiseParticipantOwnerProductVariantComponentsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantComponentQueryBuilder> build)
        {
            var query = new Query<ProductVariantComponent>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantComponentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantComponent>(query);
            return this;
        }

        public DeliveryPromiseParticipantOwnerProductVariantComponentsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}