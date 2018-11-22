using Microsoft.EntityFrameworkCore;
using System;

namespace ConsoleApp1
{
    public enum EditorType
    {
        dxAutocomplete = 0,
        dxCalendar = 1,
        dxCheckBox = 2,
        dxColorBox = 3,
        dxDateBox = 4,
        dxDropDownBox = 5,
        dxLookup = 6,
        dxNumberBox = 7,
        dxRadioGroup = 8,
        dxRangeSlider = 9,
        dxSelectBox = 10,
        dxSlider = 11,
        dxSwitch = 12,
        dxTagBox = 13,
        dxTextArea = 14,
        dxTextBox = 15
    }

    public abstract class EditorOptionsBase
    {
        public EditorType EditorType { get; private set; }
        public bool ReadOnly { get; set; } = false;
    }

    public enum MaskMode
    {
        always,
        onFocus
    }

    public enum TextBoxMode
    {
        email,
        password,
        search,
        tel,
        text,
        url
    }

    public abstract class EditorOptionsText : EditorOptionsBase
    {
        public string Mask { get; set; }
        public string MaskChar { get; set; }
        public string MaskInvalidMessage { get; set; }
        public TextBoxMode? Mode { get; set; }
        public string Placeholder { get; set; }
        public bool ShowClearButton { get; set; }
        public MaskMode ShowMaskMode { get; set; }
        public bool Spellcheck { get; set; }
    }

    public class EditorOptionsTextBox : EditorOptionsText
    {
    }

    public class EditorOptionsTextArea : EditorOptionsText
    {
        public int? MaxLength { get; set; }

        public bool AutoResizeEnabled { get; set; }
        public double? MaxHeight { get; set; }
        public double? MinHeight { get; set; }
    }

    public class EditorOptionsNumberBox : EditorOptionsText
    {
        public string Format { get; set; }
        public string InvalidValueMessage { get; set; }
        public double? Min { get; set; }
        public double? Max { get; set; }
        public bool ShowSpinButtons { get; set; }
        public double Step { get; set; }
        public bool UseLargeSpinButtons { get; set; }
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
