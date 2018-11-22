namespace Movie_Tutorial.BasicSamples {
    export interface OrderBulkActionRequest extends Serenity.ServiceRequest {
        OrderIDs?: number[];
    }
}

