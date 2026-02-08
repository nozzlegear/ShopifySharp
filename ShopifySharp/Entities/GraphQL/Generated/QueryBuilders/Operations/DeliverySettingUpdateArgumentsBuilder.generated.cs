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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class DeliverySettingUpdateArgumentsBuilder : ArgumentsBuilderBase<DeliverySettingUpdatePayload, DeliverySettingUpdateArgumentsBuilder>
    {
        protected override DeliverySettingUpdateArgumentsBuilder Self => this;

        public DeliverySettingUpdateArgumentsBuilder(IQuery<DeliverySettingUpdatePayload> query) : base(query)
        {
        }

        public DeliverySettingUpdateArgumentsBuilder Setting(DeliverySettingInput? setting)
        {
            base.InnerQuery.AddArgument("setting", setting);
            return this;
        }
    }
}