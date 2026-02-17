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
    public sealed class LinkedMetafieldQueryBuilder : FieldsQueryBuilderBase<LinkedMetafield, LinkedMetafieldQueryBuilder>
    {
        protected override LinkedMetafieldQueryBuilder Self => this;

        public LinkedMetafieldQueryBuilder() : this("linkedMetafield")
        {
        }

        public LinkedMetafieldQueryBuilder(string name) : base(new Query<LinkedMetafield>(name))
        {
        }

        public LinkedMetafieldQueryBuilder(IQuery<LinkedMetafield> query) : base(query)
        {
        }

        public LinkedMetafieldQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public LinkedMetafieldQueryBuilder Namespace()
        {
            base.InnerQuery.AddField("namespace");
            return this;
        }
    }
}