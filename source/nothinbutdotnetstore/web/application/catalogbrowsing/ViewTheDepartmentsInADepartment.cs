﻿using nothinbutdotnetstore.web.application.stubs;
using nothinbutdotnetstore.web.core;
using nothinbutdotnetstore.web.core.stubs;

namespace nothinbutdotnetstore.web.application.catalogbrowsing
{
    public class ViewTheDepartmentsInADepartment : ViewBase
    {
        public ViewTheDepartmentsInADepartment(): base(){ }

        public ViewTheDepartmentsInADepartment(IFindInformationInTheStoreCatalog information_in_the_store_catalog_repository,
            IDisplayReportModels report_engine): base(information_in_the_store_catalog_repository, report_engine)
        {
        }

        public override void run(IContainRequestInformation request)
        {
            base.displayResults(information_in_the_store_catalog_repository.get_departments_in(request.map<DepartmentItem>()));
        }
    }
}