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
    public sealed class PublicationUserErrorQueryBuilder : FieldsQueryBuilderBase<PublicationUserError, PublicationUserErrorQueryBuilder>
    {
        protected override PublicationUserErrorQueryBuilder Self => this;

        public PublicationUserErrorQueryBuilder() : this("publicationUserError")
        {
        }

        public PublicationUserErrorQueryBuilder(string name) : base(new Query<PublicationUserError>(name))
        {
        }

        public PublicationUserErrorQueryBuilder(IQuery<PublicationUserError> query) : base(query)
        {
        }

        public PublicationUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public PublicationUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public PublicationUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}