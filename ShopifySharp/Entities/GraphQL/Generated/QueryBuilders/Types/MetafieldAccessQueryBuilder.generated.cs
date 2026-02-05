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
    public sealed class MetafieldAccessQueryBuilder : FieldsQueryBuilderBase<MetafieldAccess, MetafieldAccessQueryBuilder>
    {
        protected override MetafieldAccessQueryBuilder Self => this;

        public MetafieldAccessQueryBuilder() : this("metafieldAccess")
        {
        }

        public MetafieldAccessQueryBuilder(string name) : base(new Query<MetafieldAccess>(name))
        {
        }

        public MetafieldAccessQueryBuilder(IQuery<MetafieldAccess> query) : base(query)
        {
        }

        public MetafieldAccessQueryBuilder Admin()
        {
            base.InnerQuery.AddField("admin");
            return this;
        }

        public MetafieldAccessQueryBuilder CustomerAccount()
        {
            base.InnerQuery.AddField("customerAccount");
            return this;
        }

        public MetafieldAccessQueryBuilder Storefront()
        {
            base.InnerQuery.AddField("storefront");
            return this;
        }
    }
}