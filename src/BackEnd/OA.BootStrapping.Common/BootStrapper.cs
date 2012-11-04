namespace OA.BootStrapping.Common
{
    using StructureMap;

    public static class BootStrapper
    {
        public static TType GetInstance<TType>()
        {
            return ObjectFactory.GetInstance<TType>();
        }

        public static void Initialize(object thisInstance)
        {
            ObjectFactory.BuildUp(thisInstance);
        }
    }
}