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
    public sealed class CustomerAccountPageInterfaceCasesBuilder : InterfaceCasesBuilderBase<ICustomerAccountPage, CustomerAccountPageInterfaceCasesBuilder>
    {
        protected override CustomerAccountPageInterfaceCasesBuilder Self => this;

        public CustomerAccountPageInterfaceCasesBuilder(string fieldName = "customerAccountPage") : this(new Query<ICustomerAccountPage>(fieldName))
        {
        }

        public CustomerAccountPageInterfaceCasesBuilder(IQuery<ICustomerAccountPage> query) : base(query)
        {
        }

        public CustomerAccountPageInterfaceCasesBuilder OnCustomerAccountAppExtensionPage(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerAccountAppExtensionPageQueryBuilder> build)
        {
            var query = new Query<CustomerAccountAppExtensionPage>("... on CustomerAccountAppExtensionPage");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerAccountAppExtensionPageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CustomerAccountPageInterfaceCasesBuilder OnCustomerAccountNativePage(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerAccountNativePageQueryBuilder> build)
        {
            var query = new Query<CustomerAccountNativePage>("... on CustomerAccountNativePage");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerAccountNativePageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}