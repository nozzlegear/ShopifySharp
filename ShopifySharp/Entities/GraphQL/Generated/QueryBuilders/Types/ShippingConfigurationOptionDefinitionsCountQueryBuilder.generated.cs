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
    public sealed class ShippingConfigurationOptionDefinitionsCountQueryBuilder : FieldsQueryBuilderBase<Count, ShippingConfigurationOptionDefinitionsCountQueryBuilder>, IHasArguments<ShippingConfigurationOptionDefinitionsCountArgumentsBuilder>
    {
        public ShippingConfigurationOptionDefinitionsCountArgumentsBuilder Arguments { get; }
        protected override ShippingConfigurationOptionDefinitionsCountQueryBuilder Self => this;

        public ShippingConfigurationOptionDefinitionsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new ShippingConfigurationOptionDefinitionsCountArgumentsBuilder(base.InnerQuery);
        }

        public ShippingConfigurationOptionDefinitionsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new ShippingConfigurationOptionDefinitionsCountArgumentsBuilder(base.InnerQuery);
        }

        public ShippingConfigurationOptionDefinitionsCountQueryBuilder SetArguments(Action<ShippingConfigurationOptionDefinitionsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ShippingConfigurationOptionDefinitionsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public ShippingConfigurationOptionDefinitionsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}