/* Title:           Inventory Costing Class
 * Date:            8-3-17
 * Author:          Terry Holmes */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace InventoryCostingDLL
{
    public class InventoryCostingClass
    {
        //setting up the class
        EventLogClass TheEventLogClass = new EventLogClass();

        FindReceiveJHMaterialOverDateRangeDataSet aFindReceiveJHMaterialOverDateRangeDataSet;
        FindReceiveJHMaterialOverDateRangeDataSetTableAdapters.FindReceiveJHMaterialOverDateRangeTableAdapter aFindReceiveJHMaterialOverDateRangeTableAdapter;

        FindReceiveJHMaterialForProjectDataSet aFindReceiveJHMaterialforProjectDataSet;
        FindReceiveJHMaterialForProjectDataSetTableAdapters.FindReceiveJHMaterialForProjectTableAdapter aFindReceiveJHMaterialForProjectTableAdpater;

        FindIssuedJHMaterialCostByProjectDataSet aFindIssuedJHMaterialCostByProjectDataSet;
        FindIssuedJHMaterialCostByProjectDataSetTableAdapters.FindIssuedJHMaterialCostByProjectTableAdapter aFindIssuedJHMaterialCostByProjectTableAdapter;

        FindIssuedJHMaterialOverDateRangeDataSet aFindIssuedJHMaterialOverDateRangeDataSet;
        FindIssuedJHMaterialOverDateRangeDataSetTableAdapters.FindIssuedJHMaterialOverDateRangeTableAdapter aFindIssuedJHMaterialOverDateRangeTableAdapter;

        FindReceivedJHMaterialsFromVendorDateRangeDataSet aFindReceivedJHMaterialsFromVendorDateRangeDataSet;
        FindReceivedJHMaterialsFromVendorDateRangeDataSetTableAdapters.FindReceivedJHMasterialsFromVendorDateRangeTableAdapter aFindReceivedJHMaterialsFromVendorDateRangeTableAdapter;

        FindJHMaterialReturnedDataSet aFindJHMaterialReturnedDataSet;
        FindJHMaterialReturnedDataSetTableAdapters.FindJHMaterialReturnedCostTableAdapter aFindJHMaterialReturnedTableAdapter;

        FindIssuedJHMaterialByEmployeeIDDataSet aFindIssuedJHMaterialByEmployeeIDDataSet;
        FindIssuedJHMaterialByEmployeeIDDataSetTableAdapters.FindIssuedJHMaterialByEmployeeIDTableAdapter aFindIssuedJHMaterialByEmployeeIDTableAdapter;

        //FindIssuedJHMaterialByWarehouseIDDataSet aFindIssuedJHMaterialByWarehouseIDDataSet;
        //FindIssuedJHMaterialByWarehouseIDDataSetTableAdapters.FindIssuedJHMaterialByWarehouseIDTableAdapter aFindIssuedJHMaterialByWarehouseIDTableAdapter;

        //FindReceiveJHMaterialByWarehouseIDDataSet aFindReceiveJHMaterialByWarehouseID;
        //FindReceiveJHMaterialByWarehouseIDDataSetTableAdapters.FindReceiveJHCostingByWarehouseIDTableAdapter aFindReceiveJHMaterialByWarehouseIDTableAdapter;

        FindReturnedJHMaterialByWarehouseIDDataSet aFindReturnJHMaterialByWarehouseIDDataSet;
        FindReturnedJHMaterialByWarehouseIDDataSetTableAdapters.FindReturnedJHMaterialByWarehouseIDTableAdapter aFindReturnJHMaterialByWarehouseIDDTableAdapter;

        public FindReturnedJHMaterialByWarehouseIDDataSet FindReturnedJHMaterialByWarehouseID(int intWarehouseID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindReturnJHMaterialByWarehouseIDDataSet = new FindReturnedJHMaterialByWarehouseIDDataSet();
                aFindReturnJHMaterialByWarehouseIDDTableAdapter = new FindReturnedJHMaterialByWarehouseIDDataSetTableAdapters.FindReturnedJHMaterialByWarehouseIDTableAdapter();
                aFindReturnJHMaterialByWarehouseIDDTableAdapter.Fill(aFindReturnJHMaterialByWarehouseIDDataSet.FindReturnedJHMaterialByWarehouseID, intWarehouseID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Inventory Costing Class // Find Returned JH Material By Warehouse ID " + Ex.Message);
            }

            return aFindReturnJHMaterialByWarehouseIDDataSet;
        }
        public FindIssuedJHMaterialByEmployeeIDDataSet FindIssuedJHMaterialByEmployeeID(int intEmployeeID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindIssuedJHMaterialByEmployeeIDDataSet = new FindIssuedJHMaterialByEmployeeIDDataSet();
                aFindIssuedJHMaterialByEmployeeIDTableAdapter = new FindIssuedJHMaterialByEmployeeIDDataSetTableAdapters.FindIssuedJHMaterialByEmployeeIDTableAdapter();
                aFindIssuedJHMaterialByEmployeeIDTableAdapter.Fill(aFindIssuedJHMaterialByEmployeeIDDataSet.FindIssuedJHMaterialByEmployeeID, intEmployeeID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Inventory Costing Class // Find Issued JH Material By Employee ID " + Ex.Message);
            }

            return aFindIssuedJHMaterialByEmployeeIDDataSet;
        }
        public FindJHMaterialReturnedDataSet FindJHMaterialReturned(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindJHMaterialReturnedDataSet = new FindJHMaterialReturnedDataSet();
                aFindJHMaterialReturnedTableAdapter = new FindJHMaterialReturnedDataSetTableAdapters.FindJHMaterialReturnedCostTableAdapter();
                aFindJHMaterialReturnedTableAdapter.Fill(aFindJHMaterialReturnedDataSet.FindJHMaterialReturnedCost, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Inventory Costing Class // Find JH Material Returned " + Ex.Message);
            }

            return aFindJHMaterialReturnedDataSet;
        }
        public FindReceivedJHMaterialsFromVendorDateRangeDataSet FindReceivedJHMaterialsFromVendorDateRange(string strVendorName, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindReceivedJHMaterialsFromVendorDateRangeDataSet = new FindReceivedJHMaterialsFromVendorDateRangeDataSet();
                aFindReceivedJHMaterialsFromVendorDateRangeTableAdapter = new FindReceivedJHMaterialsFromVendorDateRangeDataSetTableAdapters.FindReceivedJHMasterialsFromVendorDateRangeTableAdapter();
                aFindReceivedJHMaterialsFromVendorDateRangeTableAdapter.Fill(aFindReceivedJHMaterialsFromVendorDateRangeDataSet.FindReceivedJHMasterialsFromVendorDateRange, strVendorName, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Inventory Costing Class \\ Find Received JH Materials From Vendor Date Range " + Ex.Message);
            }

            return aFindReceivedJHMaterialsFromVendorDateRangeDataSet;
        }
        public FindIssuedJHMaterialOverDateRangeDataSet FindIssuedJHMaterialOverDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindIssuedJHMaterialOverDateRangeDataSet = new FindIssuedJHMaterialOverDateRangeDataSet();
                aFindIssuedJHMaterialOverDateRangeTableAdapter = new FindIssuedJHMaterialOverDateRangeDataSetTableAdapters.FindIssuedJHMaterialOverDateRangeTableAdapter();
                aFindIssuedJHMaterialOverDateRangeTableAdapter.Fill(aFindIssuedJHMaterialOverDateRangeDataSet.FindIssuedJHMaterialOverDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Inventory Costing Class // Find Issued JH Material Over Date Range " + Ex.Message);
            }

            return aFindIssuedJHMaterialOverDateRangeDataSet;
        }
        public FindIssuedJHMaterialCostByProjectDataSet FindIssuedJHMaterialCostByProject(string strAssignedProjectID)
        {
            try
            {
                aFindIssuedJHMaterialCostByProjectDataSet = new FindIssuedJHMaterialCostByProjectDataSet();
                aFindIssuedJHMaterialCostByProjectTableAdapter = new FindIssuedJHMaterialCostByProjectDataSetTableAdapters.FindIssuedJHMaterialCostByProjectTableAdapter();
                aFindIssuedJHMaterialCostByProjectTableAdapter.Fill(aFindIssuedJHMaterialCostByProjectDataSet.FindIssuedJHMaterialCostByProject, strAssignedProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Inventory Costing Class // Find Issued JH Material Cost By Project " + Ex.Message);
            }

            return aFindIssuedJHMaterialCostByProjectDataSet;
        }
        public FindReceiveJHMaterialForProjectDataSet FindReceiveJHMaterialForProject(string strAssignedProjectID)
        {
            try
            {
                aFindReceiveJHMaterialforProjectDataSet = new FindReceiveJHMaterialForProjectDataSet();
                aFindReceiveJHMaterialForProjectTableAdpater = new FindReceiveJHMaterialForProjectDataSetTableAdapters.FindReceiveJHMaterialForProjectTableAdapter();
                aFindReceiveJHMaterialForProjectTableAdpater.Fill(aFindReceiveJHMaterialforProjectDataSet.FindReceiveJHMaterialForProject, strAssignedProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Inventory Costing Class // Find Receive JH Material For Project " + Ex.Message);
            }

            return aFindReceiveJHMaterialforProjectDataSet;
        }
        public FindReceiveJHMaterialOverDateRangeDataSet FindReceiveJHMaterialOverDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindReceiveJHMaterialOverDateRangeDataSet = new FindReceiveJHMaterialOverDateRangeDataSet();
                aFindReceiveJHMaterialOverDateRangeTableAdapter = new FindReceiveJHMaterialOverDateRangeDataSetTableAdapters.FindReceiveJHMaterialOverDateRangeTableAdapter();
                aFindReceiveJHMaterialOverDateRangeTableAdapter.Fill(aFindReceiveJHMaterialOverDateRangeDataSet.FindReceiveJHMaterialOverDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Inventory Costing Class // Find Receive JH Material Over Date Range " + Ex.Message);
            }

            return aFindReceiveJHMaterialOverDateRangeDataSet;
        }
    }
}
