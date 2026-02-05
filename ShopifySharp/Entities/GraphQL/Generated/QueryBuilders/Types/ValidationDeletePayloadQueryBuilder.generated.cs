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
    public sealed class ValidationDeletePayloadQueryBuilder : FieldsQueryBuilderBase<ValidationDeletePayload, ValidationDeletePayloadQueryBuilder>
    {
        protected override ValidationDeletePayloadQueryBuilder Self => this;

        public ValidationDeletePayloadQueryBuilder() : this("validationDeletePayload")
        {
        }

        public ValidationDeletePayloadQueryBuilder(string name) : base(new Query<ValidationDeletePayload>(name))
        {
        }

        public ValidationDeletePayloadQueryBuilder(IQuery<ValidationDeletePayload> query) : base(query)
        {
        }

        public ValidationDeletePayloadQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public ValidationDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ValidationUserErrorQueryBuilder> build)
        {
            var query = new Query<ValidationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ValidationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ValidationUserError>(query);
            return this;
        }
    }
}