using nothinbutdotnetstore.web.application.stubs;
using nothinbutdotnetstore.web.core;
using nothinbutdotnetstore.web.core.stubs;

namespace nothinbutdotnetstore.web.application.catalogbrowsing
{
    public abstract class ViewBase : IProcessApplicationSpecificBehaviour
    {
        protected IDisplayReportModels report_engine;
        protected IFindInformationInTheStoreCatalog information_in_the_store_catalog_repository;

        protected ViewBase(): this(Stub.with<StubReportEngine>(), Stub.with<StubInformationInTheStoreCatalogRepository>())
        {
        }

        protected ViewBase(IDisplayReportModels report_engine, IFindInformationInTheStoreCatalog information_in_the_store_catalog_repository)
        {
            this.report_engine = report_engine;
            this.information_in_the_store_catalog_repository = information_in_the_store_catalog_repository;
        }

        public virtual void run(IContainRequestInformation request)
        {
        }

        protected void display<Results>(Results results)
        {
            report_engine.display(results);
        }
    }
}