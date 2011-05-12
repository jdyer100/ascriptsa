using nothinbutdotnetstore.web.application.stubs;
using nothinbutdotnetstore.web.core;
using nothinbutdotnetstore.web.core.stubs;

namespace nothinbutdotnetstore.web.application.catalogbrowsing
{
  public class ViewTheMainDepartmentsInTheStore : ViewBase
  {

    public ViewTheMainDepartmentsInTheStore() : this(new StubInformationInTheStoreCatalogRepository(),
                                                     new StubReportEngine())
    {
    }

    public ViewTheMainDepartmentsInTheStore(IFindInformationInTheStoreCatalog information_in_the_store_catalog_repository,
                                            IDisplayReportModels reporting_engine):base(information_in_the_store_catalog_repository,reporting_engine)
    {
      
    }

    public override void run(IContainRequestInformation request)
    {
        base.displayResults(information_in_the_store_catalog_repository.get_the_main_departments_in_the_store());
    }
  }
}