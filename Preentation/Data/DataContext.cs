using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Preentation.Data;

public class DataContext(DbContextOptions<DataContext> options) : IdentityDbContext(options)
{
}