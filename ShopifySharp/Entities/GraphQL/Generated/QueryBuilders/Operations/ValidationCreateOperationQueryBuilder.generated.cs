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
    public sealed class ValidationCreateOperationQueryBuilder : FieldsQueryBuilderBase<ValidationCreatePayload, ValidationCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<ValidationCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ValidationCreateArgumentsBuilder Arguments { get; }
        protected override ValidationCreateOperationQueryBuilder Self => this;

        public ValidationCreateOperationQueryBuilder() : this("validationCreate")
        {
        }

        public ValidationCreateOperationQueryBuilder(string name) : base(new Query<ValidationCreatePayload>(name))
        {
            Arguments = new ValidationCreateArgumentsBuilder(base.InnerQuery);
        }

        public ValidationCreateOperationQueryBuilder(IQuery<ValidationCreatePayload> query) : base(query)
        {
            Arguments = new ValidationCreateArgumentsBuilder(base.InnerQuery);
        }

        public ValidationCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ValidationUserErrorQueryBuilder> build)
        {
            var query = new Query<ValidationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ValidationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ValidationUserError>(query);
            return this;
        }

        public ValidationCreateOperationQueryBuilder Validation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ValidationQueryBuilder> build)
        {
            var query = new Query<Validation>("validation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ValidationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Validation>(query);
            return this;
        }
    }
}