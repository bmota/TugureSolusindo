using Tugure.Solusindo.Auditing;
using Shouldly;
using Xunit;

namespace Tugure.Solusindo.Tests.Auditing
{
    public class NamespaceStripper_Tests: AppTestBase
    {
        private readonly INamespaceStripper _namespaceStripper;

        public NamespaceStripper_Tests()
        {
            _namespaceStripper = Resolve<INamespaceStripper>();
        }

        [Fact]
        public void Should_Stripe_Namespace()
        {
            var controllerName = _namespaceStripper.StripNameSpace("Tugure.Solusindo.Web.Controllers.HomeController");
            controllerName.ShouldBe("HomeController");
        }

        [Theory]
        [InlineData("Tugure.Solusindo.Auditing.GenericEntityService`1[[Tugure.Solusindo.Storage.BinaryObject, Tugure.Solusindo.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null]]", "GenericEntityService<BinaryObject>")]
        [InlineData("CompanyName.ProductName.Services.Base.EntityService`6[[CompanyName.ProductName.Entity.Book, CompanyName.ProductName.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[CompanyName.ProductName.Services.Dto.Book.CreateInput, N...", "EntityService<Book, CreateInput>")]
        [InlineData("Tugure.Solusindo.Auditing.XEntityService`1[Tugure.Solusindo.Auditing.AService`5[[Tugure.Solusindo.Storage.BinaryObject, Tugure.Solusindo.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[Tugure.Solusindo.Storage.TestObject, Tugure.Solusindo.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],]]", "XEntityService<AService<BinaryObject, TestObject>>")]
        public void Should_Stripe_Generic_Namespace(string serviceName, string result)
        {
            var genericServiceName = _namespaceStripper.StripNameSpace(serviceName);
            genericServiceName.ShouldBe(result);
        }
    }
}
