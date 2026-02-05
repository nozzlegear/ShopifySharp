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
    public sealed class MediaWarningQueryBuilder : FieldsQueryBuilderBase<MediaWarning, MediaWarningQueryBuilder>
    {
        protected override MediaWarningQueryBuilder Self => this;

        public MediaWarningQueryBuilder() : this("mediaWarning")
        {
        }

        public MediaWarningQueryBuilder(string name) : base(new Query<MediaWarning>(name))
        {
        }

        public MediaWarningQueryBuilder(IQuery<MediaWarning> query) : base(query)
        {
        }

        public MediaWarningQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public MediaWarningQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}