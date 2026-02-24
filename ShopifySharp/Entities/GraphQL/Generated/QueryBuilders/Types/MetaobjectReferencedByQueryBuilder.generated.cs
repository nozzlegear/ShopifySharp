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
    public sealed class MetaobjectReferencedByQueryBuilder : FieldsQueryBuilderBase<MetafieldRelationConnection, MetaobjectReferencedByQueryBuilder>, IHasArguments<MetaobjectReferencedByArgumentsBuilder>
    {
        public MetaobjectReferencedByArgumentsBuilder Arguments { get; }
        protected override MetaobjectReferencedByQueryBuilder Self => this;

        public MetaobjectReferencedByQueryBuilder(string name) : base(new Query<MetafieldRelationConnection>(name))
        {
            Arguments = new MetaobjectReferencedByArgumentsBuilder(base.InnerQuery);
        }

        public MetaobjectReferencedByQueryBuilder(IQuery<MetafieldRelationConnection> query) : base(query)
        {
            Arguments = new MetaobjectReferencedByArgumentsBuilder(base.InnerQuery);
        }

        public MetaobjectReferencedByQueryBuilder SetArguments(Action<MetaobjectReferencedByArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetaobjectReferencedByQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldRelationEdgeQueryBuilder> build)
        {
            var query = new Query<MetafieldRelationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldRelationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldRelationEdge>(query);
            return this;
        }

        public MetaobjectReferencedByQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldRelationQueryBuilder> build)
        {
            var query = new Query<MetafieldRelation>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldRelationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldRelation>(query);
            return this;
        }

        public MetaobjectReferencedByQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}