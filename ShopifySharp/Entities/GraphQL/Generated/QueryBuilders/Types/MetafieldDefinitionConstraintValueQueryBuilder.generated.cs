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
    public sealed class MetafieldDefinitionConstraintValueQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinitionConstraintValue, MetafieldDefinitionConstraintValueQueryBuilder>
    {
        protected override MetafieldDefinitionConstraintValueQueryBuilder Self => this;

        public MetafieldDefinitionConstraintValueQueryBuilder() : this("metafieldDefinitionConstraintValue")
        {
        }

        public MetafieldDefinitionConstraintValueQueryBuilder(string name) : base(new Query<MetafieldDefinitionConstraintValue>(name))
        {
        }

        public MetafieldDefinitionConstraintValueQueryBuilder(IQuery<MetafieldDefinitionConstraintValue> query) : base(query)
        {
        }

        public MetafieldDefinitionConstraintValueQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}