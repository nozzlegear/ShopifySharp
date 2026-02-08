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
    public sealed class ValidationDeleteOperationQueryBuilder : FieldsQueryBuilderBase<ValidationDeletePayload, ValidationDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<ValidationDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ValidationDeleteArgumentsBuilder Arguments { get; }
        protected override ValidationDeleteOperationQueryBuilder Self => this;

        public ValidationDeleteOperationQueryBuilder() : this("validationDelete")
        {
        }

        public ValidationDeleteOperationQueryBuilder(string name) : base(new Query<ValidationDeletePayload>(name))
        {
            Arguments = new ValidationDeleteArgumentsBuilder(base.InnerQuery);
        }

        public ValidationDeleteOperationQueryBuilder(IQuery<ValidationDeletePayload> query) : base(query)
        {
            Arguments = new ValidationDeleteArgumentsBuilder(base.InnerQuery);
        }

        public ValidationDeleteOperationQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public ValidationDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ValidationUserErrorQueryBuilder> build)
        {
            var query = new Query<ValidationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ValidationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ValidationUserError>(query);
            return this;
        }
    }
}