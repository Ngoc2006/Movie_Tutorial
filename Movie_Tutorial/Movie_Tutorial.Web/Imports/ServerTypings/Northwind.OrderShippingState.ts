namespace Movie_Tutorial.Northwind {
    export enum OrderShippingState {
        NotShipped = 0,
        Shipped = 1
    }
    Serenity.Decorators.registerEnumType(OrderShippingState, 'Movie_Tutorial.Northwind.OrderShippingState', 'Northwind.OrderShippingState');
}

