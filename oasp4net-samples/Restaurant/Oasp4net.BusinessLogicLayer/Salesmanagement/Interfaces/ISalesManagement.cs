using Oasp4net.BusinessLogicLayer.OfferManagement.Interfaces;


namespace Oasp4net.BusinessLogicLayer.Salesmanagement.Interfaces
{
    /// <summary>
    /// Interface for SalesManagement
    /// </summary>
    public interface ISalesManagement : IUcChangeTable, IUcFindBill, IUcFindOrder, IUcFindOrderPosition, IUcManageBill, IUcManageOrder, IUcManageOrderPosition
    {
    }
}
