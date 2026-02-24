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
    public sealed class MetafieldReferencerProductTagsQueryBuilder : FieldsQueryBuilderBase<StringConnection, MetafieldReferencerProductTagsQueryBuilder>, IHasArguments<MetafieldReferencerProductTagsArgumentsBuilder>
    {
        public MetafieldReferencerProductTagsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerProductTagsQueryBuilder Self => this;

        public MetafieldReferencerProductTagsQueryBuilder(string name) : base(new Query<StringConnection>(name))
        {
            Arguments = new MetafieldReferencerProductTagsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerProductTagsQueryBuilder(IQuery<StringConnection> query) : base(query)
        {
            Arguments = new MetafieldReferencerProductTagsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerProductTagsQueryBuilder SetArguments(Action<MetafieldReferencerProductTagsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerProductTagsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StringEdgeQueryBuilder> build)
        {
            var query = new Query<StringEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StringEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StringEdge>(query);
            return this;
        }

        public MetafieldReferencerProductTagsQueryBuilder Nodes()
        {
            base.InnerQuery.AddField("nodes");
            return this;
        }

        public MetafieldReferencerProductTagsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}