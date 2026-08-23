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
    public sealed class CustomerMomentInterfaceCasesBuilder : InterfaceCasesBuilderBase<ICustomerMoment, CustomerMomentInterfaceCasesBuilder>
    {
        protected override CustomerMomentInterfaceCasesBuilder Self => this;

        public CustomerMomentInterfaceCasesBuilder(string fieldName = "node") : this(new Query<ICustomerMoment>(fieldName))
        {
        }

        public CustomerMomentInterfaceCasesBuilder(IQuery<ICustomerMoment> query) : base(query)
        {
        }

        public CustomerMomentInterfaceCasesBuilder OnCustomerVisit(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerVisitQueryBuilder> build)
        {
            var query = new Query<CustomerVisit>("... on CustomerVisit");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerVisitQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}