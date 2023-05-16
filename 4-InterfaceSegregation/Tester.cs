namespace InterfaceSegregation
{
    public class Tester : IGeneralWorkActivities, ITestActivities
    {
        public Tester()
        {
        }

        void IGeneralWorkActivities.Comunicate()
        {
            throw new NotImplementedException();
        }

        void IGeneralWorkActivities.Plan()
        {
            throw new NotImplementedException();
        }

        void ITestActivities.Test()
        {
            throw new NotImplementedException();
        }
    }
}