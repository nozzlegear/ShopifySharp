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
    public sealed class ProductOptionsReorderUserErrorQueryBuilder : FieldsQueryBuilderBase<ProductOptionsReorderUserError, ProductOptionsReorderUserErrorQueryBuilder>
    {
        protected override ProductOptionsReorderUserErrorQueryBuilder Self => this;

        public ProductOptionsReorderUserErrorQueryBuilder() : this("productOptionsReorderUserError")
        {
        }

        public ProductOptionsReorderUserErrorQueryBuilder(string name) : base(new Query<ProductOptionsReorderUserError>(name))
        {
        }

        public ProductOptionsReorderUserErrorQueryBuilder(IQuery<ProductOptionsReorderUserError> query) : base(query)
        {
        }

        public ProductOptionsReorderUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ProductOptionsReorderUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ProductOptionsReorderUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}