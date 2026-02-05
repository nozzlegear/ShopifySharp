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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class MediaEdgeQueryBuilder : FieldsQueryBuilderBase<MediaEdge, MediaEdgeQueryBuilder>
    {
        protected override MediaEdgeQueryBuilder Self => this;

        public MediaEdgeQueryBuilder() : this("mediaEdge")
        {
        }

        public MediaEdgeQueryBuilder(string name) : base(new Query<MediaEdge>(name))
        {
        }

        public MediaEdgeQueryBuilder(IQuery<MediaEdge> query) : base(query)
        {
        }

        public MediaEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public MediaEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaQueryBuilder> build)
        {
            var query = new Query<IMedia>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IMedia>(query);
            return this;
        }
    }
}