namespace Movie_Tutorial.Membership {
    export interface LoginRequest extends Serenity.ServiceRequest {
        Username?: string;
        Password?: string;
    }
}

