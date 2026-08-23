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
    public sealed class CheckoutAndAccountsConfigurationBrandingPaletteQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingPalette, CheckoutAndAccountsConfigurationBrandingPaletteQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingPaletteQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingPaletteQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingPalette")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingPaletteQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingPalette>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingPaletteQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingPalette> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingPaletteQueryBuilder Color1()
        {
            base.InnerQuery.AddField("color1");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingPaletteQueryBuilder Color10()
        {
            base.InnerQuery.AddField("color10");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingPaletteQueryBuilder Color11()
        {
            base.InnerQuery.AddField("color11");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingPaletteQueryBuilder Color12()
        {
            base.InnerQuery.AddField("color12");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingPaletteQueryBuilder Color13()
        {
            base.InnerQuery.AddField("color13");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingPaletteQueryBuilder Color14()
        {
            base.InnerQuery.AddField("color14");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingPaletteQueryBuilder Color15()
        {
            base.InnerQuery.AddField("color15");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingPaletteQueryBuilder Color16()
        {
            base.InnerQuery.AddField("color16");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingPaletteQueryBuilder Color17()
        {
            base.InnerQuery.AddField("color17");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingPaletteQueryBuilder Color18()
        {
            base.InnerQuery.AddField("color18");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingPaletteQueryBuilder Color19()
        {
            base.InnerQuery.AddField("color19");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingPaletteQueryBuilder Color2()
        {
            base.InnerQuery.AddField("color2");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingPaletteQueryBuilder Color20()
        {
            base.InnerQuery.AddField("color20");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingPaletteQueryBuilder Color3()
        {
            base.InnerQuery.AddField("color3");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingPaletteQueryBuilder Color4()
        {
            base.InnerQuery.AddField("color4");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingPaletteQueryBuilder Color5()
        {
            base.InnerQuery.AddField("color5");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingPaletteQueryBuilder Color6()
        {
            base.InnerQuery.AddField("color6");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingPaletteQueryBuilder Color7()
        {
            base.InnerQuery.AddField("color7");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingPaletteQueryBuilder Color8()
        {
            base.InnerQuery.AddField("color8");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingPaletteQueryBuilder Color9()
        {
            base.InnerQuery.AddField("color9");
            return this;
        }
    }
}