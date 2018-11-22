namespace Movie_Tutorial {
    export interface ScriptUserDefinition {
        Username?: string;
        DisplayName?: string;
        IsAdmin?: boolean;
        Permissions?: { [key: string]: boolean };
    }
}

