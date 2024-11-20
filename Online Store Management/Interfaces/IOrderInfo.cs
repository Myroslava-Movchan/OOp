﻿using Online_Store_Management.Models;

namespace Online_Store_Management.Interfaces
{
    public interface IOrderInfo
    {
        Task<OrderInfo> PostAsync(Product product, CancellationToken cancellationToken);
        Task<bool> CompareOrdersAsync(OrderInfo order, CancellationToken cancellationToken);
        Task<bool> AddToTableAsync(OrderInfo order, CancellationToken cancellationToken);
        Task<int> EstimateDeliveryAsync(CancellationToken cancellationToken);
        decimal GetTotal(OrderInfo order);
    }
}
