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
    public sealed class TaxonomyCategoryAttributesQueryBuilder : FieldsQueryBuilderBase<TaxonomyCategoryAttributeConnection, TaxonomyCategoryAttributesQueryBuilder>, IHasArguments<TaxonomyCategoryAttributesArgumentsBuilder>
    {
        public TaxonomyCategoryAttributesArgumentsBuilder Arguments { get; }
        protected override TaxonomyCategoryAttributesQueryBuilder Self => this;

        public TaxonomyCategoryAttributesQueryBuilder(string name) : base(new Query<TaxonomyCategoryAttributeConnection>(name))
        {
            Arguments = new TaxonomyCategoryAttributesArgumentsBuilder(base.InnerQuery);
        }

        public TaxonomyCategoryAttributesQueryBuilder(IQuery<TaxonomyCategoryAttributeConnection> query) : base(query)
        {
            Arguments = new TaxonomyCategoryAttributesArgumentsBuilder(base.InnerQuery);
        }

        public TaxonomyCategoryAttributesQueryBuilder SetArguments(Action<TaxonomyCategoryAttributesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public TaxonomyCategoryAttributesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyCategoryAttributeEdgeQueryBuilder> build)
        {
            var query = new Query<TaxonomyCategoryAttributeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyCategoryAttributeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxonomyCategoryAttributeEdge>(query);
            return this;
        }

        public TaxonomyCategoryAttributesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }

        public TaxonomyCategoryAttributesQueryBuilder Nodes(Action<TaxonomyCategoryAttributeUnionCasesBuilder> build)
        {
            var query = new Query<TaxonomyCategoryAttribute>("nodes");
            var unionBuilder = new TaxonomyCategoryAttributeUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}