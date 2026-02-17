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
    public sealed class CatalogUserErrorQueryBuilder : FieldsQueryBuilderBase<CatalogUserError, CatalogUserErrorQueryBuilder>
    {
        protected override CatalogUserErrorQueryBuilder Self => this;

        public CatalogUserErrorQueryBuilder() : this("catalogUserError")
        {
        }

        public CatalogUserErrorQueryBuilder(string name) : base(new Query<CatalogUserError>(name))
        {
        }

        public CatalogUserErrorQueryBuilder(IQuery<CatalogUserError> query) : base(query)
        {
        }

        public CatalogUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CatalogUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CatalogUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}