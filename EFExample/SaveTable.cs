namespace EFExample;

public class SaveTable
{
    //Сохранение
    public async Task Save(AppDbContext dbContext)
    {
        await dbContext.SaveChangesAsync();
    }
}