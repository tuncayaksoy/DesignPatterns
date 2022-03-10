namespace Singleton.Libs
{
    public class Sample3
    {
        //Thread Safe

        private static readonly object LockObject = new object();

        private static Sample3 _instance;

        private Sample3()
        {

        }

        public static Sample3 GetInstance()
        {
            lock (LockObject)
            {
                return _instance ?? (_instance = new Sample3());
            }
        }
    }
}
