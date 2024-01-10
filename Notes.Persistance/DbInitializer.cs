namespace Notes.Persistance
{
    public class DbInitializer
    {
        public static void Initialize(NoteDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
