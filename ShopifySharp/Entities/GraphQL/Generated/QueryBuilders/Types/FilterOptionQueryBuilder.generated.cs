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
    public sealed class FilterOptionQueryBuilder : FieldsQueryBuilderBase<FilterOption, FilterOptionQueryBuilder>
    {
        protected override FilterOptionQueryBuilder Self => this;

        public FilterOptionQueryBuilder() : this("filterOption")
        {
        }

        public FilterOptionQueryBuilder(string name) : base(new Query<FilterOption>(name))
        {
        }

        public FilterOptionQueryBuilder(IQuery<FilterOption> query) : base(query)
        {
        }

        public FilterOptionQueryBuilder Label()
        {
            base.InnerQuery.AddField("label");
            return this;
        }

        public FilterOptionQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}