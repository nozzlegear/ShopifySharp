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
    public sealed class FeeQueryBuilder : FieldsQueryBuilderBase<IFee, FeeQueryBuilder>
    {
        protected override FeeQueryBuilder Self => this;

        public FeeQueryBuilder() : this("fee")
        {
        }

        public FeeQueryBuilder(string name) : base(new Query<IFee>(name))
        {
        }

        public FeeQueryBuilder(IQuery<IFee> query) : base(query)
        {
        }

        public FeeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public FeeQueryBuilder OnRestockingFee(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RestockingFeeQueryBuilder> build)
        {
            var query = new Query<RestockingFee>("... on RestockingFee");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RestockingFeeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public FeeQueryBuilder OnReturnShippingFee(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnShippingFeeQueryBuilder> build)
        {
            var query = new Query<ReturnShippingFee>("... on ReturnShippingFee");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnShippingFeeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public FeeQueryBuilder Fee(Action<FeeInterfaceCasesBuilder> build)
        {
            var query = new Query<IFee>("fee");
            var unionBuilder = new FeeInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}