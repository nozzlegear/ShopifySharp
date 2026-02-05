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
    public sealed class CombinedListingUpdateArgumentsBuilder : ArgumentsBuilderBase<CombinedListingUpdatePayload, CombinedListingUpdateArgumentsBuilder>
    {
        protected override CombinedListingUpdateArgumentsBuilder Self => this;

        public CombinedListingUpdateArgumentsBuilder(IQuery<CombinedListingUpdatePayload> query) : base(query)
        {
        }

        public CombinedListingUpdateArgumentsBuilder OptionsAndValues(ICollection<OptionAndValueInput>? optionsAndValues)
        {
            base.InnerQuery.AddArgument("optionsAndValues", optionsAndValues);
            return this;
        }

        public CombinedListingUpdateArgumentsBuilder ParentProductId(string? parentProductId)
        {
            base.InnerQuery.AddArgument("parentProductId", parentProductId);
            return this;
        }

        public CombinedListingUpdateArgumentsBuilder ProductsAdded(ICollection<ChildProductRelationInput>? productsAdded)
        {
            base.InnerQuery.AddArgument("productsAdded", productsAdded);
            return this;
        }

        public CombinedListingUpdateArgumentsBuilder ProductsEdited(ICollection<ChildProductRelationInput>? productsEdited)
        {
            base.InnerQuery.AddArgument("productsEdited", productsEdited);
            return this;
        }

        public CombinedListingUpdateArgumentsBuilder ProductsRemovedIds(ICollection<string>? productsRemovedIds)
        {
            base.InnerQuery.AddArgument("productsRemovedIds", productsRemovedIds);
            return this;
        }

        public CombinedListingUpdateArgumentsBuilder Title(string? title)
        {
            base.InnerQuery.AddArgument("title", title);
            return this;
        }
    }
}