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
    public sealed class ValidationCreatePayloadQueryBuilder : FieldsQueryBuilderBase<ValidationCreatePayload, ValidationCreatePayloadQueryBuilder>
    {
        protected override ValidationCreatePayloadQueryBuilder Self => this;

        public ValidationCreatePayloadQueryBuilder() : this("validationCreatePayload")
        {
        }

        public ValidationCreatePayloadQueryBuilder(string name) : base(new Query<ValidationCreatePayload>(name))
        {
        }

        public ValidationCreatePayloadQueryBuilder(IQuery<ValidationCreatePayload> query) : base(query)
        {
        }

        public ValidationCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ValidationUserErrorQueryBuilder> build)
        {
            var query = new Query<ValidationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ValidationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ValidationUserError>(query);
            return this;
        }

        public ValidationCreatePayloadQueryBuilder Validation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ValidationQueryBuilder> build)
        {
            var query = new Query<Validation>("validation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ValidationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Validation>(query);
            return this;
        }
    }
}