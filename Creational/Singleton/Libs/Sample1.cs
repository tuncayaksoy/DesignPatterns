namespace Singleton.Libs
{
    public class Sample1
    {
        //Not Thread Safe

        private static Sample1 _instance;

        private Sample1()
        {

        }

        public static Sample1 GetInstance()
        {
            return _instance ?? (_instance = new Sample1());
        }
    }
}
