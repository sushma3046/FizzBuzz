namespace FizzBuzz.HelperClasses
{
    public class fizzbuzzViewModel
    {

        public fizzbuzzViewModel(string input, string output)
        {
            Value = input;
            Result = output;
        }

        public string Value { get; set; }
        public string Result { get; set; }
    }
}