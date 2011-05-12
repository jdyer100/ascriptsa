using System;

namespace nothinbutdotnetstore.web.core
{
    public class ProcessOneUniqueRequest : IProcessOneUniqueRequest
    {
        private string action;
        public ProcessOneUniqueRequest()
        {
            action = "ProcessOneUniqueRequestAction";
        }

        public void run(IContainRequestInformation request)
        {
            throw new NotImplementedException();
        }

        public bool can_handle(IContainRequestInformation request)
        {
            return request.action == action;
        }


    }
}