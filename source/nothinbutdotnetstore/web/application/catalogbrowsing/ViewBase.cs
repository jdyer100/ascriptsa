using System;
using System.Collections.Generic;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.web.application.catalogbrowsing
{
    public abstract class ViewBase : IProcessApplicationSpecificBehaviour
    {
        protected IFindInformationInTheStoreCatalog information_in_the_store_catalog_repository;
        protected IDisplayReportModels report_engine;

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