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
    public sealed class ProductBundleComponentQuantityOptionValueQueryBuilder : FieldsQueryBuilderBase<ProductBundleComponentQuantityOptionValue, ProductBundleComponentQuantityOptionValueQueryBuilder>
    {
        protected override ProductBundleComponentQuantityOptionValueQueryBuilder Self => this;

        public ProductBundleComponentQuantityOptionValueQueryBuilder() : this("productBundleComponentQuantityOptionValue")
        {
        }

        public ProductBundleComponentQuantityOptionValueQueryBuilder(string name) : base(new Query<ProductBundleComponentQuantityOptionValue>(name))
        {
        }

        public ProductBundleComponentQuantityOptionValueQueryBuilder(IQuery<ProductBundleComponentQuantityOptionValue> query) : base(query)
        {
        }

        public ProductBundleComponentQuantityOptionValueQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public ProductBundleComponentQuantityOptionValueQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }
    }
}