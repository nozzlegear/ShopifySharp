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
    public sealed class ProductOptionsDeleteUserErrorQueryBuilder : FieldsQueryBuilderBase<ProductOptionsDeleteUserError, ProductOptionsDeleteUserErrorQueryBuilder>
    {
        protected override ProductOptionsDeleteUserErrorQueryBuilder Self => this;

        public ProductOptionsDeleteUserErrorQueryBuilder() : this("productOptionsDeleteUserError")
        {
        }

        public ProductOptionsDeleteUserErrorQueryBuilder(string name) : base(new Query<ProductOptionsDeleteUserError>(name))
        {
        }

        public ProductOptionsDeleteUserErrorQueryBuilder(IQuery<ProductOptionsDeleteUserError> query) : base(query)
        {
        }

        public ProductOptionsDeleteUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ProductOptionsDeleteUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ProductOptionsDeleteUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}