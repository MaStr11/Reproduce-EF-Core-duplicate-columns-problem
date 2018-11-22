using Microsoft.EntityFrameworkCore;
using System;

namespace ConsoleApp1
{
    public enum EditorType
    {
        dxCalendar = 1,
        dxNumberBox = 7,
        dxTextArea = 14,
        dxTextBox = 15
    }

    public abstract class EditorOptionsBase
    {
        public EditorType EditorType { get; private set; }
        public bool ReadOnly { get; set; } = false;
    }

    public abstract class EditorOptionsText : EditorOptionsBase
    {
        public string Mask { get; set; }
    }

    public class EditorOptionsTextBox : EditorOptionsText
    {
    }

    public class EditorOptionsTextArea : EditorOptionsText
    {
        public int? MaxLength { get; set; }
    }

    public class EditorOptionsNumberBox : EditorOptionsText
    {
        public string Format { get; set; }
    }

    public class EditorOptionsCalendar : EditorOptionsBase
    {
    }

    class MyContext : DbContext
    {
        public MyContext() : base(new DbContextOptionsBuilder()
                .UseSqlServer(@"Data Source = (LocalDb)\MSSQLLocalDB; Initial Catalog = Test;").Options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var editorOptionsBase = modelBuilder.Entity<EditorOptionsBase>();
            editorOptionsBase.Property(typeof(int), "Id");
            editorOptionsBase.HasKey("Id");
            editorOptionsBase.HasDiscriminator<EditorType>(nameof(EditorType)).
                HasValue<EditorOptionsNumberBox>(EditorType.dxNumberBox).
                HasValue<EditorOptionsTextBox>(EditorType.dxTextBox).
                HasValue<EditorOptionsTextArea>(EditorType.dxTextArea).
                HasValue<EditorOptionsCalendar>(EditorType.dxCalendar);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
