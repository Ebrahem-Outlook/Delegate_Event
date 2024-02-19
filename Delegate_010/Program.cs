namespace Delegate_Event
{

    delegate TResult Func<out TResult>();

    delegate TResult Func<in T, out TResult>(T t);
    delegate TResult Func<in T, in T1, out TResult>(T t, T1 t1);
    delegate TResult Func<T, T1, T2, TResult>(T t, T1 t1, T2 t2);
    delegate TResult Func<in T, in T1, in T2, in T3, out TResult>(T t, T1 t1, T2 t2, T3 t3);


    delegate void Action();
    delegate void Action<in T>(T t);
    delegate void Action<in T, in T1>(T t, T1 t1);

    public class Program
    {
        public static void Main(String[] args)
        {

        }


    }
}