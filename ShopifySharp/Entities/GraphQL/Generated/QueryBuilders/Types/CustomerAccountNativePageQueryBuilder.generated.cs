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
    public sealed class CustomerAccountNativePageQueryBuilder : FieldsQueryBuilderBase<CustomerAccountNativePage, CustomerAccountNativePageQueryBuilder>
    {
        protected override CustomerAccountNativePageQueryBuilder Self => this;

        public CustomerAccountNativePageQueryBuilder() : this("customerAccountNativePage")
        {
        }

        public CustomerAccountNativePageQueryBuilder(string name) : base(new Query<CustomerAccountNativePage>(name))
        {
        }

        public CustomerAccountNativePageQueryBuilder(IQuery<CustomerAccountNativePage> query) : base(query)
        {
        }

        public CustomerAccountNativePageQueryBuilder DefaultCursor()
        {
            base.InnerQuery.AddField("defaultCursor");
            return this;
        }

        public CustomerAccountNativePageQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public CustomerAccountNativePageQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CustomerAccountNativePageQueryBuilder PageType()
        {
            base.InnerQuery.AddField("pageType");
            return this;
        }

        public CustomerAccountNativePageQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}