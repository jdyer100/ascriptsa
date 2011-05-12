 using Machine.Specifications;
 using developwithpassion.specifications.rhinomocks;
 using developwithpassion.specifications.extensions;
 using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs
{   
    public class ProcessOneUniqueRequestSpecs
    {
        public abstract class concern : Observes<IProcessOneUniqueRequest,
                                            ProcessOneUniqueRequest>
        {
        
        }

        [Subject(typeof(ProcessOneUniqueRequest))]
        public class when_processing_a_unique_request : concern
        {
            Establish c = () =>
            {

                request = fake.an<IContainRequestInformation>();

                depends.on<IContainRequestInformation>(request);
            };

            Because b = () =>
                result = sut.can_handle(request);

            It should_return_true = () =>
                result.ShouldEqual(true);

            static IContainRequestInformation request;
            static bool result;
        }
    }
}
