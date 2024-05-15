using Microsoft.AspNetCore.Components;

namespace TFCyberDemoBlazorWasm.Pages
{
    public partial class Demo1
    {
        public int MyValue { get; set; } = 42;

        public void Increment()
        {
            MyValue++;
        }
        public void Decrement()
        {
            MyValue--;
        }
        public void ModifyValue(int value)
        {
            MyValue = value;
        }

        public void ReponsePourAllan()
        {
            MyValue *= 2;
        }
    }
}
