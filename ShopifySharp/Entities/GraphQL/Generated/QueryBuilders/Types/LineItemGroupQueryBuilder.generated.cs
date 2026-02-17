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
    public sealed class LineItemGroupQueryBuilder : FieldsQueryBuilderBase<LineItemGroup, LineItemGroupQueryBuilder>
    {
        protected override LineItemGroupQueryBuilder Self => this;

        public LineItemGroupQueryBuilder() : this("lineItemGroup")
        {
        }

        public LineItemGroupQueryBuilder(string name) : base(new Query<LineItemGroup>(name))
        {
        }

        public LineItemGroupQueryBuilder(IQuery<LineItemGroup> query) : base(query)
        {
        }

        public LineItemGroupQueryBuilder CustomAttributes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AttributeQueryBuilder> build)
        {
            var query = new Query<ShopifySharp.GraphQL.Attribute>("customAttributes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifySharp.GraphQL.Attribute>(query);
            return this;
        }

        public LineItemGroupQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public LineItemGroupQueryBuilder ProductId()
        {
            base.InnerQuery.AddField("productId");
            return this;
        }

        public LineItemGroupQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public LineItemGroupQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public LineItemGroupQueryBuilder VariantId()
        {
            base.InnerQuery.AddField("variantId");
            return this;
        }

        public LineItemGroupQueryBuilder VariantSku()
        {
            base.InnerQuery.AddField("variantSku");
            return this;
        }
    }
}