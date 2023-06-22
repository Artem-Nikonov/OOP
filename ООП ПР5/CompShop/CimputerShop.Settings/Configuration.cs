using ComputerShop.DI;
using ComputerShop.Bll;
using ComputerShop.Data.Memory;
using ComputerShop.Data.Sql;
using SimpleInjector;

namespace ComputerShop.Settings
{
    public class Configuration
    {
        public Container Container { get; }

        public Configuration()
        {
            Container = new Container();

            Setup();
        }

        public virtual void Setup()
        {
            Container.Register<IComputer, Computer>(Lifestyle.Transient);
            Container.Register<ICheck, Check>(Lifestyle.Transient);
            Container.Register<IShop, Shop>(Lifestyle.Singleton);
            Container.Register<IData<IComputer>, ComputerSqlData>(Lifestyle.Singleton);
            Container.Register<IData<ICheck>, CheckSqlData>(Lifestyle.Singleton);
        }
    }
}