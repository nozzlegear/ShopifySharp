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
    public sealed class ProductFullSyncUserErrorQueryBuilder : FieldsQueryBuilderBase<ProductFullSyncUserError, ProductFullSyncUserErrorQueryBuilder>
    {
        protected override ProductFullSyncUserErrorQueryBuilder Self => this;

        public ProductFullSyncUserErrorQueryBuilder() : this("productFullSyncUserError")
        {
        }

        public ProductFullSyncUserErrorQueryBuilder(string name) : base(new Query<ProductFullSyncUserError>(name))
        {
        }

        public ProductFullSyncUserErrorQueryBuilder(IQuery<ProductFullSyncUserError> query) : base(query)
        {
        }

        public ProductFullSyncUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ProductFullSyncUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ProductFullSyncUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}