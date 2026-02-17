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
    public sealed class StringEdgeQueryBuilder : FieldsQueryBuilderBase<StringEdge, StringEdgeQueryBuilder>
    {
        protected override StringEdgeQueryBuilder Self => this;

        public StringEdgeQueryBuilder() : this("stringEdge")
        {
        }

        public StringEdgeQueryBuilder(string name) : base(new Query<StringEdge>(name))
        {
        }

        public StringEdgeQueryBuilder(IQuery<StringEdge> query) : base(query)
        {
        }

        public StringEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public StringEdgeQueryBuilder Node()
        {
            base.InnerQuery.AddField("node");
            return this;
        }
    }
}