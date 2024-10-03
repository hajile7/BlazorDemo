namespace BlazorPractice.Services 
{
    public class TestService 
    {
        public string TestVar {  get; set; } = string.Empty;
        public bool IsSet => !string.IsNullOrEmpty(TestVar);

        public void SetTest(string test) 
        {
            TestVar = test;
        }

        public void UnsetTest()
        {
            TestVar = string.Empty;
        }

    }
}
