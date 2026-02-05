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
    public sealed class ComponentizedProductsBundleConsolidatedOptionSelectionQueryBuilder : FieldsQueryBuilderBase<ComponentizedProductsBundleConsolidatedOptionSelection, ComponentizedProductsBundleConsolidatedOptionSelectionQueryBuilder>
    {
        protected override ComponentizedProductsBundleConsolidatedOptionSelectionQueryBuilder Self => this;

        public ComponentizedProductsBundleConsolidatedOptionSelectionQueryBuilder() : this("componentizedProductsBundleConsolidatedOptionSelection")
        {
        }

        public ComponentizedProductsBundleConsolidatedOptionSelectionQueryBuilder(string name) : base(new Query<ComponentizedProductsBundleConsolidatedOptionSelection>(name))
        {
        }

        public ComponentizedProductsBundleConsolidatedOptionSelectionQueryBuilder(IQuery<ComponentizedProductsBundleConsolidatedOptionSelection> query) : base(query)
        {
        }

        public ComponentizedProductsBundleConsolidatedOptionSelectionQueryBuilder Components(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ComponentizedProductsBundleConsolidatedOptionSelectionComponentQueryBuilder> build)
        {
            var query = new Query<ComponentizedProductsBundleConsolidatedOptionSelectionComponent>("components");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ComponentizedProductsBundleConsolidatedOptionSelectionComponentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ComponentizedProductsBundleConsolidatedOptionSelectionComponent>(query);
            return this;
        }

        public ComponentizedProductsBundleConsolidatedOptionSelectionQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}