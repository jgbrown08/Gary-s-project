﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rutherford.Repository
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RutherfordEntities : DbContext
    {
        public RutherfordEntities()
            : base("name=RutherfordEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
    
        public virtual ObjectResult<AddCustomer_Result> AddCustomer(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AddCustomer_Result>("AddCustomer", nameParameter);
        }
    
        public virtual ObjectResult<AddEvent_Result> AddEvent(string name, Nullable<System.DateTime> date, string location, Nullable<decimal> price, Nullable<int> totalTickets, string notes)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var locationParameter = location != null ?
                new ObjectParameter("location", location) :
                new ObjectParameter("location", typeof(string));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(decimal));
    
            var totalTicketsParameter = totalTickets.HasValue ?
                new ObjectParameter("totalTickets", totalTickets) :
                new ObjectParameter("totalTickets", typeof(int));
    
            var notesParameter = notes != null ?
                new ObjectParameter("notes", notes) :
                new ObjectParameter("notes", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AddEvent_Result>("AddEvent", nameParameter, dateParameter, locationParameter, priceParameter, totalTicketsParameter, notesParameter);
        }
    
        public virtual ObjectResult<GetCustomer_Result> GetCustomer(Nullable<int> customerId)
        {
            var customerIdParameter = customerId.HasValue ?
                new ObjectParameter("customerId", customerId) :
                new ObjectParameter("customerId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCustomer_Result>("GetCustomer", customerIdParameter);
        }
    
        public virtual ObjectResult<GetEvent_Result> GetEvent(Nullable<int> eventId)
        {
            var eventIdParameter = eventId.HasValue ?
                new ObjectParameter("eventId", eventId) :
                new ObjectParameter("eventId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetEvent_Result>("GetEvent", eventIdParameter);
        }
    
        public virtual ObjectResult<RemoveCustomer_Result> RemoveCustomer(Nullable<int> customerId)
        {
            var customerIdParameter = customerId.HasValue ?
                new ObjectParameter("customerId", customerId) :
                new ObjectParameter("customerId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RemoveCustomer_Result>("RemoveCustomer", customerIdParameter);
        }
    
        public virtual ObjectResult<UpdateCustomer_Result> UpdateCustomer(Nullable<int> customerId, string name)
        {
            var customerIdParameter = customerId.HasValue ?
                new ObjectParameter("customerId", customerId) :
                new ObjectParameter("customerId", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UpdateCustomer_Result>("UpdateCustomer", customerIdParameter, nameParameter);
        }
    
        public virtual ObjectResult<UpdateEvent_Result> UpdateEvent(Nullable<int> eventId, string name, Nullable<System.DateTime> date, string location, Nullable<decimal> price, Nullable<int> totalTickets, string notes)
        {
            var eventIdParameter = eventId.HasValue ?
                new ObjectParameter("eventId", eventId) :
                new ObjectParameter("eventId", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var locationParameter = location != null ?
                new ObjectParameter("location", location) :
                new ObjectParameter("location", typeof(string));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(decimal));
    
            var totalTicketsParameter = totalTickets.HasValue ?
                new ObjectParameter("totalTickets", totalTickets) :
                new ObjectParameter("totalTickets", typeof(int));
    
            var notesParameter = notes != null ?
                new ObjectParameter("notes", notes) :
                new ObjectParameter("notes", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UpdateEvent_Result>("UpdateEvent", eventIdParameter, nameParameter, dateParameter, locationParameter, priceParameter, totalTicketsParameter, notesParameter);
        }
    
        public virtual ObjectResult<AddTransaction_Result> AddTransaction(Nullable<int> customerId, Nullable<int> eventId, Nullable<int> qty, Nullable<decimal> paid, Nullable<System.DateTime> date, Nullable<decimal> ccNumber)
        {
            var customerIdParameter = customerId.HasValue ?
                new ObjectParameter("customerId", customerId) :
                new ObjectParameter("customerId", typeof(int));
    
            var eventIdParameter = eventId.HasValue ?
                new ObjectParameter("eventId", eventId) :
                new ObjectParameter("eventId", typeof(int));
    
            var qtyParameter = qty.HasValue ?
                new ObjectParameter("qty", qty) :
                new ObjectParameter("qty", typeof(int));
    
            var paidParameter = paid.HasValue ?
                new ObjectParameter("paid", paid) :
                new ObjectParameter("paid", typeof(decimal));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var ccNumberParameter = ccNumber.HasValue ?
                new ObjectParameter("ccNumber", ccNumber) :
                new ObjectParameter("ccNumber", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AddTransaction_Result>("AddTransaction", customerIdParameter, eventIdParameter, qtyParameter, paidParameter, dateParameter, ccNumberParameter);
        }
    
        public virtual ObjectResult<GetEventTransaction_Result> GetEventTransaction(Nullable<int> eventId)
        {
            var eventIdParameter = eventId.HasValue ?
                new ObjectParameter("eventId", eventId) :
                new ObjectParameter("eventId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetEventTransaction_Result>("GetEventTransaction", eventIdParameter);
        }
    
        public virtual ObjectResult<GetTransaction_Result> GetTransaction(Nullable<int> customerId, Nullable<int> eventId)
        {
            var customerIdParameter = customerId.HasValue ?
                new ObjectParameter("customerId", customerId) :
                new ObjectParameter("customerId", typeof(int));
    
            var eventIdParameter = eventId.HasValue ?
                new ObjectParameter("eventId", eventId) :
                new ObjectParameter("eventId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetTransaction_Result>("GetTransaction", customerIdParameter, eventIdParameter);
        }
    
        public virtual ObjectResult<GetCustomerTransaction_Result> GetCustomerTransaction(Nullable<int> customerId)
        {
            var customerIdParameter = customerId.HasValue ?
                new ObjectParameter("customerId", customerId) :
                new ObjectParameter("customerId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCustomerTransaction_Result>("GetCustomerTransaction", customerIdParameter);
        }
    
        public virtual ObjectResult<RemoveEvent_Result> RemoveEvent(Nullable<int> eventId)
        {
            var eventIdParameter = eventId.HasValue ?
                new ObjectParameter("eventId", eventId) :
                new ObjectParameter("eventId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RemoveEvent_Result>("RemoveEvent", eventIdParameter);
        }
    
        public virtual ObjectResult<GetCustomers_Result> GetCustomers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCustomers_Result>("GetCustomers");
        }
    
        public virtual ObjectResult<GetEvents_Result> GetEvents()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetEvents_Result>("GetEvents");
        }
    
        public virtual ObjectResult<GetTransactions_Result> GetTransactions()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetTransactions_Result>("GetTransactions");
        }
    
        public virtual ObjectResult<Nullable<int>> GetTotalPurchasedEventTickets(Nullable<int> eventId)
        {
            var eventIdParameter = eventId.HasValue ?
                new ObjectParameter("eventId", eventId) :
                new ObjectParameter("eventId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetTotalPurchasedEventTickets", eventIdParameter);
        }
    }
}
