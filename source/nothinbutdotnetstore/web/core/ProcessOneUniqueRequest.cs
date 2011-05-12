using System;

namespace nothinbutdotnetstore.web.core
{
    public class ProcessOneUniqueRequest : IProcessOneUniqueRequest
    {
        public ProcessOneUniqueRequest()
        {
            Action = "ProcessOneUniqueRequestAction";
        }

        public void run(IContainRequestInformation request)
        {
            throw new NotImplementedException();
        }

        public bool can_handle(IContainRequestInformation request)
        {
            return request.Action == Action;
        }

        public string Action { get; set; }

    }
}