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
    public sealed class PublicationDeletePayloadQueryBuilder : FieldsQueryBuilderBase<PublicationDeletePayload, PublicationDeletePayloadQueryBuilder>
    {
        protected override PublicationDeletePayloadQueryBuilder Self => this;

        public PublicationDeletePayloadQueryBuilder() : this("publicationDeletePayload")
        {
        }

        public PublicationDeletePayloadQueryBuilder(string name) : base(new Query<PublicationDeletePayload>(name))
        {
        }

        public PublicationDeletePayloadQueryBuilder(IQuery<PublicationDeletePayload> query) : base(query)
        {
        }

        public PublicationDeletePayloadQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public PublicationDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationUserErrorQueryBuilder> build)
        {
            var query = new Query<PublicationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PublicationUserError>(query);
            return this;
        }
    }
}