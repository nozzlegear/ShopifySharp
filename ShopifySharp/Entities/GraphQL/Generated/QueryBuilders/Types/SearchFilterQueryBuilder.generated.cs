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
    public sealed class SearchFilterQueryBuilder : FieldsQueryBuilderBase<SearchFilter, SearchFilterQueryBuilder>
    {
        protected override SearchFilterQueryBuilder Self => this;

        public SearchFilterQueryBuilder() : this("searchFilter")
        {
        }

        public SearchFilterQueryBuilder(string name) : base(new Query<SearchFilter>(name))
        {
        }

        public SearchFilterQueryBuilder(IQuery<SearchFilter> query) : base(query)
        {
        }

        public SearchFilterQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public SearchFilterQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}