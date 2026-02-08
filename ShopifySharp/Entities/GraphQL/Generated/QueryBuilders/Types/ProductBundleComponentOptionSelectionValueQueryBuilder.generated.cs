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
    public sealed class ProductBundleComponentOptionSelectionValueQueryBuilder : FieldsQueryBuilderBase<ProductBundleComponentOptionSelectionValue, ProductBundleComponentOptionSelectionValueQueryBuilder>
    {
        protected override ProductBundleComponentOptionSelectionValueQueryBuilder Self => this;

        public ProductBundleComponentOptionSelectionValueQueryBuilder() : this("productBundleComponentOptionSelectionValue")
        {
        }

        public ProductBundleComponentOptionSelectionValueQueryBuilder(string name) : base(new Query<ProductBundleComponentOptionSelectionValue>(name))
        {
        }

        public ProductBundleComponentOptionSelectionValueQueryBuilder(IQuery<ProductBundleComponentOptionSelectionValue> query) : base(query)
        {
        }

        public ProductBundleComponentOptionSelectionValueQueryBuilder SelectionStatus()
        {
            base.InnerQuery.AddField("selectionStatus");
            return this;
        }

        public ProductBundleComponentOptionSelectionValueQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}