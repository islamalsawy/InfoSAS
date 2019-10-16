﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mid
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ICDBTrdAEntities1 : DbContext
    {
        public ICDBTrdAEntities1()
            : base("name=ICDBTrdAEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MainCmpnam> MainCmpnam { get; set; }
        public virtual DbSet<MainBranch> MainBranch { get; set; }
    
        public virtual int updatebranch(Nullable<int> brn_No, Nullable<int> cmp_No, string brn_Nm, string brn_Tel, string brn_Adrs, string brn_Email, Nullable<int> acc_Customer, Nullable<int> acc_Suplier, Nullable<int> acc_Cashier, Nullable<int> acc_Suplier2, Nullable<int> acc_Sales, Nullable<int> acc_RetSal, Nullable<int> csh_SalAcc, Nullable<int> csh_RetsalAcc, Nullable<int> cmp_PurchaseAcc, Nullable<int> cmp_RetPurchAcc, Nullable<int> cmp_CshPurDiscAcc, Nullable<int> agnt_CshPurDiscAcc, Nullable<int> agnt_BnusPurDiscAcc, Nullable<int> csh_PurAcc, Nullable<decimal> inv_Undprs, Nullable<int> cost_SalInvt, Nullable<int> cost_INVt, Nullable<int> acc_TaxExtraDb, Nullable<int> acc_TaxExtraCR)
        {
            var brn_NoParameter = brn_No.HasValue ?
                new ObjectParameter("Brn_No", brn_No) :
                new ObjectParameter("Brn_No", typeof(int));
    
            var cmp_NoParameter = cmp_No.HasValue ?
                new ObjectParameter("Cmp_No", cmp_No) :
                new ObjectParameter("Cmp_No", typeof(int));
    
            var brn_NmParameter = brn_Nm != null ?
                new ObjectParameter("Brn_Nm", brn_Nm) :
                new ObjectParameter("Brn_Nm", typeof(string));
    
            var brn_TelParameter = brn_Tel != null ?
                new ObjectParameter("Brn_Tel", brn_Tel) :
                new ObjectParameter("Brn_Tel", typeof(string));
    
            var brn_AdrsParameter = brn_Adrs != null ?
                new ObjectParameter("Brn_Adrs", brn_Adrs) :
                new ObjectParameter("Brn_Adrs", typeof(string));
    
            var brn_EmailParameter = brn_Email != null ?
                new ObjectParameter("Brn_Email", brn_Email) :
                new ObjectParameter("Brn_Email", typeof(string));
    
            var acc_CustomerParameter = acc_Customer.HasValue ?
                new ObjectParameter("Acc_Customer", acc_Customer) :
                new ObjectParameter("Acc_Customer", typeof(int));
    
            var acc_SuplierParameter = acc_Suplier.HasValue ?
                new ObjectParameter("Acc_Suplier", acc_Suplier) :
                new ObjectParameter("Acc_Suplier", typeof(int));
    
            var acc_CashierParameter = acc_Cashier.HasValue ?
                new ObjectParameter("Acc_Cashier", acc_Cashier) :
                new ObjectParameter("Acc_Cashier", typeof(int));
    
            var acc_Suplier2Parameter = acc_Suplier2.HasValue ?
                new ObjectParameter("Acc_Suplier2", acc_Suplier2) :
                new ObjectParameter("Acc_Suplier2", typeof(int));
    
            var acc_SalesParameter = acc_Sales.HasValue ?
                new ObjectParameter("Acc_Sales", acc_Sales) :
                new ObjectParameter("Acc_Sales", typeof(int));
    
            var acc_RetSalParameter = acc_RetSal.HasValue ?
                new ObjectParameter("Acc_RetSal", acc_RetSal) :
                new ObjectParameter("Acc_RetSal", typeof(int));
    
            var csh_SalAccParameter = csh_SalAcc.HasValue ?
                new ObjectParameter("Csh_SalAcc", csh_SalAcc) :
                new ObjectParameter("Csh_SalAcc", typeof(int));
    
            var csh_RetsalAccParameter = csh_RetsalAcc.HasValue ?
                new ObjectParameter("Csh_RetsalAcc", csh_RetsalAcc) :
                new ObjectParameter("Csh_RetsalAcc", typeof(int));
    
            var cmp_PurchaseAccParameter = cmp_PurchaseAcc.HasValue ?
                new ObjectParameter("Cmp_PurchaseAcc", cmp_PurchaseAcc) :
                new ObjectParameter("Cmp_PurchaseAcc", typeof(int));
    
            var cmp_RetPurchAccParameter = cmp_RetPurchAcc.HasValue ?
                new ObjectParameter("Cmp_RetPurchAcc", cmp_RetPurchAcc) :
                new ObjectParameter("Cmp_RetPurchAcc", typeof(int));
    
            var cmp_CshPurDiscAccParameter = cmp_CshPurDiscAcc.HasValue ?
                new ObjectParameter("Cmp_CshPurDiscAcc", cmp_CshPurDiscAcc) :
                new ObjectParameter("Cmp_CshPurDiscAcc", typeof(int));
    
            var agnt_CshPurDiscAccParameter = agnt_CshPurDiscAcc.HasValue ?
                new ObjectParameter("Agnt_CshPurDiscAcc", agnt_CshPurDiscAcc) :
                new ObjectParameter("Agnt_CshPurDiscAcc", typeof(int));
    
            var agnt_BnusPurDiscAccParameter = agnt_BnusPurDiscAcc.HasValue ?
                new ObjectParameter("Agnt_BnusPurDiscAcc", agnt_BnusPurDiscAcc) :
                new ObjectParameter("Agnt_BnusPurDiscAcc", typeof(int));
    
            var csh_PurAccParameter = csh_PurAcc.HasValue ?
                new ObjectParameter("Csh_PurAcc", csh_PurAcc) :
                new ObjectParameter("Csh_PurAcc", typeof(int));
    
            var inv_UndprsParameter = inv_Undprs.HasValue ?
                new ObjectParameter("Inv_Undprs", inv_Undprs) :
                new ObjectParameter("Inv_Undprs", typeof(decimal));
    
            var cost_SalInvtParameter = cost_SalInvt.HasValue ?
                new ObjectParameter("Cost_SalInvt", cost_SalInvt) :
                new ObjectParameter("Cost_SalInvt", typeof(int));
    
            var cost_INVtParameter = cost_INVt.HasValue ?
                new ObjectParameter("Cost_INVt", cost_INVt) :
                new ObjectParameter("Cost_INVt", typeof(int));
    
            var acc_TaxExtraDbParameter = acc_TaxExtraDb.HasValue ?
                new ObjectParameter("Acc_TaxExtraDb", acc_TaxExtraDb) :
                new ObjectParameter("Acc_TaxExtraDb", typeof(int));
    
            var acc_TaxExtraCRParameter = acc_TaxExtraCR.HasValue ?
                new ObjectParameter("Acc_TaxExtraCR", acc_TaxExtraCR) :
                new ObjectParameter("Acc_TaxExtraCR", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updatebranch", brn_NoParameter, cmp_NoParameter, brn_NmParameter, brn_TelParameter, brn_AdrsParameter, brn_EmailParameter, acc_CustomerParameter, acc_SuplierParameter, acc_CashierParameter, acc_Suplier2Parameter, acc_SalesParameter, acc_RetSalParameter, csh_SalAccParameter, csh_RetsalAccParameter, cmp_PurchaseAccParameter, cmp_RetPurchAccParameter, cmp_CshPurDiscAccParameter, agnt_CshPurDiscAccParameter, agnt_BnusPurDiscAccParameter, csh_PurAccParameter, inv_UndprsParameter, cost_SalInvtParameter, cost_INVtParameter, acc_TaxExtraDbParameter, acc_TaxExtraCRParameter);
        }
    
        public virtual int updatebranchs(Nullable<int> brn_No, Nullable<int> cmp_No, string brn_Nm, string brn_Tel, string brn_Adrs, string brn_Email, Nullable<int> acc_Customer, Nullable<int> acc_Suplier, Nullable<int> acc_Cashier, Nullable<int> acc_Suplier2, Nullable<int> acc_Sales, Nullable<int> acc_RetSal, Nullable<int> csh_SalAcc, Nullable<int> csh_RetsalAcc, Nullable<int> cmp_PurchaseAcc, Nullable<int> cmp_RetPurchAcc, Nullable<int> cmp_CshPurDiscAcc, Nullable<int> agnt_CshPurDiscAcc, Nullable<int> agnt_BnusPurDiscAcc, Nullable<int> csh_PurAcc, Nullable<decimal> inv_Undprs, Nullable<int> cost_SalInvt, Nullable<int> cost_INVt, Nullable<int> acc_TaxExtraDb, Nullable<int> acc_TaxExtraCR)
        {
            var brn_NoParameter = brn_No.HasValue ?
                new ObjectParameter("Brn_No", brn_No) :
                new ObjectParameter("Brn_No", typeof(int));
    
            var cmp_NoParameter = cmp_No.HasValue ?
                new ObjectParameter("Cmp_No", cmp_No) :
                new ObjectParameter("Cmp_No", typeof(int));
    
            var brn_NmParameter = brn_Nm != null ?
                new ObjectParameter("Brn_Nm", brn_Nm) :
                new ObjectParameter("Brn_Nm", typeof(string));
    
            var brn_TelParameter = brn_Tel != null ?
                new ObjectParameter("Brn_Tel", brn_Tel) :
                new ObjectParameter("Brn_Tel", typeof(string));
    
            var brn_AdrsParameter = brn_Adrs != null ?
                new ObjectParameter("Brn_Adrs", brn_Adrs) :
                new ObjectParameter("Brn_Adrs", typeof(string));
    
            var brn_EmailParameter = brn_Email != null ?
                new ObjectParameter("Brn_Email", brn_Email) :
                new ObjectParameter("Brn_Email", typeof(string));
    
            var acc_CustomerParameter = acc_Customer.HasValue ?
                new ObjectParameter("Acc_Customer", acc_Customer) :
                new ObjectParameter("Acc_Customer", typeof(int));
    
            var acc_SuplierParameter = acc_Suplier.HasValue ?
                new ObjectParameter("Acc_Suplier", acc_Suplier) :
                new ObjectParameter("Acc_Suplier", typeof(int));
    
            var acc_CashierParameter = acc_Cashier.HasValue ?
                new ObjectParameter("Acc_Cashier", acc_Cashier) :
                new ObjectParameter("Acc_Cashier", typeof(int));
    
            var acc_Suplier2Parameter = acc_Suplier2.HasValue ?
                new ObjectParameter("Acc_Suplier2", acc_Suplier2) :
                new ObjectParameter("Acc_Suplier2", typeof(int));
    
            var acc_SalesParameter = acc_Sales.HasValue ?
                new ObjectParameter("Acc_Sales", acc_Sales) :
                new ObjectParameter("Acc_Sales", typeof(int));
    
            var acc_RetSalParameter = acc_RetSal.HasValue ?
                new ObjectParameter("Acc_RetSal", acc_RetSal) :
                new ObjectParameter("Acc_RetSal", typeof(int));
    
            var csh_SalAccParameter = csh_SalAcc.HasValue ?
                new ObjectParameter("Csh_SalAcc", csh_SalAcc) :
                new ObjectParameter("Csh_SalAcc", typeof(int));
    
            var csh_RetsalAccParameter = csh_RetsalAcc.HasValue ?
                new ObjectParameter("Csh_RetsalAcc", csh_RetsalAcc) :
                new ObjectParameter("Csh_RetsalAcc", typeof(int));
    
            var cmp_PurchaseAccParameter = cmp_PurchaseAcc.HasValue ?
                new ObjectParameter("Cmp_PurchaseAcc", cmp_PurchaseAcc) :
                new ObjectParameter("Cmp_PurchaseAcc", typeof(int));
    
            var cmp_RetPurchAccParameter = cmp_RetPurchAcc.HasValue ?
                new ObjectParameter("Cmp_RetPurchAcc", cmp_RetPurchAcc) :
                new ObjectParameter("Cmp_RetPurchAcc", typeof(int));
    
            var cmp_CshPurDiscAccParameter = cmp_CshPurDiscAcc.HasValue ?
                new ObjectParameter("Cmp_CshPurDiscAcc", cmp_CshPurDiscAcc) :
                new ObjectParameter("Cmp_CshPurDiscAcc", typeof(int));
    
            var agnt_CshPurDiscAccParameter = agnt_CshPurDiscAcc.HasValue ?
                new ObjectParameter("Agnt_CshPurDiscAcc", agnt_CshPurDiscAcc) :
                new ObjectParameter("Agnt_CshPurDiscAcc", typeof(int));
    
            var agnt_BnusPurDiscAccParameter = agnt_BnusPurDiscAcc.HasValue ?
                new ObjectParameter("Agnt_BnusPurDiscAcc", agnt_BnusPurDiscAcc) :
                new ObjectParameter("Agnt_BnusPurDiscAcc", typeof(int));
    
            var csh_PurAccParameter = csh_PurAcc.HasValue ?
                new ObjectParameter("Csh_PurAcc", csh_PurAcc) :
                new ObjectParameter("Csh_PurAcc", typeof(int));
    
            var inv_UndprsParameter = inv_Undprs.HasValue ?
                new ObjectParameter("Inv_Undprs", inv_Undprs) :
                new ObjectParameter("Inv_Undprs", typeof(decimal));
    
            var cost_SalInvtParameter = cost_SalInvt.HasValue ?
                new ObjectParameter("Cost_SalInvt", cost_SalInvt) :
                new ObjectParameter("Cost_SalInvt", typeof(int));
    
            var cost_INVtParameter = cost_INVt.HasValue ?
                new ObjectParameter("Cost_INVt", cost_INVt) :
                new ObjectParameter("Cost_INVt", typeof(int));
    
            var acc_TaxExtraDbParameter = acc_TaxExtraDb.HasValue ?
                new ObjectParameter("Acc_TaxExtraDb", acc_TaxExtraDb) :
                new ObjectParameter("Acc_TaxExtraDb", typeof(int));
    
            var acc_TaxExtraCRParameter = acc_TaxExtraCR.HasValue ?
                new ObjectParameter("Acc_TaxExtraCR", acc_TaxExtraCR) :
                new ObjectParameter("Acc_TaxExtraCR", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updatebranchs", brn_NoParameter, cmp_NoParameter, brn_NmParameter, brn_TelParameter, brn_AdrsParameter, brn_EmailParameter, acc_CustomerParameter, acc_SuplierParameter, acc_CashierParameter, acc_Suplier2Parameter, acc_SalesParameter, acc_RetSalParameter, csh_SalAccParameter, csh_RetsalAccParameter, cmp_PurchaseAccParameter, cmp_RetPurchAccParameter, cmp_CshPurDiscAccParameter, agnt_CshPurDiscAccParameter, agnt_BnusPurDiscAccParameter, csh_PurAccParameter, inv_UndprsParameter, cost_SalInvtParameter, cost_INVtParameter, acc_TaxExtraDbParameter, acc_TaxExtraCRParameter);
        }
    }
}
