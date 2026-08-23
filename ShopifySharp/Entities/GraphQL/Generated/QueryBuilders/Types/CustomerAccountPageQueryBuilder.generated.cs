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
    public sealed class CustomerAccountPageQueryBuilder : FieldsQueryBuilderBase<ICustomerAccountPage, CustomerAccountPageQueryBuilder>, IHasArguments<CustomerAccountPageArgumentsBuilder>
    {
        public CustomerAccountPageArgumentsBuilder Arguments { get; }
        protected override CustomerAccountPageQueryBuilder Self => this;

        public CustomerAccountPageQueryBuilder() : this("customerAccountPage")
        {
        }

        public CustomerAccountPageQueryBuilder(string name) : base(new Query<ICustomerAccountPage>(name))
        {
            Arguments = new CustomerAccountPageArgumentsBuilder(base.InnerQuery);
        }

        public CustomerAccountPageQueryBuilder(IQuery<ICustomerAccountPage> query) : base(query)
        {
            Arguments = new CustomerAccountPageArgumentsBuilder(base.InnerQuery);
        }

        public CustomerAccountPageQueryBuilder SetArguments(Action<CustomerAccountPageArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CustomerAccountPageQueryBuilder DefaultCursor()
        {
            base.InnerQuery.AddField("defaultCursor");
            return this;
        }

        public CustomerAccountPageQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public CustomerAccountPageQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CustomerAccountPageQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public CustomerAccountPageQueryBuilder OnCustomerAccountAppExtensionPage(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerAccountAppExtensionPageQueryBuilder> build)
        {
            var query = new Query<CustomerAccountAppExtensionPage>("... on CustomerAccountAppExtensionPage");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerAccountAppExtensionPageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CustomerAccountPageQueryBuilder OnCustomerAccountNativePage(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerAccountNativePageQueryBuilder> build)
        {
            var query = new Query<CustomerAccountNativePage>("... on CustomerAccountNativePage");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerAccountNativePageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CustomerAccountPageQueryBuilder CustomerAccountPage(Action<CustomerAccountPageInterfaceCasesBuilder> build)
        {
            var query = new Query<ICustomerAccountPage>("customerAccountPage");
            var unionBuilder = new CustomerAccountPageInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}