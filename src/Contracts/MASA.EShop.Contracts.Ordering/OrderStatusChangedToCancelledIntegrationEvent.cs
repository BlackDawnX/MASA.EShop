﻿using MASA.Contrib.Dispatcher.IntegrationEvents.Dapr;

namespace MASA.EShop.Contracts.Ordering
{
    public class OrderStatusChangedToCancelledIntegrationEvent: IntegrationEvent
    {
        public Guid OrderId { get; init; }
        public string OrderStatus { get; init; } = default!;
        public string Description { get; init; } = default!;
        public string BuyerName { get; init; } = default!;
        public override string Topic { get ; set ; } = nameof(OrderStatusChangedToCancelledIntegrationEvent);

        private OrderStatusChangedToCancelledIntegrationEvent()
        {
        }

        public OrderStatusChangedToCancelledIntegrationEvent(Guid orderId, string orderStatus,
            string description, string buyerName)
        {
            OrderId = orderId;
            OrderStatus = orderStatus;
            Description = description;
            BuyerName = buyerName;
        }
    }
}
