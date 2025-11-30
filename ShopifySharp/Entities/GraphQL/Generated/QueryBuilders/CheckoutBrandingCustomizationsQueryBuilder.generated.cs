#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class CheckoutBrandingCustomizationsQueryBuilder() : GraphQueryBuilder<CheckoutBrandingCustomizations>("checkoutBrandingCustomizations")
{
    public CheckoutBrandingCustomizationsQueryBuilder AddFieldBuyerJourney(Func<CheckoutBrandingBuyerJourneyQueryBuilder, CheckoutBrandingBuyerJourneyQueryBuilder> build)
    {
        AddField<CheckoutBrandingBuyerJourney, CheckoutBrandingBuyerJourneyQueryBuilder>("buyerJourney", build);
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldCartLink(Func<CheckoutBrandingCartLinkQueryBuilder, CheckoutBrandingCartLinkQueryBuilder> build)
    {
        AddField<CheckoutBrandingCartLink, CheckoutBrandingCartLinkQueryBuilder>("cartLink", build);
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldCheckbox(Func<CheckoutBrandingCheckboxQueryBuilder, CheckoutBrandingCheckboxQueryBuilder> build)
    {
        AddField<CheckoutBrandingCheckbox, CheckoutBrandingCheckboxQueryBuilder>("checkbox", build);
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldChoiceList(Func<CheckoutBrandingChoiceListQueryBuilder, CheckoutBrandingChoiceListQueryBuilder> build)
    {
        AddField<CheckoutBrandingChoiceList, CheckoutBrandingChoiceListQueryBuilder>("choiceList", build);
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldContent(Func<CheckoutBrandingContentQueryBuilder, CheckoutBrandingContentQueryBuilder> build)
    {
        AddField<CheckoutBrandingContent, CheckoutBrandingContentQueryBuilder>("content", build);
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldControl(Func<CheckoutBrandingControlQueryBuilder, CheckoutBrandingControlQueryBuilder> build)
    {
        AddField<CheckoutBrandingControl, CheckoutBrandingControlQueryBuilder>("control", build);
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldDivider(Func<CheckoutBrandingDividerStyleQueryBuilder, CheckoutBrandingDividerStyleQueryBuilder> build)
    {
        AddField<CheckoutBrandingDividerStyle, CheckoutBrandingDividerStyleQueryBuilder>("divider", build);
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldExpressCheckout(Func<CheckoutBrandingExpressCheckoutQueryBuilder, CheckoutBrandingExpressCheckoutQueryBuilder> build)
    {
        AddField<CheckoutBrandingExpressCheckout, CheckoutBrandingExpressCheckoutQueryBuilder>("expressCheckout", build);
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldFavicon(Func<CheckoutBrandingImageQueryBuilder, CheckoutBrandingImageQueryBuilder> build)
    {
        AddField<CheckoutBrandingImage, CheckoutBrandingImageQueryBuilder>("favicon", build);
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldFooter(Func<CheckoutBrandingFooterQueryBuilder, CheckoutBrandingFooterQueryBuilder> build)
    {
        AddField<CheckoutBrandingFooter, CheckoutBrandingFooterQueryBuilder>("footer", build);
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldGlobal(Func<CheckoutBrandingGlobalQueryBuilder, CheckoutBrandingGlobalQueryBuilder> build)
    {
        AddField<CheckoutBrandingGlobal, CheckoutBrandingGlobalQueryBuilder>("global", build);
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldHeader(Func<CheckoutBrandingHeaderQueryBuilder, CheckoutBrandingHeaderQueryBuilder> build)
    {
        AddField<CheckoutBrandingHeader, CheckoutBrandingHeaderQueryBuilder>("header", build);
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldHeadingLevel1(Func<CheckoutBrandingHeadingLevelQueryBuilder, CheckoutBrandingHeadingLevelQueryBuilder> build)
    {
        AddField<CheckoutBrandingHeadingLevel, CheckoutBrandingHeadingLevelQueryBuilder>("headingLevel1", build);
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldHeadingLevel2(Func<CheckoutBrandingHeadingLevelQueryBuilder, CheckoutBrandingHeadingLevelQueryBuilder> build)
    {
        AddField<CheckoutBrandingHeadingLevel, CheckoutBrandingHeadingLevelQueryBuilder>("headingLevel2", build);
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldHeadingLevel3(Func<CheckoutBrandingHeadingLevelQueryBuilder, CheckoutBrandingHeadingLevelQueryBuilder> build)
    {
        AddField<CheckoutBrandingHeadingLevel, CheckoutBrandingHeadingLevelQueryBuilder>("headingLevel3", build);
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldMain(Func<CheckoutBrandingMainQueryBuilder, CheckoutBrandingMainQueryBuilder> build)
    {
        AddField<CheckoutBrandingMain, CheckoutBrandingMainQueryBuilder>("main", build);
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldMerchandiseThumbnail(Func<CheckoutBrandingMerchandiseThumbnailQueryBuilder, CheckoutBrandingMerchandiseThumbnailQueryBuilder> build)
    {
        AddField<CheckoutBrandingMerchandiseThumbnail, CheckoutBrandingMerchandiseThumbnailQueryBuilder>("merchandiseThumbnail", build);
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldOrderSummary(Func<CheckoutBrandingOrderSummaryQueryBuilder, CheckoutBrandingOrderSummaryQueryBuilder> build)
    {
        AddField<CheckoutBrandingOrderSummary, CheckoutBrandingOrderSummaryQueryBuilder>("orderSummary", build);
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldPrimaryButton(Func<CheckoutBrandingButtonQueryBuilder, CheckoutBrandingButtonQueryBuilder> build)
    {
        AddField<CheckoutBrandingButton, CheckoutBrandingButtonQueryBuilder>("primaryButton", build);
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldSecondaryButton(Func<CheckoutBrandingButtonQueryBuilder, CheckoutBrandingButtonQueryBuilder> build)
    {
        AddField<CheckoutBrandingButton, CheckoutBrandingButtonQueryBuilder>("secondaryButton", build);
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldSelect(Func<CheckoutBrandingSelectQueryBuilder, CheckoutBrandingSelectQueryBuilder> build)
    {
        AddField<CheckoutBrandingSelect, CheckoutBrandingSelectQueryBuilder>("select", build);
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldTextField(Func<CheckoutBrandingTextFieldQueryBuilder, CheckoutBrandingTextFieldQueryBuilder> build)
    {
        AddField<CheckoutBrandingTextField, CheckoutBrandingTextFieldQueryBuilder>("textField", build);
        return this;
    }
}