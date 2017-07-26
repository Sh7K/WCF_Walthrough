using System.ServiceModel;

namespace NumericService
{
    [ServiceContract]
 public   interface INumericService
    {
        [OperationContract]
        int Add(int a,int b);
        [OperationContract]
        int Multiply(int a,int b);
    }
    public class NumericService : INumericService
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
