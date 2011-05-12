 using System.Collections.Generic;
 using System.Linq;
 using Machine.Specifications;
 using developwithpassion.specifications.rhinomocks;
 using developwithpassion.specifications.extensions;
 using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs
{   
    public class CommandRegistrySpecs
    {
        public abstract class concern : Observes<IFindSpecificRequestHandlers,
                                            CommandRegistry>
        {
        
        }

        [Subject(typeof(CommandRegistry))]
        public class when_finding_the_command_that_can_process_a_request_and_it_has_the_command : concern
        {
            Establish c = () =>
            {
                all_possible_commands = Enumerable.Range(1,100).Select(x => fake.an<IProcessOneUniqueRequest>()).ToList();
                depends.on<IEnumerable<IProcessOneUniqueRequest>>(all_possible_commands);

                request = fake.an<IContainRequestInformation>();
                the_command_that_can_process_the_request = fake.an<IProcessOneUniqueRequest>();

                all_possible_commands.Add(the_command_that_can_process_the_request);

                the_command_that_can_process_the_request.setup(x => x.can_handle(request)).Return(true);
            };

            Because b = () =>
                result = sut.get_the_command_that_can_process(request);


            It should_return_the_command_to_the_caller = () =>
                result.ShouldEqual(the_command_that_can_process_the_request);


            static IProcessOneUniqueRequest result;
            static IProcessOneUniqueRequest the_command_that_can_process_the_request;
            static IContainRequestInformation request;
            static IList<IProcessOneUniqueRequest> all_possible_commands;
        }

        public class when_attempting_to_find_a_handler_and_it_does_not_have_it : concern
        {

            Establish c = () =>
            {
                the_special_case = fake.an<IProcessOneUniqueRequest>();
                depends.on<MissingHandlerFactory>(() => the_special_case);
                all_possible_commands = Enumerable.Range(1,100).Select(x => fake.an<IProcessOneUniqueRequest>()).ToList();
                depends.on<IEnumerable<IProcessOneUniqueRequest>>(all_possible_commands);
                request = fake.an<IContainRequestInformation>();

            };

            Because b = () =>
                result = sut.get_the_command_that_can_process(request);


            It should_return_the_special_case = () =>
                result.ShouldEqual(the_special_case);


            static IProcessOneUniqueRequest result;
            static IContainRequestInformation request;
            static IList<IProcessOneUniqueRequest> all_possible_commands;
            static IProcessOneUniqueRequest the_special_case;
        }
    }
}
