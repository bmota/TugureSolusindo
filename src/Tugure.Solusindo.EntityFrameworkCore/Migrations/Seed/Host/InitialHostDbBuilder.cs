using Tugure.Solusindo.EntityFrameworkCore;

namespace Tugure.Solusindo.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly SolusindoDbContext _context;

        public InitialHostDbBuilder(SolusindoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
