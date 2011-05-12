using developwithpassion.specifications.rhinomocks;
using Machine.Specifications;
using nothinbutdotnetstore.web.application.catalogbrowsing;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs
{
    [Subject(typeof(ViewTheMainDepartmentsInTheStore))]
  public class ViewTheMainDepartmentsInTheStoreSpecs
  {
    public abstract class concern : Observes<IProcessApplicationSpecificBehaviour,
                                      ViewTheMainDepartmentsInTheStore>
    {
    }

    public class when_run : concern
    {
      Establish c = () =>
      {
        request = fake.an<IContainRequestInformation>();
      };

      Because b = () =>
        sut.run(request);


      It return_a_view_of_departments = () =>
      {
          result = sut.results;
      };

      static IContainRequestInformation request;
        static IView result;
    }
  }
}