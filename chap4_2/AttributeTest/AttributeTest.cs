using System;

namespace AttributeTest
{
    [AdditionalInfoAttribute("전미경", "2018/10/1", Download = "http://oic.asia")]
    class Test
    {
        static void Main()
        {
            Type type = typeof(Test);
            foreach (Attribute attr in type.GetCustomAttributes(true))
            {              // 사용자정의에 있는것 하나씩꺼내서
                AdditionalInfoAttribute info = attr as AdditionalInfoAttribute;      // AdditionalInfoAttribute로 형변환하는것

                if (info != null)
                {
                    Console.WriteLine("Name={0}, Update={1}, DownLoad={2}",
                        info.Name, info.Update, info.Download);
                }
            }
        }
    }
}
