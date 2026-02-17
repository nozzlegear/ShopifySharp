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
    public sealed class NavigationItemQueryBuilder : FieldsQueryBuilderBase<NavigationItem, NavigationItemQueryBuilder>
    {
        protected override NavigationItemQueryBuilder Self => this;

        public NavigationItemQueryBuilder() : this("navigationItem")
        {
        }

        public NavigationItemQueryBuilder(string name) : base(new Query<NavigationItem>(name))
        {
        }

        public NavigationItemQueryBuilder(IQuery<NavigationItem> query) : base(query)
        {
        }

        public NavigationItemQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public NavigationItemQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public NavigationItemQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}