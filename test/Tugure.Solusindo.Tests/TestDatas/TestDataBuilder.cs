using Tugure.Solusindo.EntityFrameworkCore;

namespace Tugure.Solusindo.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly SolusindoDbContext _context;
        private readonly int _tenantId;

        public TestDataBuilder(SolusindoDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            new TestOrganizationUnitsBuilder(_context, _tenantId).Create();
            new TestSubscriptionPaymentBuilder(_context, _tenantId).Create();

            _context.SaveChanges();
        }
    }
}
