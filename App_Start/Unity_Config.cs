using MyCalc.Core.Calculators;
using Unity;

namespace MyCalc.App_Start
{
    public static class Unity_Config
    {
        public static IUnityContainer RegisterInstances(this IUnityContainer container)
        {
            container.RegisterType<ICalculator, ExpressionCalculator>();
            return container;
        }
    }
}
