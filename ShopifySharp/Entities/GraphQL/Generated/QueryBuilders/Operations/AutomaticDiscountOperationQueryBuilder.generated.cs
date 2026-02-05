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
    [Obsolete("Use `automaticDiscountNode` instead.")]
    public sealed class AutomaticDiscountOperationQueryBuilder : FieldsQueryBuilderBase<DiscountAutomatic, AutomaticDiscountOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountAutomatic>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public AutomaticDiscountArgumentsBuilder Arguments { get; }
        protected override AutomaticDiscountOperationQueryBuilder Self => this;

        public AutomaticDiscountOperationQueryBuilder() : this("automaticDiscount")
        {
        }

        public AutomaticDiscountOperationQueryBuilder(string name) : base(new Query<DiscountAutomatic>(name))
        {
            Arguments = new AutomaticDiscountArgumentsBuilder(base.InnerQuery);
        }

        public AutomaticDiscountOperationQueryBuilder(IQuery<DiscountAutomatic> query) : base(query)
        {
            Arguments = new AutomaticDiscountArgumentsBuilder(base.InnerQuery);
        }
    }
}