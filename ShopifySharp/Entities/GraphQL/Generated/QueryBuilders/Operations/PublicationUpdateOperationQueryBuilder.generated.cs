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
    public sealed class PublicationUpdateOperationQueryBuilder : FieldsQueryBuilderBase<PublicationUpdatePayload, PublicationUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<PublicationUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PublicationUpdateArgumentsBuilder Arguments { get; }
        protected override PublicationUpdateOperationQueryBuilder Self => this;

        public PublicationUpdateOperationQueryBuilder() : this("publicationUpdate")
        {
        }

        public PublicationUpdateOperationQueryBuilder(string name) : base(new Query<PublicationUpdatePayload>(name))
        {
            Arguments = new PublicationUpdateArgumentsBuilder(base.InnerQuery);
        }

        public PublicationUpdateOperationQueryBuilder(IQuery<PublicationUpdatePayload> query) : base(query)
        {
            Arguments = new PublicationUpdateArgumentsBuilder(base.InnerQuery);
        }

        public PublicationUpdateOperationQueryBuilder Publication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PublicationQueryBuilder> build)
        {
            var query = new Query<Publication>("publication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Publication>(query);
            return this;
        }

        public PublicationUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PublicationUserErrorQueryBuilder> build)
        {
            var query = new Query<PublicationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PublicationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PublicationUserError>(query);
            return this;
        }
    }
}