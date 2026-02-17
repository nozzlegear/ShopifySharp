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
    public sealed class MetafieldIdentifierQueryBuilder : FieldsQueryBuilderBase<MetafieldIdentifier, MetafieldIdentifierQueryBuilder>
    {
        protected override MetafieldIdentifierQueryBuilder Self => this;

        public MetafieldIdentifierQueryBuilder() : this("metafieldIdentifier")
        {
        }

        public MetafieldIdentifierQueryBuilder(string name) : base(new Query<MetafieldIdentifier>(name))
        {
        }

        public MetafieldIdentifierQueryBuilder(IQuery<MetafieldIdentifier> query) : base(query)
        {
        }

        public MetafieldIdentifierQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public MetafieldIdentifierQueryBuilder Namespace()
        {
            base.InnerQuery.AddField("namespace");
            return this;
        }

        public MetafieldIdentifierQueryBuilder OwnerId()
        {
            base.InnerQuery.AddField("ownerId");
            return this;
        }
    }
}