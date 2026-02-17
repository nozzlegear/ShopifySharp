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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class PublicationDeleteOperationQueryBuilder : FieldsQueryBuilderBase<PublicationDeletePayload, PublicationDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<PublicationDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PublicationDeleteArgumentsBuilder Arguments { get; }
        protected override PublicationDeleteOperationQueryBuilder Self => this;

        public PublicationDeleteOperationQueryBuilder() : this("publicationDelete")
        {
        }

        public PublicationDeleteOperationQueryBuilder(string name) : base(new Query<PublicationDeletePayload>(name))
        {
            Arguments = new PublicationDeleteArgumentsBuilder(base.InnerQuery);
        }

        public PublicationDeleteOperationQueryBuilder(IQuery<PublicationDeletePayload> query) : base(query)
        {
            Arguments = new PublicationDeleteArgumentsBuilder(base.InnerQuery);
        }

        public PublicationDeleteOperationQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public PublicationDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PublicationUserErrorQueryBuilder> build)
        {
            var query = new Query<PublicationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PublicationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PublicationUserError>(query);
            return this;
        }
    }
}