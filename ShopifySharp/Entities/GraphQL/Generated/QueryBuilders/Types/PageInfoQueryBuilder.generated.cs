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
    public sealed class PageInfoQueryBuilder : FieldsQueryBuilderBase<PageInfo, PageInfoQueryBuilder>
    {
        protected override PageInfoQueryBuilder Self => this;

        public PageInfoQueryBuilder() : this("pageInfo")
        {
        }

        public PageInfoQueryBuilder(string name) : base(new Query<PageInfo>(name))
        {
        }

        public PageInfoQueryBuilder(IQuery<PageInfo> query) : base(query)
        {
        }

        public PageInfoQueryBuilder EndCursor()
        {
            base.InnerQuery.AddField("endCursor");
            return this;
        }

        public PageInfoQueryBuilder HasNextPage()
        {
            base.InnerQuery.AddField("hasNextPage");
            return this;
        }

        public PageInfoQueryBuilder HasPreviousPage()
        {
            base.InnerQuery.AddField("hasPreviousPage");
            return this;
        }

        public PageInfoQueryBuilder StartCursor()
        {
            base.InnerQuery.AddField("startCursor");
            return this;
        }
    }
}