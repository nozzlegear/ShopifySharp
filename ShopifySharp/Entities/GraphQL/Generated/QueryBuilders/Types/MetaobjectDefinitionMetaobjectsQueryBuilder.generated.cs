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
    public sealed class MetaobjectDefinitionMetaobjectsQueryBuilder : FieldsQueryBuilderBase<MetaobjectConnection, MetaobjectDefinitionMetaobjectsQueryBuilder>, IHasArguments<MetaobjectDefinitionMetaobjectsArgumentsBuilder>
    {
        public MetaobjectDefinitionMetaobjectsArgumentsBuilder Arguments { get; }
        protected override MetaobjectDefinitionMetaobjectsQueryBuilder Self => this;

        public MetaobjectDefinitionMetaobjectsQueryBuilder(string name) : base(new Query<MetaobjectConnection>(name))
        {
            Arguments = new MetaobjectDefinitionMetaobjectsArgumentsBuilder(base.InnerQuery);
        }

        public MetaobjectDefinitionMetaobjectsQueryBuilder(IQuery<MetaobjectConnection> query) : base(query)
        {
            Arguments = new MetaobjectDefinitionMetaobjectsArgumentsBuilder(base.InnerQuery);
        }

        public MetaobjectDefinitionMetaobjectsQueryBuilder SetArguments(Action<MetaobjectDefinitionMetaobjectsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetaobjectDefinitionMetaobjectsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectEdgeQueryBuilder> build)
        {
            var query = new Query<MetaobjectEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectEdge>(query);
            return this;
        }

        public MetaobjectDefinitionMetaobjectsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectQueryBuilder> build)
        {
            var query = new Query<Metaobject>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metaobject>(query);
            return this;
        }

        public MetaobjectDefinitionMetaobjectsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}