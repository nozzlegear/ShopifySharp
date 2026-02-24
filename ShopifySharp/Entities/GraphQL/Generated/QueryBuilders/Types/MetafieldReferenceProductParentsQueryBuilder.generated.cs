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
    public sealed class MetafieldReferenceProductParentsQueryBuilder : FieldsQueryBuilderBase<ProductConnection, MetafieldReferenceProductParentsQueryBuilder>, IHasArguments<MetafieldReferenceProductParentsArgumentsBuilder>
    {
        public MetafieldReferenceProductParentsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferenceProductParentsQueryBuilder Self => this;

        public MetafieldReferenceProductParentsQueryBuilder(string name) : base(new Query<ProductConnection>(name))
        {
            Arguments = new MetafieldReferenceProductParentsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceProductParentsQueryBuilder(IQuery<ProductConnection> query) : base(query)
        {
            Arguments = new MetafieldReferenceProductParentsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceProductParentsQueryBuilder SetArguments(Action<MetafieldReferenceProductParentsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferenceProductParentsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductEdgeQueryBuilder> build)
        {
            var query = new Query<ProductEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductEdge>(query);
            return this;
        }

        public MetafieldReferenceProductParentsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public MetafieldReferenceProductParentsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}