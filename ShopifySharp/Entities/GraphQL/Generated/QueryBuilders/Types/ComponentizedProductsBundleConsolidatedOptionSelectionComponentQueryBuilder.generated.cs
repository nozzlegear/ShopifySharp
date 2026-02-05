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
    public sealed class ComponentizedProductsBundleConsolidatedOptionSelectionComponentQueryBuilder : FieldsQueryBuilderBase<ComponentizedProductsBundleConsolidatedOptionSelectionComponent, ComponentizedProductsBundleConsolidatedOptionSelectionComponentQueryBuilder>
    {
        protected override ComponentizedProductsBundleConsolidatedOptionSelectionComponentQueryBuilder Self => this;

        public ComponentizedProductsBundleConsolidatedOptionSelectionComponentQueryBuilder() : this("componentizedProductsBundleConsolidatedOptionSelectionComponent")
        {
        }

        public ComponentizedProductsBundleConsolidatedOptionSelectionComponentQueryBuilder(string name) : base(new Query<ComponentizedProductsBundleConsolidatedOptionSelectionComponent>(name))
        {
        }

        public ComponentizedProductsBundleConsolidatedOptionSelectionComponentQueryBuilder(IQuery<ComponentizedProductsBundleConsolidatedOptionSelectionComponent> query) : base(query)
        {
        }

        public ComponentizedProductsBundleConsolidatedOptionSelectionComponentQueryBuilder OptionId()
        {
            base.InnerQuery.AddField("optionId");
            return this;
        }

        public ComponentizedProductsBundleConsolidatedOptionSelectionComponentQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}