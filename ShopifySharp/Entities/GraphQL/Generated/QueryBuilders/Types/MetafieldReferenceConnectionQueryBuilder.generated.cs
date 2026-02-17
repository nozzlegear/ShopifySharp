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
    public sealed class MetafieldReferenceConnectionQueryBuilder : FieldsQueryBuilderBase<MetafieldReferenceConnection, MetafieldReferenceConnectionQueryBuilder>
    {
        protected override MetafieldReferenceConnectionQueryBuilder Self => this;

        public MetafieldReferenceConnectionQueryBuilder() : this("metafieldReferenceConnection")
        {
        }

        public MetafieldReferenceConnectionQueryBuilder(string name) : base(new Query<MetafieldReferenceConnection>(name))
        {
        }

        public MetafieldReferenceConnectionQueryBuilder(IQuery<MetafieldReferenceConnection> query) : base(query)
        {
        }

        public MetafieldReferenceConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldReferenceEdgeQueryBuilder> build)
        {
            var query = new Query<MetafieldReferenceEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldReferenceEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldReferenceEdge>(query);
            return this;
        }

        public MetafieldReferenceConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }

        public MetafieldReferenceConnectionQueryBuilder Nodes(Action<MetafieldReferenceUnionCasesBuilder> build)
        {
            var query = new Query<MetafieldReference>("nodes");
            var unionBuilder = new MetafieldReferenceUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}