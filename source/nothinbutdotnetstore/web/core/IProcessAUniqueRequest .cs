using System;

namespace nothinbutdotnetstore.web.core
{
    public interface IProcessOneUniqueRequest 
    {
        void run(IContainRequestInformation request);
        bool can_handle(IContainRequestInformation request);
    }

   public class ProcessOneUniqueRequest : IProcessOneUniqueRequest
    {
        public void run(IContainRequestInformation request)
        {
            throw new NotImplementedException();
        }

        public bool can_handle(IContainRequestInformation request)
        {
            throw new NotImplementedException();
        }
    }
}