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
    public sealed class MetaobjectAccessQueryBuilder : FieldsQueryBuilderBase<MetaobjectAccess, MetaobjectAccessQueryBuilder>
    {
        protected override MetaobjectAccessQueryBuilder Self => this;

        public MetaobjectAccessQueryBuilder() : this("metaobjectAccess")
        {
        }

        public MetaobjectAccessQueryBuilder(string name) : base(new Query<MetaobjectAccess>(name))
        {
        }

        public MetaobjectAccessQueryBuilder(IQuery<MetaobjectAccess> query) : base(query)
        {
        }

        public MetaobjectAccessQueryBuilder Admin()
        {
            base.InnerQuery.AddField("admin");
            return this;
        }

        public MetaobjectAccessQueryBuilder CustomerAccount()
        {
            base.InnerQuery.AddField("customerAccount");
            return this;
        }

        public MetaobjectAccessQueryBuilder Storefront()
        {
            base.InnerQuery.AddField("storefront");
            return this;
        }
    }
}