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
    public sealed class MobilePlatformApplicationEdgeQueryBuilder : FieldsQueryBuilderBase<MobilePlatformApplicationEdge, MobilePlatformApplicationEdgeQueryBuilder>
    {
        protected override MobilePlatformApplicationEdgeQueryBuilder Self => this;

        public MobilePlatformApplicationEdgeQueryBuilder() : this("mobilePlatformApplicationEdge")
        {
        }

        public MobilePlatformApplicationEdgeQueryBuilder(string name) : base(new Query<MobilePlatformApplicationEdge>(name))
        {
        }

        public MobilePlatformApplicationEdgeQueryBuilder(IQuery<MobilePlatformApplicationEdge> query) : base(query)
        {
        }

        public MobilePlatformApplicationEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public MobilePlatformApplicationEdgeQueryBuilder Node(Action<MobilePlatformApplicationUnionCasesBuilder> build)
        {
            var query = new Query<MobilePlatformApplication>("node");
            var unionBuilder = new MobilePlatformApplicationUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}