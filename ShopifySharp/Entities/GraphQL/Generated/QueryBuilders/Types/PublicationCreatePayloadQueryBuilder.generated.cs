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
    public sealed class PublicationCreatePayloadQueryBuilder : FieldsQueryBuilderBase<PublicationCreatePayload, PublicationCreatePayloadQueryBuilder>
    {
        protected override PublicationCreatePayloadQueryBuilder Self => this;

        public PublicationCreatePayloadQueryBuilder() : this("publicationCreatePayload")
        {
        }

        public PublicationCreatePayloadQueryBuilder(string name) : base(new Query<PublicationCreatePayload>(name))
        {
        }

        public PublicationCreatePayloadQueryBuilder(IQuery<PublicationCreatePayload> query) : base(query)
        {
        }

        public PublicationCreatePayloadQueryBuilder Publication(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationQueryBuilder> build)
        {
            var query = new Query<Publication>("publication");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Publication>(query);
            return this;
        }

        public PublicationCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationUserErrorQueryBuilder> build)
        {
            var query = new Query<PublicationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PublicationUserError>(query);
            return this;
        }
    }
}