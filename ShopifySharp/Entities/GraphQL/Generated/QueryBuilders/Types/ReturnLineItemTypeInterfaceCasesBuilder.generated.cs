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
    public sealed class ReturnLineItemTypeInterfaceCasesBuilder : InterfaceCasesBuilderBase<IReturnLineItemType, ReturnLineItemTypeInterfaceCasesBuilder>
    {
        protected override ReturnLineItemTypeInterfaceCasesBuilder Self => this;

        public ReturnLineItemTypeInterfaceCasesBuilder(string fieldName = "node") : this(new Query<IReturnLineItemType>(fieldName))
        {
        }

        public ReturnLineItemTypeInterfaceCasesBuilder(IQuery<IReturnLineItemType> query) : base(query)
        {
        }

        public ReturnLineItemTypeInterfaceCasesBuilder OnReturnLineItem(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnLineItemQueryBuilder> build)
        {
            var query = new Query<ReturnLineItem>("... on ReturnLineItem");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public ReturnLineItemTypeInterfaceCasesBuilder OnUnverifiedReturnLineItem(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UnverifiedReturnLineItemQueryBuilder> build)
        {
            var query = new Query<UnverifiedReturnLineItem>("... on UnverifiedReturnLineItem");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UnverifiedReturnLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}