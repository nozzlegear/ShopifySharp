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
    public sealed class MediaUserErrorQueryBuilder : FieldsQueryBuilderBase<MediaUserError, MediaUserErrorQueryBuilder>
    {
        protected override MediaUserErrorQueryBuilder Self => this;

        public MediaUserErrorQueryBuilder() : this("mediaUserError")
        {
        }

        public MediaUserErrorQueryBuilder(string name) : base(new Query<MediaUserError>(name))
        {
        }

        public MediaUserErrorQueryBuilder(IQuery<MediaUserError> query) : base(query)
        {
        }

        public MediaUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public MediaUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public MediaUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}