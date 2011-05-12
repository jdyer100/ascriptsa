using nothinbutdotnetstore.web.application.stubs;
using nothinbutdotnetstore.web.core;
using nothinbutdotnetstore.web.core.stubs;

namespace nothinbutdotnetstore.web.application.catalogbrowsing
{
  public class ViewProductsInADepartment : ViewBase
  {

    public ViewProductsInADepartment() : this(new StubReportEngine(),
                                              new StubInformationInTheStoreCatalogRepository())
    {
    }

    public ViewProductsInADepartment(IDisplayReportModels report_engine,
                                     IFindInformationInTheStoreCatalog information_in_the_store_catalog_repository):
        base(report_engine:report_engine, information_in_the_store_catalog_repository: information_in_the_store_catalog_repository)
    {
    }

    public override void run(IContainRequestInformation request)
    {
        base.displayResults(information_in_the_store_catalog_repository.get_products_in(request.map<DepartmentItem>()));
    }
  }
}