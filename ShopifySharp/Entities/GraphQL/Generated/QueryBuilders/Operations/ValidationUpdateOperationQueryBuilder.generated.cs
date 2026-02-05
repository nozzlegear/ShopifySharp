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
    public sealed class ValidationUpdateOperationQueryBuilder : FieldsQueryBuilderBase<ValidationUpdatePayload, ValidationUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<ValidationUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ValidationUpdateArgumentsBuilder Arguments { get; }
        protected override ValidationUpdateOperationQueryBuilder Self => this;

        public ValidationUpdateOperationQueryBuilder() : this("validationUpdate")
        {
        }

        public ValidationUpdateOperationQueryBuilder(string name) : base(new Query<ValidationUpdatePayload>(name))
        {
            Arguments = new ValidationUpdateArgumentsBuilder(base.InnerQuery);
        }

        public ValidationUpdateOperationQueryBuilder(IQuery<ValidationUpdatePayload> query) : base(query)
        {
            Arguments = new ValidationUpdateArgumentsBuilder(base.InnerQuery);
        }

        public ValidationUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ValidationUserErrorQueryBuilder> build)
        {
            var query = new Query<ValidationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ValidationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ValidationUserError>(query);
            return this;
        }

        public ValidationUpdateOperationQueryBuilder Validation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ValidationQueryBuilder> build)
        {
            var query = new Query<Validation>("validation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ValidationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Validation>(query);
            return this;
        }
    }
}