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
    public sealed class ProductChangeStatusUserErrorQueryBuilder : FieldsQueryBuilderBase<ProductChangeStatusUserError, ProductChangeStatusUserErrorQueryBuilder>
    {
        protected override ProductChangeStatusUserErrorQueryBuilder Self => this;

        public ProductChangeStatusUserErrorQueryBuilder() : this("productChangeStatusUserError")
        {
        }

        public ProductChangeStatusUserErrorQueryBuilder(string name) : base(new Query<ProductChangeStatusUserError>(name))
        {
        }

        public ProductChangeStatusUserErrorQueryBuilder(IQuery<ProductChangeStatusUserError> query) : base(query)
        {
        }

        public ProductChangeStatusUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ProductChangeStatusUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ProductChangeStatusUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}