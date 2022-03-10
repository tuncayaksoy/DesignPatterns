namespace Singleton.Libs
{
    public class Sample2
    {
        //Not Thread Safe

        private static readonly Sample2 Instance = new Sample2();

        private Sample2()
        {

        }

        public static Sample2 GetInstace()
        {
            return Instance;
        }
    }
}
