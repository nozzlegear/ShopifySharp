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
    public sealed class CustomerAccountAppExtensionPageQueryBuilder : FieldsQueryBuilderBase<CustomerAccountAppExtensionPage, CustomerAccountAppExtensionPageQueryBuilder>
    {
        protected override CustomerAccountAppExtensionPageQueryBuilder Self => this;

        public CustomerAccountAppExtensionPageQueryBuilder() : this("customerAccountAppExtensionPage")
        {
        }

        public CustomerAccountAppExtensionPageQueryBuilder(string name) : base(new Query<CustomerAccountAppExtensionPage>(name))
        {
        }

        public CustomerAccountAppExtensionPageQueryBuilder(IQuery<CustomerAccountAppExtensionPage> query) : base(query)
        {
        }

        public CustomerAccountAppExtensionPageQueryBuilder AppExtensionUuid()
        {
            base.InnerQuery.AddField("appExtensionUuid");
            return this;
        }

        public CustomerAccountAppExtensionPageQueryBuilder DefaultCursor()
        {
            base.InnerQuery.AddField("defaultCursor");
            return this;
        }

        public CustomerAccountAppExtensionPageQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public CustomerAccountAppExtensionPageQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CustomerAccountAppExtensionPageQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}