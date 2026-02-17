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
    public sealed class ProductFeedCreateUserErrorQueryBuilder : FieldsQueryBuilderBase<ProductFeedCreateUserError, ProductFeedCreateUserErrorQueryBuilder>
    {
        protected override ProductFeedCreateUserErrorQueryBuilder Self => this;

        public ProductFeedCreateUserErrorQueryBuilder() : this("productFeedCreateUserError")
        {
        }

        public ProductFeedCreateUserErrorQueryBuilder(string name) : base(new Query<ProductFeedCreateUserError>(name))
        {
        }

        public ProductFeedCreateUserErrorQueryBuilder(IQuery<ProductFeedCreateUserError> query) : base(query)
        {
        }

        public ProductFeedCreateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ProductFeedCreateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ProductFeedCreateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}