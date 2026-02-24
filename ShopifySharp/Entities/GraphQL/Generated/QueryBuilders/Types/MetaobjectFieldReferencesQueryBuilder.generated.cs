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
    public sealed class MetaobjectFieldReferencesQueryBuilder : FieldsQueryBuilderBase<MetafieldReferenceConnection, MetaobjectFieldReferencesQueryBuilder>, IHasArguments<MetaobjectFieldReferencesArgumentsBuilder>
    {
        public MetaobjectFieldReferencesArgumentsBuilder Arguments { get; }
        protected override MetaobjectFieldReferencesQueryBuilder Self => this;

        public MetaobjectFieldReferencesQueryBuilder(string name) : base(new Query<MetafieldReferenceConnection>(name))
        {
            Arguments = new MetaobjectFieldReferencesArgumentsBuilder(base.InnerQuery);
        }

        public MetaobjectFieldReferencesQueryBuilder(IQuery<MetafieldReferenceConnection> query) : base(query)
        {
            Arguments = new MetaobjectFieldReferencesArgumentsBuilder(base.InnerQuery);
        }

        public MetaobjectFieldReferencesQueryBuilder SetArguments(Action<MetaobjectFieldReferencesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetaobjectFieldReferencesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldReferenceEdgeQueryBuilder> build)
        {
            var query = new Query<MetafieldReferenceEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldReferenceEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldReferenceEdge>(query);
            return this;
        }

        public MetaobjectFieldReferencesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }

        public MetaobjectFieldReferencesQueryBuilder Nodes(Action<MetafieldReferenceUnionCasesBuilder> build)
        {
            var query = new Query<MetafieldReference>("nodes");
            var unionBuilder = new MetafieldReferenceUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}