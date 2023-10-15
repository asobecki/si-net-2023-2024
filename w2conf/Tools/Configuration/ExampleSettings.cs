namespace w2conf.Tools.Configuration
{
    public class ExampleSettings
    {
        public bool FirstParam { get; set; }
        public DetailedSettings SecondParam { get; set; }

        public ExampleSettings()
        {
            FirstParam = false;
            SecondParam = new DetailedSettings();
        }
    }

    public class DetailedSettings
    {
        public string Parameter3 { get; set; }
        public string Parameter4 { get; set; }
        public string Parameter5 { get; set; }
    }

}
