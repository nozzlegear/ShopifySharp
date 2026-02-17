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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class ValidationUserErrorQueryBuilder : FieldsQueryBuilderBase<ValidationUserError, ValidationUserErrorQueryBuilder>
    {
        protected override ValidationUserErrorQueryBuilder Self => this;

        public ValidationUserErrorQueryBuilder() : this("validationUserError")
        {
        }

        public ValidationUserErrorQueryBuilder(string name) : base(new Query<ValidationUserError>(name))
        {
        }

        public ValidationUserErrorQueryBuilder(IQuery<ValidationUserError> query) : base(query)
        {
        }

        public ValidationUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ValidationUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ValidationUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}