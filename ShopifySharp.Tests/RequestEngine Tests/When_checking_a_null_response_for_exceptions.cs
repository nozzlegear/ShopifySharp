using Machine.Specifications;
using RestSharp;
using System;

namespace ShopifySharp.Tests.RequestEngine_Tests
{
    [Subject(typeof(RequestEngine))]
    class When_checking_a_null_response_for_exceptions
    {
        Establish context = () =>
        {
            byte[] bytes = null;
            var req = new Moq.Mock<IRestResponse>();

            req.Setup(r => r.StatusCode).Returns(System.Net.HttpStatusCode.InternalServerError);
            req.Setup(r => r.RawBytes).Returns(bytes);
            req.Setup(r => r.StatusDescription).Returns("Internal Server Error");

            FakeResponse = req.Object;
        };

        Because of = () =>
        {
            CaughtException = Catch.Exception(() => RequestEngine.CheckResponseExceptions(FakeResponse));
        };

        It should_return_a_message_about_the_statuscode = () =>
        {
            CaughtException.ShouldBeOfExactType<ShopifyException>();

            var ex = (ShopifyException)CaughtException;

            ex.HttpStatusCode.ShouldEqual(System.Net.HttpStatusCode.InternalServerError);
            ex.Message.ShouldContain("Response did not indicate success. Status: 500");
        };

        Cleanup after = () =>
        {

        };

        static Exception CaughtException;

        static IRestResponse FakeResponse;
    }
}
