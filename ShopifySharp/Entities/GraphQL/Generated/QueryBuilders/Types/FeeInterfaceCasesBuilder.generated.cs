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
    public sealed class FeeInterfaceCasesBuilder : InterfaceCasesBuilderBase<IFee, FeeInterfaceCasesBuilder>
    {
        protected override FeeInterfaceCasesBuilder Self => this;

        public FeeInterfaceCasesBuilder(string fieldName = "fee") : this(new Query<IFee>(fieldName))
        {
        }

        public FeeInterfaceCasesBuilder(IQuery<IFee> query) : base(query)
        {
        }

        public FeeInterfaceCasesBuilder OnRestockingFee(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RestockingFeeQueryBuilder> build)
        {
            var query = new Query<RestockingFee>("... on RestockingFee");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RestockingFeeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public FeeInterfaceCasesBuilder OnReturnShippingFee(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnShippingFeeQueryBuilder> build)
        {
            var query = new Query<ReturnShippingFee>("... on ReturnShippingFee");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnShippingFeeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}