using System;
using System.Collections.Generic;
using nothinbutdotnetstore.web.application.stubs;
using nothinbutdotnetstore.web.core;
using nothinbutdotnetstore.web.core.stubs;

namespace nothinbutdotnetstore.web.application.catalogbrowsing
{
    public abstract class ViewBase : IProcessApplicationSpecificBehaviour
    {
        protected IFindInformationInTheStoreCatalog information_in_the_store_catalog_repository;
        protected IDisplayReportModels report_engine;

        protected ViewBase(): this(new StubInformationInTheStoreCatalogRepository(), new StubReportEngine()) { }

        protected ViewBase(IFindInformationInTheStoreCatalog information_in_the_store_catalog_repository, IDisplayReportModels report_engine)
        {
            this.information_in_the_store_catalog_repository = information_in_the_store_catalog_repository;
            this.report_engine = report_engine;
        }

        public virtual void run(IContainRequestInformation request)
        {
        }

        protected void displayResults<T>(IEnumerable<T> results)
        {
            report_engine.display(results);
        }
    }
    
}