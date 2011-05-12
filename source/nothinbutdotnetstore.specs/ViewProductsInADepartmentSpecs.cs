using System.Collections.Generic;
 using developwithpassion.specifications.rhinomocks;
 using Machine.Specifications;
 using developwithpassion.specifications.extensions;
 using nothinbutdotnetstore.web.application;
 using nothinbutdotnetstore.web.application.catalogbrowsing;
 using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs
{   
    public class ViewProductsInADepartmentSpecs
    {
        public abstract class concern : Observes<IProcessApplicationSpecificBehaviour,
                                            ViewTheProductsInADepartment>
        {
        
        }

        [Subject(typeof(ViewTheProductsInADepartment))]
        public class when_run : concern
        {
              Establish c = () =>
              {
                request = fake.an<IContainRequestInformation>();
                var testdepartment = new DepartmentItem();

                department_repository = depends.on<IFindDepartments>();
                the_department_products = new List<ProductItem> {new ProductItem()};
                report_engine = depends.on<IDisplayReportModels>();

                request.setup(x => x.map<DepartmentItem>()).Return(testdepartment);
                department_repository.setup(x => x.get_products_in(testdepartment)).Return(the_department_products);
              };

              Because b = () =>
                sut.run(request);


              It should_display_the_products_in_the_department =
                () =>
                  report_engine.received(x => x.display(the_department_products));


              static IContainRequestInformation request;
              static IFindDepartments department_repository;
              static IDisplayReportModels report_engine;
              static IEnumerable<ProductItem> the_department_products;
            }                
        }
}
