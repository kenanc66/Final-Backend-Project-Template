using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product Added";
        public static string ProductNameInvalid = "Product Name is Invalid";
        public static string MaintenanceTime ="System maintenance time";
        public static string ProductsListed ="Products Listed";
        public static string ProductCountOfCategoryError="Category Count Overrun";
        public static string ProductNameAlreadyExists="Name Exists";
        public static string CategoryLimitExceded = "Category Limit Exceeded";
        public static string AuthorizationDenied="Authorisation Error.";
    }
}
