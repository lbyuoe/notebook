using System;

[AttributeUsage(AttributeTargets.All)]
public class HelpAttribute : System.Attribute {
    private string topic;
    public readonly string Url;

    public string Topic {
        get { return topic; }
        set { topic = value; }
    }

    public HelpAttribute(string url) {
        this.Url = url;
    }
}

[HelpAttribute("Information on the class MyClass")]
class MyClass { }

namespace AttributeAppl {
    class Program {
        static void Main(string[] args) {
            // 获取有关成员属性的信息并提供对成员元数据的访问权限
            System.Reflection.MemberInfo info = typeof(MyClass);
            // 返回应用于此成员的所有自定义属性的数组
            object[] attributes = info.GetCustomAttributes(true);
            for (int i = 0; i < attributes.Length; i++) {
                System.Console.WriteLine(attributes[i]);
            }
            Console.ReadKey();
        }
    }
}