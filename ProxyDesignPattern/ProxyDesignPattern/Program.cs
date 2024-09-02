namespace ProxyDesignPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            Subject proxy = new Proxy();
            proxy.DoSomeWork();
        }
    }
}