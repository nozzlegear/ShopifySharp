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
    public sealed class NavigableQueryBuilder : FieldsQueryBuilderBase<INavigable, NavigableQueryBuilder>
    {
        protected override NavigableQueryBuilder Self => this;

        public NavigableQueryBuilder() : this("navigable")
        {
        }

        public NavigableQueryBuilder(string name) : base(new Query<INavigable>(name))
        {
        }

        public NavigableQueryBuilder(IQuery<INavigable> query) : base(query)
        {
        }

        public NavigableQueryBuilder DefaultCursor()
        {
            base.InnerQuery.AddField("defaultCursor");
            return this;
        }
    }
}