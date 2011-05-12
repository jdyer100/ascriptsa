using System.Collections.Generic;
using nothinbutdotnetstore.web.application.stubs;
using nothinbutdotnetstore.web.core;
using nothinbutdotnetstore.web.core.stubs;

namespace nothinbutdotnetstore.web.application.catalogbrowsing
{
  public class ViewTheProductsInADepartment : IProcessApplicationSpecificBehaviour
  {
    IFindDepartments department_repository;
    IDisplayReportModels report_engine;

    public ViewTheProductsInADepartment():this(new StubDepartmentsRepository(),
      new StubReportEngine())
    {
    }

    public ViewTheProductsInADepartment(IFindDepartments department_repository, IDisplayReportModels report_engine)
    {
      this.department_repository = department_repository;
      this.report_engine = report_engine;
    }

    public void run(IContainRequestInformation request)
    {
      report_engine.display(department_repository.get_products_in(request.map<DepartmentItem>()));
    }
  }
}