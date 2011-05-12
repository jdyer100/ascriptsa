using System;

namespace nothinbutdotnetstore.web.core
{
  public class ProcessOneUniqueRequest : IProcessOneUniqueRequest
  {
    IncomingRequestMeetsCriteria request_criteria;
    IProcessApplicationSpecificBehaviour application_specific_behaviour;
      IView _results;
    public ProcessOneUniqueRequest(IncomingRequestMeetsCriteria request_criteria,
                                   IProcessApplicationSpecificBehaviour application_specific_behaviour)
    {
      this.request_criteria = request_criteria;
      this.application_specific_behaviour = application_specific_behaviour;
    }

    public void run(IContainRequestInformation request)
    {
      application_specific_behaviour.run(request);
       _results = application_specific_behaviour.results;
    }

      public IView results
      {
          get { return _results; }
      }

      public bool can_handle(IContainRequestInformation request)
    {
      return request_criteria(request);
    }
  }
}