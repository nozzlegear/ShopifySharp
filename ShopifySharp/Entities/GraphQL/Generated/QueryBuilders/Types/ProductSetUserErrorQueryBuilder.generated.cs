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
    public sealed class ProductSetUserErrorQueryBuilder : FieldsQueryBuilderBase<ProductSetUserError, ProductSetUserErrorQueryBuilder>
    {
        protected override ProductSetUserErrorQueryBuilder Self => this;

        public ProductSetUserErrorQueryBuilder() : this("productSetUserError")
        {
        }

        public ProductSetUserErrorQueryBuilder(string name) : base(new Query<ProductSetUserError>(name))
        {
        }

        public ProductSetUserErrorQueryBuilder(IQuery<ProductSetUserError> query) : base(query)
        {
        }

        public ProductSetUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ProductSetUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ProductSetUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}