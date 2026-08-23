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

        public MediaEdgeQueryBuilder Node(Action<MediaInterfaceCasesBuilder> build)
        {
            var query = new Query<IMedia>("node");
            var unionBuilder = new MediaInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}