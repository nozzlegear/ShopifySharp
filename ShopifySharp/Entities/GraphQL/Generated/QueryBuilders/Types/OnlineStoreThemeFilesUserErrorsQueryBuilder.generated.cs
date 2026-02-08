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
    public sealed class OnlineStoreThemeFilesUserErrorsQueryBuilder : FieldsQueryBuilderBase<OnlineStoreThemeFilesUserErrors, OnlineStoreThemeFilesUserErrorsQueryBuilder>
    {
        protected override OnlineStoreThemeFilesUserErrorsQueryBuilder Self => this;

        public OnlineStoreThemeFilesUserErrorsQueryBuilder() : this("onlineStoreThemeFilesUserErrors")
        {
        }

        public OnlineStoreThemeFilesUserErrorsQueryBuilder(string name) : base(new Query<OnlineStoreThemeFilesUserErrors>(name))
        {
        }

        public OnlineStoreThemeFilesUserErrorsQueryBuilder(IQuery<OnlineStoreThemeFilesUserErrors> query) : base(query)
        {
        }

        public OnlineStoreThemeFilesUserErrorsQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public OnlineStoreThemeFilesUserErrorsQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public OnlineStoreThemeFilesUserErrorsQueryBuilder Filename()
        {
            base.InnerQuery.AddField("filename");
            return this;
        }

        public OnlineStoreThemeFilesUserErrorsQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}