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
    public sealed class ValidationUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<ValidationUpdatePayload, ValidationUpdatePayloadQueryBuilder>
    {
        protected override ValidationUpdatePayloadQueryBuilder Self => this;

        public ValidationUpdatePayloadQueryBuilder() : this("validationUpdatePayload")
        {
        }

        public ValidationUpdatePayloadQueryBuilder(string name) : base(new Query<ValidationUpdatePayload>(name))
        {
        }

        public ValidationUpdatePayloadQueryBuilder(IQuery<ValidationUpdatePayload> query) : base(query)
        {
        }

        public ValidationUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ValidationUserErrorQueryBuilder> build)
        {
            var query = new Query<ValidationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ValidationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ValidationUserError>(query);
            return this;
        }

        public ValidationUpdatePayloadQueryBuilder Validation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ValidationQueryBuilder> build)
        {
            var query = new Query<Validation>("validation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ValidationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Validation>(query);
            return this;
        }
    }
}