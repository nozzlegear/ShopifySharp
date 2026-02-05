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
    public sealed class MetafieldDefinitionConstraintsQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinitionConstraints, MetafieldDefinitionConstraintsQueryBuilder>
    {
        protected override MetafieldDefinitionConstraintsQueryBuilder Self => this;

        public MetafieldDefinitionConstraintsQueryBuilder() : this("metafieldDefinitionConstraints")
        {
        }

        public MetafieldDefinitionConstraintsQueryBuilder(string name) : base(new Query<MetafieldDefinitionConstraints>(name))
        {
        }

        public MetafieldDefinitionConstraintsQueryBuilder(IQuery<MetafieldDefinitionConstraints> query) : base(query)
        {
        }

        public MetafieldDefinitionConstraintsQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public MetafieldDefinitionConstraintsQueryBuilder Values(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConstraintValueConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConstraintValueConnection>("values");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConstraintValueConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConstraintValueConnection>(query);
            return this;
        }
    }
}