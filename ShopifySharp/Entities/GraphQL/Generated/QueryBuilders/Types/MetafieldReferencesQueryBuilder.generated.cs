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
    public sealed class MetafieldReferencesQueryBuilder : FieldsQueryBuilderBase<MetafieldReferenceConnection, MetafieldReferencesQueryBuilder>, IHasArguments<MetafieldReferencesArgumentsBuilder>
    {
        public MetafieldReferencesArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencesQueryBuilder Self => this;

        public MetafieldReferencesQueryBuilder(string name) : base(new Query<MetafieldReferenceConnection>(name))
        {
            Arguments = new MetafieldReferencesArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencesQueryBuilder(IQuery<MetafieldReferenceConnection> query) : base(query)
        {
            Arguments = new MetafieldReferencesArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencesQueryBuilder SetArguments(Action<MetafieldReferencesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldReferenceEdgeQueryBuilder> build)
        {
            var query = new Query<MetafieldReferenceEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldReferenceEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldReferenceEdge>(query);
            return this;
        }

        public MetafieldReferencesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }

        public MetafieldReferencesQueryBuilder Nodes(Action<MetafieldReferenceUnionCasesBuilder> build)
        {
            var query = new Query<MetafieldReference>("nodes");
            var unionBuilder = new MetafieldReferenceUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}