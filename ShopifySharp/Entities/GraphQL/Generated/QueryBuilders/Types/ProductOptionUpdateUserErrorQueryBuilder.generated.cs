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
    public sealed class ProductOptionUpdateUserErrorQueryBuilder : FieldsQueryBuilderBase<ProductOptionUpdateUserError, ProductOptionUpdateUserErrorQueryBuilder>
    {
        protected override ProductOptionUpdateUserErrorQueryBuilder Self => this;

        public ProductOptionUpdateUserErrorQueryBuilder() : this("productOptionUpdateUserError")
        {
        }

        public ProductOptionUpdateUserErrorQueryBuilder(string name) : base(new Query<ProductOptionUpdateUserError>(name))
        {
        }

        public ProductOptionUpdateUserErrorQueryBuilder(IQuery<ProductOptionUpdateUserError> query) : base(query)
        {
        }

        public ProductOptionUpdateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ProductOptionUpdateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ProductOptionUpdateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}