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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class PublicationCreateOperationQueryBuilder : FieldsQueryBuilderBase<PublicationCreatePayload, PublicationCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<PublicationCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PublicationCreateArgumentsBuilder Arguments { get; }
        protected override PublicationCreateOperationQueryBuilder Self => this;

        public PublicationCreateOperationQueryBuilder() : this("publicationCreate")
        {
        }

        public PublicationCreateOperationQueryBuilder(string name) : base(new Query<PublicationCreatePayload>(name))
        {
            Arguments = new PublicationCreateArgumentsBuilder(base.InnerQuery);
        }

        public PublicationCreateOperationQueryBuilder(IQuery<PublicationCreatePayload> query) : base(query)
        {
            Arguments = new PublicationCreateArgumentsBuilder(base.InnerQuery);
        }

        public PublicationCreateOperationQueryBuilder Publication(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationQueryBuilder> build)
        {
            var query = new Query<Publication>("publication");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Publication>(query);
            return this;
        }

        public PublicationCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationUserErrorQueryBuilder> build)
        {
            var query = new Query<PublicationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PublicationUserError>(query);
            return this;
        }
    }
}