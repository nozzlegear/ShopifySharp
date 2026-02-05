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
    public sealed class ProductOptionsCreateUserErrorQueryBuilder : FieldsQueryBuilderBase<ProductOptionsCreateUserError, ProductOptionsCreateUserErrorQueryBuilder>
    {
        protected override ProductOptionsCreateUserErrorQueryBuilder Self => this;

        public ProductOptionsCreateUserErrorQueryBuilder() : this("productOptionsCreateUserError")
        {
        }

        public ProductOptionsCreateUserErrorQueryBuilder(string name) : base(new Query<ProductOptionsCreateUserError>(name))
        {
        }

        public ProductOptionsCreateUserErrorQueryBuilder(IQuery<ProductOptionsCreateUserError> query) : base(query)
        {
        }

        public ProductOptionsCreateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ProductOptionsCreateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ProductOptionsCreateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}