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
    public sealed class CashDrawerTotalAdjustmentsQueryBuilder : FieldsQueryBuilderBase<MoneyV2, CashDrawerTotalAdjustmentsQueryBuilder>, IHasArguments<CashDrawerTotalAdjustmentsArgumentsBuilder>
    {
        public CashDrawerTotalAdjustmentsArgumentsBuilder Arguments { get; }
        protected override CashDrawerTotalAdjustmentsQueryBuilder Self => this;

        public CashDrawerTotalAdjustmentsQueryBuilder(string name) : base(new Query<MoneyV2>(name))
        {
            Arguments = new CashDrawerTotalAdjustmentsArgumentsBuilder(base.InnerQuery);
        }

        public CashDrawerTotalAdjustmentsQueryBuilder(IQuery<MoneyV2> query) : base(query)
        {
            Arguments = new CashDrawerTotalAdjustmentsArgumentsBuilder(base.InnerQuery);
        }

        public CashDrawerTotalAdjustmentsQueryBuilder SetArguments(Action<CashDrawerTotalAdjustmentsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CashDrawerTotalAdjustmentsQueryBuilder Amount()
        {
            base.InnerQuery.AddField("amount");
            return this;
        }

        public CashDrawerTotalAdjustmentsQueryBuilder CurrencyCode()
        {
            base.InnerQuery.AddField("currencyCode");
            return this;
        }
    }
}