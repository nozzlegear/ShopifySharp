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
    public sealed class MetafieldDefinitionIdentifierQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinitionIdentifier, MetafieldDefinitionIdentifierQueryBuilder>
    {
        protected override MetafieldDefinitionIdentifierQueryBuilder Self => this;

        public MetafieldDefinitionIdentifierQueryBuilder() : this("metafieldDefinitionIdentifier")
        {
        }

        public MetafieldDefinitionIdentifierQueryBuilder(string name) : base(new Query<MetafieldDefinitionIdentifier>(name))
        {
        }

        public MetafieldDefinitionIdentifierQueryBuilder(IQuery<MetafieldDefinitionIdentifier> query) : base(query)
        {
        }

        public MetafieldDefinitionIdentifierQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public MetafieldDefinitionIdentifierQueryBuilder Namespace()
        {
            base.InnerQuery.AddField("namespace");
            return this;
        }

        public MetafieldDefinitionIdentifierQueryBuilder OwnerType()
        {
            base.InnerQuery.AddField("ownerType");
            return this;
        }
    }
}