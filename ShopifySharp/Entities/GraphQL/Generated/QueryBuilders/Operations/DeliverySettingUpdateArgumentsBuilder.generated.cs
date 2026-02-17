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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
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