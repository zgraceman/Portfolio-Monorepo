using System;

namespace InventoryManagementSystem
{
    public static class Utility
    {
        public static decimal ConvertCurrency(decimal amount, decimal exchangeRate)
        {
            return amount * exchangeRate;
        }
    }
}

