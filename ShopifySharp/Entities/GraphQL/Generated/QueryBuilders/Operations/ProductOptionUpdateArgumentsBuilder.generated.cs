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
    public sealed class ProductOptionUpdateArgumentsBuilder : ArgumentsBuilderBase<ProductOptionUpdatePayload, ProductOptionUpdateArgumentsBuilder>
    {
        protected override ProductOptionUpdateArgumentsBuilder Self => this;

        public ProductOptionUpdateArgumentsBuilder(IQuery<ProductOptionUpdatePayload> query) : base(query)
        {
        }

        public ProductOptionUpdateArgumentsBuilder Option(OptionUpdateInput? option)
        {
            base.InnerQuery.AddArgument("option", option);
            return this;
        }

        public ProductOptionUpdateArgumentsBuilder OptionValuesToAdd(ICollection<OptionValueCreateInput>? optionValuesToAdd)
        {
            base.InnerQuery.AddArgument("optionValuesToAdd", optionValuesToAdd);
            return this;
        }

        public ProductOptionUpdateArgumentsBuilder OptionValuesToDelete(ICollection<string>? optionValuesToDelete)
        {
            base.InnerQuery.AddArgument("optionValuesToDelete", optionValuesToDelete);
            return this;
        }

        public ProductOptionUpdateArgumentsBuilder OptionValuesToUpdate(ICollection<OptionValueUpdateInput>? optionValuesToUpdate)
        {
            base.InnerQuery.AddArgument("optionValuesToUpdate", optionValuesToUpdate);
            return this;
        }

        public ProductOptionUpdateArgumentsBuilder ProductId(string? productId)
        {
            base.InnerQuery.AddArgument("productId", productId);
            return this;
        }

        public ProductOptionUpdateArgumentsBuilder VariantStrategy(ProductOptionUpdateVariantStrategy? variantStrategy)
        {
            base.InnerQuery.AddArgument("variantStrategy", variantStrategy);
            return this;
        }
    }
}