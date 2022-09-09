namespace Classes;

public class Program
{
    //interfejs to zbior metod
    public interface IEkspresDoKawy
    {
        void ZaparzKawe();
        void DodajMleka();
    }

    public interface ISokowirowka
    {
        void WyciskajSok();
    }

    public class RobotKuchenny : IEkspresDoKawy, ISokowirowka
    {
        public void DodajMleka()
        {
            Console.WriteLine("Dodaje mleko.");
        }

        public void WyciskajSok()
        {
            Console.WriteLine("Wyciskam sok.");
        }

        public void ZaparzKawe()
        {
            Console.WriteLine("Parze kawe.");
        }
    }

    public class MiniEkspres : IEkspresDoKawy
    {
        public void DodajMleka()
        {
            throw new NotImplementedException();
        }

        public void ZaparzKawe()
        {
            Console.WriteLine("Mini ekspres parzy kawe.");
        }
    }

    public static void ZaparzLatte(IEkspresDoKawy ekspres)
    {
        ekspres.ZaparzKawe();
    }


    public static void Main(string[] args)
    {
        RobotKuchenny robot = new RobotKuchenny(); ;
        ISokowirowka sokowirowka = new RobotKuchenny();
        IEkspresDoKawy ekspres = new RobotKuchenny();
        object o = new RobotKuchenny();
        var mini = new MiniEkspres();

        ZaparzLatte(robot);
        ZaparzLatte(mini);
        //if(redis skonfigurowany){
        //    service.RegisterType < ICache, RedisCache>
        //}else
        //{
        //    service.RegisterType < ICache, IMemoryCache>
        //}
    }
}