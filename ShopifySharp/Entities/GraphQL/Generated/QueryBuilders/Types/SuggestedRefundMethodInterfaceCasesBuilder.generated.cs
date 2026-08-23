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
    public sealed class SuggestedRefundMethodInterfaceCasesBuilder : InterfaceCasesBuilderBase<ISuggestedRefundMethod, SuggestedRefundMethodInterfaceCasesBuilder>
    {
        protected override SuggestedRefundMethodInterfaceCasesBuilder Self => this;

        public SuggestedRefundMethodInterfaceCasesBuilder(string fieldName = "suggestedRefundMethod") : this(new Query<ISuggestedRefundMethod>(fieldName))
        {
        }

        public SuggestedRefundMethodInterfaceCasesBuilder(IQuery<ISuggestedRefundMethod> query) : base(query)
        {
        }

        public SuggestedRefundMethodInterfaceCasesBuilder OnSuggestedStoreCreditRefund(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SuggestedStoreCreditRefundQueryBuilder> build)
        {
            var query = new Query<SuggestedStoreCreditRefund>("... on SuggestedStoreCreditRefund");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SuggestedStoreCreditRefundQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}